﻿namespace SqlBuilder.Statment.Select
{
    public class WhereStatment : StatementBase
    {
        internal WhereStatment(SqlBuilder context) : base(context)
        {
        }

        internal WhereStatment(SqlBuilder context, string condition) : base(context)
        {
            this.StatementBock = string.Format(" where {0}", condition);
        }


        public AndStatment And(string condition)
        {
            return new AndStatment(Context, condition);
        }

        public OrStatment Or(string condition)
        {
            return new OrStatment(Context, condition);
        }

        public GroupByStatment GroupBy(params string[] columns)
        {
            return new GroupByStatment(Context, columns);
        }

        public OrderByStatment OrderBy(params string[] columns)
        {
            return new OrderByStatment(Context, columns);
        }
    }
}