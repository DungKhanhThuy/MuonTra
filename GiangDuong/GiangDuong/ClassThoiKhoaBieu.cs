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
    class ClassThoiKhoaBieu
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_TKB");
        }

        public void TKB_DB(string proc, string malop, string maphong, string ngaybatdau, string buoi, string ngayketthuc)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaLop", malop);
                command.Parameters.AddWithValue("@MaPhong", maphong);
                command.Parameters.AddWithValue("@NgayBatDau", ngaybatdau);
                command.Parameters.AddWithValue("@Buoi", buoi);
                command.Parameters.AddWithValue("@NgayKetThuc", ngayketthuc);
                //command.Parameters.AddWithValue("@MaLop", SqlDbType.VarChar).Value = malop;
                //command.Parameters.AddWithValue("@MaPhong", SqlDbType.VarChar).Value = maphong;
                //command.Parameters.AddWithValue("@NgayBatDau", SqlDbType.VarChar).Value = ngaybatdau;
                //command.Parameters.AddWithValue("@Buoi", SqlDbType.VarChar).Value = buoi;
                //command.Parameters.AddWithValue("@NgayKetThuc", SqlDbType.VarChar).Value = ngayketthuc;
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
