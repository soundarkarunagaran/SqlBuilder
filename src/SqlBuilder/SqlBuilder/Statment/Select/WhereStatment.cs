namespace SqlBuilder.Statment.Select
{
    public class WhereStatment : StatementBase
    {
        internal WhereStatment(SqlBuilder context, string condition) : base(context)
        {
            this.StatementBock = "where " + condition;
        }

        public OrderByStatment OrderBy(params string[] columns)
        {
            return new OrderByStatment(Context ,columns);
        }

        public WhereStatment Where(string condition)
        {
            return new WhereStatment(Context, condition);
        }

        public GroupByStatment GroupBy(params string[] columns)
        {
            return new GroupByStatment(Context, columns);
        }
    }
}