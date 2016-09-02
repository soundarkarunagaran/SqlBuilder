namespace SqlBuilder.Select
{
    public class As : StatementBase
    {
        public As(SqlBuilder context, string aliasName)
            : base(context)
        {
            this.StatementBock = string.Format("as {0}", aliasName);
        }

        public Where Where(string condition)
        {
            return new Where(Context, condition);
        }
    }
}