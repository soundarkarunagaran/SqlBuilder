using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
    public class OrStatment : WhereStatment
    {
        public OrStatment(SqlBuilder context, string condition)
            : base(context)
        {
            this.StatementBock = string.Format(" or {0}", condition);
        }
    }
}