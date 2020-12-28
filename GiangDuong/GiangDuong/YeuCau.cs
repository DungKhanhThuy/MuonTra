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
    class YeuCau
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_YeuCau");
        }

        public void YeuCau_DB(string proc, string mayc, string mahv, string manv, DateTime tgmuon, string ghichu )
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
                command.Parameters.AddWithValue("@MaHV", SqlDbType.VarChar).Value = mahv;
                command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = manv;
                command.Parameters.AddWithValue("@TGMuon", SqlDbType.VarChar).Value = tgmuon;
                command.Parameters.AddWithValue("@GhiChu", SqlDbType.VarChar).Value = ghichu;
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SuaYeuCau(string proc, string mayc, string mahv, string manv, DateTime tgmuon, DateTime tgtra, string ghichu)
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
                command.Parameters.AddWithValue("@MaHV", SqlDbType.VarChar).Value = mahv;
                command.Parameters.AddWithValue("@MaNV", SqlDbType.VarChar).Value = manv;
                command.Parameters.AddWithValue("@TGMuon", SqlDbType.DateTime).Value = tgmuon;
                command.Parameters.AddWithValue("@TGTra", SqlDbType.DateTime).Value = tgtra;
                command.Parameters.AddWithValue("@GhiChu", SqlDbType.VarChar).Value = ghichu;
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
