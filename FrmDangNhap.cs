using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class FrmDangNhap : Form
    {
        function fn = new function();
        String query;
        DataSet ds;
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
            query = "select * from NhanVien";
            ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtTenDangNhap.Text == "root" && txtMatKhau.Text == "root")
                {
                    FrmAdmin admin = new FrmAdmin();
                    this.Hide();
                }
            }
            else
            {
                query = "select * from NhanVien where TenDangNhap = '" + txtTenDangNhap.Text + "' and MatKhau ='" + txtMatKhau.Text + "'";
                ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count != 0)
                {
                    String role = ds.Tables[0].Rows[0][8].ToString();
                    if (role == "Admin")
                    {
                        FrmAdmin admin = new FrmAdmin(txtTenDangNhap.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Nhân viên")
                    {
                        FrmNhanVien nhanvien = new FrmNhanVien(txtTenDangNhap.Text);
                        nhanvien.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("Câu lệnh SQL: " + query);

                }
            }



            //if (txtTenDangNhap.Text == "admin" && txtMatKhau.Text == "admin")
            //{
            //    FrmAdmin admin = new FrmAdmin();
            //    admin.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://facebook.com/ggnut.bh";
                ProcessStartInfo psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
