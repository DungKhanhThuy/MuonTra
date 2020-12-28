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
    class ClassGiaoBan
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_GiaoBan");
        }

        public void GiaoBan_DB(string proc, string mank, string manv, string thoigian, string noidung)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaNK", mank);
                command.Parameters.AddWithValue("@MaNV", manv);
                command.Parameters.AddWithValue("@ThoiGian", thoigian);
                command.Parameters.AddWithValue("@NoiDung", noidung);
                command.ExecuteNonQuery();
                command.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
