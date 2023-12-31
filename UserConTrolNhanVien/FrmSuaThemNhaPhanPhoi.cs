using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho.UserConTrolNhanVien
{
    public partial class FrmSuaThemNhaPhanPhoi : Form
    {
        private string _maNhaPhanPhoi;
        function fn = new function();
        String query;
        public FrmSuaThemNhaPhanPhoi()
        {
            InitializeComponent();
        }

        public FrmSuaThemNhaPhanPhoi(string maNhaPhanPhoi)
        {
            InitializeComponent();
            this._maNhaPhanPhoi = maNhaPhanPhoi;
            LoadNhaPhanPhoi();
        }

        private void LoadNhaPhanPhoi()
        {
            query = "SELECT * FROM NhaPhanPhoi WHERE MaNhaPhanPhoi = '" + _maNhaPhanPhoi + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtMaNhaPhanPhoi.Text = ds.Tables[0].Rows[0]["MaNhaPhanPhoi"].ToString();
                txtTenNhaPhanPhoi.Text = ds.Tables[0].Rows[0]["TenNhaPhanPhoi"].ToString();
                txtDiaChi.Text = ds.Tables[0].Rows[0]["DiaChi"].ToString();
                txtSoDienThoai.Text = ds.Tables[0].Rows[0]["SoDienThoai"].ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string maNhaPhanPhoi = txtMaNhaPhanPhoi.Text;
                string tenNhaPhanPhoi = txtTenNhaPhanPhoi.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;

                string query = "UPDATE NhaPhanPhoi SET TenNhaPhanPhoi = N'" + tenNhaPhanPhoi + "', DiaChi = N'" + diaChi + "', SoDienThoai = '" + soDienThoai + "' WHERE MaNhaPhanPhoi = '" + maNhaPhanPhoi + "'";
                fn.setData(query, "Thông tin nhà phân phối đã được sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox
                string tenNhaPhanPhoi = txtTenNhaPhanPhoi.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSoDienThoai.Text;

                // Tạo câu truy vấn INSERT
                string query = "INSERT INTO NhaPhanPhoi (TenNhaPhanPhoi, DiaChi, SoDienThoai) VALUES (N'" + tenNhaPhanPhoi + "', N'" + diaChi + "', '" + soDienThoai + "')";

                // Gọi phương thức setData để thực hiện truy vấn INSERT
                fn.setData(query, "Thông tin nhà phân phối đã được thêm mới thành công!");

                // Hiển thị thông báo hoặc thực hiện các công việc khác sau khi thêm mới thành công
                //MessageBox.Show("Thông tin nhà phân phối đã được thêm mới thành công!");

                // Đóng form sau khi thêm mới thành công (nếu cần)
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
