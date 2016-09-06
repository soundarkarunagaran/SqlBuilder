using System;
using System.Linq;

namespace SqlBuilder.Statment.Select
{
    public class ColumnStatment : StatementBase
    {
        internal ColumnStatment(SqlBuilder context, params string[] column)
            : base(context)
        {
            if (this.Context.Statements.First(item => item.GetType() == typeof (ColumnStatment)) == this)
            {
                this.StatementBock = String.Join(",", column);
            }
            else
            {
                this.StatementBock = string.Format(",{0}", String.Join(",", column)) ;
            }

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