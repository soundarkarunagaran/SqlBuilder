namespace SqlBuilder.Statment.Select
{
    public class AsStatment : StatementBase
    {
        public AsStatment(SqlBuilder context, string aliasName)
            : base(context)
        {
            this.StatementBock = string.Format("as {0}", aliasName);
        }

        /// <summary>
        /// 查询一个表
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public FormStatment Form(string tableName)
        {
            return new FormStatment(Context, tableName);
        }

        /// <summary>
        /// 子查询
        /// </summary>
        /// <param name="statment"></param>
        /// <returns></returns>
        public FormStatment Form(StatementBase subStatment)
        {
            return new FormStatment(this.Context, subStatment);
        }

        public WhereStatment Where(string condition)
        {
            return new WhereStatment(Context, condition);
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