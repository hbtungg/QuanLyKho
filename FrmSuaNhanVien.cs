using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QuanLyKho
{

    public partial class FrmSuaNhanVien : Form
    {
        private string tenDangNhap;
        function fn = new function();
        String query;
        public FrmSuaNhanVien(string selectedTenDangNhap)
        {
            InitializeComponent();
            this.tenDangNhap = selectedTenDangNhap;
            LoadThongTinNhanVien();
        }

        private void LoadThongTinNhanVien()
        {
            // Sử dụng mã tương tự như trong UserControlHoSo_Enter để tải thông tin của nhân viên từ cơ sở dữ liệu
            query = "SELECT * FROM NhanVien WHERE TenDangNhap = '" + tenDangNhap + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                cbbVaiTro.Text = ds.Tables[0].Rows[0][8].ToString();
                txtHoTen.Text = ds.Tables[0].Rows[0][4].ToString();
                txtMaNhanVien.Text = ds.Tables[0].Rows[0][1].ToString();
                txtNgaySinh.Text = ds.Tables[0].Rows[0][5].ToString();
                txtDiaChi.Text = ds.Tables[0].Rows[0][6].ToString();
                txtSoDienThoai.Text = ds.Tables[0].Rows[0][7].ToString();
                txtTenDangNhap.Text = ds.Tables[0].Rows[0][2].ToString();
                txtMatKhau.Text = ds.Tables[0].Rows[0][3].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên.");
                this.Close(); // Đóng form nếu không tìm thấy thông tin nhân viên
            }
        }
        private void FrmSuaNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị mới từ các TextBox và ComboBox
                string vaiTro = cbbVaiTro.Text;
                string maNhanVien = txtMaNhanVien.Text;
                string hoTen = txtHoTen.Text;
                string ngaySinh = txtNgaySinh.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;
                string tenDangNhap = txtTenDangNhap.Text;
                string matKhau = txtMatKhau.Text;

                // Tạo câu truy vấn UPDATE
                string query = "UPDATE NhanVien SET VaiTro = '" + vaiTro + "', HoTen = '" + hoTen + "', NgaySinh = '" + ngaySinh + "', DiaChi = '" + diaChi + "', SoDienThoai = '" + soDienThoai + "', MatKhau = '" + matKhau + "' WHERE  TenDangNhap = '" + tenDangNhap + "'";

                // Gọi phương thức setData để thực hiện truy vấn UPDATE
                fn.setData(query, "Hồ sơ đã được cập nhật thành công!");

                // Hiển thị thông báo hoặc thực hiện các công việc khác sau khi cập nhật thành công
                MessageBox.Show("Hồ sơ đã được cập nhật thành công!");

                // Đóng form sau khi cập nhật thành công (nếu cần)
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
