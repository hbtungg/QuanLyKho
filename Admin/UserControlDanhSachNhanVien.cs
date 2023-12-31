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
    public partial class UserControlDanhSachNhanVien : UserControl
    {

        function fn = new function();
        String query;
        String currentUser = "";
        String selectedVaiTro = "";

        public UserControlDanhSachNhanVien()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void UserControlDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM NhanVien";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM NhanVien WHERE TenDangNhap LIKE '" + txtTimKiem.Text + "%' OR HoTen LIKE '" + txtTimKiem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnXoaHoSo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không?", "Xóa thông tin!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (currentUser != tenDangNhap)
                {
                    query = "DELETE FROM NhanVien WHERE TenDangNhap = '" + tenDangNhap + "'";
                    fn.setData(query, "Bản ghi đã xóa.");
                    UserControlDanhSachNhanVien_Load(this, null);
                }
                else
                {
                    MessageBox.Show("Lỗi, hãy thử lại sau. \n Hồ sơ của bạn.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        String tenDangNhap;

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã click vào một hàng hợp lệ không
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Lấy giá trị của cột thứ 3 trong hàng được click
                    tenDangNhap = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu có)
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            UserControlDanhSachNhanVien_Load(this, null);
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã double-click vào một hàng hợp lệ không
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Lấy giá trị của cột thứ 3 trong hàng được double-click
                    String selectedTenDangNhap = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    String selectedVaiTro = guna2DataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                    if (selectedVaiTro == "Nhân viên")
                    {
                        // Hiển thị form chỉnh sửa thông tin của nhân viên
                        FrmSuaNhanVien frmSuaNhanVien = new FrmSuaNhanVien(selectedTenDangNhap);
                        frmSuaNhanVien.ShowDialog();

                        // Reload danh sách nhân viên sau khi chỉnh sửa (nếu cần)
                        UserControlDanhSachNhanVien_Load(this, null);
                    } else if (selectedVaiTro == "Admin")
                    {
                        MessageBox.Show("Không được phép sửa thông tin của Admin." , "Error!" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu có)
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
