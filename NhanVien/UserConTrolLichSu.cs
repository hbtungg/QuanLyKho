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

namespace QuanLyKho.NhanVien
{
    public partial class UserConTrolLichSu : UserControl
    {
        function fn = new function();
        string query;
        public UserConTrolLichSu()
        {
            InitializeComponent();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Build the search query based on TenDangNhap, LoaiThaoTac, MaPhieuNhap, and MaPhieuXuat
                string searchQuery = "SELECT * FROM LichSu WHERE TenDangNhap LIKE '%" + txtTimKiem.Text + "%' OR LoaiThaoTac LIKE '%" + txtTimKiem.Text + "%' OR MaPhieuNhap LIKE '%" + txtTimKiem.Text + "%' OR MaPhieuXuat LIKE '%" + txtTimKiem.Text + "%'";

                // Retrieve data from the database based on the search query
                DataSet ds = fn.getData(searchQuery);

                // Check if the DataSet has data
                if (ds != null && ds.Tables.Count > 0)
                {
                    // Update the DataGridView with the search results
                    dataLichSu.DataSource = ds.Tables[0];
                }
                else
                {
                    // If no matching records are found, clear the DataGridView
                    dataLichSu.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void UserConTrolLichSu_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM LichSu";
            DataSet ds = fn.getData(query);
            dataLichSu.DataSource = ds.Tables[0];
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            UserConTrolLichSu_Load(this, null);        }
    }
}
