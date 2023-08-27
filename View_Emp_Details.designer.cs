namespace Project01
{
    partial class View_Emp_Details
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
            this.View_EmpGridView = new System.Windows.Forms.DataGridView();
            this.Select_Emp = new System.Windows.Forms.RadioButton();
            this.all_emp = new System.Windows.Forms.RadioButton();
            this.show_EmpID = new System.Windows.Forms.Label();
            this.Select_EmpID_combo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.btn_back = new MagicUI.MagicControl.MagicButton();
            ((System.ComponentModel.ISupportInitialize)(this.View_EmpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_EmpID_combo)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(410, 58);
            this.label1.TabIndex = 30;
            this.label1.Text = "View Employee Details";
            // 
            // View_EmpGridView
            // 
            this.View_EmpGridView.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.View_EmpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.View_EmpGridView.Location = new System.Drawing.Point(22, 334);
            this.View_EmpGridView.Name = "View_EmpGridView";
            this.View_EmpGridView.RowHeadersWidth = 51;
            this.View_EmpGridView.RowTemplate.Height = 24;
            this.View_EmpGridView.Size = new System.Drawing.Size(1228, 317);
            this.View_EmpGridView.TabIndex = 31;
            // 
            // Select_Emp
            // 
            this.Select_Emp.AutoSize = true;
            this.Select_Emp.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_Emp.Location = new System.Drawing.Point(487, 206);
            this.Select_Emp.Name = "Select_Emp";
            this.Select_Emp.Size = new System.Drawing.Size(134, 30);
            this.Select_Emp.TabIndex = 33;
            this.Select_Emp.TabStop = true;
            this.Select_Emp.Text = "Select Emp ID";
            this.Select_Emp.UseVisualStyleBackColor = true;
            this.Select_Emp.CheckedChanged += new System.EventHandler(this.Select_Emp_CheckedChanged);
            // 
            // all_emp
            // 
            this.all_emp.AutoSize = true;
            this.all_emp.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_emp.Location = new System.Drawing.Point(121, 206);
            this.all_emp.Name = "all_emp";
            this.all_emp.Size = new System.Drawing.Size(136, 30);
            this.all_emp.TabIndex = 34;
            this.all_emp.TabStop = true;
            this.all_emp.Text = "All Employees";
            this.all_emp.UseVisualStyleBackColor = true;
            this.all_emp.CheckedChanged += new System.EventHandler(this.all_emp_CheckedChanged);
            // 
            // show_EmpID
            // 
            this.show_EmpID.AutoSize = true;
            this.show_EmpID.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_EmpID.Location = new System.Drawing.Point(1008, 15);
            this.show_EmpID.Name = "show_EmpID";
            this.show_EmpID.Size = new System.Drawing.Size(81, 33);
            this.show_EmpID.TabIndex = 47;
            this.show_EmpID.Text = "emp ID";
            // 
            // Select_EmpID_combo
            // 
            this.Select_EmpID_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Select_EmpID_combo.DropDownWidth = 121;
            this.Select_EmpID_combo.Items.AddRange(new object[] {
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
            "December",
            "All"});
            this.Select_EmpID_combo.Location = new System.Drawing.Point(649, 206);
            this.Select_EmpID_combo.Name = "Select_EmpID_combo";
            this.Select_EmpID_combo.Size = new System.Drawing.Size(196, 25);
            this.Select_EmpID_combo.TabIndex = 48;
            this.Select_EmpID_combo.SelectedIndexChanged += new System.EventHandler(this.Select_EmpID_combo_SelectedIndexChanged);
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
            this.btn_back.Size = new System.Drawing.Size(57, 31);
            this.btn_back.TabIndex = 72;
            this.btn_back.Text = "Back";
            this.btn_back.TextColor = System.Drawing.Color.White;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // View_Emp_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 702);
            this.ControlBox = false;
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.Select_EmpID_combo);
            this.Controls.Add(this.show_EmpID);
            this.Controls.Add(this.all_emp);
            this.Controls.Add(this.Select_Emp);
            this.Controls.Add(this.View_EmpGridView);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.Name = "View_Emp_Details";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.View_Emp_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_EmpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_EmpID_combo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView View_EmpGridView;
        private System.Windows.Forms.RadioButton Select_Emp;
        private System.Windows.Forms.RadioButton all_emp;
        private System.Windows.Forms.Label show_EmpID;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Select_EmpID_combo;
        private MagicUI.MagicControl.MagicButton btn_back;
    }
}