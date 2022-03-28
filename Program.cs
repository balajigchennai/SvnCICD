using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Azure Cloud11");
            try
            {
                string spname = System.Configuration.ConfigurationManager.AppSettings["StoreProcedure"].ToString();
                SqlDriver obj = new SqlDriver();
                DataTable dtInfo = new DataTable();
                dtInfo = obj.GetData(spname);

                Console.WriteLine("Count:" + dtInfo.Rows.Count);
                foreach (DataRow dataRow in dtInfo.Rows)
                {
                    Console.WriteLine(dataRow[0] +"-" + dataRow[1]);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured while invoking data  from Azure DB: " + ex.InnerException.ToString());
                Console.ReadLine();
               
            }

        }
    }
}
