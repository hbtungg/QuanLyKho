using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System.Data;

namespace QuanLyKho
{
    internal class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=VICTUSPRO\SQLEXPRESS;Initial Catalog=dotNetQLK;Integrated Security=True";
            return con;

            //SqlConnection con = new SqlConnection(@"Data Source=VICTUSPRO\SQLEXPRESS;Initial Catalog=dotNetQLK;Integrated Security=True");
            //return con;

        }

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection con = GetConnection())
                {
                    con.Open();
                    // Nếu đến đây mà không có exception, kết nối thành công
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Xuất thông báo lỗi (hoặc có thể ghi log)
                MessageBox.Show($"Connection failed. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public DataSet getData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query, String msg)
        {

            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(msg, "Information" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }
}
