using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlBuilder.Statment;
using SqlBuilder.Statment.Select;

namespace SqlBuilder
{
    public class SqlBuilder
    {
        public string Dialect { get; private set; }
        internal List<StatementBase> Statements { get; private set; }

        private SqlBuilder()
        {
            Statements = new List<StatementBase>();
        }

        internal void AddStatement(StatementBase statment)
        {
            this.Statements.Add(statment);
        }

        public override string ToString()
        {
            return string.Join(" \n", this.Statements.Select(item => item.StatementBock));
        }

        public static SqlBuilder Database(string dialect = "")
        {
            return new SqlBuilder() {Dialect = dialect};
        }

        public SelectStatment Select
        {
            get { return new SelectStatment(this); }
        }
    }
}