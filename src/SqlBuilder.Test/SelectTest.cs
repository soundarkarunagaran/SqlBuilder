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
            Assert.AreEqual(sql.ToString(), "select a,b ,c as c ,d as d");
        }
    }
}
