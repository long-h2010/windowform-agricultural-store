using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;
        private string connect = "Data Source=.\\SQLEXPRESS;Initial Catalog=QUANLYNONGSAN;Integrated Security=True";

        public static DataProvider Instance
        { 
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; } 
        }

        private DataProvider() { }
        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if(para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                connection.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, object[] para = null)
        {
            int dt = 0;

            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteNonQuery();
                connection.Close();
            }
            return dt;
        }

        public object ExecuteScalar(string query, object[] para = null)
        {
            object dt = 0;

            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }
                dt = cmd.ExecuteScalar();
                connection.Close();
            }
            return dt;
        }
    }
}
