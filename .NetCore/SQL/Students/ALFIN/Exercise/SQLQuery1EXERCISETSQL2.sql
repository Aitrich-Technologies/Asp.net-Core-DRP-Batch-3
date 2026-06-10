create database Tours_Bookings_Systems;

go
USE Tours_Bookings_Systems;
go


CREATE TABLE Agency(
AgencyID int PRIMARY KEY,
Name VARCHAR(50),
Address VARCHAR(100),
ContactNumber VARCHAR(20) )

go

CREATE proc Insert_Agency
 @AgencyID INT,
 @Name VARCHAR(50),
 @Address VARCHAR(100),
 @ContactNumber VARCHAR(20)
AS
BEGIN
INSERT INTO Agency
VALUES (@AgencyID, @Name, @Address, @ContactNumber)
END
GO

EXEC Insert_Agency 2,'Sunday Travels','Kochi','9876543212';

go
CREATE PROCEDURE Update_Agency
 (@AgencyID INT,
 @Name VARCHAR(50),
 @Address VARCHAR(100),
 @ContactNumber VARCHAR(20))
AS
BEGIN
UPDATE Agency
SET Name = @Name,Address = @Address, ContactNumber = @ContactNumber WHERE AgencyID = @AgencyID
END
GO

EXEC Update_Agency 1,'New Sunday Travels','Ernakulam','9999999999';

go
CREATE proc Delete_Agency
(@AgencyID INT)
AS
BEGIN
DELETE FROM Agency WHERE AgencyID = @AgencyID
END
GO

EXEC Delete_Agency 2;

select * from Agency;

CREATE TABLE Customer(
CustomerID int PRIMARY KEY, 
Name VARCHAR(50),
Email VARCHAR(50), 
Phone VARCHAR(20) )

select * from Agency;

go

CREATE PROCEDURE Insert_Customer
 (@CustomerID as INT,
 @Name as  VARCHAR(50),
 @Email as VARCHAR(100),
 @Phone as VARCHAR(20))
AS
BEGIN
INSERT INTO Customer(CustomerID,Name,Email,Phone)
VALUES (@CustomerID, @Name, @Email, @Phone)
END
GO

EXEC Insert_Customer 3,'Alfin','alfin@gmail.com','9876543210';

go
CREATE PROCEDURE Update_Customer
@CustomerID INT,
@Name VARCHAR(50),
@Email VARCHAR(100),
@Phone VARCHAR(20)
AS
BEGIN
UPDATE Customer SET Name = @Name,Email = @Email, Phone = @Phone WHERE CustomerID = @CustomerID
END
GO

EXEC Update_Customer 1,'sanjay','sanjay@gmail.com','9998887776';

go
CREATE PROC Delete_Customer
(@CustomerID INT)
AS
BEGIN
DELETE FROM Customer WHERE CustomerID = @CustomerID
END
GO

EXEC Delete_Customer 1;
select * from Customer;

CREATE TABLE Tour(
TourID int PRIMARY KEY,
AgencyID int 
FOREIGN KEY (AgencyID) REFERENCES Agency(AgencyID),
Name VARCHAR(50),
Destination VARCHAR(50),
Price decimal(10,2))


go
CREATE PROC Insert_Tour
(@TourID INT,
 @AgencyID INT,
 @Name VARCHAR(50),
 @Destination VARCHAR(50),
 @Price DECIMAL(10,2)
 )
AS
BEGIN
INSERT INTO Tour (TourID,AgencyID,Name,Destination,Price)
VALUES (@TourID,@AgencyID, @Name, @Destination, @Price)
END
GO
drop proc Insert_Tour;

EXEC Insert_Tour 3,1,'Kerala Trip','Munnar',15000;

select * from Tour;
go
CREATE PROCEDURE Update_Tour
 @TourID INT,
 @Name VARCHAR(50),
 @Destination VARCHAR(50),
 @Price DECIMAL(10,2),
 @AgencyID INT
AS
BEGIN
UPDATE Tour SET Name = @Name,Destination = @Destination,Price = @Price,AgencyID = @AgencyID  WHERE TourID = @TourID
END
GO

EXEC Update_Tour 1,'Premium Kerala Trip','Wayanad',18000,1;


go
CREATE PROCEDURE Delete_Tour
(@TourID INT)
AS
BEGIN
DELETE FROM Tour WHERE TourID = @TourID
END
GO

EXEC Delete_Tour 1;

CREATE TABLE Booking(
BookingID int PRIMARY KEY,
CustomerID int,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
TourID int,
FOREIGN KEY (TourID) REFERENCES Tour(TourID),
BookingDate SMALLDATETIME,
NumberOfSeats int)

go
CREATE PROC Insert_Booking
 (@BookingID as INT,
 @CustomerID as INT,
 @TourID as INT,
 @BookingDate as SMALLDATETIME,
 @NumberOfSeats as int)
AS
BEGIN
INSERT INTO Booking (BookingID,CustomerID,TourID,BookingDate,NumberOfSeats) 
VALUES (@BookingID, @CustomerID, @TourID, @BookingDate, @NumberOfSeats)
END
GO

EXEC Insert_Booking 1,3,3,'2026-06-02',5;

GO
CREATE PROC Update_Booking(
@BookingID INT,
@CustomerID INT,
@TourID INT,
@BookingDate as smalldatetime,
@numberofseats as int)
AS
BEGIN
UPDATE Booking
SET BookingDate = @BookingDate,NumberOfSeats = @numberofseats WHERE BookingID = @BookingID
END
GO

EXEC Update_Booking 1,1,1,'2026-07-10',10;

GO
CREATE PROC Delete_Booking
(@BookingID INT)
AS
BEGIN
DELETE FROM Booking WHERE BookingID = @BookingID
END
GO

EXEC Delete_Booking 1;
select * from Booking;

CREATE TABLE Customer_Registration(
RegistrationID int PRIMARY KEY,
CustomerID int,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
Tour int,
FOREIGN KEY (Tour) REFERENCES Tour(TourID),
RegistrationDate SMALLDATETIME )

GO
CREATE PROC GetTourByDestination
( @Destination VARCHAR(50))
AS
BEGIN
SELECT *
FROM Tour WHERE Destination = @Destination
END
GO

EXEC GetTourByDestination 'Munnar';


GO
CREATE PROC GetAgencyByTourName
( @TourName VARCHAR(50))
AS
BEGIN
SELECT A.AgencyID,
 A.Name AS AgencyName,
 A.Address,
 A.ContactNumber,
 T.Name AS TourName
 FROM Agency A
 INNER JOIN Tour T
 ON A.AgencyID = T.AgencyID
 WHERE T.Name = @TourName
END
GO

EXEC GetAgencyByTourName 'Kerala Trip';

GO
CREATE PROCEDURE GetBookingDetails
AS
BEGIN
SELECT
B.BookingID,
C.CustomerID,
C.Name AS CustomerName,
C.Email,
T.TourID,
T.Name AS TourName,
T.Destination,
T.Price,
A.AgencyID,
A.Name AS AgencyName,
A.ContactNumber,
B.BookingDate
FROM Booking B
INNER JOIN Customer C
ON B.CustomerID = C.CustomerID
INNER JOIN Tour T
ON B.TourID = T.TourID
INNER JOIN Agency A
ON T.AgencyID = A.AgencyID
END
GO

EXEC GetBookingDetails;