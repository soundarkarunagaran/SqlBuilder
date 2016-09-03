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
                Select.Distinct.Column("a","b").Column("c").Form("test").As("t").Where("1=1").OrderBy("id desc").Limit(1, 10).ToString();

            var subQuery = SqlBuilder.Database(Dialect.SqlServer2005).
                Select.All.Form("test").As("t").Where("1=1").OrderBy("id").Limit(1, 10);

            
            var sql2 = SqlBuilder.Database(Dialect.SqlServer2005).Select.All.Form(subQuery).As("sub").GroupBy("asdf").Having("123").ToString();
        }
    }
}