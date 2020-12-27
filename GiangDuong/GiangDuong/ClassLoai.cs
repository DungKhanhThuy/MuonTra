using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiangDuong
{
    class ClassLoai
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_Loai");
        }

        public void ThemLoai(string maloai, string tenloai)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ThemLoai";
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaLoai", SqlDbType.VarChar).Value = maloai;
                command.Parameters.AddWithValue("@TenLoai", SqlDbType.VarChar).Value = tenloai;
                
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SuaLoai(string maloai, string tenloai)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SuaLoai";
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaLoai", SqlDbType.VarChar).Value = maloai;
                command.Parameters.AddWithValue("@TenLoai", SqlDbType.VarChar).Value = tenloai;
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
