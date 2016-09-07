using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            var sql = SqlBuilder.Database(Dialect.SqlServer2005).Select.All.Form("table1").As("t1");
            Assert.AreEqual(sql.ToString(), "select * form table1 as t1");
            sql = SqlBuilder.Database(Dialect.SqlServer2005).Select.All.Form("table1").As("t1").Form("table2").As( "t2");
            Assert.AreEqual(sql.ToString(), "select * form table1 as t1,table2 as t2");
        }
    }
}
