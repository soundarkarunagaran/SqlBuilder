namespace SqlBuilder.Select
{
    public class Limit : StatementBase
    {
        public Limit(SqlBuilder context, int start, int end)
            : base(context)
        {
            this.StatementBock = string.Format("limit{0},{1}", start, end);
        }
    }
}