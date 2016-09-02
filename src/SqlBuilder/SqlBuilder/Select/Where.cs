namespace SqlBuilder.Select
{
    public class Where : StatementBase
    {
        internal Where(SqlBuilder context, string condition) : base(context)
        {
            this.StatementBock = "where " + condition;
        }

        public OrderBy OrderBy(params string[] columns)
        {
            return new OrderBy(Context ,columns);
        }


    }
}