namespace SqlBuilder.Statment.Select
{
    public class SelectStatment : StatementBase
    {
        internal SelectStatment(SqlBuilder context) : base(context)
        {
            this.StatementBock = "select";
        }

        
                    public DistinctStatment Distinct
        {
            get { return new DistinctStatment(Context); }
        }

        public ColumnStatment All
        {
            get { return new ColumnStatment(Context, "*"); }
        }

        public ColumnStatment Column(params string[] column)
        {
            return new ColumnStatment(Context, column);
        }


    }
}