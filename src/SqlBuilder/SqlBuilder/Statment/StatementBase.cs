namespace SqlBuilder.Statment
{
    public abstract class StatementBase
    {
        public string StatementBock { get; set; }
        internal SqlBuilder Context { get; set; }

        protected StatementBase()
        {
        }

        protected StatementBase(SqlBuilder context)
        {
            Context =  SqlBuilder.Database(context.Dialect);
            Context.Statements.AddRange(context.Statements);
            Context.AddStatement(this);
        }

        public override string ToString()
        {
            return Context.ToString();
        }
    }
}