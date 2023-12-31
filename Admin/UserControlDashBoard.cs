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
    public partial class UserControlDashBoard : UserControl
    {
        function fn = new function();
        String query;
        DataSet ds;
        public UserControlDashBoard()
        {
            InitializeComponent();
        }

        private void UserControlDashBoard_Load(object sender, EventArgs e)
        {
            query = "select count(VaiTro) from NhanVien where VaiTro = 'Admin'";
            ds = fn.getData(query);
            setLabel(ds, lblAdmin);

            query = "select count(VaiTro) from NhanVien where VaiTro = 'Nhân viên'";
            ds = fn.getData(query);
            setLabel(ds, lblNhanVien);
        }

        private void setLabel(DataSet ds, Label lbl)
        {
            if (ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                lbl.Text = "0";
            }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            UserControlDashBoard_Load(this, null);
        }
    }
}
