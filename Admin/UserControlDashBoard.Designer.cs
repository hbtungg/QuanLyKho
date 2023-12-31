namespace QuanLyKho.Admin
{
    partial class UserControlDashBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDashBoard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panel1 = new Panel();
            lblAdmin = new Label();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            lblNhanVien = new Label();
            label5 = new Label();
            label3 = new Label();
            btnSync = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 43);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 0;
            label1.Text = "DashBoard";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lblAdmin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(274, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 619);
            panel1.TabIndex = 1;
            // 
            // lblAdmin
            // 
            lblAdmin.BackColor = SystemColors.ControlLight;
            lblAdmin.BorderStyle = BorderStyle.Fixed3D;
            lblAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdmin.Location = new Point(254, 566);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(43, 31);
            lblAdmin.TabIndex = 2;
            lblAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.GradientInactiveCaption;
            label4.Location = new Point(65, 566);
            label4.Name = "label4";
            label4.Size = new Size(183, 31);
            label4.TabIndex = 1;
            label4.Text = "Tổng số Admin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GradientInactiveCaption;
            label2.Location = new Point(182, 30);
            label2.Name = "label2";
            label2.Size = new Size(86, 31);
            label2.TabIndex = 0;
            label2.Text = "Admin";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.HotTrack;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(lblNhanVien);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(935, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(448, 619);
            panel2.TabIndex = 2;
            // 
            // lblNhanVien
            // 
            lblNhanVien.BackColor = SystemColors.ControlLight;
            lblNhanVien.BorderStyle = BorderStyle.Fixed3D;
            lblNhanVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNhanVien.Location = new Point(313, 570);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(43, 31);
            lblNhanVien.TabIndex = 3;
            lblNhanVien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.GradientInactiveCaption;
            label5.Location = new Point(91, 566);
            label5.Name = "label5";
            label5.Size = new Size(216, 31);
            label5.TabIndex = 3;
            label5.Text = "Tổng số nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.GradientInactiveCaption;
            label3.Location = new Point(161, 30);
            label3.Name = "label3";
            label3.Size = new Size(126, 31);
            label3.TabIndex = 3;
            label3.Text = "Nhân Viên";
            // 
            // btnSync
            // 
            btnSync.BorderRadius = 25;
            btnSync.BorderThickness = 1;
            btnSync.Cursor = Cursors.Hand;
            btnSync.CustomBorderColor = Color.Black;
            btnSync.CustomizableEdges = customizableEdges1;
            btnSync.DisabledState.BorderColor = Color.DarkGray;
            btnSync.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSync.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSync.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSync.FillColor = Color.White;
            btnSync.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSync.ForeColor = Color.White;
            btnSync.Image = (Image)resources.GetObject("btnSync.Image");
            btnSync.ImageSize = new Size(30, 30);
            btnSync.Location = new Point(271, 43);
            btnSync.Name = "btnSync";
            btnSync.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSync.Size = new Size(50, 50);
            btnSync.TabIndex = 3;
            btnSync.Click += btnSync_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.GradientInactiveCaption;
            label6.Location = new Point(33, 181);
            label6.Name = "label6";
            label6.Size = new Size(341, 124);
            label6.TabIndex = 3;
            label6.Text = "Chức năng:\r\n- Quản lý danh sách nhân viên.\r\n- Thêm nhân viên.\r\n- Chỉnh sửa hồ sơ.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.GradientInactiveCaption;
            label7.Location = new Point(44, 181);
            label7.Name = "label7";
            label7.Size = new Size(355, 155);
            label7.TabIndex = 4;
            label7.Text = "Chức năng:\r\n- Quản lý danh mục sản phẩm.\r\n- Quản lý danh sách sản phẩm.\r\n- Quản lý nhà phân phối.\r\n- Quản lý hoạt động nhập, xuất.";
            // 
            // UserControlDashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnSync);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "UserControlDashBoard";
            Size = new Size(1665, 1100);
            Load += UserControlDashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Label lblAdmin;
        private Label label4;
        private Label label5;
        private Label lblNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnSync;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label label6;
        private Label label7;
    }
}
