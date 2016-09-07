using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
    public class UnionStatement : StatementBase
    {
        protected virtual string Symbol {
            get
            {
                return "union"; 
            } 
        }

        internal UnionStatement(SqlBuilder context, StatementBase statmen) : base(context)
        {
            if (this.Context.Statements.First() == this)
            {
                this.StatementBock = string.Format(" {0}", statmen.ToString());
            }
            else
            {
                this.StatementBock = string.Format("\n{0}\n {1}", Symbol, statmen.ToString());
            }
        }

        public UnionStatement Union(StatementBase statmen)
        {
            return new UnionStatement(this.Context, statmen);
        }

        public UnionStatement UnionAll(StatementBase statmen)
        {
            return new UnionAllStatement(this.Context, statmen);
        }
    }
}