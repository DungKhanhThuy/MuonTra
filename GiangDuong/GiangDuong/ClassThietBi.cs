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
    class ClassThietBi
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_ThietBi");
        }

        public void TB_DB(string proc, string matb, string tentb, string maloai, string tinhtrang)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaTb", matb);
                command.Parameters.AddWithValue("@TenTB", tentb);
                command.Parameters.AddWithValue("@MaLoai", maloai);
                command.Parameters.AddWithValue("@TinhTrang", tinhtrang);
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
