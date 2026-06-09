create database retailstore;

create table Customers(CustomerID int PRIMARY KEY, Name varchar(30), City varchar(50));

drop table Orders;

create table Orders(
OrderID int PRIMARY KEY,
CustomerID int,
Product varchar(50),
Amount DECIMAL
);

INSERT INTO Customers values
(1,'John', 'NewYork'),
(2,'Alice','Los Angeles'),
(3,'Bob','Chicago');

INSERT INTO Orders values
(101,1, 'Laptop',1200),
(102,1,'Smartphone',800),
(103,2,'Headphones',150),
(104,4,'Tablet',300);

INSERT INTO Orders values

SELECT c.Name, o.Product, o.Amount
FROM Customers c
INNER JOIN Orders o
ON c.CustomerID = o.CustomerID;

SELECT c.Name, o.Product, o.Amount
FROM Customers c
LEFT JOIN Orders o
ON c.CustomerID = o.CustomerID;

SELECT c.Name, o.Product, o.Amount
FROM Customers c
RIGHT JOIN Orders o
ON c.CustomerID = o.CustomerID;

SELECT c.Name, o.Product, o.Amount
FROM Customers c
FULL OUTER JOIN Orders o
ON c.CustomerID = o.CustomerID;


SELECT c.Name,
COUNT(o.OrderID) AS TotalOrders
FROM Customers c
JOIN Orders o
ON c.CustomerID = o.CustomerID
GROUP BY c.Name
HAVING COUNT(o.OrderID) >= 1;

