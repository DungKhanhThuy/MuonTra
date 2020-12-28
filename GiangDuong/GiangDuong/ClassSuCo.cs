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
    class ClassSuCo
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_SuCo");
        }

        public void SuCo_DB(string proc, string masc, string mayc, string matb, string suco, string xuly)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaSC", masc);
                command.Parameters.AddWithValue("@MaYC", mayc);
                command.Parameters.AddWithValue("@MaTB", matb);
                command.Parameters.AddWithValue("@SuCo", suco);
                command.Parameters.AddWithValue("@XuLy", xuly);
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
