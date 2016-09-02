using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Select
{
    public class OrderBy : StatementBase
    {
        public OrderBy(SqlBuilder context, params string[] columns)
            : base(context)
        {
            this.StatementBock = string.Format("order by {0}", string.Join(",", columns));
        }

        public Limit Limit(int start, int end)
        {
            return new Limit(this.Context, start, end);
        }
    }
}