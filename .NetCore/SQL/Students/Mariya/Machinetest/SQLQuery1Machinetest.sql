Create database sales_management
 use 
 sales_management

 CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(50),
    Price DECIMAL(10,2)
);

INSERT INTO Product VALUES
(1, 'Laptop', 50000),
(2, 'Smartphone', 25000),
(3, 'Tablet', 30000),
(4, 'Smartwatch', 10000);



CREATE TABLE Sales (
    SaleID INT PRIMARY KEY,
    ProductID INT,
    Quantity INT,
    SaleDate DATE,
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);
INSERT INTO Sales VALUES
(101, 1, 3, '2024-03-01'),
(102, 2, 5, '2024-03-02'),
(103, 1, 2, '2024-03-05'),
(104, 3, 1, '2024-03-06'),
(105, 2, 3, '2024-03-07');

SELECT 
    p.ProductID,
    p.ProductName,
    SUM(p.Price * s.Quantity) AS TotalRevenue
FROM Product p
JOIN Sales s
    ON p.ProductID = s.ProductID
GROUP BY p.ProductID, p.ProductName;


SELECT 
    p.ProductID,
    p.ProductName,
    SUM(s.Quantity) AS TotalQuantitySold
FROM Product p
JOIN Sales s ON p.ProductID = s.ProductID
GROUP BY p.ProductID, p.ProductName
ORDER BY TotalQuantitySold DESC


SELECT 
    p.ProductName
FROM Product p
LEFT JOIN Sales s 
ON p.ProductID = s.ProductID
WHERE s.ProductID IS NULL;
   

SELECT 
    SUM(s.Quantity * p.Price) AS TotalRevenue
FROM Sales s
JOIN Product p 
    ON s.ProductID = p.ProductID
WHERE s.SaleDate BETWEEN '2024-03-01' AND '2024-03-31';





