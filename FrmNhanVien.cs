using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyKho
{
    public partial class FrmNhanVien : Form
    {
        String nhanVien = "";
        public FrmNhanVien()
        {
            InitializeComponent();
        }

        public string ID
        {
            get { return nhanVien.ToString(); }
        }

        public FrmNhanVien(String TenDangNhap)
        {
            InitializeComponent();
            lblUserName.Text = TenDangNhap;
            nhanVien = TenDangNhap;
            userControlNhapXuat1.ID = ID;
        }
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            userControlDanhSachSanPham1.Visible = true;
            userControlDanhMucSanPham1.Visible = true;
            userControlNhaPhanPhoi1.Visible = true;
            userControlNhapXuat1.Visible = true;
            userConTrolLichSu1.Visible = true;
            btnDanhSachSanPham.PerformClick();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FrmDangNhap frmDangNhap = new FrmDangNhap();
            frmDangNhap.Show();
            this.Hide();
        }

        private void btnDanhSachSanPham_Click(object sender, EventArgs e)
        {
            userControlDanhSachSanPham1.Visible = true;
            userControlDanhSachSanPham1.BringToFront();
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhMucSanPham_Click(object sender, EventArgs e)
        {
            userControlDanhMucSanPham1.Visible = true;
            userControlDanhMucSanPham1.BringToFront();
        }

        private void btnNhaPhanPhoi_Click(object sender, EventArgs e)
        {
            userControlNhaPhanPhoi1.Visible = true;
            userControlNhaPhanPhoi1.BringToFront();
        }

        private void btnNhapXuat_Click(object sender, EventArgs e)
        {
            userControlNhapXuat1.Visible = true;
            userControlNhapXuat1.BringToFront();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            userConTrolLichSu1.Visible = true;
            userConTrolLichSu1.BringToFront();
        }
    }
}
