using System.Linq;

namespace SqlBuilder.Select
{
    public class Limit : StatementBase
    {
        internal Limit(SqlBuilder context, int start, int end) : base()
        {
            if (context.Dialect == Dialect.SqlServer2005)
            {
                //构造一个新的查询，讲传参进来的查询当作子查询
                this.Context = SqlBuilder.Database(context.Dialect);

                /* 转换查询为以下格式
                select * form (
                    select row_number() over(order by id desc) as row_number,* form test as t where 1=1
                ) where row_number between 1 and 10
                 */

                var orderColumnName = "row_number";
                var orderby = context.Statements.FirstOrDefault(item => item.GetType() == typeof(OrderBy));
                context.Statements.Remove(orderby);

                var column = context.Statements.FirstOrDefault(item => item.GetType() == typeof(Column));
                column.StatementBock = column.StatementBock.Insert(0,
                    string.Format("row_number() over({1}) as {0},", orderColumnName, orderby.StatementBock));

                this.StatementBock = this.Context.Select.All.Form(context.Statements.Last())
                    .Where(string.Format("{0} between {1} and {2}", orderColumnName, start, end))
                    .ToString();
            }
            else
            {
                this.Context = context;
                this.StatementBock = string.Format("limit{0},{1}", start, end);
            }
            this.Context.AddStatement(this);
        }
    }
}