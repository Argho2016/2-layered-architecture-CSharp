using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL.Tables
{
    public class Infos
    {
        //get - select * from info
        public List<Info> Get()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mazid\source\repos\CRUD\DB\Test.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from INFO";
            SqlCommand cmd = new SqlCommand(query, conn);
            List<Info> data = new List<Info>();
            SqlDataReader reader = cmd.ExecuteReader();

            

            //loop - for, while, foreach, do while
            while(reader.Read())
            {
                Info temp = new Info();
                temp.Name = reader.GetString(reader.GetOrdinal("NAME"));
                temp.City = reader.GetString(reader.GetOrdinal("CITY"));
                temp.Country = reader.GetString(reader.GetOrdinal("COUNTRY"));
                data.Add(temp);

            }
            return data;
        }

        //add - insert
        
        //other operations

    }
}
