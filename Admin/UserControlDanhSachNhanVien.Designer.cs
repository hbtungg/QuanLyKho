namespace QuanLyKho.Admin
{
    partial class UserControlDanhSachNhanVien
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDanhSachNhanVien));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            label2 = new Label();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            btnXoaHoSo = new Guna.UI2.WinForms.Guna2Button();
            btnReload = new Guna.UI2.WinForms.Guna2Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 43);
            label1.Name = "label1";
            label1.Size = new Size(347, 46);
            label1.TabIndex = 1;
            label1.Text = "Danh sách nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1188, 160);
            label2.Name = "label2";
            label2.Size = new Size(105, 28);
            label2.TabIndex = 2;
            label2.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.CustomizableEdges = customizableEdges1;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.ForeColor = Color.Black;
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(1310, 160);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderForeColor = Color.Silver;
            txtTimKiem.PlaceholderText = "Nhập thông tin tìm kiếm...";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(287, 32);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 4;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.Location = new Point(71, 226);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.RowTemplate.Height = 29;
            guna2DataGridView1.Size = new Size(1526, 676);
            guna2DataGridView1.TabIndex = 4;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.CellClick += guna2DataGridView1_CellClick;
            guna2DataGridView1.CellDoubleClick += guna2DataGridView1_CellDoubleClick;
            // 
            // btnXoaHoSo
            // 
            btnXoaHoSo.BorderRadius = 15;
            btnXoaHoSo.Cursor = Cursors.Hand;
            btnXoaHoSo.CustomizableEdges = customizableEdges3;
            btnXoaHoSo.DisabledState.BorderColor = Color.DarkGray;
            btnXoaHoSo.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoaHoSo.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoaHoSo.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoaHoSo.FillColor = SystemColors.ControlDark;
            btnXoaHoSo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoaHoSo.ForeColor = Color.Black;
            btnXoaHoSo.HoverState.FillColor = SystemColors.ControlDarkDark;
            btnXoaHoSo.HoverState.ForeColor = Color.White;
            btnXoaHoSo.Image = (Image)resources.GetObject("btnXoaHoSo.Image");
            btnXoaHoSo.Location = new Point(1434, 958);
            btnXoaHoSo.Name = "btnXoaHoSo";
            btnXoaHoSo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnXoaHoSo.Size = new Size(162, 56);
            btnXoaHoSo.TabIndex = 9;
            btnXoaHoSo.Text = "Xóa hồ sơ";
            btnXoaHoSo.Click += btnXoaHoSo_Click;
            // 
            // btnReload
            // 
            btnReload.BorderRadius = 15;
            btnReload.Cursor = Cursors.Hand;
            btnReload.CustomizableEdges = customizableEdges5;
            btnReload.DisabledState.BorderColor = Color.DarkGray;
            btnReload.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReload.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReload.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReload.FillColor = SystemColors.ControlDark;
            btnReload.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnReload.ForeColor = Color.Black;
            btnReload.HoverState.FillColor = SystemColors.ControlDarkDark;
            btnReload.HoverState.ForeColor = Color.White;
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.ImageSize = new Size(18, 18);
            btnReload.Location = new Point(1229, 958);
            btnReload.Name = "btnReload";
            btnReload.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnReload.Size = new Size(162, 56);
            btnReload.TabIndex = 10;
            btnReload.Text = "Reload";
            btnReload.Click += btnReload_Click;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // UserControlDanhSachNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnReload);
            Controls.Add(btnXoaHoSo);
            Controls.Add(guna2DataGridView1);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlDanhSachNhanVien";
            Size = new Size(1667, 1102);
            Load += UserControlDanhSachNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Button btnXoaHoSo;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
