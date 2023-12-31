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

namespace QuanLyKho.UserConTrolDanhSachNhanVien
{
    public partial class FrmSuaSanPham : Form
    {
        private string _maSanPham;
        private string _maLoaiSanPham;
        function fn = new function();
        string query;

        public FrmSuaSanPham(string maSanPham, string maLoaiSanPham)
        {
            InitializeComponent();
            this._maSanPham = maSanPham;
            this._maLoaiSanPham = maLoaiSanPham;
            LoadThongTinSanPham();
            LoadMaLoaiSanPhamComboBox();
        }

        private void LoadThongTinSanPham()
        {
            query = "SELECT * FROM SanPham s inner join LoaiSanPham ls on s.MaLoaiSanPham = ls.MaLoaiSanPham WHERE MaSanPham = '" + _maSanPham + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtMaSanPham.Text = ds.Tables[0].Rows[0]["MaSanPham"].ToString();
                txtTenSanPham.Text = ds.Tables[0].Rows[0]["TenSanPham"].ToString();

                object maLoaiSanPhamValue = ds.Tables[0].Rows[0]["MaLoaiSanPham"];
                cbbMaLoai.SelectedValue = maLoaiSanPhamValue;

                txtSoLuongTon.Text = ds.Tables[0].Rows[0]["SoLuongTon"].ToString();
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sản phẩm.");
                this.Close(); // Đóng form nếu không tìm thấy thông tin sản phẩm
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LoadMaLoaiSanPhamComboBox()
        {
            try
            {
                // Define a query to retrieve product categories
                string query = "SELECT * FROM LoaiSanPham";

                // Use the getData method to fetch data from the database
                DataSet ds = fn.getData(query);

                // Check if there are any rows in the result
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Set the DataSource, DisplayMember, and ValueMember for the ComboBox
                    cbbMaLoai.DataSource = ds.Tables[0];
                    cbbMaLoai.DisplayMember = "TenLoaiSanPham";
                    cbbMaLoai.ValueMember = "MaLoaiSanPham";

                    // Set the selected value to the one passed from the calling form
                    cbbMaLoai.SelectedValue = _maLoaiSanPham;
                }
                else
                {
                    // If there are no product categories, you may want to handle this case
                    MessageBox.Show("Không có dữ liệu loại sản phẩm.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions if any
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }





        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            try
            {

                string tenSanPham = txtTenSanPham.Text;
                //string soLuongTon = txtSoLuongTon.Tex;
                string maLoai = cbbMaLoai.SelectedValue.ToString();

                // Tạo câu truy vấn UPDATE
                string query = "UPDATE SanPham SET TenSanPham = '" + tenSanPham + "',  MaLoaiSanPham = '" + maLoai + "' WHERE  MaSanPham = '" + _maSanPham + "'";

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenSanPham = txtTenSanPham.Text;
            string maLoai = cbbMaLoai.SelectedValue.ToString();
            query = "INSERT INTO SanPham (TenSanPham, SoLuongTon, MaLoaiSanPham) VALUES (N'" + tenSanPham + "', '0', '" + maLoai + "')";
            fn.setData(query, "Sản phẩm được thêm thành công!");
        }
    }
}
