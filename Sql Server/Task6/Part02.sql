use AdventureWorks2012

/*
1. Display the SalesOrderID, ShipDate of the SalesOrderHearder
table (Sales schema) to designate SalesOrders that occurred
within the period ‘7/28/2002’ and ‘7/29/2014’*/select  s.SalesOrderID,s.ShipDatefrom sales.SalesOrderHeader swhere s.OrderDate between '7/28/2002' and '7/29/2014'/*2. Display only Products(Production schema) with a StandardCost
below $110.00 (show ProductID, Name only)
*/
select p.ProductID, p.Name
from Production.Product p
WHERE p.StandardCost < 110.00;

--3. Display ProductID, Name if its weight is unknown
select p.ProductID,p.Name
from Production.Product p
WHERE p.Weight is null;

--4. Display all Products with a Silver, Black, or Red Color
select p.*
from Production.Product p
WHERE p.Color='Silver' or p.Color='Black' or p.Color='Red';


--5. Display any Product with a Name starting with the letter B
select p.*
from Production.Product p
WHERE p.Name like 'B%';

/*
6. Run the following Query

UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

Then write a query that displays any Product description with
underscore value in its description.
*/
UPDATE Production.ProductDescription
SET Description = 'Chromoly steel_High of defects'
WHERE ProductDescriptionID = 3

select p.*
from Production.ProductDescription p
where p.Description like '%[_]%'


--7. Display the Employees HireDate (note no repeated values are allowed)
select distinct hiredate 
from employee -- not correct but i can't find employee in any table

/*
8. Display the Product Name and its ListPrice within the values of
100 and 120 the list should have the following format "The [product
name] is only! [List price]" (the list will be sorted according to its
ListPrice value)*/select 'The ' + p.Name + ' is only! ' + cast(p.ListPrice AS VARCHAR) AS ProductInfo
from Production.Product p
where p.ListPrice Between 100 And 120
