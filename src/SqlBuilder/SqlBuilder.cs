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
            return string.Join("", this.Statements.Select(item => item.StatementBock)).Trim();
        }

        public static SqlBuilder Database(string dialect = "")
        {
            return new SqlBuilder() {Dialect = dialect};
        }

        public SelectStatment Select
        {
            get { return new SelectStatment(this); }
        }

        public UnionStatement Union(params StatementBase[] statments)
        {
            UnionStatement result = null;
            foreach (var statment in statments)
            {
                if(result==null)
                    result = new UnionStatement(this, statment);
                else
                    result.Union(statment);
            }
            return result;
        }

        public UnionStatement UnionAll(params StatementBase[] statments)
        {
            UnionAllStatement result = null;
            foreach (var statment in statments)
            {
                if (result == null)
                    result = new UnionAllStatement(this, statment);
                else
                    result.UnionAll(statment);
            }
            return result;
        }
    }
}