namespace SqlBuilder.Statment
{
    public abstract class StatementBase
    {
        public string StatementBock { get; set; }
        internal SqlBuilder Context { get; set; }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="isNew">是否为一个新的查询</param>
        protected StatementBase(SqlBuilder context, bool isNew = false)
        {
            Context = SqlBuilder.Database(context.Dialect);
            if (!isNew)
                Context.Statements.AddRange(context.Statements);
            Context.AddStatement(this);
        }

        public override string ToString()
        {
            return Context.ToString();
        }
    }
}