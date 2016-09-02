using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder
{
    public class SqlBuilder
    {
        private SqlBuilder()
        {
        }

        public static SqlBuilder Database(string dialect = "")
        {
            return new SqlBuilder();
        }

        public Select.Select Select
        {
            get { return new Select.Select(this); }
        }
    }
}