namespace SqlBuilder.Select
{
    public class Select : StatementBase
    {
        internal Select(SqlBuilder context) : base(context)
        {
            this.StatementBock = "select";
        }

        public Column All
        {
            get { return new Column(Context, "*"); }
        }

        public Column Column(params string[] column)
        {
            return new Column(Context, column);
        }
    }
}