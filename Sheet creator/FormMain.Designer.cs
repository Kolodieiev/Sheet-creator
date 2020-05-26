namespace SheetCreator
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnSelectEtalon = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbCellSize = new System.Windows.Forms.GroupBox();
            this.NumCellHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NumCellWidth = new System.Windows.Forms.NumericUpDown();
            this.lblOr = new System.Windows.Forms.Label();
            this.NumRowCount = new System.Windows.Forms.NumericUpDown();
            this.NumColCount = new System.Windows.Forms.NumericUpDown();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.lblColCount = new System.Windows.Forms.Label();
            this.lblBgColor = new System.Windows.Forms.Label();
            this.lblGridColor = new System.Windows.Forms.Label();
            this.PanelGridColor = new System.Windows.Forms.Panel();
            this.PanelBgColor = new System.Windows.Forms.Panel();
            this.LblBorderTickness = new System.Windows.Forms.Label();
            this.NumBorderTickness = new System.Windows.Forms.NumericUpDown();
            this.gbCellSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCellHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCellWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRowCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumColCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBorderTickness)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectEtalon
            // 
            resources.ApplyResources(this.btnSelectEtalon, "btnSelectEtalon");
            this.btnSelectEtalon.Name = "btnSelectEtalon";
            this.btnSelectEtalon.UseVisualStyleBackColor = true;
            this.btnSelectEtalon.Click += new System.EventHandler(this.BtnSelectEtalon_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // gbCellSize
            // 
            this.gbCellSize.Controls.Add(this.NumCellHeight);
            this.gbCellSize.Controls.Add(this.label2);
            this.gbCellSize.Controls.Add(this.NumCellWidth);
            this.gbCellSize.Controls.Add(this.lblOr);
            this.gbCellSize.Controls.Add(this.btnSelectEtalon);
            resources.ApplyResources(this.gbCellSize, "gbCellSize");
            this.gbCellSize.Name = "gbCellSize";
            this.gbCellSize.TabStop = false;
            // 
            // NumCellHeight
            // 
            resources.ApplyResources(this.NumCellHeight, "NumCellHeight");
            this.NumCellHeight.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.NumCellHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCellHeight.Name = "NumCellHeight";
            this.NumCellHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // NumCellWidth
            // 
            resources.ApplyResources(this.NumCellWidth, "NumCellWidth");
            this.NumCellWidth.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.NumCellWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCellWidth.Name = "NumCellWidth";
            this.NumCellWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblOr
            // 
            resources.ApplyResources(this.lblOr, "lblOr");
            this.lblOr.Name = "lblOr";
            // 
            // NumRowCount
            // 
            resources.ApplyResources(this.NumRowCount, "NumRowCount");
            this.NumRowCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumRowCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumRowCount.Name = "NumRowCount";
            this.NumRowCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NumColCount
            // 
            resources.ApplyResources(this.NumColCount, "NumColCount");
            this.NumColCount.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumColCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumColCount.Name = "NumColCount";
            this.NumColCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblRowCount
            // 
            resources.ApplyResources(this.lblRowCount, "lblRowCount");
            this.lblRowCount.Name = "lblRowCount";
            // 
            // lblColCount
            // 
            resources.ApplyResources(this.lblColCount, "lblColCount");
            this.lblColCount.Name = "lblColCount";
            // 
            // lblBgColor
            // 
            resources.ApplyResources(this.lblBgColor, "lblBgColor");
            this.lblBgColor.Name = "lblBgColor";
            // 
            // lblGridColor
            // 
            resources.ApplyResources(this.lblGridColor, "lblGridColor");
            this.lblGridColor.Name = "lblGridColor";
            // 
            // PanelGridColor
            // 
            this.PanelGridColor.BackColor = System.Drawing.Color.MediumBlue;
            this.PanelGridColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelGridColor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PanelGridColor, "PanelGridColor");
            this.PanelGridColor.Name = "PanelGridColor";
            this.PanelGridColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelGridColor_MouseClick);
            // 
            // PanelBgColor
            // 
            this.PanelBgColor.BackColor = System.Drawing.Color.LightBlue;
            this.PanelBgColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelBgColor.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.PanelBgColor, "PanelBgColor");
            this.PanelBgColor.Name = "PanelBgColor";
            this.PanelBgColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PanelGridColor_MouseClick);
            // 
            // LblBorderTickness
            // 
            resources.ApplyResources(this.LblBorderTickness, "LblBorderTickness");
            this.LblBorderTickness.Name = "LblBorderTickness";
            // 
            // NumBorderTickness
            // 
            resources.ApplyResources(this.NumBorderTickness, "NumBorderTickness");
            this.NumBorderTickness.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.NumBorderTickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumBorderTickness.Name = "NumBorderTickness";
            this.NumBorderTickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NumBorderTickness);
            this.Controls.Add(this.LblBorderTickness);
            this.Controls.Add(this.PanelBgColor);
            this.Controls.Add(this.PanelGridColor);
            this.Controls.Add(this.lblGridColor);
            this.Controls.Add(this.lblBgColor);
            this.Controls.Add(this.lblColCount);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.NumColCount);
            this.Controls.Add(this.NumRowCount);
            this.Controls.Add(this.gbCellSize);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.gbCellSize.ResumeLayout(false);
            this.gbCellSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCellHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCellWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRowCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumColCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumBorderTickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectEtalon;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbCellSize;
        private System.Windows.Forms.NumericUpDown NumCellHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumCellWidth;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.NumericUpDown NumRowCount;
        private System.Windows.Forms.NumericUpDown NumColCount;
        private System.Windows.Forms.Label lblRowCount;
        private System.Windows.Forms.Label lblColCount;
        private System.Windows.Forms.Label lblBgColor;
        private System.Windows.Forms.Label lblGridColor;
        private System.Windows.Forms.Panel PanelGridColor;
        private System.Windows.Forms.Panel PanelBgColor;
        private System.Windows.Forms.Label LblBorderTickness;
        private System.Windows.Forms.NumericUpDown NumBorderTickness;
    }
}

