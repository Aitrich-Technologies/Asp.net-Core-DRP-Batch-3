create database tour_managements;

go
use tour_managements
go

CREATE TABLE Agency
(
    AgencyID INT PRIMARY KEY,
    Name VARCHAR(50),
    Address VARCHAR(100),
    ContactNumber VARCHAR(20)
);
GO
CREATE PROC Agency_list
(
    @AgencyID INT,
    @Name VARCHAR(50),
    @Address VARCHAR(100),
    @ContactNumber VARCHAR(20)
)
AS
BEGIN
    INSERT INTO Agency
    (AgencyID, Name, Address, ContactNumber)
    VALUES
    (@AgencyID, @Name, @Address, @ContactNumber)
END
GO

EXEC Agency_list
4,
'Anaa',
'Fly Abroad',
'9544118830';

SELECT * FROM Agency;
GO


CREATE PROC Agency_master_update
(
    @AgencyID INT,
    @Name VARCHAR(50),
    @Address VARCHAR(100),
    @ContactNumber VARCHAR(20)
)
AS
BEGIN
    UPDATE Agency
    SET Name = @Name,
        Address = @Address,
        ContactNumber = @ContactNumber
    WHERE AgencyID = @AgencyID
END
GO

EXEC Agency_master_update
3,
'Anju',
'Sky Travels',
'9876543287';

SELECT * FROM Agency;
Go

CREATE PROC Agency_delete
(
    @AgencyID INT
)
AS
BEGIN
    DELETE FROM Agency
    WHERE AgencyID = @AgencyID
END
GO

-- EXEC Agency_delete 3;



CREATE TABLE Tour
(
    TourID INT PRIMARY KEY,
    AgencyID INT,
    Name VARCHAR(50),
    Destination VARCHAR(50),
    Price DECIMAL(10,2),
    FOREIGN KEY (AgencyID)
    REFERENCES Agency(AgencyID)
);

GO
CREATE PROC Tour_insert
(
    @TourID INT,
    @AgencyID INT,
    @Name VARCHAR(50),
    @Destination VARCHAR(50),
    @Price DECIMAL(10,2)
)
AS
BEGIN
    INSERT INTO Tour
    VALUES
    (@TourID,@AgencyID,@Name,@Destination,@Price)
END
GO

EXEC Tour_insert
5,
3,
'Exploring Paris',
'Paris',
40000;

SELECT * FROM Tour;

GO
CREATE PROC Tour_update
(
    @TourID INT,
    @AgencyID INT,
    @Name VARCHAR(50),
    @Destination VARCHAR(50),
    @Price DECIMAL(10,2)
)
AS
BEGIN
    UPDATE Tour
    SET AgencyID = @AgencyID,
        Name = @Name,
        Destination = @Destination,
        Price = @Price
    WHERE TourID = @TourID
END
GO


CREATE PROC Tour_delete
(
    @TourID INT
)
AS
BEGIN
    DELETE FROM Tour
    WHERE TourID = @TourID
END
GO


CREATE TABLE Customer
(
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(50),
    Email VARCHAR(50),
    Phone VARCHAR(20)
);
GO

CREATE PROC Customer_Masterinsert
(
    @CustomerID INT,
    @Name VARCHAR(50),
    @Email VARCHAR(50),
    @Phone VARCHAR(20)
)
AS
BEGIN
    INSERT INTO Customer
    VALUES(@CustomerID,@Name,@Email,@Phone)
END
GO

EXEC Customer_Masterinsert
106,
'Sanjay',
'sanjay225@gmail.com',
'858528585';

SELECT * FROM Customer;
GO
CREATE PROC Customer_update
(
    @CustomerID INT,
    @Name VARCHAR(50),
    @Email VARCHAR(50),
    @Phone VARCHAR(20)
)
AS
BEGIN
    UPDATE Customer
    SET Name = @Name,
        Email = @Email,
        Phone = @Phone
    WHERE CustomerID = @CustomerID
END
GO

/* CUSTOMER DELETE */

CREATE PROC Customer_delete
(
    @CustomerID INT
)
AS
BEGIN
    DELETE FROM Customer
    WHERE CustomerID = @CustomerID
END
GO

CREATE TABLE Booking
(
    BookingID INT PRIMARY KEY,
    CustomerID INT,
    TourID INT,
    BookingDate SMALLDATETIME,
    NumberOfSeats INT,
    FOREIGN KEY(CustomerID)
    REFERENCES Customer(CustomerID),

    FOREIGN KEY(TourID)
    REFERENCES Tour(TourID)
);
GO


CREATE PROC Booking_insert
(
    @BookingID INT,
    @CustomerID INT,
    @TourID INT,
    @BookingDate SMALLDATETIME,
    @NumberOfSeats INT
)
AS
BEGIN
    INSERT INTO Booking
    VALUES
    (@BookingID,@CustomerID,
     @TourID,@BookingDate,
     @NumberOfSeats)
END
GO

EXEC Booking_insert
1,
106,
5,
'2025-02-01',
5;

SELECT * FROM Booking;
GO


CREATE PROC Booking_update
(
    @BookingID INT,
    @CustomerID INT,
    @TourID INT,
    @BookingDate SMALLDATETIME,
    @NumberOfSeats INT
)
AS
BEGIN
    UPDATE Booking
    SET CustomerID = @CustomerID,
        TourID = @TourID,
        BookingDate = @BookingDate,
        NumberOfSeats = @NumberOfSeats
    WHERE BookingID = @BookingID
END
GO

CREATE PROC Booking_delete
(
    @BookingID INT
)
AS
BEGIN
    DELETE FROM Booking
    WHERE BookingID = @BookingID
END
GO

CREATE TABLE Customer_Registration
(
    RegistrationID INT PRIMARY KEY,
    CustomerID INT,
    TourID INT,
    RegistrationDate SMALLDATETIME,

    FOREIGN KEY(CustomerID)
    REFERENCES Customer(CustomerID),

    FOREIGN KEY(TourID)
    REFERENCES Tour(TourID)
);
GO

CREATE PROC Tour_By_Destination
(
    @Destination VARCHAR(50)
)
AS
BEGIN
    SELECT *
    FROM Tour
    WHERE Destination = @Destination
END
GO

EXEC Tour_By_Destination 'Paris';
GO

CREATE PROC Agency_By_TourName
(
    @TourName VARCHAR(50)
)
AS
BEGIN
    SELECT A.*
    FROM Agency A
    INNER JOIN Tour T
    ON A.AgencyID = T.AgencyID
    WHERE T.Name = @TourName
END
GO

EXEC Agency_By_TourName 'Exploring Paris';
GO


CREATE PROC Booking_Details
AS
BEGIN
    SELECT
        B.BookingID,
        C.Name AS CustomerName,
        C.Email,
        C.Phone,
        T.Name AS TourName,
        T.Destination,
        T.Price,
        A.Name AS AgencyName,
        A.ContactNumber,
        B.BookingDate,
        B.NumberOfSeats

    FROM Booking B

    INNER JOIN Customer C
        ON B.CustomerID = C.CustomerID

    INNER JOIN Tour T
        ON B.TourID = T.TourID

    INNER JOIN Agency A
        ON T.AgencyID = A.AgencyID
END
GO

EXEC Booking_Details;
GO

