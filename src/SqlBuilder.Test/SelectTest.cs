using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SqlBuilder.Statment;

namespace SqlBuilder.Test
{
    [TestClass]
    public class SelectTest
    {
        [TestMethod]
        public void TestSelect()
        {
            var sql = SqlBuilder.Database(Dialect.SqlServer2005).Select;
            Assert.AreEqual(sql.ToString(), "select");
        }


        [TestMethod]
        public void TestColumn()
        {
            var sql = SqlBuilder.Database(Dialect.SqlServer2005).Select.All;
            Assert.AreEqual(sql.ToString(), "select *");
            sql = SqlBuilder.Database(Dialect.Sqlite).Select.Column("a","b").Column("c").As("c").Column("d as d");
            Assert.AreEqual(sql.ToString(), "select a,b,c as c,d as d");
        }

        [TestMethod]
        public void TestForm()
        {
            StatementBase sql = SqlBuilder.Database(Dialect.SqlServer2005).Select.All.Form("table1").As("t1");
            Assert.AreEqual(sql.ToString(), "select * form table1 as t1");
            sql = SqlBuilder.Database(Dialect.SqlServer2005).Select.All.Form("table1").As("t1").Form("table2 as t2");
            Assert.AreEqual(sql.ToString(), "select * form table1 as t1,table2 as t2");
        }


        [TestMethod]
        public void TestWhere()
        {
            StatementBase sql = SqlBuilder.Database(Dialect.SqlServer2005).
                Select.All.Form("table1").As("t1").Where("t1.id>10").And("t1.id<100").Or("1=2");
            Assert.AreEqual(sql.ToString(), "select * form table1 as t1 where t1.id>10 and t1.id<100 or 1=2");
        }


        [TestMethod]
        public void InnerForm()
        {
            var sql = SqlBuilder.Database(Dialect.SqlServer2005).
                Select.All.Form("table1").As("t1").LeftJoin("table2").As("t2").On("t1.id=t2.tId");
            Assert.AreEqual(sql.ToString(), "select * form table1 as t1 left join table2 as t2 on t1.id=t2.tId");
        }
    }
}
