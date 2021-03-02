# TradeCategoryConsole
A bank has a portfolio of thousands of trades and they need to be categorized. A trade is a commercial negotiation between a bank and a client. Each trade has a value that indicates the transaction amount in dollars and a text indicating if the client´s sector is "Public" or "Private". They implement the following interface:

```c#
interface ITrade{
  double Value { get; }
  string ClientSector { get; }
}
```

Currently, there are three categories rules:

- LOWRISK: Trades with value less than 1,000,000 and client from Public Sector
- MEDIUMRISK: Trades with value greater than 1,000,000 and client from Public Sector
- HIGHRISK: Trades with value greater than 1,000,000 and client from Private Sector

Imagine you receive a list of trades and you need to return a list of categories as below:

## input

```c#
Trade1 {Value = 2000000; ClientSector = "Private"}
Trade2 {Value = 400000; ClientSector = "Public"}
Trade3 {Value = 500000; ClientSector = "Public"}
Trade4 {Value = 3000000; ClientSector = "Public"}

portfolio = {Trade1, Trade2, Trade3, Trade4}
```

## output

```c#
tradeCategories = {"HIGHRISK", "LOWRISK", "LOWRISK", "MEDIUMRISK"}
```

Your designmusttake into account category rules can be added/removed/modified andwillbecome highly complex in the near future.Please write your answer in C# showing clearly what classes, interfaces, methods and design patternsyou would create/use to solve this problem. Also, object oriented programming is appreciated.

## Solution

![alt text](https://github.com/fecassa/TradeCategoryConsole/blob/master/TradeCategoryConsole/img/cover.png?raw=true)

## SQL Solution

```sql
CREATE TABLE Trade (
    id int NOT NULL AUTO_INCREMENT,
    Value double, 
    ClientSelector CHAR(50) NOT NULL,
     PRIMARY KEY (id)
 );

insert into Trade (Value, ClientSelector) values (2000000,'Private');
insert into Trade (Value, ClientSelector) values (400000,'Public');
insert into Trade (Value, ClientSelector) values (500000,'Public');
insert into Trade (Value, ClientSelector) values (3000000,'Public');

SELECT CASE
  WHEN Value < 1000000 AND ClientSelector = UPPER('Public')  then 'LOWRISK'
  WHEN Value > 1000000 AND ClientSelector = UPPER('Public')  then 'MEDIUMRISK'
  WHEN Value > 1000000 AND ClientSelector = UPPER('Private')  then 'HIGHRISK'
  ELSE 'UNDEFINED'
END AS TRADECATEGORIES
FROM TRADE
```
