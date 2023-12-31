namespace QuanLyKho
{
    partial class FrmAdmin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            panel1 = new Panel();
            label2 = new Label();
            btnHoSo = new Guna.UI2.WinForms.Guna2Button();
            btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            btnDanhSachNhanVien = new Guna.UI2.WinForms.Guna2Button();
            btnThemNguoiDung = new Guna.UI2.WinForms.Guna2Button();
            btnDashBoard = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            lblUserName = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            userControlDashBoard1 = new Admin.UserControlDashBoard();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(components);
            userControlThemNhanVien1 = new Admin.UserControlThemNhanVien();
            userControlDanhSachNhanVien1 = new Admin.UserControlDanhSachNhanVien();
            guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(components);
            userControlHoSo1 = new Admin.UserControlHoSo();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnHoSo);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnDanhSachNhanVien);
            panel1.Controls.Add(btnThemNguoiDung);
            panel1.Controls.Add(btnDashBoard);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 1100);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(21, 996);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 13;
            label2.Text = "Welcome:";
            // 
            // btnHoSo
            // 
            btnHoSo.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnHoSo.Cursor = Cursors.Hand;
            btnHoSo.CustomizableEdges = customizableEdges1;
            btnHoSo.DisabledState.BorderColor = Color.DarkGray;
            btnHoSo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnHoSo.DisabledState.FillColor = Color.FromArgb(64, 64, 64);
            btnHoSo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnHoSo.FillColor = Color.FromArgb(64, 64, 64);
            btnHoSo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoSo.ForeColor = Color.White;
            btnHoSo.HoverState.FillColor = Color.White;
            btnHoSo.HoverState.ForeColor = Color.Black;
            btnHoSo.Location = new Point(0, 704);
            btnHoSo.Name = "btnHoSo";
            btnHoSo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnHoSo.Size = new Size(256, 70);
            btnHoSo.TabIndex = 12;
            btnHoSo.Text = "Hồ Sơ";
            btnHoSo.Click += btnHoSo_Click;
            // 
            // btnDangXuat
            // 
            btnDangXuat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnDangXuat.Cursor = Cursors.Hand;
            btnDangXuat.CustomizableEdges = customizableEdges3;
            btnDangXuat.DisabledState.BorderColor = Color.DarkGray;
            btnDangXuat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangXuat.DisabledState.FillColor = Color.FromArgb(64, 64, 64);
            btnDangXuat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangXuat.FillColor = Color.FromArgb(64, 64, 64);
            btnDangXuat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.HoverState.FillColor = Color.White;
            btnDangXuat.HoverState.ForeColor = Color.Black;
            btnDangXuat.Location = new Point(0, 812);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDangXuat.Size = new Size(256, 70);
            btnDangXuat.TabIndex = 11;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnDanhSachNhanVien
            // 
            btnDanhSachNhanVien.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnDanhSachNhanVien.Cursor = Cursors.Hand;
            btnDanhSachNhanVien.CustomizableEdges = customizableEdges5;
            btnDanhSachNhanVien.DisabledState.BorderColor = Color.DarkGray;
            btnDanhSachNhanVien.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDanhSachNhanVien.DisabledState.FillColor = Color.FromArgb(64, 64, 64);
            btnDanhSachNhanVien.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDanhSachNhanVien.FillColor = Color.FromArgb(64, 64, 64);
            btnDanhSachNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDanhSachNhanVien.ForeColor = Color.White;
            btnDanhSachNhanVien.HoverState.FillColor = Color.White;
            btnDanhSachNhanVien.HoverState.ForeColor = Color.Black;
            btnDanhSachNhanVien.Location = new Point(3, 597);
            btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            btnDanhSachNhanVien.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnDanhSachNhanVien.Size = new Size(256, 70);
            btnDanhSachNhanVien.TabIndex = 10;
            btnDanhSachNhanVien.Text = "Danh Sách Nhân Viên";
            btnDanhSachNhanVien.Click += btnDanhSachNhanVien_Click;
            // 
            // btnThemNguoiDung
            // 
            btnThemNguoiDung.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnThemNguoiDung.Cursor = Cursors.Hand;
            btnThemNguoiDung.CustomizableEdges = customizableEdges7;
            btnThemNguoiDung.DisabledState.BorderColor = Color.DarkGray;
            btnThemNguoiDung.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThemNguoiDung.DisabledState.FillColor = Color.FromArgb(64, 64, 64);
            btnThemNguoiDung.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThemNguoiDung.FillColor = Color.FromArgb(64, 64, 64);
            btnThemNguoiDung.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThemNguoiDung.ForeColor = Color.White;
            btnThemNguoiDung.HoverState.FillColor = Color.White;
            btnThemNguoiDung.HoverState.ForeColor = Color.Black;
            btnThemNguoiDung.Location = new Point(0, 478);
            btnThemNguoiDung.Name = "btnThemNguoiDung";
            btnThemNguoiDung.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnThemNguoiDung.Size = new Size(256, 70);
            btnThemNguoiDung.TabIndex = 9;
            btnThemNguoiDung.Text = "Thêm Người Dùng";
            btnThemNguoiDung.Click += btnThemNguoiDung_Click;
            // 
            // btnDashBoard
            // 
            btnDashBoard.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnDashBoard.Cursor = Cursors.Hand;
            btnDashBoard.CustomizableEdges = customizableEdges9;
            btnDashBoard.DisabledState.BorderColor = Color.DarkGray;
            btnDashBoard.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDashBoard.DisabledState.FillColor = Color.FromArgb(64, 64, 64);
            btnDashBoard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDashBoard.FillColor = Color.FromArgb(64, 64, 64);
            btnDashBoard.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDashBoard.ForeColor = Color.White;
            btnDashBoard.HoverState.FillColor = Color.White;
            btnDashBoard.HoverState.ForeColor = Color.Black;
            btnDashBoard.Location = new Point(0, 355);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDashBoard.Size = new Size(256, 70);
            btnDashBoard.TabIndex = 8;
            btnDashBoard.Text = "DashBoard";
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(253, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(2223, 1598);
            panel2.TabIndex = 1;
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.Red;
            lblUserName.Location = new Point(30, 973);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(256, 68);
            lblUserName.TabIndex = 7;
            lblUserName.Text = "Admin";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            lblUserName.Click += lblUserName_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(73, 217);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 1;
            label1.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(49, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // userControlDashBoard1
            // 
            userControlDashBoard1.BorderStyle = BorderStyle.FixedSingle;
            userControlDashBoard1.Location = new Point(256, 0);
            userControlDashBoard1.Name = "userControlDashBoard1";
            userControlDashBoard1.Size = new Size(2084, 1378);
            userControlDashBoard1.TabIndex = 1;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = panel1;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = panel2;
            // 
            // guna2Elipse3
            // 
            guna2Elipse3.TargetControl = panel2;
            // 
            // userControlThemNhanVien1
            // 
            userControlThemNhanVien1.ForeColor = Color.Black;
            userControlThemNhanVien1.Location = new Point(256, 0);
            userControlThemNhanVien1.Name = "userControlThemNhanVien1";
            userControlThemNhanVien1.Size = new Size(2258, 1440);
            userControlThemNhanVien1.TabIndex = 2;
            // 
            // userControlDanhSachNhanVien1
            // 
            userControlDanhSachNhanVien1.Location = new Point(256, 0);
            userControlDanhSachNhanVien1.Name = "userControlDanhSachNhanVien1";
            userControlDanhSachNhanVien1.Size = new Size(2084, 1378);
            userControlDanhSachNhanVien1.TabIndex = 3;
            // 
            // guna2Elipse4
            // 
            guna2Elipse4.TargetControl = panel2;
            // 
            // userControlHoSo1
            // 
            userControlHoSo1.ForeColor = Color.Black;
            userControlHoSo1.Location = new Point(256, 0);
            userControlHoSo1.Name = "userControlHoSo1";
            userControlHoSo1.Size = new Size(2084, 1378);
            userControlHoSo1.TabIndex = 4;
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(userControlHoSo1);
            Controls.Add(userControlDanhSachNhanVien1);
            Controls.Add(userControlThemNhanVien1);
            Controls.Add(userControlDashBoard1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAdmin";
            WindowState = FormWindowState.Maximized;
            Load += FrmAdmin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblUserName;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnDashBoard;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnDanhSachNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnThemNguoiDung;
        private Guna.UI2.WinForms.Guna2Button btnHoSo;
        private Admin.UserControlDashBoard userControlDashBoard1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Admin.UserControlThemNhanVien userControlThemNhanVien1;
        private Label label2;
        private Admin.UserControlDanhSachNhanVien userControlDanhSachNhanVien1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Admin.UserControlHoSo userControlHoSo1;
    }
}