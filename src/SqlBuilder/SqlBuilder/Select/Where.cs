namespace SqlBuilder.Select
{
    public class Where : StatementBase
    {
        internal Where(SqlBuilder context, string condition) : base(context)
        {
            this.StatementBock = "where " + condition;
        }

        public Limit Limit(int start, int end)
        {
            return new Limit(this.Context, start, end);
        }
    }
}