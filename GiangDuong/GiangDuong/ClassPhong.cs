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
    class ClassPhong
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_Phong");
        }

        public void ThemPhong(string maphong)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ThemPhong";
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaPhong", SqlDbType.VarChar).Value = maphong;


                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SuaPhong(string maphong)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SuaPhong";
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaPhong", SqlDbType.VarChar).Value = maphong;
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
