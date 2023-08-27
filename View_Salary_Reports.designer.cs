namespace Project01
{
    partial class View_Salary_Reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Project01.DataSet2();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.combo_DepID = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.radio_dep = new System.Windows.Forms.RadioButton();
            this.SalreportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Combo_Select_Month = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Select__Month = new System.Windows.Forms.RadioButton();
            this.Combo_Select_Emp_ID = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.Select_Emp_ID = new System.Windows.Forms.RadioButton();
            this.Combo_position = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.radio_position = new System.Windows.Forms.RadioButton();
            this.radio_allEmp = new System.Windows.Forms.RadioButton();
            this.show_EmpID = new System.Windows.Forms.Label();
            this.btn_back = new MagicUI.MagicControl.MagicButton();
            this.salaryTableAdapter = new Project01.DataSet2TableAdapters.salaryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_DepID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_Select_Month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_Select_Emp_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_position)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "salary";
            this.salaryBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.label1.Size = new System.Drawing.Size(368, 58);
            this.label1.TabIndex = 30;
            this.label1.Text = "View Salary Reports";
            // 
            // combo_DepID
            // 
            this.combo_DepID.DropDownWidth = 138;
            this.combo_DepID.Items.AddRange(new object[] {
            "D001",
            "D002",
            "D003",
            "D004"});
            this.combo_DepID.Location = new System.Drawing.Point(528, 98);
            this.combo_DepID.Name = "combo_DepID";
            this.combo_DepID.Size = new System.Drawing.Size(145, 25);
            this.combo_DepID.TabIndex = 44;
            this.combo_DepID.Text = "Select DepID";
            this.combo_DepID.SelectedIndexChanged += new System.EventHandler(this.combo_DepID_SelectedIndexChanged);
            // 
            // radio_dep
            // 
            this.radio_dep.AutoSize = true;
            this.radio_dep.Location = new System.Drawing.Point(414, 98);
            this.radio_dep.MinimumSize = new System.Drawing.Size(103, 25);
            this.radio_dep.Name = "radio_dep";
            this.radio_dep.Size = new System.Drawing.Size(108, 25);
            this.radio_dep.TabIndex = 43;
            this.radio_dep.TabStop = true;
            this.radio_dep.Text = "Select DepID";
            this.radio_dep.UseVisualStyleBackColor = true;
            this.radio_dep.CheckedChanged += new System.EventHandler(this.radio_dep_CheckedChanged);
            // 
            // SalreportViewer1
            // 
            this.SalreportViewer1.BackColor = System.Drawing.Color.AliceBlue;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.salaryBindingSource;
            this.SalreportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.SalreportViewer1.LocalReport.ReportEmbeddedResource = "Project01.Report1.rdlc";
            this.SalreportViewer1.Location = new System.Drawing.Point(12, 198);
            this.SalreportViewer1.Name = "SalreportViewer1";
            this.SalreportViewer1.ServerReport.BearerToken = null;
            this.SalreportViewer1.Size = new System.Drawing.Size(1878, 823);
            this.SalreportViewer1.TabIndex = 42;
            this.SalreportViewer1.Load += new System.EventHandler(this.SalreportViewer1_Load);
            // 
            // Combo_Select_Month
            // 
            this.Combo_Select_Month.DropDownWidth = 138;
            this.Combo_Select_Month.Items.AddRange(new object[] {
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
            this.Combo_Select_Month.Location = new System.Drawing.Point(162, 98);
            this.Combo_Select_Month.Name = "Combo_Select_Month";
            this.Combo_Select_Month.Size = new System.Drawing.Size(138, 25);
            this.Combo_Select_Month.TabIndex = 41;
            this.Combo_Select_Month.Text = "Select_Month";
            this.Combo_Select_Month.SelectedIndexChanged += new System.EventHandler(this.Combo_Select_Month_SelectedIndexChanged);
            // 
            // Select__Month
            // 
            this.Select__Month.AutoSize = true;
            this.Select__Month.Location = new System.Drawing.Point(41, 98);
            this.Select__Month.MinimumSize = new System.Drawing.Size(103, 25);
            this.Select__Month.Name = "Select__Month";
            this.Select__Month.Size = new System.Drawing.Size(105, 25);
            this.Select__Month.TabIndex = 40;
            this.Select__Month.TabStop = true;
            this.Select__Month.Text = "Select Month";
            this.Select__Month.UseVisualStyleBackColor = true;
            this.Select__Month.CheckedChanged += new System.EventHandler(this.Select__Month_CheckedChanged);
            // 
            // Combo_Select_Emp_ID
            // 
            this.Combo_Select_Emp_ID.DropDownWidth = 138;
            this.Combo_Select_Emp_ID.Location = new System.Drawing.Point(915, 98);
            this.Combo_Select_Emp_ID.Name = "Combo_Select_Emp_ID";
            this.Combo_Select_Emp_ID.Size = new System.Drawing.Size(145, 25);
            this.Combo_Select_Emp_ID.TabIndex = 46;
            this.Combo_Select_Emp_ID.Text = "Select_Emp_ID";
            this.Combo_Select_Emp_ID.SelectedIndexChanged += new System.EventHandler(this.Combo_Select_Emp_ID_SelectedIndexChanged);
            // 
            // Select_Emp_ID
            // 
            this.Select_Emp_ID.AutoSize = true;
            this.Select_Emp_ID.Location = new System.Drawing.Point(792, 98);
            this.Select_Emp_ID.MinimumSize = new System.Drawing.Size(103, 25);
            this.Select_Emp_ID.Name = "Select_Emp_ID";
            this.Select_Emp_ID.Size = new System.Drawing.Size(117, 25);
            this.Select_Emp_ID.TabIndex = 45;
            this.Select_Emp_ID.TabStop = true;
            this.Select_Emp_ID.Text = "Select Emp_ID";
            this.Select_Emp_ID.UseVisualStyleBackColor = true;
            this.Select_Emp_ID.CheckedChanged += new System.EventHandler(this.Select_Emp_ID_CheckedChanged);
            // 
            // Combo_position
            // 
            this.Combo_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combo_position.DropDownWidth = 138;
            this.Combo_position.Items.AddRange(new object[] {
            "Chief Executive Officer (CEO)",
            "Human Resources Manager",
            "Marketing Manager",
            "Sales Representative",
            "Project Manager",
            "Accountant",
            "Legal Counsel",
            "Other",
            "Temporary Worker",
            "Labourer"});
            this.Combo_position.Location = new System.Drawing.Point(1309, 98);
            this.Combo_position.Name = "Combo_position";
            this.Combo_position.Size = new System.Drawing.Size(145, 25);
            this.Combo_position.TabIndex = 48;
            this.Combo_position.SelectedIndexChanged += new System.EventHandler(this.Combo_position_SelectedIndexChanged);
            // 
            // radio_position
            // 
            this.radio_position.AutoSize = true;
            this.radio_position.Location = new System.Drawing.Point(1186, 98);
            this.radio_position.MinimumSize = new System.Drawing.Size(103, 25);
            this.radio_position.Name = "radio_position";
            this.radio_position.Size = new System.Drawing.Size(117, 25);
            this.radio_position.TabIndex = 47;
            this.radio_position.TabStop = true;
            this.radio_position.Text = "Select Position";
            this.radio_position.UseVisualStyleBackColor = true;
            this.radio_position.CheckedChanged += new System.EventHandler(this.radio_position_CheckedChanged);
            // 
            // radio_allEmp
            // 
            this.radio_allEmp.AutoSize = true;
            this.radio_allEmp.Location = new System.Drawing.Point(1591, 98);
            this.radio_allEmp.MinimumSize = new System.Drawing.Size(103, 25);
            this.radio_allEmp.Name = "radio_allEmp";
            this.radio_allEmp.Size = new System.Drawing.Size(119, 25);
            this.radio_allEmp.TabIndex = 49;
            this.radio_allEmp.TabStop = true;
            this.radio_allEmp.Text = "All_Employees";
            this.radio_allEmp.UseVisualStyleBackColor = true;
            this.radio_allEmp.CheckedChanged += new System.EventHandler(this.radio_allEmp_CheckedChanged);
            // 
            // show_EmpID
            // 
            this.show_EmpID.AutoSize = true;
            this.show_EmpID.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_EmpID.Location = new System.Drawing.Point(1586, 17);
            this.show_EmpID.Name = "show_EmpID";
            this.show_EmpID.Size = new System.Drawing.Size(65, 26);
            this.show_EmpID.TabIndex = 70;
            this.show_EmpID.Text = "emp ID";
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
            this.btn_back.Location = new System.Drawing.Point(1833, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(57, 35);
            this.btn_back.TabIndex = 72;
            this.btn_back.Text = "Back";
            this.btn_back.TextColor = System.Drawing.Color.White;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // View_Salary_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1062);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.show_EmpID);
            this.Controls.Add(this.radio_allEmp);
            this.Controls.Add(this.Combo_position);
            this.Controls.Add(this.radio_position);
            this.Controls.Add(this.Combo_Select_Emp_ID);
            this.Controls.Add(this.Select_Emp_ID);
            this.Controls.Add(this.combo_DepID);
            this.Controls.Add(this.radio_dep);
            this.Controls.Add(this.SalreportViewer1);
            this.Controls.Add(this.Combo_Select_Month);
            this.Controls.Add(this.Select__Month);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1018);
            this.Name = "View_Salary_Reports";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.View_Salary_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_DepID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_Select_Month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_Select_Emp_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_position)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox combo_DepID;
        private System.Windows.Forms.RadioButton radio_dep;
        private Microsoft.Reporting.WinForms.ReportViewer SalreportViewer1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Combo_Select_Month;
        private System.Windows.Forms.RadioButton Select__Month;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Combo_Select_Emp_ID;
        private System.Windows.Forms.RadioButton Select_Emp_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Combo_position;
        private System.Windows.Forms.RadioButton radio_position;
        private System.Windows.Forms.RadioButton radio_allEmp;
        private System.Windows.Forms.Label show_EmpID;
        private MagicUI.MagicControl.MagicButton btn_back;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private DataSet2TableAdapters.salaryTableAdapter salaryTableAdapter;
    }
}