namespace SqlBuilder.Statment
{
    public static class WhereCondition
    {
        public static string In<T>(this string column, params T[] array)
        {
            return string.Format("{0} in ({1})", column, string.Join(",", array));
        }

        public static string In(this string column, StatementBase subStatment)
        {
            return string.Format("{0} in ({1})", column, subStatment);
        }
        
        public static string NotIn<T>(this string column, params T[] array)
        {
            return string.Format("{0} not in ({1})", column, string.Join(",", array));
        }

        public static string NotIn(this string column, StatementBase subStatment)
        {
            return string.Format("{0} not in ({1})", column, subStatment);
        }
        public static string Exists(this string column, StatementBase subStatment)
        {
            return string.Format("exists ({1})", column, subStatment);
        }

        public static string NotExists(this string column, StatementBase subStatment)
        {
            return string.Format("not exists ({1})", column, subStatment);
        }
    }
}