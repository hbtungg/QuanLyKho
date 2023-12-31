using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class FormTestKetNoi : Form
    {
        function function = new function();
        public FormTestKetNoi()
        {
            InitializeComponent();
        }

        private void FormTestKetNoi_Load(object sender, EventArgs e)
        {
            if (function.TestConnection())
            {
                MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Tiếp tục với các thao tác khác sau khi kiểm tra kết nối.
            }
            else
            {
                MessageBox.Show("Connection failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể thoát ứng dụng hoặc thực hiện các xử lý khác tùy thuộc vào yêu cầu của bạn.
                this.Close(); // Đóng form chính nếu kết nối không thành công.
            }
        }
    }
}
