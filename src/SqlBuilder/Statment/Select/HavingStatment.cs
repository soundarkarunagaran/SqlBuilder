namespace SqlBuilder.Statment.Select
{
    public class HavingStatment : StatementBase
    {
        internal HavingStatment(SqlBuilder context, params string[] columns)
            : base(context)
        {
            this.StatementBock = string.Format("having {0}", string.Join(",", columns));
        }

        public OrderByStatment OrderBy(params string[] columns)
        {
            return new OrderByStatment(Context, columns);
        }
    }
}