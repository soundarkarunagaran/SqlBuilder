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
            var sql = SqlBuilder.Database(Dialect.Sqlite).
                Select.Column("year(sj) as [year]")
                .Form("Enterprise_CZSJYF")
                .GroupBy("year(sj)")
                ;

     

            var subQuery = SqlBuilder.Database(Dialect.SqlServer2005).
                Select.All.Form("test").As("t").Where("1=1");

            var union = SqlBuilder.Database(Dialect.Sqlite).Union(sql, subQuery)
                .UnionAll(sql);

            var sql2 =
                SqlBuilder.Database(Dialect.SqlServer2005)
                    .Select.All.Form(subQuery)
                    .As("sub")
                    .GroupBy("asdf")
                    .Having("123")
                    .ToString();
        }
    }
}