using System.Linq;

namespace SqlBuilder.Statment.Select
{
    public class LimitStatment : StatementBase
    {
        internal LimitStatment(SqlBuilder context, int start, int end) : base(context, true)
        {
            if (context.Dialect == Dialect.SqlServer2005)
            {
                /* 转换查询为以下格式
                select * form (
                    select row_number() over(order by id desc) as row_number,* form test as t where 1=1
                ) where row_number between 1 and 10
                 */

                //原语句中移除orderBy
                var orderby = context.Statements.FirstOrDefault(item => item.GetType() == typeof(OrderByStatment));
                context.Statements.Remove(orderby);

                //修改第一个列语句
                var orderColumnName = "row_number";
                var column = context.Statements.FirstOrDefault(item => item.GetType() == typeof(ColumnStatment));
                column.StatementBock = column.StatementBock.Insert(0,
                    string.Format("row_number() over({1}) as {0},", orderColumnName, orderby.StatementBock));
                
                this.StatementBock = this.Context.Select.All.Form(context.Statements.Last())
                    .Where(string.Format("{0} between {1} and {2}", orderColumnName, start, end))
                    .ToString();
            }
            else
            {
                this.Context = context;
                this.StatementBock = string.Format(" limit{0},{1}", start, end);
            }
        }
    }
}