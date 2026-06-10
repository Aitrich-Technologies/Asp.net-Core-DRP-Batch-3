create database customerscheme;

CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(50)
);

CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Price DECIMAL(10,2)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE,
    ProductID INT,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

INSERT INTO Customers
VALUES
(1,'John Doe'),
(2,'Jane Smith'),
(3,'Michael Brown'),
(4,'Emily Davis');

INSERT INTO Products
VALUES
(1,'Laptop',1000),
(2,'Smartphone',500),
(3,'Tablet',300),
(4,'Headphones',100);

INSERT INTO Orders
VALUES
(101,1,'2023-01-10',1),
(102,3,'2023-02-15',2),
(103,4,'2023-03-05',3),
(104,1,'2023-04-12',2);

SELECT CustomerID,COUNT(OrderID) AS OrderCount FROM Orders GROUP BY CustomerID;
SELECT SUM(Products.Price) AS TotalRevenue FROM Orders INNER JOIN Products ON Orders.ProductID = Products.ProductID;
SELECT Avg(Products.Price) AS Averageprice FROM Orders INNER JOIN Products ON Orders.ProductID = Products.ProductID;
SELECT MIN(Price) AS LowestPrice FROM Products;
SELECT Max(Price) AS HighestPrice FROM Products;
SELECT COUNT(DISTINCT CustomerID) AS UniqueCustomers FROM Orders;
SELECT CustomerID, AVG(ProductID) AS AverageSpent FROM Orders GROUP BY CustomerID;
SELECT Products.ProductName,SUM(Products.Price) AS TotalRevenue FROM Orders INNER JOIN Products ON Orders.ProductID = Products.ProductID
GROUP BY Products.ProductName;
SELECT ProductID,COUNT(OrderID) AS OrderCount FROM Orders GROUP BY ProductID HAVING COUNT(OrderID) > 1;
SELECT Customers.CustomerName, SUM(Products.Price) AS TotalSpent,AVG(Products.Price) AS AverageOrderValue FROM Orders 
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID INNER JOIN Products ON Orders.ProductID = Products.ProductID GROUP BY Customers.CustomerName;




