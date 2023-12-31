using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class FrmAdmin : Form
    {
        String nhanVien = "";
        public FrmAdmin()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return nhanVien.ToString(); }
        }
        public FrmAdmin(String TenDangNhap)
        {
            InitializeComponent();
            lblUserName.Text = TenDangNhap;
            nhanVien = TenDangNhap;
            userControlDanhSachNhanVien1.ID = ID;
            userControlHoSo1.ID = ID;
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            userControlDashBoard1.Visible = true;
            userControlDashBoard1.BringToFront();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            userControlDashBoard1.Visible = false;
            userControlThemNhanVien1.Visible = false;
            userControlDanhSachNhanVien1.Visible = false;
            userControlHoSo1.Visible = false;
            btnDashBoard.PerformClick();

        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            userControlThemNhanVien1.Visible = true;
            userControlThemNhanVien1.BringToFront();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachNhanVien_Click(object sender, EventArgs e)
        {
            userControlDanhSachNhanVien1.Visible = true;
            userControlDanhSachNhanVien1.BringToFront();
        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            userControlHoSo1.Visible = true;
            userControlHoSo1.BringToFront();
        }
    }
}
