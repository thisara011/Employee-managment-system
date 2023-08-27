namespace Project01
{
    partial class Payrolls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_emp_id = new System.Windows.Forms.Label();
            this.GridView_MyPayroll = new System.Windows.Forms.DataGridView();
            this.all_Month_radiobtn = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.payrol_comboMonth = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.select_radiobtn = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.btn_back = new MagicUI.MagicControl.MagicButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_MyPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrol_comboMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Rounding = 12;
            this.kryptonPalette1.FormStyles.FormMain.StateActive.Border.Width = 0;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 58);
            this.label1.TabIndex = 30;
            this.label1.Text = "My Payroll";
            // 
            // lbl_emp_id
            // 
            this.lbl_emp_id.AutoSize = true;
            this.lbl_emp_id.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_id.Location = new System.Drawing.Point(971, 14);
            this.lbl_emp_id.Name = "lbl_emp_id";
            this.lbl_emp_id.Size = new System.Drawing.Size(71, 26);
            this.lbl_emp_id.TabIndex = 32;
            this.lbl_emp_id.Text = "Emp_ID";
            // 
            // GridView_MyPayroll
            // 
            this.GridView_MyPayroll.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.GridView_MyPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_MyPayroll.Location = new System.Drawing.Point(12, 276);
            this.GridView_MyPayroll.Name = "GridView_MyPayroll";
            this.GridView_MyPayroll.RowHeadersWidth = 51;
            this.GridView_MyPayroll.RowTemplate.Height = 24;
            this.GridView_MyPayroll.Size = new System.Drawing.Size(1238, 385);
            this.GridView_MyPayroll.TabIndex = 36;
            // 
            // all_Month_radiobtn
            // 
            this.all_Month_radiobtn.Location = new System.Drawing.Point(61, 192);
            this.all_Month_radiobtn.Name = "all_Month_radiobtn";
            this.all_Month_radiobtn.Size = new System.Drawing.Size(97, 24);
            this.all_Month_radiobtn.TabIndex = 37;
            this.all_Month_radiobtn.Values.Text = "All Months";
            this.all_Month_radiobtn.CheckedChanged += new System.EventHandler(this.all_Month_radiobtn_CheckedChanged);
            // 
            // payrol_comboMonth
            // 
            this.payrol_comboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payrol_comboMonth.DropDownWidth = 121;
            this.payrol_comboMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.payrol_comboMonth.Location = new System.Drawing.Point(509, 191);
            this.payrol_comboMonth.Name = "payrol_comboMonth";
            this.payrol_comboMonth.Size = new System.Drawing.Size(121, 25);
            this.payrol_comboMonth.TabIndex = 39;
            this.payrol_comboMonth.SelectedIndexChanged += new System.EventHandler(this.payrol_comboMonth_SelectedIndexChanged);
            // 
            // select_radiobtn
            // 
            this.select_radiobtn.Location = new System.Drawing.Point(378, 192);
            this.select_radiobtn.Name = "select_radiobtn";
            this.select_radiobtn.Size = new System.Drawing.Size(114, 24);
            this.select_radiobtn.TabIndex = 40;
            this.select_radiobtn.Values.Text = "Select Month";
            this.select_radiobtn.CheckedChanged += new System.EventHandler(this.select_radiobtn_CheckedChanged);
            // 
            // btn_back
            // 
            this.btn_back.AutoSize = true;
            this.btn_back.BackColor = System.Drawing.Color.IndianRed;
            this.btn_back.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btn_back.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_back.BorderRadius = 20;
            this.btn_back.BorderSize = 0;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(1193, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(57, 35);
            this.btn_back.TabIndex = 72;
            this.btn_back.Text = "Back";
            this.btn_back.TextColor = System.Drawing.Color.White;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Payrolls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1270, 725);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.select_radiobtn);
            this.Controls.Add(this.payrol_comboMonth);
            this.Controls.Add(this.all_Month_radiobtn);
            this.Controls.Add(this.GridView_MyPayroll);
            this.Controls.Add(this.lbl_emp_id);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Payrolls";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Payrolls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_MyPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrol_comboMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_emp_id;
        private System.Windows.Forms.DataGridView GridView_MyPayroll;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton all_Month_radiobtn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox payrol_comboMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton select_radiobtn;
        private MagicUI.MagicControl.MagicButton btn_back;
    }
}