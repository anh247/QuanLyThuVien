using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO 
{
    public class DataProvider
    {
        Connection cn = new Connection();
        private DataProvider(){}
       // string conn = @"Data Source = DAMTHANG\SQLEXPRESS; Initial Catalog = QuanLyTV; Integrated Security = True";
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }
        /// <summary>
        /// Trả về datatable theo cua query:
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
          //  using (SqlConnection connection = new SqlConnection(conn))
           // {
                
                SqlCommand cmd = new SqlCommand(query, cn.con);
                cn.OpenConn();
                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listpar = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item != string.Empty && item[0] == '@')
                        {
                            listpar.Add(item);
                        }
                        
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(listpar[i], parameter[i]);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                cn.CloseConn();
                return data;
            //}
        }
        /// <summary>
        /// Thực hiện thêm | Sửa | Xóa 
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public int ExcuteNonQuery(string query,object[] parameter = null)
        {
            int accpectedRows = 0;

            DataTable data = new DataTable();
           // using (SqlConnection connection = new SqlConnection(conn))
           // {
                SqlCommand cmd = new SqlCommand(query, cn.con);
                cn.OpenConn();
                if (parameter != null)
                {
                    string[] temp = query.Split(' ');
                    List<string> listpar = new List<string>();
                    foreach (string item in temp)
                    {
                        if (item !=string.Empty&&item[0] == '@')
                        {
                            listpar.Add(item);
                        }
                    }
                    for (int i = 0; i < parameter.Length; i++)
                    {
                        cmd.Parameters.AddWithValue(listpar[i], parameter[i]);
                    }
                }
                accpectedRows=cmd.ExecuteNonQuery();
                cn.CloseConn();
           // }

            return accpectedRows;
        }
        
    }
}
