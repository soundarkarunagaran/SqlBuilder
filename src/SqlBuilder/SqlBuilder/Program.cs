using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
       var sql=     SqlBuilder.Database(Dialect.Sqlite).Select.All.Form("test").Where("1=1").Limit(1,10).ToString();
        }
    }
}
