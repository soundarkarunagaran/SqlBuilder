using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
    public class InnerJoinStatment : StatementBase
    {
        internal InnerJoinStatment(SqlBuilder context, string tableName) : base(context)
        {
            this.StatementBock = string.Format("inner join {0}", tableName);
        }

        public WhereStatment Where(string condition)
        {
            return new WhereStatment(Context, condition);
        }

        public AsStatment As(string aliasName)
        {
            return new AsStatment(Context, aliasName);
        }

        public OrderByStatment OrderBy(params string[] columns)
        {
            return new OrderByStatment(Context, columns);
        }

        public GroupByStatment GroupBy(params string[] columns)
        {
            return new GroupByStatment(Context, columns);
        }
    }
}