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
            SqlBuilder.Database(Dialect.Sqlite).Select.All.Form("test").Where("a");
        }
    }
}
