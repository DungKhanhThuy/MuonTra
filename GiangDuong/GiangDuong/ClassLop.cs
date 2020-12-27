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
    class ClassLop
    {
        ConnectDB cn = new ConnectDB();
        public DataTable Show()
        {
            return cn.LoadData("HienThi_Lop");
        }

        public void ThemLop(string maloai, string tenloai)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "ThemLop";
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaLop", SqlDbType.VarChar).Value = maloai;
                command.Parameters.AddWithValue("@TenLop", SqlDbType.VarChar).Value = tenloai;

                command.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SuaLop(string maloai, string tenloai)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SuaLop";
                command.Connection = cn;
                command.Parameters.AddWithValue("@MaLop", SqlDbType.VarChar).Value = maloai;
                command.Parameters.AddWithValue("@TenLop", SqlDbType.VarChar).Value = tenloai;
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
