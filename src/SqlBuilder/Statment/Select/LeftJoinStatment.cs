using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlBuilder.Statment.Select
{
   public  class LeftJoinStatment: InnerJoinStatment
    {
        protected override string Symbol
        {
            get
            {
                return "left join";
            }
        }
        public LeftJoinStatment(SqlBuilder context, string tableName) : base(context, tableName)
        {

        }
    }
}
