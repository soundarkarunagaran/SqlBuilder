namespace SqlBuilder.Select
{
    public class Column
    {
        private readonly SqlBuilder _context;

        internal Column(SqlBuilder context, params string[] column)
        {
            _context = context;
        }

        public Form Form(string tableName, string aliasName = null)
        {
            return new Form(this._context, tableName, aliasName);
        }
    }
}