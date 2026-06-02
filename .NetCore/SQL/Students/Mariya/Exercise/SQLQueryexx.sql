CREATE LOGIN TourUser WITH PASSWORD = 'Tour@123';

USE master;
GO

CREATE DATABASE tour_booking_information;
GO

USE tour_booking_information;
GO

CREATE USER TourUser FOR LOGIN TourUser;

ALTER ROLE db_owner ADD MEMBER TourUser;
GO



CREATE TABLE Agency
(
    AgencyID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Address VARCHAR(100),
    ContactNumber VARCHAR(20)
);

CREATE TABLE Customer
(
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Email VARCHAR(50) UNIQUE,
    Phone VARCHAR(20)
);

CREATE TABLE Tour
(
    TourID INT PRIMARY KEY,
    AgencyID INT NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Destination VARCHAR(50),
    Price DECIMAL(10,2),

    CONSTRAINT FK_Tour_Agency
    FOREIGN KEY (AgencyID)
    REFERENCES Agency(AgencyID)
);

CREATE TABLE Booking
(
    BookingID INT PRIMARY KEY,
    CustomerID INT NOT NULL,
    TourID INT NOT NULL,
    BookingDate SMALLDATETIME,
    NumberOfSeats INT CHECK (NumberOfSeats > 0),

    CONSTRAINT FK_Booking_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customer(CustomerID),

    CONSTRAINT FK_Booking_Tour
    FOREIGN KEY (TourID)
    REFERENCES Tour(TourID)
);

CREATE TABLE Customer_Registration
(
    RegistrationID INT PRIMARY KEY,
    CustomerID INT NOT NULL,
    Tour INT NOT NULL,
    RegistrationDate SMALLDATETIME,

    CONSTRAINT FK_CR_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customer(CustomerID),

    CONSTRAINT FK_CR_Tour
    FOREIGN KEY (Tour)
    REFERENCES Tour(TourID)
);




INSERT INTO Agency VALUES
(1,'Holiday Travels','Mumbai','9876541111'),
(2,'Dream Vacations','Delhi','9876542222'),
(3,'Global Tours','Bangalore','9876543333');

INSERT INTO Customer VALUES
(101,'Rahul Mehta','rahul@gmail.com','9876500001'),
(102,'Anita Sharma','anita@gmail.com','9876500002'),
(103,'Rohan Patel','rohan@gmail.com','9876500003'),
(104,'Priya Singh','priya@gmail.com','9876500004'),
(105,'Amit Verma','amit@gmail.com','9876500005');

INSERT INTO Tour VALUES
(201,1,'Goa Beach Holiday','Goa',22000.00),
(202,1,'Kerala Backwaters','Kerala',18000.00),
(203,2,'Himalayan Adventure','Manali',30000.00),
(204,3,'Rajasthan Heritage Tour','Jaipur',25000.00);

INSERT INTO Booking VALUES
(301,101,201,'2025-01-10',2),
(302,102,202,'2025-01-15',1),
(303,103,203,'2025-02-05',3),
(304,102,201,'2025-01-20',2),
(305,104,204,'2025-03-12',1);

INSERT INTO Customer_Registration VALUES
(401,101,201,'2025-01-05'),
(402,102,202,'2025-01-08'),
(403,103,203,'2025-02-01'),
(404,102,201,'2025-01-18'),
(405,104,204,'2025-03-01'),
(406,101,202,'2025-01-12');



CREATE VIEW vw_CustomerBookedTours
AS
SELECT
    C.CustomerID,
    C.Name AS CustomerName,
    T.TourID,
    T.Name AS TourName,
    T.Destination,
    B.BookingDate,
    B.NumberOfSeats
FROM Customer C
JOIN Booking B
    ON C.CustomerID = B.CustomerID
JOIN Tour T
    ON B.TourID = T.TourID;

SELECT * FROM vw_CustomerBookedTours;



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
FROM Customer C
JOIN Booking B
    ON C.CustomerID = B.CustomerID
JOIN Tour T
    ON B.TourID = T.TourID
JOIN Agency A
    ON T.AgencyID = A.AgencyID;




SELECT T.*
FROM Tour T
JOIN Agency A
    ON T.AgencyID = A.AgencyID
WHERE A.Name = 'Holiday Travels';




SELECT B.*
FROM Booking B
JOIN Customer C
    ON B.CustomerID = C.CustomerID
WHERE C.Name = 'Anita Sharma';




SELECT
    A.Name AS AgencyName,
    C.Name AS CustomerName
FROM Agency A
JOIN Tour T
    ON A.AgencyID = T.AgencyID
JOIN Booking B
    ON T.TourID = B.TourID
JOIN Customer C
    ON B.CustomerID = C.CustomerID
ORDER BY A.Name;




SELECT *
FROM Tour
ORDER BY Price DESC;



SELECT
    B.BookingID,
    C.Name AS CustomerName,
    T.Name AS TourName,
    T.Destination,
    B.BookingDate
FROM Booking B
JOIN Customer C
    ON B.CustomerID = C.CustomerID
JOIN Tour T
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
    STRING_AGG(Name, ', ') AS Tours
FROM Tour
GROUP BY Destination;


SELECT
    C.CustomerID,
    C.Name,
    COUNT(CR.Tour) AS NumberOfTours
FROM Customer C
JOIN Customer_Registration CR
    ON C.CustomerID = CR.CustomerID
GROUP BY C.CustomerID, C.Name
HAVING COUNT(CR.Tour) > 1;




SELECT
    T.TourID,
    T.Name AS TourName,
    COUNT(CR.CustomerID) AS TotalCustomers
FROM Tour T
LEFT JOIN Customer_Registration CR
    ON T.TourID = CR.Tour
GROUP BY T.TourID, T.Name;




SELECT
    A.AgencyID,
    A.Name AS AgencyName,
    SUM(T.Price) AS TotalRevenue
FROM Agency A
JOIN Tour T
    ON A.AgencyID = T.AgencyID
JOIN Customer_Registration CR
    ON T.TourID = CR.Tour
GROUP BY A.AgencyID, A.Name;




SELECT DISTINCT
    C.CustomerID,
    C.Name
FROM Customer C
JOIN Booking B
    ON C.CustomerID = B.CustomerID
WHERE MONTH(B.BookingDate) = 1
AND YEAR(B.BookingDate) = 2025;




SELECT *
FROM Tour
WHERE Price > 20000;




SELECT TOP 3
    T.Destination,
    COUNT(CR.RegistrationID) AS TotalRegistrations
FROM Tour T
JOIN Customer_Registration CR
    ON T.TourID = CR.Tour
GROUP BY T.Destination
ORDER BY TotalRegistrations DESC;




SELECT
    C.CustomerID,
    C.Name
FROM Customer C
LEFT JOIN Customer_Registration CR
    ON C.CustomerID = CR.CustomerID
WHERE CR.CustomerID IS NULL;