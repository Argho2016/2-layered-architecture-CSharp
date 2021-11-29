using DAL.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Database
    {
       public Infos InfoTable { get; set; }

        public Database()
        {
            InfoTable = new Infos();
        }
    }
}
