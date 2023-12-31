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
    public partial class UserControlThemNhanVien : UserControl
    {
        function fn = new function();
        String query;
        public UserControlThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            String vaiTro = cbbVaiTro.Text;
            String maNhanVien = txtMaNhanVien.Text;
            String hoTen = txtHoTen.Text;
            String ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            String diaChi = txtDiaChi.Text;
            String soDienThoai = txtSoDienThoai.Text;
            String tenDangNhap = txtTenDangNhap.Text;
            String matKhau = txtMatKhau.Text;

            try
            {
                query = "insert into NhanVien (MaNhanVien, TenDangNhap, MatKhau, HoTen, NgaySinh, DiaChi, SoDienThoai, Vaitro)" +
                    "values ('" + maNhanVien + "', '" + tenDangNhap + "', '" + matKhau + "', N'" + hoTen + "', '" + ngaySinh + "', N'" + diaChi + "', '" + soDienThoai + "', N'" + vaiTro + "')";
                fn.setData(query, "Đăng ký thành công!");
                Console.WriteLine("Câu lệnh SQL đã được thực hiện thành công: " + query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Lỗi khi thực hiện câu lệnh SQL. Lỗi: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            cbbVaiTro.SelectedIndex = -1;
            txtMaNhanVien.Clear();
            txtHoTen.Clear();
            dtpNgaySinh.ResetText();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();

        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            query = "select * from NhanVien where TenDangNhap = '" + txtTenDangNhap.Text + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                picThemNhanVien.ImageLocation = @"C:\Users\thanh\OneDrive\Hình ảnh\icon\check.png";
            }
            else
            {
                picThemNhanVien.ImageLocation = @"C:\Users\thanh\OneDrive\Hình ảnh\icon\disable.png";
            }
        }
    }
}
