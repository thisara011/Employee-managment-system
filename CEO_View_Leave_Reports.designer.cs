namespace Project01
{
    partial class CEO_View_Leave_Reports
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
            this.leaveRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Project01.DataSet2();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Select_Emp_ID = new System.Windows.Forms.RadioButton();
            this.Combo_Select_Emp_ID = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.combo_DepID = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.radio_dep = new System.Windows.Forms.RadioButton();
            this.radio_allEmp = new System.Windows.Forms.RadioButton();
            this.btn_back = new MagicUI.MagicControl.MagicButton();
            this.lbl_emp_id = new System.Windows.Forms.Label();
            this.SalreportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.leaveRequestTableAdapter = new Project01.DataSet2TableAdapters.LeaveRequestTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_Select_Emp_ID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_DepID)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveRequestBindingSource
            // 
            this.leaveRequestBindingSource.DataMember = "LeaveRequest";
            this.leaveRequestBindingSource.DataSource = this.dataSet2;
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
            this.label1.Size = new System.Drawing.Size(355, 58);
            this.label1.TabIndex = 30;
            this.label1.Text = "View Leave Reports";
            // 
            // Select_Emp_ID
            // 
            this.Select_Emp_ID.AutoSize = true;
            this.Select_Emp_ID.Location = new System.Drawing.Point(148, 131);
            this.Select_Emp_ID.MinimumSize = new System.Drawing.Size(103, 25);
            this.Select_Emp_ID.Name = "Select_Emp_ID";
            this.Select_Emp_ID.Size = new System.Drawing.Size(117, 25);
            this.Select_Emp_ID.TabIndex = 31;
            this.Select_Emp_ID.TabStop = true;
            this.Select_Emp_ID.Text = "Select Emp_ID";
            this.Select_Emp_ID.UseVisualStyleBackColor = true;
            this.Select_Emp_ID.CheckedChanged += new System.EventHandler(this.Select_Emp_ID_CheckedChanged);
            // 
            // Combo_Select_Emp_ID
            // 
            this.Combo_Select_Emp_ID.DropDownWidth = 138;
            this.Combo_Select_Emp_ID.Location = new System.Drawing.Point(271, 131);
            this.Combo_Select_Emp_ID.Name = "Combo_Select_Emp_ID";
            this.Combo_Select_Emp_ID.Size = new System.Drawing.Size(138, 25);
            this.Combo_Select_Emp_ID.TabIndex = 34;
            this.Combo_Select_Emp_ID.Text = "Select_Emp_ID";
            this.Combo_Select_Emp_ID.SelectedIndexChanged += new System.EventHandler(this.Combo_Select_Emp_ID_SelectedIndexChanged);
            // 
            // combo_DepID
            // 
            this.combo_DepID.DropDownWidth = 138;
            this.combo_DepID.Items.AddRange(new object[] {
            "D001",
            "D002",
            "D003",
            "D004"});
            this.combo_DepID.Location = new System.Drawing.Point(563, 131);
            this.combo_DepID.Name = "combo_DepID";
            this.combo_DepID.Size = new System.Drawing.Size(138, 25);
            this.combo_DepID.TabIndex = 39;
            this.combo_DepID.Text = "Select DepID";
            this.combo_DepID.SelectedIndexChanged += new System.EventHandler(this.combo_DepID_SelectedIndexChanged);
            // 
            // radio_dep
            // 
            this.radio_dep.AutoSize = true;
            this.radio_dep.Location = new System.Drawing.Point(449, 131);
            this.radio_dep.MinimumSize = new System.Drawing.Size(103, 25);
            this.radio_dep.Name = "radio_dep";
            this.radio_dep.Size = new System.Drawing.Size(108, 25);
            this.radio_dep.TabIndex = 38;
            this.radio_dep.TabStop = true;
            this.radio_dep.Text = "Select DepID";
            this.radio_dep.UseVisualStyleBackColor = true;
            this.radio_dep.CheckedChanged += new System.EventHandler(this.radio_dep_CheckedChanged);
            // 
            // radio_allEmp
            // 
            this.radio_allEmp.AutoSize = true;
            this.radio_allEmp.Location = new System.Drawing.Point(949, 131);
            this.radio_allEmp.MinimumSize = new System.Drawing.Size(103, 25);
            this.radio_allEmp.Name = "radio_allEmp";
            this.radio_allEmp.Size = new System.Drawing.Size(119, 25);
            this.radio_allEmp.TabIndex = 40;
            this.radio_allEmp.TabStop = true;
            this.radio_allEmp.Text = "All_Employees";
            this.radio_allEmp.UseVisualStyleBackColor = true;
            this.radio_allEmp.CheckedChanged += new System.EventHandler(this.radio_allEmp_CheckedChanged);
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
            this.btn_back.TabIndex = 74;
            this.btn_back.Text = "Back";
            this.btn_back.TextColor = System.Drawing.Color.White;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_emp_id
            // 
            this.lbl_emp_id.AutoSize = true;
            this.lbl_emp_id.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_emp_id.Location = new System.Drawing.Point(944, 17);
            this.lbl_emp_id.Name = "lbl_emp_id";
            this.lbl_emp_id.Size = new System.Drawing.Size(0, 26);
            this.lbl_emp_id.TabIndex = 73;
            // 
            // SalreportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.leaveRequestBindingSource;
            this.SalreportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.SalreportViewer1.LocalReport.ReportEmbeddedResource = "Project01.Report2.rdlc";
            this.SalreportViewer1.Location = new System.Drawing.Point(57, 227);
            this.SalreportViewer1.Name = "SalreportViewer1";
            this.SalreportViewer1.ServerReport.BearerToken = null;
            this.SalreportViewer1.Size = new System.Drawing.Size(1130, 403);
            this.SalreportViewer1.TabIndex = 75;
            // 
            // leaveRequestTableAdapter
            // 
            this.leaveRequestTableAdapter.ClearBeforeFill = true;
            // 
            // CEO_View_Leave_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.SalreportViewer1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_emp_id);
            this.Controls.Add(this.radio_allEmp);
            this.Controls.Add(this.combo_DepID);
            this.Controls.Add(this.radio_dep);
            this.Controls.Add(this.Combo_Select_Emp_ID);
            this.Controls.Add(this.Select_Emp_ID);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "CEO_View_Leave_Reports";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CEO_View_Leave_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Combo_Select_Emp_ID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combo_DepID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Select_Emp_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Combo_Select_Emp_ID;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox combo_DepID;
        private System.Windows.Forms.RadioButton radio_dep;
        private System.Windows.Forms.RadioButton radio_allEmp;
        private MagicUI.MagicControl.MagicButton btn_back;
        private System.Windows.Forms.Label lbl_emp_id;
        private Microsoft.Reporting.WinForms.ReportViewer SalreportViewer1;
        private System.Windows.Forms.BindingSource leaveRequestBindingSource;
        private DataSet2 dataSet2;
        private DataSet2TableAdapters.LeaveRequestTableAdapter leaveRequestTableAdapter;
    }
}