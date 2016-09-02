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
            var sql = SqlBuilder.Database(Dialect.SqlServer2005).
                Select.Column("*").Form("test").As("t").Where("1=1").Limit(1, 10).ToString();
            var sql1 = SqlBuilder.Database(Dialect.Sqlite).
                         Select.All.Form("test").As("t").Where("1=1").Limit(1, 10).ToString();
        }
    }
}