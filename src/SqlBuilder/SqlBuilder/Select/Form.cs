namespace SqlBuilder.Select
{
    public class Form
    {
        private readonly SqlBuilder _context;

        internal Form(SqlBuilder context, string tableName, string aliasName = null)
        {
            _context = context;
        }

        public Where Where(string condition)
        {
            return new Where(this._context, condition);
        }
    }
}