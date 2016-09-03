namespace SqlBuilder.Statment.Select
{
    public class FormStatment : StatementBase
    {
        internal FormStatment(SqlBuilder context, string tableName)
            : base(context)
        {
            this.StatementBock = string.Format("form {0}", tableName);
        }

        /// <summary>
        /// 子查询
        /// </summary>
        /// <param name="context">当前context</param>
        /// <param name="statment">子查询</param>
        internal FormStatment(SqlBuilder context, StatementBase statment)
            : base(context)
        {
            this.StatementBock = string.Format("form ({0})", statment.ToString());
        }


        public WhereStatment Where(string condition)
        {
            return new WhereStatment(Context, condition);
        }

        public AsStatment As(string aliasName)
        {
            return new AsStatment(Context, aliasName);
        }

        public OrderByStatment OrderBy(params string[] columns)
        {
            return new OrderByStatment(Context, columns);
        }

        public GroupByStatment GroupBy(params string[] columns)
        {
            return new GroupByStatment(Context, columns);
        }
    }
}