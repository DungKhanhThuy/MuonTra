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
    class ClassNguoiDung
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_NguoiDung");
        }

        public void NguoiDung_DB(string proc, string manv, string matkhau, string laadmin)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = manv;
                command.Parameters.AddWithValue("@MatKhau", SqlDbType.VarChar).Value = matkhau;
                command.Parameters.AddWithValue("@LaAdmin", SqlDbType.VarChar).Value = laadmin;
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
