CREATE DATABASE Tour_Booking_System;

USE Tour_Booking_System;

CREATE TABLE Agency(
AgencyID int PRIMARY KEY,
Name VARCHAR(50),
Address VARCHAR(100),
ContactNumber VARCHAR(20) )

SELECT * FROM Agency

GO
CREATE PROC Agency_insert
(@agencyid AS int, @name AS VARCHAR(50), @address AS VARCHAR(100), @contactnumber AS VARCHAR(20))
AS
BEGIN
INSERT INTO Agency(AgencyID, Name, Address, ContactNumber)
VALUES (@agencyid, @name, @address, @contactnumber)
END
GO

EXEC Agency_insert 2,'def Agency','DefAgency',9873526712;



GO
CREATE proc Agency_Update
(
@id as int,
@name as varchar(50),
@address as varchar(100),
@contactnumber as varchar(20)
)
as
begin
update Agency set name = @name,address = @address where AgencyID = @id
end
GO
EXEC Agency_Update 1,' Travel Partner ',' travelPartner',987654321;


GO
CREATE proc Agency_Delete
(
@v_id as int
)
as
begin
delete from Agency  where AgencyID = @v_id
end
GO
EXEC Agency_Delete 2;




CREATE TABLE Customer(
CustomerID int PRIMARY KEY, 
Name VARCHAR(50),
Email VARCHAR(50), 
Phone VARCHAR(20) )

INSERT INTO Customer VALUES(101,'Rahul','rahul@gmail.com',9738789374),
(102,'Arya','arya@gmail.com',9876542345),
(103,'Alfin','alfin@gmail.com',7827384826)

SELECT * FROM Customer
DROP TABLE Customer


GO
CREATE PROC Customer_insert
(@customerid AS int, @name AS VARCHAR(50), @email VARCHAR(100), @phone AS VARCHAR(20))
AS
BEGIN
INSERT INTO Customer(CustomerID, Name, Email, Phone)
VALUES (@customerid, @name, @email, @phone)
END
GO


EXEC Customer_insert 103,'Alfin','alfin@gmail.com',7827384826;


GO
CREATE proc Customer_Update
(
@id as int,
@name as varchar(50),
@email as varchar(100),
@phone as varchar(20)
)
as
begin
update Customer set Name = @name where CustomerID = @id
end
GO
EXEC Customer_Update 101,'Mariya','rahul@gmail.com',9738789374;


GO
CREATE proc Customer_Delete
(
@v_id as int
)
as
begin
delete from Customer  where CustomerID = @v_id
end
GO
EXEC Customer_Delete 102;



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
DROP TABLE Tour


GO
CREATE PROC Tour_insert
(@tourid as int, @agencyid AS int, @name AS VARCHAR(50), @destination AS VARCHAR(50), @price AS VARCHAR(20))
AS
BEGIN
INSERT INTO Tour(TourID, AgencyID, Name, Destination, Price)
VALUES (@tourid, @agencyid, @name, @destination, @price)
END
GO

EXEC Tour_insert 14262,2, 'Trecking', 'Pathanamthitta', 30000;



GO
CREATE proc Tour_Update
(
@tid as int,
@agencyid as int,
@tname as varchar(50),
@destination as varchar(100),
@price as varchar(20)
)
as
begin
update Tour set Name = @tname,Destination = @destination where TourID = @tid
end
GO
EXEC Tour_Update 14262,1,' Racing',' Goa','5000';


GO
CREATE proc Tour_Delete
(
@v_id as int
)
as
begin
delete from Tour  where AgencyID = @v_id
end
GO
EXEC Tour_Delete 2;




CREATE TABLE Booking(
BookingID int PRIMARY KEY,
CustomerID int,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
TourID int,
FOREIGN KEY (TourID) REFERENCES Tour(TourID),
BookingDate SMALLDATETIME,
NumberOfSeats int)


GO
CREATE PROC Booking_insert
(@bookingid as int, @customerid AS int, @tourid AS int, @bookingdate AS smalldatetime, @numberofseats AS int)
AS
BEGIN
INSERT INTO Booking(BookingID, CustomerID, TourID, BookingDate, NumberOfSeats)
VALUES (@bookingid, @customerid, @tourid, @bookingdate, @numberofseats
)
END
GO

EXEC Booking_insert 187664,103,14262,'2026-05-24', 10;


GO
CREATE proc Booking_Update
(@bookingid as int,
@customerid AS int,
@tourid AS int,
@bookingdate AS smalldatetime,
@numberofseats AS int)
as
begin
update Booking set BookingDate = @bookingdate,NumberOfSeats = @numberofseats where BookingID = @bookingid
end
GO
EXEC Booking_Update 187664,103,14262,'2026-05-27', 15;


GO
CREATE proc Booking_Delete
(
@bookingid as int
)
as
begin
delete from Booking  where BookingID = @bookingid
end
GO
EXEC Booking_Delete 187664;



SELECT * FROM Booking
DROP TABLE Booking

CREATE TABLE Customer_Registration(
RegistrationID int PRIMARY KEY,
CustomerID int,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
Tour int,
FOREIGN KEY (Tour) REFERENCES Tour(TourID),
RegistrationDate SMALLDATETIME )

DROP TABLE Customer_Registration
INSERT INTO Customer_Registration VALUES(0001,101,14262,2026-06-24),
(0002,103,13214,2026-05-06)

SELECT * FROM Customer_Registration


CREATE PROC sp_GetToursByDestination 
@Destination VARCHAR(50)
AS
BEGIN
SELECT * FROM Tour
WHERE Destination = @Destination
END
GO

EXEC sp_GetToursByDestination 'Goa';


CREATE PROCEDURE GetAgencyByTourName
    @TourName VARCHAR(50)
AS
BEGIN
    SELECT A.*
    FROM Agency A
    INNER JOIN Tour T
        ON A.AgencyID = T.AgencyID
    WHERE T.Name = @TourName
END

EXEC GetAgencyByTourName 'All India Trip'


CREATE PROC GetBookingDetails
AS
BEGIN
    SELECT
        B.BookingID,
        B.BookingDate,
        B.NumberOfSeats,

        C.CustomerID,
        C.Name,
        C.Phone,
        C.Email,

        T.TourID,
        T.Name,
        T.Destination,
        T.Price,

        A.AgencyID,
        A.Name,
        A.ContactNumber
    FROM Booking B
    INNER JOIN Customer C
        ON B.CustomerID = C.CustomerID
    INNER JOIN Tour T
        ON B.TourID = T.TourID
    INNER JOIN Agency A
        ON T.AgencyID = A.AgencyID
END

EXEC GetBookingDetails