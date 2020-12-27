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
        public DataTable Show()
        {
            string sql = "SELECT hv.MaHV, hv.TenHV, l.MaLop, l.TenLop, hv.SDT, hv.DonVi FROM HocVien as hv, Lop as l WHERE hv.MaLop = l.MaLop";
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            da.Dispose();
            return dt;
        }

        public void SuaHocVien(string MaHV, string TenHV, string DonVi, string SDT, string MaLop)
        {
            try
            {
                string sql = "SuaHocVien";
                SqlConnection con = new SqlConnection(ConnectDB.getconnect());
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHV", MaHV);
                cmd.Parameters.AddWithValue("@TenHv", TenHV);
                cmd.Parameters.AddWithValue("@DonVi", DonVi);
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@MaLop", MaLop);

                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ThemHocVien(string MaHV, string TenHV, string DonVi, string SDT, string MaLop)
        {
            string sql = "ThemHocVien";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mahv", MaHV);
            cmd.Parameters.AddWithValue("@ten", TenHV);
            cmd.Parameters.AddWithValue("@donvi", DonVi);
            cmd.Parameters.AddWithValue("@sdt", SDT);
            cmd.Parameters.AddWithValue("@malop", MaLop);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }

        public void XoaHocVien(string MaHV)
        {
            string sql = "XoaHocVien";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaHV", MaHV);

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
    }
}
