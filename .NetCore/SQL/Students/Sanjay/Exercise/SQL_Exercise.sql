CREATE DATABASE tour_booking_information;
USE tour_booking_information;

CREATE TABLE Agency(
AgencyID int PRIMARY KEY,
Name VARCHAR(50),
Address VARCHAR(100),
ContactNumber VARCHAR(20) )

INSERT INTO Agency VALUES(1,'Abc Agency','AbcAgency',9873526712),
(2,'Def Agency', 'DefAgency',1234567890)

SELECT * FROM Agency



CREATE TABLE Customer(
CustomerID int PRIMARY KEY, 
Name VARCHAR(50),
Email VARCHAR(50), 
Phone VARCHAR(20) )

INSERT INTO Customer VALUES(101,'Rahul','rahul@gmail.com',9738789374),
(102,'Arya','arya@gmail.com',9876542345),
(103,'Alfin','alfin@gmail.com',7827384826)

SELECT * FROM Customer


CREATE TABLE Tour(
TourID int PRIMARY KEY,
AgencyID int 
FOREIGN KEY (AgencyID) REFERENCES Agency(AgencyID),
Name VARCHAR(50),
Destination VARCHAR(50),
Price decimal(10,2))


INSERT INTO Tour VALUES(13214,1,'Hill Climbing', 'Himagel Pradesh', 50000),
(14262,2, 'Trecking', 'Pathanamthitta', 30000),
(12325,1, 'All India Trip', 'India',100000)

SELECT * FROM Tour


CREATE TABLE Booking(
BookingID int PRIMARY KEY,
CustomerID int,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
TourID int,
FOREIGN KEY (TourID) REFERENCES Tour(TourID),
BookingDate SMALLDATETIME,
NumberOfSeats int)

INSERT INTO Booking VALUES(8765432,101,14262,2026-05-23,5),
(2363264,103,13214,2025-06-12,10)

SELECT * FROM Booking


CREATE TABLE Customer_Registration(
RegistrationID int PRIMARY KEY,
CustomerID int,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
Tour int,
FOREIGN KEY (Tour) REFERENCES Tour(TourID),
RegistrationDate SMALLDATETIME )


INSERT INTO Customer_Registration VALUES(0001,101,14262,2026-06-24),
(0002,103,13214,2026-05-06)

SELECT * FROM Customer_Registration



SELECT
C.CustomerID,
C.Name AS CustomerName,
T.Name AS TourName,
T.Destination,
B.BookingDate
FROM Customer C
JOIN Booking B
ON C.CustomerID = B.CustomerID
JOIN Tour T
ON B.TourID = T.TourID;



UPDATE Customer SET Phone = 9876543210 where Name = 'Rahul'


UPDATE Tour SET Price = 25000 WHERE Name = 'Hill Climbing'


SELECT
C.Name AS Customer,
T.Name AS Tour,
A.Name AS Agency
FROM Booking B
JOIN Customer C
ON B.CustomerID = C.CustomerID
JOIN Tour T
ON B.TourID = T.TourID
JOIN Agency A
ON T.AgencyID = A.AgencyID;

SELECT T.*
FROM Tour T
JOIN Agency A
ON T.AgencyID = A.AgencyID
WHERE A.Name = 'Abc Agency';


SELECT *
FROM Booking B
JOIN Customer C
ON B.CustomerID = C.CustomerID
WHERE C.Name = 'Alfin';


SELECT
A.Name AS Agency,
COUNT(DISTINCT C.CustomerID) AS Customers
FROM Agency A
JOIN Tour T
ON A.AgencyID = T.AgencyID
JOIN Booking B
ON T.TourID = B.TourID
JOIN Customer C
ON B.CustomerID = C.CustomerID
GROUP BY A.Name;


SELECT *
FROM Tour
ORDER BY Price DESC;


SELECT B.*
FROM Booking B
JOIN Tour T
ON B.TourID = T.TourID
WHERE T.Destination = 'Kerala';


SELECT
T.Name,
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
COUNT(CR.Tour) AS TotalTours
FROM Customer C
JOIN Customer_Registration CR
ON C.CustomerID = CR.CustomerID
GROUP BY C.CustomerID, C.Name
HAVING COUNT(CR.Tour) > 1;


SELECT
T.Name,
COUNT(CR.CustomerID) AS TotalCustomers
FROM Tour T
LEFT JOIN Customer_Registration CR
ON T.TourID = CR.Tour
GROUP BY T.Name;


SELECT
A.Name AS Agency,
SUM(T.Price) AS TotalRevenue
FROM Agency A
JOIN Tour T
ON A.AgencyID = T.AgencyID
JOIN Customer_Registration CR
ON T.TourID = CR.Tour
GROUP BY A.Name;


SELECT DISTINCT
C.CustomerID,
C.Name
FROM Customer C
JOIN Booking B
ON C.CustomerID = B.CustomerID
WHERE MONTH(B.BookingDate) = 7
AND YEAR(B.BookingDate) = 1905;

SELECT *
FROM Tour
WHERE Price > 20000;


SELECT TOP 3
T.Destination,
COUNT(*) AS Registrations
FROM Customer_Registration CR
JOIN Tour T
ON CR.Tour = T.TourID
GROUP BY T.Destination
ORDER BY Registrations DESC;


SELECT
C.CustomerID,
C.Name
FROM Customer C
LEFT JOIN Customer_Registration CR
ON C.CustomerID = CR.CustomerID
WHERE CR.CustomerID IS NULL;