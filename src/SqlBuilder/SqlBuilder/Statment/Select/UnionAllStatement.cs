using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
    public class UnionAllStatement : UnionStatement
    {
        protected override string Symbol
        {
            get { return "union all"; }
        }

        internal UnionAllStatement(SqlBuilder context, StatementBase statmen) : base(context,statmen)
        {
        }
    }
}