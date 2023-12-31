using QuanLyKho.NhanVien;
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
    public partial class FrmThemLoaiSanPham : Form
    {
        function fn = new function();
        string query;
        public FrmThemLoaiSanPham()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLoai = txtTenLoai.Text;
            query = "INSERT INTO LoaiSanPham (TenLoaiSanPham) VALUES (N'" + tenLoai + "')";
            fn.setData(query, "Đã thêm thành công!");
            this.Hide();

        }
    }
}
