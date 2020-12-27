using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GiangDuong
{
    public class ConnectDB
    {
        SqlConnection connection = new SqlConnection();
        public ConnectDB()
        {
            try
            {
                connection.ConnectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=QLTBGD; Integrated Security=true";
                connection.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        static public String getconnect()
        {
            return (@"Data Source=.\SQLEXPRESS; Initial Catalog=QLTBGD; Integrated Security=true");
        }



        public DataTable LoadData(string proc)
        {
            DataTable data = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
            cn.Open();
            command.Connection = cn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            cn.Close();
            adapter.Dispose();
            return data;
        }

        public DataTable LoadData1(string proc, string param, string value)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
            cn.Open();
            command.Connection = cn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param, SqlDbType.VarChar).Value = value;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            cn.Close();
            adapter.Dispose();
            return table;
        }

        public DataTable LoadData2(string proc, string param1, string param2, string value1, string value2)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
            cn.Open();
            command.Connection = cn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param1, SqlDbType.VarChar).Value = value1;
            command.Parameters.AddWithValue(param2, SqlDbType.VarChar).Value = value2;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            cn.Close();
            adapter.Dispose();
            return table;
        }

        public DataTable LoadData3(string proc, string param1, string param2, string param3, string value1, string value2, string value3)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
            cn.Open();
            command.Connection = cn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param1, SqlDbType.VarChar).Value = value1;
            command.Parameters.AddWithValue(param2, SqlDbType.VarChar).Value = value2;
            command.Parameters.AddWithValue(param3, SqlDbType.VarChar).Value = value3;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            cn.Close();
            adapter.Dispose();
            return table;
        }
        public DataTable LoadData4(string proc, string param1, string param2, string param3, string param4, string value1, string value2, string value3, string value4)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
            cn.Open();
            command.Connection = cn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param1, SqlDbType.VarChar).Value = value1;
            command.Parameters.AddWithValue(param2, SqlDbType.VarChar).Value = value2;
            command.Parameters.AddWithValue(param3, SqlDbType.VarChar).Value = value3;
            command.Parameters.AddWithValue(param4, SqlDbType.VarChar).Value = value4;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            cn.Close();
            adapter.Dispose();
            return table;
        }

        public DataTable LoadData5(string proc, string param1, string param2, string param3, string param4, string param5, string value1, string value2, string value3, string value4, string value5)
        {
            DataTable table = new DataTable();
            SqlCommand command = new SqlCommand();
            SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
            cn.Open();
            command.Connection = cn;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = proc;
            command.Parameters.AddWithValue(param1, SqlDbType.VarChar).Value = value1;
            command.Parameters.AddWithValue(param2, SqlDbType.VarChar).Value = value2;
            command.Parameters.AddWithValue(param3, SqlDbType.VarChar).Value = value3;
            command.Parameters.AddWithValue(param4, SqlDbType.VarChar).Value = value4;
            command.Parameters.AddWithValue(param5, SqlDbType.VarChar).Value = value5;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            cn.Close();
            adapter.Dispose();
            return table;
        }



        public void Xoa(string proc, string param, string ma)
        {
            try
            {
                SqlCommand command = new SqlCommand(proc, connection);
                SqlConnection cn = new SqlConnection(ConnectDB.getconnect());
                cn.Open();
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue(param, SqlDbType.VarChar).Value = ma;
                command.ExecuteNonQuery();
                cn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


    }
}
