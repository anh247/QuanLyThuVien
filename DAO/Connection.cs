using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Connection
    {
        string strConn = @"Data Source=DESKTOP-G2AC9ID\HOANGTUSOI;Initial Catalog=QLTV;Integrated Security=True";
        public SqlConnection con { get; set; }
        public SqlDataReader drd { get; set; }
        public SqlCommand cmd { get; set; }
        SqlDataAdapter dar;
        DataTable table;
        //KẾT NOI
        public Connection()
        {
            con = new SqlConnection(strConn);
            drd = null;
            cmd = null;
        }
        public bool OpenConn()
        {
            try
            {
                this.con.Open();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool CloseConn()
        {
            try

            {
                this.con.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        /// <summary>
        /// Gọi Hàm
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public SqlDataReader executeSQL(string strSQL)
        {

            this.cmd = new SqlCommand(strSQL, this.con);
            this.drd = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return this.drd;
        }

        public bool executeUpdate(string strUpdate)
        {
            this.cmd = new SqlCommand(strUpdate, this.con);
            int a = (int)cmd.ExecuteNonQuery();
            if (a >= 1)
                return true;
            return false;
        }
        public int executeScala(string strSQL)
        {
            this.cmd = new SqlCommand(strSQL, this.con);
            int temp = (int)cmd.ExecuteScalar();
            return temp;
        }
    }
}
