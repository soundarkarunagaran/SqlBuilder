using System;

namespace SqlBuilder.Statment.Select
{
    public class ColumnStatment : StatementBase
    {
        internal ColumnStatment(SqlBuilder context, params string[] column)
            : base(context)
        {
            this.StatementBock = String.Join(",", column);
        }


        public ColumnStatment Column(params string[] column)
        {
            return new ColumnStatment(Context, column);
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
    }
}