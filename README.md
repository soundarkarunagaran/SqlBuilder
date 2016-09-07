# SqlBuilder
一个通过链式方法编写Sql语句的类库，本项目的目标是：一次编写生成各种数据库方言。

例子：

普通查询
代码：SqlBuilder.Database(Dialect.SqlServer2005).Select.All.Form("table1").As("t1");
SQL：select * form table1 as t1

Where查询
代码：SqlBuilder.Database(Dialect.SqlServer2005).Select.All.Form("table1").As("t1").Where("t1.id>10").And("t1.id<100").Or("1=2");
SQL：select * form table1 as t1 where t1.id>10 and t1.id<100 or 1=2
