using Sheet_creator;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SheetCreator
{
    public partial class FormMain : Form
    {
        private Image _image = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblRowCount.Text = GlobalStrings.NumberOfRows;
            lblColCount.Text = GlobalStrings.NumberOfColumns;
            LblBorderTickness.Text = GlobalStrings.BorderTickness;
            lblGridColor.Text = GlobalStrings.GridColor;
            lblBgColor.Text = GlobalStrings.BackColor;
            lblOr.Text = GlobalStrings.Or;
            gbCellSize.Text = GlobalStrings.CellSize;
            btnSelectEtalon.Text = GlobalStrings.SelectEtalon;
            btnSave.Text = GlobalStrings.Save;
        }

        private void PanelGridColor_MouseClick(object sender, MouseEventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            ((Panel)sender).BackColor = cd.Color;
        }

        private void BtnSelectEtalon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog
            {
                Filter = GlobalStrings.ImgFiles + "|*.bmp;*.png;"
            };

            if (openDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                _image = Image.FromFile(openDialog.FileName);
                MessageBox.Show(GlobalStrings.Done);
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show(GlobalStrings.OutOfMemory);
                return;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(GlobalStrings.FileNotFound);
                return;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(GlobalStrings.UnauthorizedAccess);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(GlobalStrings.Exception + ": "
                    + ex.Message + "\n" + ex.StackTrace);
                return;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            GridCreator gridCrtr = new GridCreator(
                (int)NumCellWidth.Value,
                (int)NumCellHeight.Value,
                (int)NumRowCount.Value,
                (int)NumColCount.Value,
                (int)NumBorderTickness.Value,
                PanelGridColor.BackColor,
                PanelBgColor.BackColor,
                _image);

            Image createdGrid = gridCrtr.GetSheet();

            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "(*.png)|*.png|(*.bmp)|*.bmp"
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ImageFormat format = ImageFormat.Png;

                string ext = Path.GetExtension(saveDialog.FileName);
                switch (ext)
                {
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }

                try
                {
                    createdGrid.Save(saveDialog.FileName, format);
                    MessageBox.Show(GlobalStrings.Done);
                    _image = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
            }
        }
    }

    internal class GridCreator
    {
        private int _rowCount;
        private int _colCount;
        private int _borderTickness;
        private Color _borderColor;
        private Color _bgColor;
        private Bitmap _cellBg;
        private bool _isEmptyCell;

        public GridCreator(int cellWidth,
                            int cellHeight,
                            int rowCount,
                            int colCount,
                            int borderTickness,
                            Color borderColor,
                            Color bgColor,
                            Image cellBg = null)
        {
            if (cellBg != null)
            {
                _cellBg = new Bitmap(cellBg);
            }
            else
            {
                _cellBg = new Bitmap(cellWidth, cellHeight);
                _isEmptyCell = true;
            }

            _borderTickness = borderTickness;
            _rowCount = rowCount;
            _colCount = colCount;
            _borderColor = borderColor;
            _bgColor = bgColor;
        }

        public Image GetSheet()
        {
            Image bgCell;

            if (_isEmptyCell)
            {
                bgCell = GetFilledRectangle(_cellBg.Width,
                    _cellBg.Height,
                    _bgColor.R,
                    _bgColor.G,
                    _bgColor.B);
            }
            else
            {
                bgCell = _cellBg;
            }

            Image borderRight = GetFilledRectangle(_borderTickness,
               _cellBg.Height,
               _borderColor.R,
               _borderColor.G,
               _borderColor.B);

            Image borderBot = GetFilledRectangle(_cellBg.Width + _borderTickness,
               _borderTickness,
               _borderColor.R,
               _borderColor.G,
               _borderColor.B);

            int sheetWidth = bgCell.Width * _colCount +
                             _borderTickness * (_colCount - 1);
            int sheetHeight = bgCell.Height * _rowCount +
                             _borderTickness * (_rowCount - 1);

            Bitmap sheet = new Bitmap(sheetWidth, sheetHeight);

            int currentWidth = 0;
            int currentHeight = 0;

            int cellWidth = bgCell.Width + _borderTickness;
            int cellHeight = bgCell.Height + _borderTickness;

            Graphics gSheet = Graphics.FromImage(sheet);

            for (int x = 0; x < _colCount; x++)
            {
                for (int y = 0; y < _rowCount; y++)
                {
                    gSheet.DrawImage(bgCell, currentWidth, currentHeight);

                    if (x < (_colCount - 1))
                    {
                        gSheet.DrawImage(borderRight, currentWidth + bgCell.Width, currentHeight);
                    }

                    if (y < (_rowCount - 1))
                    {
                        gSheet.DrawImage(borderBot, currentWidth, currentHeight + bgCell.Height);
                    }

                    currentHeight += cellHeight;
                }
                currentHeight = 0;
                currentWidth += cellWidth;
            }

            return sheet;

        }


        private Image GetFilledRectangle(int width, int height, byte red, byte green, byte blue)
        {
            Bitmap newBmp = new Bitmap(width, height);

            Rectangle rec = new Rectangle(0, 0, width, height);

            BitmapData bmData =
            newBmp.LockBits(rec, ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int stride = bmData.Stride;
            IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - width * 3;

                for (int y = 0; y < height; ++y)
                {
                    for (int x = 0; x < width; ++x)
                    {
                        p[2] = red;
                        p[1] = green;
                        p[0] = blue;
                        p += 3;
                    }
                    p += nOffset;
                }
            }

            newBmp.UnlockBits(bmData);

            return newBmp;
        }
    }
}
