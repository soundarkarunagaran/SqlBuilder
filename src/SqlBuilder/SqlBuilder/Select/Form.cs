namespace SqlBuilder.Select
{
    public class Form : StatementBase
    {

        internal Form(SqlBuilder context, string tableName, string aliasName = null)
            : base(context)
        {
            this.StatementBock = "form";
        }

        public Where Where(string condition)
        {
            return new Where(Context, condition);
        }
    }
}