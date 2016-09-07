using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlBuilder.Statment.Select;

namespace SqlBuilder.Statment
{
    public class JoinAsStatment : StatementBase
    {
        public JoinAsStatment(SqlBuilder context, string aliasName)
            : base(context)
        {
            this.StatementBock = string.Format(" as {0}", aliasName);
        }

        public OnStatment On(string condition)
        {
            return new OnStatment(Context, condition);
        }


    }
}
