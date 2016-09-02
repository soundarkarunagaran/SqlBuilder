namespace SqlBuilder.Select
{
    public class Select
    {
        private readonly SqlBuilder _context;

        internal Select(SqlBuilder context)
        {
            _context = context;
        }

        public Column All
        {
            get { return new Column(this._context, "*"); }
        }

        public Column Column(params string[] column)
        {
            return new Column(this._context, column);
        }
    }
}