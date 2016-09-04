using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
   public  class RightJoinStatment: InnerJoinStatment
    {
        protected virtual string Symbol
        {
            get
            {
                return "right join";
            }
        }
        public RightJoinStatment(SqlBuilder context, string tableName) : base(context, tableName)
        {

        }
    }
}
