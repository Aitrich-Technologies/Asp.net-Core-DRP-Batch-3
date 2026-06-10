create database Tour_Booking_Information;

go
use Tour_Booking_Information;
go

create login TourUser with password = 'Tour@123';
CREATE USER TourUser FOR LOGIN TourUser;
GO

CREATE TABLE Agency(
    AgencyID INT PRIMARY KEY,
    Name VARCHAR(50),
    Address VARCHAR(100),
    ContactNumber VARCHAR(20)
);

CREATE TABLE Customer(
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(50),
    Email VARCHAR(50),
    Phone VARCHAR(20)
);

CREATE TABLE Tour(
    TourID INT PRIMARY KEY,
    AgencyID INT,
    Name VARCHAR(50),
    Destination VARCHAR(50),
    Price DECIMAL(10,2),
    FOREIGN KEY (AgencyID)
    REFERENCES Agency(AgencyID)
);

CREATE TABLE Booking(
    BookingID INT PRIMARY KEY,
    CustomerID INT,
    TourID INT,
    BookingDate SMALLDATETIME,
    NumberOfSeats INT,
    FOREIGN KEY (CustomerID)
    REFERENCES Customer(CustomerID),
    FOREIGN KEY (TourID)
    REFERENCES Tour(TourID)
);

CREATE TABLE Customer_Registration(
    RegistrationID INT PRIMARY KEY,
    CustomerID INT,
    TourID INT,
    RegistrationDate SMALLDATETIME,
    FOREIGN KEY (CustomerID)
    REFERENCES Customer(CustomerID),
    FOREIGN KEY (TourID)
    REFERENCES Tour(TourID)
);

INSERT INTO Agency
VALUES
(1,'Holiday Travels','Kochi','9878444455'),
(2,'Dream Tours','Ernakulam','9876543212'),
(3,'Sky Travels','Thrissur','9872354323');

INSERT INTO Customer
VALUES
(1,'Rahul Mehta','rahul@gmail.com','9999999999'),
(2,'Anita Sharma','anita@gmail.com','8888888888'),
(3,'Arjun','arjun@gmail.com','7777777777');

INSERT INTO Tour
VALUES
(1,1,'Goa Beach Holiday','Goa',22000.00),
(2,2,'Kerala Backwater Trip','Kerala',18000.00),
(3,1,'Manali Adventure','Manali',25000.00),
(4,3,'Kashmir Tour','Kashmir',30000.00);

INSERT INTO Booking
VALUES
(1,1,1,'2025-01-10',2),
(2,2,2,'2025-01-15',3),
(3,2,1,'2025-01-18',1),
(4,3,3,'2025-02-20',2);

INSERT INTO Customer_Registration
VALUES
(1,1,1,'2025-01-05'),
(2,2,2,'2025-01-06'),
(3,2,1,'2025-01-07'),
(4,3,3,'2025-02-01'),
(5,1,3,'2025-02-05');

go
CREATE VIEW CustomerBookedTours
AS
SELECT
    C.CustomerID,
    C.Name AS CustomerName,
    T.Name AS TourName,
    T.Destination,
    B.BookingDate
FROM Customer C
INNER JOIN Booking B
ON C.CustomerID = B.CustomerID
INNER JOIN Tour T
ON B.TourID = T.TourID;
GO

UPDATE Customer
SET Phone = '9876543210'
WHERE Name = 'Rahul Mehta';

UPDATE Tour
SET Price = 25000.00
WHERE Name = 'Goa Beach Holiday';

SELECT
    C.Name AS CustomerName,
    T.Name AS TourName,
    A.Name AS AgencyName
FROM Booking B
INNER JOIN Customer C
ON B.CustomerID = C.CustomerID
INNER JOIN Tour T
ON B.TourID = T.TourID
INNER JOIN Agency A
ON T.AgencyID = A.AgencyID;

SELECT T.*
FROM Tour T
INNER JOIN Agency A
ON T.AgencyID = A.AgencyID
WHERE A.Name = 'Holiday Travels';

SELECT B.*
FROM Booking B
INNER JOIN Customer C
ON B.CustomerID = C.CustomerID
WHERE C.Name = 'Anita Sharma';

SELECT
    A.Name AS AgencyName,
    C.Name AS CustomerName
FROM Agency A
INNER JOIN Tour T
ON A.AgencyID = T.AgencyID
INNER JOIN Booking B
ON T.TourID = B.TourID
INNER JOIN Customer C
ON B.CustomerID = C.CustomerID
ORDER BY A.Name;

SELECT *FROM Tour ORDER BY Price DESC;

SELECT B.*
FROM Booking B
INNER JOIN Tour T
ON B.TourID = T.TourID
WHERE T.Destination = 'Kerala';

SELECT
    T.Name AS TourName,
    COUNT(B.BookingID) AS TotalBookings
FROM Tour T
LEFT JOIN Booking B
ON T.TourID = B.TourID
GROUP BY T.Name;

SELECT
    Destination,
    COUNT(*) AS TotalTours
FROM Tour
GROUP BY Destination;


SELECT
    C.CustomerID,
    C.Name,
    COUNT(CR.TourID) AS TotalTours
FROM Customer C
INNER JOIN Customer_Registration CR
ON C.CustomerID = CR.CustomerID
GROUP BY C.CustomerID, C.Name
HAVING COUNT(CR.TourID) > 1;

SELECT
    C.CustomerID,
    C.Name,
    COUNT(CR.TourID) AS TotalTours
FROM Customer C
INNER JOIN Customer_Registration CR
ON C.CustomerID = CR.CustomerID
GROUP BY C.CustomerID, C.Name
HAVING COUNT(CR.TourID) > 1;

SELECT
    A.Name AS AgencyName,
    SUM(T.Price) AS TotalRevenue
FROM Agency A
INNER JOIN Tour T
ON A.AgencyID = T.AgencyID
INNER JOIN Customer_Registration CR
ON T.TourID = CR.TourID
GROUP BY A.Name;

SELECT DISTINCT
    C.Name
FROM Customer C
INNER JOIN Booking B
ON C.CustomerID = B.CustomerID
WHERE MONTH(B.BookingDate) = 1
AND YEAR(B.BookingDate) = 2025;

SELECT *FROM Tour WHERE Price > 20000;

SELECT TOP 3
    T.Destination,
    COUNT(CR.CustomerID) AS TotalRegistrations
FROM Tour T
INNER JOIN Customer_Registration CR
ON T.TourID = CR.TourID
GROUP BY T.Destination
ORDER BY COUNT(CR.CustomerID) DESC;

SELECT * FROM Customer
WHERE CustomerID NOT IN
(
    SELECT CustomerID
    FROM Customer_Registration
);






