namespace SqlBuilder.Statment.Select
{
    public class GroupByStatment: StatementBase
    {
        internal GroupByStatment(SqlBuilder context, params string[] columns)
            : base(context)
        {
            this.StatementBock = string.Format("group by {0}", string.Join(",", columns));
        }

        public HavingStatment Having(params string[] columns)
        {
            return new HavingStatment(this.Context,columns);
        }

        public OrderByStatment OrderBy(params string[] columns)
        {
            return new OrderByStatment(Context, columns);
        }
    }
}