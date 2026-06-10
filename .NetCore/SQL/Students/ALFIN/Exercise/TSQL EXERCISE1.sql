create database tour_booking_information;

go
USE tour_booking_information;
go

create  table Agency(
AgencyID int primary key,
Name VARCHAR(50),
address VARCHAR(100),
ContactNumber VARCHAR(20)
)

INSERT INTO Agency VALUES(1,'Sunday Travels','kochi',9876543212);
INSERT INTO Agency VALUES(2,'friday Travels','pala',9876543213);
INSERT INTO Agency VALUES(3,'monday Travels','kottayam',9876543214);

select * from Agency;

create table Customer(
CustomerID INT primary key,
Name VARCHAR(50),
Email VARCHAR(50),
Phone VARCHAR(20)
)

INSERT INTO Customer VALUES(101,'sanjay','sanjay@gmail.com','9988776655');
INSERT INTO Customer VALUES(102,'arya','arya@gmail.com','9988776654');
INSERT INTO Customer VALUES(103,'mariya','mariya@gmail.com','9988776653');

select * from Customer;

create table Tour(
TourID INT primary key,
AgencyID int ,
Name VARCHAR(50),
Destination VARCHAR(50),
Price decimal(10,2),
FOREIGN KEY (AgencyID) REFERENCES Agency(AgencyID)
)

INSERT INTO Tour VALUES(11,1,'kerala holiday','kerala',20000);
INSERT INTO Tour VALUES(12,2,'goa holiday','goa',30000);
INSERT INTO Tour VALUES(13,3,'tamil holiday','tamil',40000);


select * from Tour;

create table Booking(
BookingID INT primary key,
CustomerID INT,
TourID INT,
BookingDate SMALLDATETIME,
NumberofSeats INT,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
FOREIGN KEY (TourID) REFERENCES Tour(TourID)
)

INSERT INTO Booking VALUES(110,101,11,2026-2-11,2);
INSERT INTO Booking VALUES(120,102,12,2026-3-22,4);
INSERT INTO Booking VALUES(130,103,13,2026-4-11,8);

SELECT * from Booking;

create table Customer_Registration(
RegistrationID int primary key,
CustomerID INT,
TourID int,
RegistrationDate SMALLDATETIME,
FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
FOREIGN KEY (TourID) REFERENCES Tour(TourID)
)

insert into Customer_Registration VALUES(111,101,11,2025-01-05);
insert into Customer_Registration VALUES(222,102,12,2025-03-15);
insert into Customer_Registration VALUES(333,103,13,2025-05-25);

SELECT * FROM Customer_Registration;


SELECT 
C.CustomerID,
C.Name as CustomerName,
T.Name as TourName,
T.Destination,
B.BookingDate
from Customer C
Join Booking B
ON C.CustomerID = B.CustomerID
Join Tour T
ON B.TourID=T.TourID;

UPDATE Customer SET Phone = 9876543210 WHERE Name = 'sanjay';

UPDATE Tour SET Price = 25000 WHERE Name = 'kerala holiday';

select
C.Name as Customer ,
T.Name as Tour,
A.Name as Agency
from Booking B
join Customer C
ON B.CustomerID = C.CustomerID
join Tour T
ON B.TourID = T.TourID
join Agency A
ON T.AgencyID = A.AgencyID;

SELECT T.*
FROM Tour T
join Agency A
ON T.AgencyID = A.AgencyID WHERE A.Name ='Sunday Travels';

SELECT B.*
FROM Booking B
join Customer  C
ON B.CustomerID = C.CustomerID WHERE C.Name = 'arya';

SELECT 
A.Name  as Agency,
C.Name as CustomerName
FROM Agency A  
JOIN Tour T
ON A.AgencyID = T.AgencyID
join Booking B
ON T.TourID = B.TourID
JOIN Customer C
ON B.CustomerID = C.CustomerID
ORDER BY A.Name;

select *
from Tour 
ORDER BY Price DESC;

SELECT B.*
FROM  Booking B
Join Tour T
ON B.TourID = T.TourID
WHERE T.Destination = 'kerala';

select 
T.Name  as TourName ,
count(B.BookingID) AS TotalBookings
from Tour T
LEFT JOIN Booking B
ON T.TourID = B.TourID
Group by T.Name;

select 
Destination ,
Count (*) as TotalTours
From Tour
Group by Destination;

select 
C.CustomerID,
C.Name,
Count(CR.TourID) AS TotalTours
From Customer C
join Customer_Registration CR
ON C.CustomerID = CR.CustomerID
group by C.CustomerID,
C.Name
HAVING COUNT(CR.TourID)>1;


SELECT
T.Name as TourName,
count(CR.CustomerID) as TotalCustomers
from Tour T
LEFT JOIN Customer_Registration CR
ON T.TourID = CR.TourID
Group by T.Name;

select
A.Name as AgencyName,
SUM(T.Price) as TotalRevenue
from Agency A 
join Tour T
ON A.AgencyID =T.AgencyID
Join Customer_Registration CR
ON T.TourID = CR.TourID
group by A.Name;

select 
distinct
C.CustomerID,
c.Name
From Customer C 
join booking B
on C.CustomerID = B.CustomerID
WHERE MONTH(B.BookingDate) =1
and year(B.BookingDate) = 2025;

SELECT*
FROM Tour
where Price > 20000;

select top 3
T.Destination,
count(CR.RegistrationID) AS TotalRegistrations
from Tour T
join Customer_Registration CR
on T.TourID = CR.TourID
Group by T.Destination
Order by TotalRegistrations DESC;

select 
C.CustomerID,
C.Name
from Customer C
left join Customer_Registration CR
ON C.CustomerID = CR.CustomerID
WHERE CR.CustomerID IS NULL;

