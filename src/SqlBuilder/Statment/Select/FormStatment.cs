namespace SqlBuilder.Statment.Select
{
    public class FormStatment : StatementBase
    {
        protected virtual string Symbol
        {
            get { return "form"; }
        }


        internal FormStatment(SqlBuilder context, string tableName)
            : base(context)
        {
            this.StatementBock = string.Format("{0} {1}", this.Symbol, tableName);
        }


        /// <summary>
        /// 子查询
        /// </summary>
        /// <param name="context">当前context</param>
        /// <param name="statment">子查询</param>
        internal FormStatment(SqlBuilder context, StatementBase statment)
            : base(context)
        {
            this.StatementBock = string.Format("{0} ({1})", this.Symbol, statment.ToString());
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

        public FormAsStatment As(string aliasName)
        {
            return new FormAsStatment(Context, aliasName);
        }

        public InnerJoinStatment InnerJoin(string tableName)
        {
            return new InnerJoinStatment(Context, tableName);
        }

        public LeftJoinStatment LeftJoin(string tableName)
        {
            return new LeftJoinStatment(Context, tableName);
        }

        public RightJoinStatment RightJoin(string tableName)
        {
            return new RightJoinStatment(Context, tableName);
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