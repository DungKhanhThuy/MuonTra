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
    class LichSu
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_LichSu");
        }

        public string create_MaLS()
        {
            DataTable dt = cn.LoadData("XemLichSu");
            int count = 0;
            count = dt.Rows.Count;
            string s1 = "";
            int s2 = 0;
            s1 = Convert.ToString(dt.Rows[count - 1][0].ToString());
            s2 = Convert.ToInt32((s1.Remove(0, 2)));
            s1 = "";
            if (s2 + 1 < 10)
                s1 = "LS00" + (s2 + 1).ToString();
            else if (s2 + 1 < 100)
                s1 = "LS0" + (s2 + 1).ToString();
            else
                s1 = "LS" + (s2 + 1).ToString();
            return s1;
        }

        public void ThemLichSu(string mals, string tenbang, string manv, string thoigian, string nd)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ThemLichSu";
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaLS", mals);
                command.Parameters.AddWithValue("@TenBang", tenbang);
                command.Parameters.AddWithValue("@MaNV", manv); 
                command.Parameters.AddWithValue("@ThoiGian", SqlDbType.VarChar).Value = thoigian;
                command.Parameters.AddWithValue("@NoiDung", nd);

                command.ExecuteNonQuery();
                command.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ThemLichSu1(string mals, string tenbang, string key1, string manv, string thoigian, string nd)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ThemLichSu1";
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaLS", mals);
                command.Parameters.AddWithValue("@TenBang", tenbang);
                command.Parameters.AddWithValue("@Key1", key1);
                command.Parameters.AddWithValue("@MaNV", manv);
                command.Parameters.AddWithValue("@ThoiGian", SqlDbType.VarChar).Value = thoigian;
                command.Parameters.AddWithValue("@NoiDung", nd);

                command.ExecuteNonQuery();
                command.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ThemLichSu1_ND(string mals, string tenbang, string manv, string key1,  string thoigian, string nd, string ndCu, string ndMoi)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ThemLichSu1_ND";
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaLS", mals);
                command.Parameters.AddWithValue("@TenBang", tenbang);
                command.Parameters.AddWithValue("@MaNV", manv);
                command.Parameters.AddWithValue("@Key1", key1);
                command.Parameters.AddWithValue("@ThoiGian", SqlDbType.VarChar).Value = thoigian;
                command.Parameters.AddWithValue("@NoiDung", nd);
                command.Parameters.AddWithValue("@ndCu", ndCu);
                command.Parameters.AddWithValue("@ndMoi", ndMoi);

                command.ExecuteNonQuery();
                command.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ThemLichSu2(string mals, string tenbang, string key1, string key2, string manv, string thoigian, string nd)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ThemLichSu2";
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaLS", mals);
                command.Parameters.AddWithValue("@TenBang", tenbang);
                command.Parameters.AddWithValue("@Key1", key1);
                command.Parameters.AddWithValue("@Key2", key2);
                command.Parameters.AddWithValue("@MaNV", manv);
                command.Parameters.AddWithValue("@ThoiGian", SqlDbType.VarChar).Value = thoigian;
                command.Parameters.AddWithValue("@NoiDung", nd);

                command.ExecuteNonQuery();
                command.Dispose();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ThemLichSu2_ND(string mals, string tenbang, string manv, string key1, string key2, string thoigian, string nd, string ndCu, string ndMoi)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ThemLichSu2_ND";
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaLS", mals);
                command.Parameters.AddWithValue("@TenBang", tenbang);
                command.Parameters.AddWithValue("@MaNV", manv);
                command.Parameters.AddWithValue("@Key1", key1);
                command.Parameters.AddWithValue("@Key2", key2);
                command.Parameters.AddWithValue("@ThoiGian", SqlDbType.VarChar).Value = thoigian;
                command.Parameters.AddWithValue("@NoiDung", nd);
                command.Parameters.AddWithValue("@ndCu", ndCu);
                command.Parameters.AddWithValue("@ndMoi", ndMoi);

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
