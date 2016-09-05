using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
    public class AndStatment : WhereStatment
    {
        public AndStatment(SqlBuilder context, string condition)
            : base(context)
        {
            this.StatementBock = string.Format("and {0}", condition);
        }
    }
}