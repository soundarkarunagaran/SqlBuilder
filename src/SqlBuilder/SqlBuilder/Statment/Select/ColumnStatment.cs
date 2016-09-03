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

        public FormStatment Form(string tableName)
        {
            return new FormStatment(Context, tableName);
        }

        public FormStatment Form(StatementBase statment)
        {
            return new FormStatment(this.Context, statment);
        }
    }
}