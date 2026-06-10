create database sales_management;

create table product(
productid int primary key,
productname varchar (50),
price  decimal(10,2)
);

insert into product
values(1,'laptop', 50000),
(2,'smartphone', 25000),
(3,'Tablet',30000),
(4,'smartwatch',10000);

select * from product;

create table sales(
saleid int primary key,
productID int,
quantity int,
saledate date,
foreign key (productID)
references product (productid)
);

insert into sales
values
(101,1,3,'2024-03-01'),
(102,2,5,'2024-03-02'),
(103,1,2,'2024-03-05'),
(104,3,1,'2024-03-06'),
(105,2,3,'2024-03-07');

select * from sales;

SELECT  P.ProductName,SUM(P.Price * S.Quantity)
TotalRevenue
FROM Product P
INNER JOIN Sales S
ON P.ProductID = S.ProductID
GROUP BY P.ProductName;


SELECT 
P.ProductName,
SUM(S.Quantity)  TotalQuantitySold
FROM Product P
INNER JOIN Sales S
ON P.ProductID = S.ProductID
GROUP BY P.ProductName
ORDER BY SUM(S.Quantity) DESC;

SELECT P.ProductName
FROM Product P
LEFT JOIN Sales S
ON P.ProductID = S.ProductID
WHERE S.ProductID IS NULL;



SELECT 
SUM(P.Price * S.Quantity)
TotalRevenueMarch2024
FROM Product P
INNER JOIN Sales S
ON P.ProductID = S.ProductID
WHERE MONTH(S.SaleDate) = 3
AND YEAR(S.SaleDate) = 2024;