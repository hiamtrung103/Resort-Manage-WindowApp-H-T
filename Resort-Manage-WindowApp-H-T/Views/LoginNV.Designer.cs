namespace Resort_Manage_WindowApp_H_T.Frm_Log_Reg
{
    partial class LoginNV
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginNV));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            rjButton1 = new CustomControls.RJControls.RJButton();
            txtPass = new CustomControls.RJControls.RJTextBox();
            txtUserName = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(492, 437);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(rjButton1);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(510, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 437);
            panel1.TabIndex = 1;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.MediumSlateBlue;
            rjButton1.BackgroundColor = Color.MediumSlateBlue;
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(170, 250);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 40);
            rjButton1.TabIndex = 2;
            rjButton1.Text = "Đăng nhập";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += btnDangNhap_click;
            // 
            // txtPass
            // 
            txtPass.BackColor = SystemColors.Window;
            txtPass.BorderColor = Color.MediumSlateBlue;
            txtPass.BorderFocusColor = Color.HotPink;
            txtPass.BorderRadius = 5;
            txtPass.BorderSize = 2;
            txtPass.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.ForeColor = Color.FromArgb(64, 64, 64);
            txtPass.Location = new Point(79, 212);
            txtPass.Margin = new Padding(4);
            txtPass.Multiline = false;
            txtPass.Name = "txtPass";
            txtPass.Padding = new Padding(10, 7, 10, 7);
            txtPass.PasswordChar = true;
            txtPass.PlaceholderColor = Color.DarkGray;
            txtPass.PlaceholderText = "";
            txtPass.Size = new Size(331, 31);
            txtPass.TabIndex = 1;
            txtPass.Texts = "";
            txtPass.UnderlinedStyle = false;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Window;
            txtUserName.BorderColor = Color.MediumSlateBlue;
            txtUserName.BorderFocusColor = Color.HotPink;
            txtUserName.BorderRadius = 5;
            txtUserName.BorderSize = 2;
            txtUserName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.ForeColor = Color.FromArgb(64, 64, 64);
            txtUserName.Location = new Point(79, 149);
            txtUserName.Margin = new Padding(4);
            txtUserName.Multiline = false;
            txtUserName.Name = "txtUserName";
            txtUserName.Padding = new Padding(10, 7, 10, 7);
            txtUserName.PasswordChar = false;
            txtUserName.PlaceholderColor = Color.DarkGray;
            txtUserName.PlaceholderText = "";
            txtUserName.Size = new Size(331, 31);
            txtUserName.TabIndex = 1;
            txtUserName.Texts = "";
            txtUserName.UnderlinedStyle = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 184);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 0;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 121);
            label2.Name = "label2";
            label2.Size = new Size(93, 24);
            label2.TabIndex = 0;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 20);
            label1.Name = "label1";
            label1.Size = new Size(161, 37);
            label1.TabIndex = 0;
            label1.Text = "Nhân viên";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(409, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.Image = Properties.Resources.red_16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.Image = Properties.Resources.yellow_16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.ImageStates.ImagePressed = Properties.Resources.yellow_16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.ImageStates.ImageTracking = Properties.Resources.yellow_16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.Image = Properties.Resources.green16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.ImageStates.ImagePressed = Properties.Resources.green16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.ImageStates.ImageTracking = Properties.Resources.green16;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.Image = Properties.Resources.yellow_16;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateCommon.Border.Width = 1;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.LightCyan;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.Beige;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.ColorAngle = 45F;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(984, 461);
            panel2.TabIndex = 3;
            // 
            // LoginNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            IsMdiContainer = true;
            Name = "LoginNV";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginNV";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJTextBox txtPass;
        private CustomControls.RJControls.RJTextBox txtUserName;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Panel panel2;
    }
}