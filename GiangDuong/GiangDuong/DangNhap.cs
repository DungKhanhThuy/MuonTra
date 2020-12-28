using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace GiangDuong
{
    public class DangNhap
    {

        public bool DangNhapHT(string Username, string Pass)
        {
            string sql = "SELECT * FROM NguoiDung WHERE MaNV='" + Username + "' AND MatKhau='" + Pass + "'";
            SqlConnection con = new SqlConnection(ConnectDB.getconnect());
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);

            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}
