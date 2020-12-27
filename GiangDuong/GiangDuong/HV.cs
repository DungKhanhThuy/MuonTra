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
    class HocVien
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {            
            return cn.LoadData("HienThi_HocVien");
        }

        public void HocVien_DB(string proc, string mahv, string tenhv, string donvi, string sdt, string malop)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaHV", SqlDbType.VarChar).Value = mahv;
                command.Parameters.AddWithValue("@ten", SqlDbType.VarChar).Value = tenhv;
                command.Parameters.AddWithValue("@DonVi", SqlDbType.VarChar).Value = donvi;
                command.Parameters.AddWithValue("@SDT", SqlDbType.VarChar).Value = sdt;
                command.Parameters.AddWithValue("@MaLop", SqlDbType.VarChar).Value = malop;
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //public void SuaHocVien(string mahv, string tenhv, string donvi, string sdt, string malop)
        //{
        //    try
        //    {
        //        SqlCommand command = new SqlCommand();
        //        SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
        //        cn.Open();
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.CommandText = "SuaHocVien";
        //        command.Connection = cn;
        //        command.Parameters.AddWithValue("@MaHV", SqlDbType.VarChar).Value = mahv;
        //        command.Parameters.AddWithValue("@ten", SqlDbType.VarChar).Value = tenhv;
        //        command.Parameters.AddWithValue("@DonVi", SqlDbType.VarChar).Value = donvi;
        //        command.Parameters.AddWithValue("@SDT", SqlDbType.VarChar).Value = sdt;
        //        command.Parameters.AddWithValue("@MaLop", SqlDbType.VarChar).Value = malop;
        //        command.ExecuteNonQuery();
        //        cn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //public void ThemHocVien(string MaHV, string TenHV, string DonVi, string SDT, string MaLop)
        //{
        //    string sql = "ThemHocVien";
        //    SqlConnection con = new SqlConnection(ConnectDB.getconnect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@mahv", MaHV);
        //    cmd.Parameters.AddWithValue("@ten", TenHV);
        //    cmd.Parameters.AddWithValue("@donvi", DonVi);
        //    cmd.Parameters.AddWithValue("@sdt", SDT);
        //    cmd.Parameters.AddWithValue("@malop", MaLop);

        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}

        //public void XoaHocVien(string MaHV)
        //{
        //    string sql = "XoaHocVien";
        //    SqlConnection con = new SqlConnection(ConnectDB.getconnect());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@MaHV", MaHV);

        //    cmd.ExecuteNonQuery();
        //    cmd.Dispose();
        //    con.Close();
        //}


    }
}
