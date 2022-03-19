using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class SqlDriver
    {
        private string GetConnectionString()
        {
            string connstr = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStringDB"].ConnectionString;

            return connstr;
        }

        public DataTable GetData(string SpName)
        {
            DataTable dt = new DataTable();
            string cs = string.Empty;
            cs = GetConnectionString();
            try{
                using (SqlConnection con = new SqlConnection(cs))
                {
                    
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = SpName;
                    con.Open();

                    SqlDataAdapter sqlobj = new SqlDataAdapter(cmd);
                    sqlobj.Fill(dt);

                    con.Close();

                }

                return dt;
            }
            catch(Exception ex) {
                Console.WriteLine("Error occured while getting information from Azure DB: " + ex.InnerException.ToString());
                return dt;
            }
        }

    }
}
