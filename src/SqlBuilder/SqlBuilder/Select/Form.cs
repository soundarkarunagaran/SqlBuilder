namespace SqlBuilder.Select
{
    public class Form : StatementBase
    {
        internal Form(SqlBuilder context, string tableName)
            : base(context)
        {
            this.StatementBock = string.Format("form {0}", tableName);
        }

        internal Form(SqlBuilder context, StatementBase statment)
            : base(context)
        {
            this.Context =  SqlBuilder.Database(context.Dialect);
            this.StatementBock = string.Format("form ({0})", statment.ToString());
        }


        public Where Where(string condition)
        {
            return new Where(Context, condition);
        }

        public As As(string aliasName)
        {
            return new As(Context, aliasName);
        }
    }
}