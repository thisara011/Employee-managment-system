namespace Project01
{
    partial class Send_Announcement
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
            this.Select_EmpID_combo = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.btn_back = new MagicUI.MagicControl.MagicButton();
            this.show_EmpID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_allEmp = new System.Windows.Forms.RadioButton();
            this.radio_selectEmp = new System.Windows.Forms.RadioButton();
            this.msgText_box = new System.Windows.Forms.RichTextBox();
            this.btn_send = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.rad_Position = new System.Windows.Forms.RadioButton();
            this.Select_Positions = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Select_EmpID_combo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_Positions)).BeginInit();
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
            this.Select_EmpID_combo.Location = new System.Drawing.Point(851, 217);
            this.Select_EmpID_combo.Name = "Select_EmpID_combo";
            this.Select_EmpID_combo.Size = new System.Drawing.Size(166, 25);
            this.Select_EmpID_combo.TabIndex = 49;
            this.Select_EmpID_combo.SelectedIndexChanged += new System.EventHandler(this.Select_EmpID_combo_SelectedIndexChanged);
            // 
            // txt_Fname
            // 
            this.txt_Fname.Location = new System.Drawing.Point(1054, 219);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(166, 22);
            this.txt_Fname.TabIndex = 50;
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
            this.btn_back.TabIndex = 74;
            this.btn_back.Text = "Back";
            this.btn_back.TextColor = System.Drawing.Color.White;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // show_EmpID
            // 
            this.show_EmpID.AutoSize = true;
            this.show_EmpID.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_EmpID.Location = new System.Drawing.Point(982, 15);
            this.show_EmpID.Name = "show_EmpID";
            this.show_EmpID.Size = new System.Drawing.Size(81, 33);
            this.show_EmpID.TabIndex = 73;
            this.show_EmpID.Text = "emp ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 60);
            this.label1.TabIndex = 75;
            this.label1.Text = "Announcement";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 36);
            this.label2.TabIndex = 76;
            this.label2.Text = "To";
            // 
            // radio_allEmp
            // 
            this.radio_allEmp.AutoSize = true;
            this.radio_allEmp.Location = new System.Drawing.Point(111, 222);
            this.radio_allEmp.Name = "radio_allEmp";
            this.radio_allEmp.Size = new System.Drawing.Size(115, 20);
            this.radio_allEmp.TabIndex = 77;
            this.radio_allEmp.TabStop = true;
            this.radio_allEmp.Text = "All Employees";
            this.radio_allEmp.UseVisualStyleBackColor = true;
            this.radio_allEmp.CheckedChanged += new System.EventHandler(this.radio_allEmp_CheckedChanged);
            // 
            // radio_selectEmp
            // 
            this.radio_selectEmp.AutoSize = true;
            this.radio_selectEmp.Location = new System.Drawing.Point(701, 222);
            this.radio_selectEmp.Name = "radio_selectEmp";
            this.radio_selectEmp.Size = new System.Drawing.Size(131, 20);
            this.radio_selectEmp.TabIndex = 78;
            this.radio_selectEmp.TabStop = true;
            this.radio_selectEmp.Text = "Select Employee";
            this.radio_selectEmp.UseVisualStyleBackColor = true;
            this.radio_selectEmp.CheckedChanged += new System.EventHandler(this.radio_selectEmp_CheckedChanged);
            // 
            // msgText_box
            // 
            this.msgText_box.BackColor = System.Drawing.Color.AliceBlue;
            this.msgText_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgText_box.Location = new System.Drawing.Point(94, 321);
            this.msgText_box.Name = "msgText_box";
            this.msgText_box.Size = new System.Drawing.Size(847, 328);
            this.msgText_box.TabIndex = 79;
            this.msgText_box.Text = "Dear <  >,\n\n\n<type content>\n\n\n\nBest Regards,\nExecutive Management.";
            // 
            // btn_send
            // 
            this.btn_send.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_send.Location = new System.Drawing.Point(987, 485);
            this.btn_send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_send.Name = "btn_send";
            this.btn_send.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_send.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_send.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_send.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_send.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_send.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_send.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_send.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_send.OverrideDefault.Border.Rounding = 20;
            this.btn_send.OverrideDefault.Border.Width = 1;
            this.btn_send.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_send.Size = new System.Drawing.Size(257, 60);
            this.btn_send.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_send.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_send.StateCommon.Back.ColorAngle = 45F;
            this.btn_send.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_send.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_send.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_send.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_send.StateCommon.Border.Rounding = 20;
            this.btn_send.StateCommon.Border.Width = 1;
            this.btn_send.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_send.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_send.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.StateCommon.Content.ShortText.Trim = ComponentFactory.Krypton.Toolkit.PaletteTextTrim.EllipsisWord;
            this.btn_send.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btn_send.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btn_send.StatePressed.Back.ColorAngle = 135F;
            this.btn_send.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btn_send.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btn_send.StatePressed.Border.ColorAngle = 135F;
            this.btn_send.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_send.StatePressed.Border.Rounding = 20;
            this.btn_send.StatePressed.Border.Width = 1;
            this.btn_send.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_send.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_send.StateTracking.Back.ColorAngle = 45F;
            this.btn_send.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_send.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_send.StateTracking.Border.Rounding = 20;
            this.btn_send.StateTracking.Border.Width = 1;
            this.btn_send.TabIndex = 80;
            this.btn_send.Values.Text = "Send";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // rad_Position
            // 
            this.rad_Position.AutoSize = true;
            this.rad_Position.Location = new System.Drawing.Point(309, 222);
            this.rad_Position.Name = "rad_Position";
            this.rad_Position.Size = new System.Drawing.Size(124, 20);
            this.rad_Position.TabIndex = 81;
            this.rad_Position.TabStop = true;
            this.rad_Position.Text = "Select Positions";
            this.rad_Position.UseVisualStyleBackColor = true;
            this.rad_Position.CheckedChanged += new System.EventHandler(this.rad_Position_CheckedChanged);
            // 
            // Select_Positions
            // 
            this.Select_Positions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Select_Positions.DropDownWidth = 166;
            this.Select_Positions.Items.AddRange(new object[] {
            "Human Resources Manager",
            "Marketing Manager",
            "Sales Representative",
            "Project Manager",
            "Accountant",
            "Legal Counsel",
            "Other",
            "Temporary Worker",
            "Labourer"});
            this.Select_Positions.Location = new System.Drawing.Point(479, 222);
            this.Select_Positions.MinimumSize = new System.Drawing.Size(166, 27);
            this.Select_Positions.Name = "Select_Positions";
            this.Select_Positions.Size = new System.Drawing.Size(166, 27);
            this.Select_Positions.TabIndex = 83;
            // 
            // Send_Announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 702);
            this.ControlBox = false;
            this.Controls.Add(this.Select_Positions);
            this.Controls.Add(this.rad_Position);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.msgText_box);
            this.Controls.Add(this.radio_selectEmp);
            this.Controls.Add(this.radio_allEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.show_EmpID);
            this.Controls.Add(this.txt_Fname);
            this.Controls.Add(this.Select_EmpID_combo);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Send_Announcement";
            this.Palette = this.kryptonPalette1;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Send_Announcement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Select_EmpID_combo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Select_Positions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Select_EmpID_combo;
        private System.Windows.Forms.TextBox txt_Fname;
        private MagicUI.MagicControl.MagicButton btn_back;
        private System.Windows.Forms.Label show_EmpID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_allEmp;
        private System.Windows.Forms.RadioButton radio_selectEmp;
        private System.Windows.Forms.RichTextBox msgText_box;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_send;
        private System.Windows.Forms.RadioButton rad_Position;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox Select_Positions;
    }
}