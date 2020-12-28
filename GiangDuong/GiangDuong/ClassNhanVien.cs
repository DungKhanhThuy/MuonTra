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
    class ClassNhanVien
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_NhanVien");
        }

        public void NV_DB(string proc, string manv, string ten, string chucvu, string sdt)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = proc;
                command.Connection = cn;

                command.Parameters.AddWithValue("@MaNV", manv);
                command.Parameters.AddWithValue("@TenNV", ten);
                command.Parameters.AddWithValue("@ChucVu", chucvu);
                command.Parameters.AddWithValue("@SDT", sdt);
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
