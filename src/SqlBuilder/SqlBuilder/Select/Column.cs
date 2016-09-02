using System;

namespace SqlBuilder.Select
{
    public class Column : StatementBase
    {

        internal Column(SqlBuilder context, params string[] column)
            : base(context)
        {
            this.StatementBock = String.Join(",", column);
        }

        public Form Form(string tableName, string aliasName = null)
        {
            return new Form(Context, tableName, aliasName);
        }
    }
}