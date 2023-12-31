using QuanLyKho.UserConTrolNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.NhanVien
{
    public partial class UserControlNhaPhanPhoi : UserControl
    {
        function fn = new function();
        string query;
        public UserControlNhaPhanPhoi()
        {
            InitializeComponent();
        }

        private void UserControlNhaPhanPhoi_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM NhaPhanPhoi";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String maNhaPhanPhoi;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maNhaPhanPhoi = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM NhaPhanPhoi WHERE MaNhaPhanPhoi LIKE '%" + txtTimKiem.Text + "%' OR TenNhaPhanPhoi LIKE N'%" + txtTimKiem.Text + "%'";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không?", "Xóa thông tin!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM NhaPhanPhoi WHERE MaNhaPhanPhoi = '" + maNhaPhanPhoi + "'";
                fn.setData(query, "Bản ghi đã xóa.");
                UserControlNhaPhanPhoi_Load(this, null);

            }
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem người dùng đã double-click vào một hàng hợp lệ không
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Lấy giá trị của cột thứ 3 trong hàng được double-click
                    maNhaPhanPhoi = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();


                    // Hiển thị form chỉnh sửa thông tin của nhân viên
                    FrmSuaThemNhaPhanPhoi frmSuaThemNhaPhanPhoi = new FrmSuaThemNhaPhanPhoi(maNhaPhanPhoi);
                    frmSuaThemNhaPhanPhoi.ShowDialog();

                    // Reload danh sách nhân viên sau khi chỉnh sửa (nếu cần)
                    UserControlNhaPhanPhoi_Load(this, null);

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
