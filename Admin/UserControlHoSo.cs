using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.Admin
{
    public partial class UserControlHoSo : UserControl
    {
        function fn = new function();
        String query;
        public UserControlHoSo()
        {
            InitializeComponent();
            //LoadHoSo();
        }

        public string ID { set { caimawelcome.Text = value; } }
        private void UserControlHoSo_Load(object sender, EventArgs e)
        {

        }

        private void LoadHoSo()
        {
            query = "SELECT * FROM NhanVien WHERE TenDangNhap = '" + caimawelcome.Text + "'";
            DataSet ds = fn.getData(query);
            cbbVaiTro.Text = ds.Tables[0].Rows[0][8].ToString();
            txtHoTen.Text = ds.Tables[0].Rows[0][4].ToString();
            txtMaNhanVien.Text = ds.Tables[0].Rows[0][1].ToString();
            txtNgaySinh.Text = ds.Tables[0].Rows[0][5].ToString();
            txtDiaChi.Text = ds.Tables[0].Rows[0][6].ToString();
            txtSoDienThoai.Text = ds.Tables[0].Rows[0][7].ToString();
            txtTenDangNhap.Text = ds.Tables[0].Rows[0][2].ToString();
            txtMatKhau.Text = ds.Tables[0].Rows[0][3].ToString();
        }

        private void UserControlHoSo_Enter(object sender, EventArgs e)
        {
            LoadHoSo();
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            UserControlHoSo_Enter(this, null);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            String vaiTro = cbbVaiTro.Text;
            String maNhanVien = txtMaNhanVien.Text;
            String hoTen = txtHoTen.Text;
            String ngaySinh = txtNgaySinh.Text;
            String diaChi = txtDiaChi.Text;
            String soDienThoai = txtSoDienThoai.Text;
            String tenDangNhap = txtTenDangNhap.Text;
            String matKhau = txtMatKhau.Text;

            string query = "UPDATE NhanVien SET VaiTro = '" + vaiTro + "', HoTen = '" + hoTen + "', NgaySinh = '" + ngaySinh + "', DiaChi = '" + diaChi + "', SoDienThoai = '" + soDienThoai + "', MatKhau = '" + matKhau + "' WHERE  TenDangNhap = '" + tenDangNhap + "'";
            fn.setData(query, "Hồ sơ đã được cập nhật thành công!");
        }
    }
}
