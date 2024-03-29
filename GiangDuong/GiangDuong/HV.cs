﻿using System;
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
    }
}
