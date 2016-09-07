# SqlBuilder
一个通过链式方法编写Sql语句的类库，本项目的目标是：一次编写生成各种数据库方言。

## 例子

### 普通查询
代码：
```csharp
SqlBuilder.Database(Dialect.SqlServer2005).Select.All.Form("table1").As("t1");
```
SQL：
```sql
select * form table1 as t1
```

### Where查询
代码：
```csharp
SqlBuilder.Database(Dialect.SqlServer2005).
Select.All.Form("table1").As("t1").Where("t1.id>10").And("t1.id<100").Or("1=2");
```
SQL：
```sql
select * form table1 as t1 where t1.id>10 and t1.id<100 or 1=2
```
### 表链接
```csharp
SqlBuilder.Database(Dialect.SqlServer2005).
Select.All.Form("table1").As("t1").Form("table2 as t2")
```
```sql
select * form table1 as t1,table2 as t2
```
```csharp
SqlBuilder.Database(Dialect.SqlServer2005).
Select.All.Form("table1").As("t1").InnerJoin("table2").As("t2").On("t1.id=t2.tId");
```
```sql
select * form table1 as t1 inner join table2 as t2 on t1.id=t2.tId
```
```csharp
SqlBuilder.Database(Dialect.SqlServer2005).
Select.All.Form("table1").As("t1").LeftJoin("table2").As("t2").On("t1.id=t2.tId");
```
```sql
select * form table1 as t1 left join table2 as t2 on t1.id=t2.tId
```
```csharp
SqlBuilder.Database(Dialect.SqlServer2005).
Select.All.Form("table1").As("t1").RightJoin("table2").As("t2").On("t1.id=t2.tId");
```
```sql
select * form table1 as t1 right join table2 as t2 on t1.id=t2.tId
```