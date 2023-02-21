using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NguyenQuangKhai.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=VinShop;Integrated Security=True";

        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } private set { instance = value; } }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {

            DataTable data = new DataTable();

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach(string strPara in listPara)
                    {
                        if (strPara.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(strPara, parameter[i]);
                            i++;
                        }
                    }

                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                connection.Close();

            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string strPara in listPara)
                    {
                        if (strPara.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(strPara, parameter[i]);
                            i++;
                        }
                    }

                }

                data = cmd.ExecuteNonQuery();

                connection.Close();

            }
            return data;
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');

                    int i = 0;

                    foreach (string strPara in listPara)
                    {
                        if (strPara.Contains("@"))
                        {
                            cmd.Parameters.AddWithValue(strPara, parameter[i]);
                            i++;
                        }
                    }

                }

                data = cmd.ExecuteScalar();

                connection.Close();

            }
            return data;
        }
    }
}
