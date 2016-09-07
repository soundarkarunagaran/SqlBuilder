using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
    public class InnerJoinStatment : StatementBase
    {
        protected virtual string Symbol
        {
            get { return "inner join"; }
        }

        internal InnerJoinStatment(SqlBuilder context, string tableName) : base(context)
        {
            this.StatementBock = string.Format(" {0} {1}", Symbol, tableName);
        }


        public JoinAsStatment As(string aliasName)
        {
            return new JoinAsStatment(Context, aliasName);
        }

    }
}