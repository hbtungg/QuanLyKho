namespace QuanLyKho
{
    partial class FrmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDangNhap));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblAuthor = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            btnThoat = new Guna.UI2.WinForms.Guna2Button();
            btnThuNho = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BackColor = SystemColors.ScrollBar;
            txtTenDangNhap.BorderStyle = BorderStyle.FixedSingle;
            txtTenDangNhap.Cursor = Cursors.IBeam;
            txtTenDangNhap.Location = new Point(615, 204);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(190, 27);
            txtTenDangNhap.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = SystemColors.ScrollBar;
            txtMatKhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatKhau.Cursor = Cursors.IBeam;
            txtMatKhau.Location = new Point(615, 253);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(190, 27);
            txtMatKhau.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(247, 246, 240);
            label1.Location = new Point(490, 207);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(247, 246, 240);
            label2.Location = new Point(490, 261);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 246, 240);
            panel1.Controls.Add(lblAuthor);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 477);
            panel1.TabIndex = 6;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Cursor = Cursors.Hand;
            lblAuthor.ForeColor = Color.FromArgb(87, 87, 86);
            lblAuthor.Location = new Point(12, 448);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(131, 20);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Author: @hbtungg";
            lblAuthor.Click += lblAuthor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 350);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(247, 246, 240);
            label4.Location = new Point(588, 133);
            label4.Name = "label4";
            label4.Size = new Size(122, 25);
            label4.TabIndex = 7;
            label4.Text = "ĐĂNG NHẬP";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BorderColor = Color.FromArgb(247, 246, 240);
            btnDangNhap.BorderRadius = 15;
            btnDangNhap.BorderThickness = 2;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.CustomBorderColor = Color.FromArgb(247, 246, 240);
            btnDangNhap.CustomizableEdges = customizableEdges1;
            btnDangNhap.DisabledState.BorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDangNhap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangNhap.FillColor = Color.FromArgb(87, 87, 86);
            btnDangNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangNhap.ForeColor = Color.FromArgb(247, 246, 240);
            btnDangNhap.HoverState.FillColor = SystemColors.ControlDarkDark;
            btnDangNhap.HoverState.ForeColor = Color.White;
            btnDangNhap.Location = new Point(570, 327);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDangNhap.Size = new Size(162, 56);
            btnDangNhap.TabIndex = 8;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.Enter += btnDangNhap_Click_1;
            // 
            // btnThoat
            // 
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.CustomizableEdges = customizableEdges3;
            btnThoat.DisabledState.BorderColor = Color.DarkGray;
            btnThoat.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThoat.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThoat.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThoat.FillColor = Color.FromArgb(87, 87, 86);
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.Location = new Point(847, 12);
            btnThoat.Name = "btnThoat";
            btnThoat.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnThoat.Size = new Size(40, 40);
            btnThoat.TabIndex = 9;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThuNho
            // 
            btnThuNho.Cursor = Cursors.Hand;
            btnThuNho.CustomizableEdges = customizableEdges5;
            btnThuNho.DisabledState.BorderColor = Color.DarkGray;
            btnThuNho.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThuNho.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThuNho.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThuNho.FillColor = Color.FromArgb(87, 87, 86);
            btnThuNho.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThuNho.ForeColor = Color.White;
            btnThuNho.Image = (Image)resources.GetObject("btnThuNho.Image");
            btnThuNho.Location = new Point(801, 12);
            btnThuNho.Name = "btnThuNho";
            btnThuNho.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnThuNho.Size = new Size(40, 40);
            btnThuNho.TabIndex = 10;
            btnThuNho.Click += btnThuNho_Click;
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(87, 87, 86);
            ClientSize = new Size(899, 477);
            Controls.Add(btnThuNho);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label4;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button btnThuNho;
        private Label lblAuthor;
    }
}