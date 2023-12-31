using Guna.UI2.WinForms;
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
    public partial class UserControlNhapXuat : UserControl
    {
        //String nhanVien = "";
        function fn = new function();
        string query;
        public UserControlNhapXuat()
        {
            InitializeComponent();
            HienThiNgayGioMacDinh();
            LoadCbbNhaPhanPhoi();
            LoadSanPham();
        }
        public string ID { set { txtNhanVien.Text = value; } }

        string ngayDinhDang;
        private void HienThiNgayGioMacDinh()
        {
            // Lấy ngày giờ hiện tại của hệ thống
            DateTime ngayGioHienTai = DateTime.Now;
            ngayDinhDang = ngayGioHienTai.ToString("yyyy-MM-dd");

            // Hiển thị ngày giờ trong một Label (hoặc bất kỳ điều gì khác bạn muốn sử dụng)
            txtThoiGian.Text = ngayDinhDang;
        }

        private void UserControlNhapXuat_Load(object sender, EventArgs e)
        {
            query = "SELECT * FROM SanPham";
            DataSet ds = fn.getData(query);
            dataSanPham.DataSource = ds.Tables[0];
        }

        private void LoadSanPham()
        {
            query = "SELECT * FROM SanPham";
            DataSet ds = fn.getData(query);
            dataSanPham.DataSource = ds.Tables[0];
        }

        private void LoadCbbNhaPhanPhoi()
        {
            try
            {
                // Define a query to retrieve product categories
                string query = "SELECT * FROM NhaPhanPhoi";

                // Use the getData method to fetch data from the database
                DataSet ds = fn.getData(query);

                // Check if there are any rows in the result
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Set the DataSource, DisplayMember, and ValueMember for the ComboBox
                    cbbNhaPhanPhoi.DataSource = ds.Tables[0];
                    cbbNhaPhanPhoi.DisplayMember = "TenNhaPhanPhoi";
                    cbbNhaPhanPhoi.ValueMember = "MaNhaPhanPhoi";
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

        private void btnNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy phần tử đã chọn từ ComboBox
                DataRowView selectedRow = (DataRowView)cbbNhaPhanPhoi.SelectedItem;

                // Kiểm tra xem có phần tử nào được chọn hay không
                if (selectedRow != null)
                {
                    // Lấy giá trị liên kết với "MaNhaPhanPhoi" và chuyển đổi thành chuỗi
                    string maNhaPhanPhoi = selectedRow["MaNhaPhanPhoi"].ToString();

                    // Lấy giá trị từ các ô nhập khác
                    string ngayNhap = txtThoiGian.Text;
                    string soLuong = txtSoLuong.Text;
                    string tenDangNhap = txtNhanVien.Text;

                    // Kiểm tra số lượng nhập có là một số dương hay không
                    if (int.TryParse(soLuong, out int soLuongNhap) && soLuongNhap > 0)
                    {
                        // Thực hiện truy vấn để lấy số lượng tồn hiện tại
                        string queryGetSoLuongTon = "SELECT SoLuongTon FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
                        DataSet dataSet = fn.getData(queryGetSoLuongTon);

                        // Kiểm tra xem DataSet có dữ liệu không
                        if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                        {
                            int soLuongTonHienTai = Convert.ToInt32(dataSet.Tables[0].Rows[0]["SoLuongTon"]);

                            // Tính toán số lượng mới
                            int soLuongMoi = soLuongNhap;
                            int soLuongTonMoi = soLuongTonHienTai + soLuongMoi;

                            // Cập nhật số lượng tồn mới vào bảng SanPham
                            string queryUpdateSoLuongTon = "UPDATE SanPham SET SoLuongTon = " + soLuongTonMoi + " WHERE MaSanPham = '" + maSanPham + "'";
                            fn.setData(queryUpdateSoLuongTon, "Cập nhật thành công!");

                            // Thêm dữ liệu vào bảng NhapHang
                            string queryInsertNhapHang = "INSERT INTO NhapHang (NgayNhap, MaNhaPhanPhoi, MaSanPham, SoLuong, TenDangNhap) VALUES ('" + ngayNhap + "','" + maNhaPhanPhoi + "', '" + maSanPham + "', '" + soLuongMoi + "','" + tenDangNhap + "')";
                            fn.setData(queryInsertNhapHang, "Đã thêm thành công!");

                            // Retrieve the newly generated MaPhieuNhap after inserting into NhapHang
                            string queryGetMaPhieuNhap = "SELECT IDENT_CURRENT('NhapHang') AS MaPhieuNhap";
                            DataSet dataSetMaPhieuNhap = fn.getData(queryGetMaPhieuNhap);

                            if (dataSetMaPhieuNhap != null && dataSetMaPhieuNhap.Tables.Count > 0 && dataSetMaPhieuNhap.Tables[0].Rows.Count > 0)
                            {
                                string maPhieuNhap = dataSetMaPhieuNhap.Tables[0].Rows[0]["MaPhieuNhap"].ToString();

                                // Thêm dữ liệu vào bảng LichSu
                                string queryInsertLichSu = "INSERT INTO LichSu (LoaiThaoTac, MaSanPham, TenDangNhap, SoLuong, MaPhieuNhap) VALUES (N'Nhập', '" + maSanPham + "', '" + tenDangNhap + "', '" + soLuongMoi + "', '" + maPhieuNhap + "')";
                                fn.setData(queryInsertLichSu, "Đã thêm vào lịch sử.");
                            }
                            else
                            {
                                MessageBox.Show("Không thể lấy mã phiếu nhập mới.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu cho sản phẩm có mã " + maSanPham);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng nhập không hợp lệ. Vui lòng nhập một số dương.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà phân phối.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        string maSanPham;
        private void dataSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                maSanPham = dataSanPham.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }


        private void btnXuat_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy phần tử đã chọn từ ComboBox
                DataRowView selectedRow = (DataRowView)cbbNhaPhanPhoi.SelectedItem;

                // Kiểm tra xem có phần tử nào được chọn hay không
                if (selectedRow != null)
                {
                    // Lấy giá trị liên kết với "MaNhaPhanPhoi" và chuyển đổi thành chuỗi
                    string maNhaPhanPhoi = selectedRow["MaNhaPhanPhoi"].ToString();

                    // Lấy giá trị từ các ô nhập khác
                    string ngayXuat = txtThoiGian.Text;
                    string soLuong = txtSoLuong.Text;
                    string tenDangNhap = txtNhanVien.Text;

                    // Kiểm tra số lượng xuất có là một số dương hay không
                    if (int.TryParse(soLuong, out int soLuongXuat) && soLuongXuat > 0)
                    {
                        // Thực hiện truy vấn để lấy số lượng tồn hiện tại
                        string queryGetSoLuongTon = "SELECT SoLuongTon FROM SanPham WHERE MaSanPham = '" + maSanPham + "'";
                        DataSet dataSet = fn.getData(queryGetSoLuongTon);

                        // Kiểm tra xem DataSet có dữ liệu không
                        if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                        {
                            int soLuongTonHienTai = Convert.ToInt32(dataSet.Tables[0].Rows[0]["SoLuongTon"]);

                            // Kiểm tra xem có đủ số lượng tồn để xuất không
                            if (soLuongTonHienTai >= soLuongXuat)
                            {
                                // Tính toán số lượng mới
                                int soLuongMoi = soLuongXuat;
                                int soLuongTonMoi = soLuongTonHienTai - soLuongMoi;

                                // Cập nhật số lượng tồn mới vào bảng SanPham
                                string queryUpdateSoLuongTon = "UPDATE SanPham SET SoLuongTon = " + soLuongTonMoi + " WHERE MaSanPham = '" + maSanPham + "'";
                                fn.setData(queryUpdateSoLuongTon, "Cập nhật thành công!");

                                // Thêm dữ liệu vào bảng XuatHang
                                string queryInsertXuatHang = "INSERT INTO XuatHang (NgayXuat, MaNhaPhanPhoi, MaSanPham, SoLuong, TenDangNhap) VALUES ('" + ngayXuat + "','" + maNhaPhanPhoi + "', '" + maSanPham + "', '" + soLuongMoi + "','" + tenDangNhap + "')";
                                fn.setData(queryInsertXuatHang, "Đã xuất thành công!");

                                // Retrieve the newly generated MaPhieuXuat after inserting into XuatHang
                                string queryGetMaPhieuXuat = "SELECT IDENT_CURRENT('XuatHang') AS MaPhieuXuat";
                                DataSet dataSetMaPhieuXuat = fn.getData(queryGetMaPhieuXuat);

                                if (dataSetMaPhieuXuat != null && dataSetMaPhieuXuat.Tables.Count > 0 && dataSetMaPhieuXuat.Tables[0].Rows.Count > 0)
                                {
                                    string maPhieuXuat = dataSetMaPhieuXuat.Tables[0].Rows[0]["MaPhieuXuat"].ToString();

                                    // Thêm dữ liệu vào bảng LichSu
                                    string queryInsertLichSu = "INSERT INTO LichSu (LoaiThaoTac, MaSanPham, TenDangNhap, SoLuong, MaPhieuXuat) VALUES (N'Xuất', '" + maSanPham + "', '" + tenDangNhap + "', '" + soLuongMoi + "', '" + maPhieuXuat + "')";
                                    fn.setData(queryInsertLichSu, "Đã thêm vào lịch sử.");
                                }
                                else
                                {
                                    MessageBox.Show("Không thể lấy mã phiếu xuất mới.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Số lượng tồn không đủ để xuất.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu cho sản phẩm có mã " + maSanPham);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng xuất không hợp lệ. Vui lòng nhập một số dương.");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một nhà phân phối.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM SanPham WHERE MaSanPham LIKE '%" + txtTimKiem.Text + "%' OR TenSanPham LIKE '%" + txtTimKiem.Text + "%'";
            DataSet ds = fn.getData(query);
            dataSanPham.DataSource = ds.Tables[0];
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            UserControlNhapXuat_Load(this, null);
        }
    }
}
