namespace SqlBuilder.Statment.Select
{
    public class AsStatment : StatementBase
    {
        public AsStatment(SqlBuilder context, string aliasName)
            : base(context)
        {
            this.StatementBock = string.Format("as {0}", aliasName);
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