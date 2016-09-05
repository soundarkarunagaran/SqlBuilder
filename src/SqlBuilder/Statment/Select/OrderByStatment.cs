namespace SqlBuilder.Statment.Select
{
    public class OrderByStatment : StatementBase
    {
        internal OrderByStatment(SqlBuilder context, params string[] columns)
            : base(context)
        {
            this.StatementBock = string.Format("order by {0}", string.Join(",", columns));
        }

        public LimitStatment Limit(int start, int end)
        {
            return new LimitStatment(this.Context, start, end);
        }
    }
}