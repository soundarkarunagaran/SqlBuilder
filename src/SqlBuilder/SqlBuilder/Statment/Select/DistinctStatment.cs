using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
    public class DistinctStatment:StatementBase
    {
        internal DistinctStatment(SqlBuilder context) : base(context)
        {
            this.StatementBock = "distinct";
        }

        public ColumnStatment All
        {
            get { return new ColumnStatment(Context, "*"); }
        }

        public ColumnStatment Column(params string[] column)
        {
            return new ColumnStatment(Context, column);
        }
    }
}
