using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
  public  class OnStatment:StatementBase
    {
        internal OnStatment(SqlBuilder context, string condition) : base(context)
        {
            this.StatementBock = string.Format("on {0}", condition);
        }

        public WhereStatment Where(string condition)
        {
            return new WhereStatment(Context, condition);
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
