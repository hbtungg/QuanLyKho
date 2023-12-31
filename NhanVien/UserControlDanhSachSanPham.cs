using QuanLyKho.UserConTrolDanhSachNhanVien;
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

namespace QuanLyKho.NhanVien
{
    public partial class UserControlDanhSachSanPham : UserControl
    {
        function fn = new function();
        String query;
        String currentUser = "";
        public UserControlDanhSachSanPham()
        {
            InitializeComponent();
        }

        public string ID
        {
            set { currentUser = value; }
        }

        private void UserControlDanhSachSanPham_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM SanPham";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM SanPham WHERE MaSanPham LIKE '%" + txtTimKiem.Text + "%' OR TenSanPham LIKE '%" + txtTimKiem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        String maSanPham;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã click vào một hàng hợp lệ không
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Lấy giá trị của cột thứ 3 trong hàng được click
                    maSanPham = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu có)
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaSanPham_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không?", "Xóa thông tin!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
                fn.setData(query, "Bản ghi đã xóa.");
                UserControlDanhSachSanPham_Load(this, null);

            }
        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                string maLoaiSanPham = guna2DataGridView1.SelectedRows[0].Cells["MaLoaiSanPham"].Value.ToString();
                FrmSuaSanPham frmSuaSanPham = new FrmSuaSanPham(maSanPham, maLoaiSanPham);
                frmSuaSanPham.ShowDialog();

                UserControlDanhSachSanPham_Load(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
