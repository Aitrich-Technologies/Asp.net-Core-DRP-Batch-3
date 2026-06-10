create database customerdb;

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(50),
    City VARCHAR(50)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    Product VARCHAR(50),
    Amount INT
);

INSERT INTO Customers
VALUES
(1,'John','New York'),
(2,'Alice','Los Angeles'),
(3,'Bob','Chicago');

INSERT INTO Orders
VALUES
(101,1,'Laptop',1200),
(102,1,'Smartphone',800),
(103,2,'Headphones',150),
(104,4,'Tablet',300);

SELECT Customers.Name, Orders.Product, Orders.Amount FROM Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
SELECT Customers.Name, Orders.Product, Orders.Amount FROM Customers LEFT  JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
SELECT Customers.Name, Orders.Product, Orders.Amount FROM Customers RIGHT JOIN Orders ON Customers.CustomerID = Orders.CustomerID;
SELECT * FROM Customers WHERE CustomerID NOT IN ( SELECT CustomerID FROM Orders);



