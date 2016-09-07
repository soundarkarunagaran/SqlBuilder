using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
    public class ColumnAsStatment: StatementBase
    {
        internal ColumnAsStatment(SqlBuilder context, string aliasName) : base(context)
        {
            this.StatementBock = string.Format(" as {0}", aliasName);
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
