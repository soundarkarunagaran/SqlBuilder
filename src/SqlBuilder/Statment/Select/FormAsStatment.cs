namespace SqlBuilder.Statment.Select
{
    public class FormAsStatment : StatementBase
    {
        public FormAsStatment(SqlBuilder context, string aliasName)
            : base(context)
        {
            this.StatementBock = string.Format(" as {0}", aliasName);
        }

        /// <summary>
        /// ��ѯһ����
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public FormStatment Form(string tableName)
        {
            return new FormStatment(Context, tableName);
        }

        /// <summary>
        /// �Ӳ�ѯ
        /// </summary>
        /// <param name="statment"></param>
        /// <returns></returns>
        public FormStatment Form(StatementBase subStatment)
        {
            return new FormStatment(this.Context, subStatment);
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