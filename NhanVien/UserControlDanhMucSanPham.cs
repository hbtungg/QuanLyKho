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


    public partial class UserControlDanhMucSanPham : UserControl
    {
        function fn = new function();
        String query;

        public UserControlDanhMucSanPham()
        {
            InitializeComponent();
        }

        private void UserControlDanhMucSanPham_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM LoaiSanPham";
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        String maLoaiSanPham;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maLoaiSanPham = guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaLoaiSanPham"].Value.ToString();
                txtTenLoai.Text = row.Cells["TenLoaiSanPham"].Value.ToString();


            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn không?", "Xóa thông tin!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "DELETE FROM LoaiSanPham WHERE MaLoaiSanPham = '" + maLoaiSanPham + "'";
                fn.setData(query, "Bản ghi đã xóa.");
                UserControlDanhMucSanPham_Load(this, null);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenLoaiSanPham = txtTenLoai.Text;
            string query = "UPDATE LoaiSanPham SET TenLoaiSanPham = N'" + tenLoaiSanPham + "' WHERE MaLoaiSanPham = '" + maLoaiSanPham + "'";

            fn.setData(query, "Hồ sơ đã được cập nhật thành công!");
            UserControlDanhMucSanPham_Load(this, null);

            // Hiển thị thông báo hoặc thực hiện các công việc khác sau khi cập nhật thành công
            //MessageBox.Show("Hồ sơ đã được cập nhật thành công!");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemLoaiSanPham frmThemLoaiSanPham = new FrmThemLoaiSanPham();
            frmThemLoaiSanPham.ShowDialog();

            UserControlDanhMucSanPham_Load(this, null);
        }
    }
}
