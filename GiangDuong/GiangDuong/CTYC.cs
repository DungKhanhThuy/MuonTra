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
    class CTYC
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show(string mayc)
        {
            return cn.LoadData1("HienThi_CTYC", "@MaYC", mayc);
        }

        public void CTYC_DB(string proc, string mayc, string matb, string datra)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaYC", SqlDbType.VarChar).Value = mayc;
                command.Parameters.AddWithValue("@MaTB", SqlDbType.VarChar).Value = matb;
                command.Parameters.AddWithValue("@DaTra", SqlDbType.Bit).Value = datra;
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Xoa_CTYC(string proc, string mayc, string matb)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaYC", SqlDbType.VarChar).Value = mayc;
                command.Parameters.AddWithValue("@MaTB", SqlDbType.VarChar).Value = matb;
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
