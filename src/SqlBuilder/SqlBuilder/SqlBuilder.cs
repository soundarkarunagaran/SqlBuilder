using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder
{
    public class SqlBuilder
    {
        public string Dialect { get; private set; }
        internal IList<StatementBase> Statements { get; private set; }

        private SqlBuilder()
        {
            Statements = new List<StatementBase>();
        }

        public void AddStatement(StatementBase statment)
        {
            this.Statements.Add(statment);
        }

        public override string ToString()
        {
            return string.Join(" ", this.Statements.Select(item => item.StatementBock));
        }


        public static SqlBuilder Database(string dialect = "")
        {
            return new SqlBuilder() {Dialect = dialect};
        }

        public Select.Select Select
        {
            get { return new Select.Select(this); }
        }
    }
}