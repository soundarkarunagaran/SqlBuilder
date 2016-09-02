using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder
{
    public abstract class StatementBase
    {
        public string StatementBock { get; set; }
        internal SqlBuilder Context { get; set; }

        protected StatementBase()
        {
        }


        protected StatementBase(SqlBuilder context)
        {
            Context = context;
            Context.AddStatement(this);
        }

        public override string ToString()
        {
            return Context.ToString();
        }
    }
}