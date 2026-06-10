create database tour_booking_portal;
use tour_booking_portal;

create table users(
id UNIQUEIDENTIFIER DEFAULT NEWID() primary key,
firstname varchar(50)not null,
lastname varchar(50)not null,
gender varchar(10)null,
dateofbirth date null,
[Role] INT NOT NULL DEFAULT 2, -- 2 for Customer
UserName VARCHAR(50) NOT NULL UNIQUE,
Email VARCHAR(100) NOT NULL UNIQUE,
TelephoneNo VARCHAR(20) NULL,
[Password] VARCHAR(200) NOT NULL,
CreatedAt DATETIME DEFAULT GETUTCDATE()
);

create table destinations(
Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
[Name] VARCHAR(100) NOT NULL,
City VARCHAR(100),
[Description] VARCHAR(MAX) NULL,
CreatedBy UNIQUEIDENTIFIER NULL, 
FOREIGN KEY (CreatedBy) REFERENCES [Users](Id) ON DELETE SET NULL
);

INSERT INTO [Users] (FirstName, LastName, UserName, Email, [Password], [Role])
VALUES ('Admin', '01', 'admin01', 'admin@tourportal.com', 'hashed_pw_123', 0);

INSERT INTO [Users] (FirstName, LastName, UserName, Email, [Password], [Role])
VALUES ('Sky High', 'Agencies', 'skyhigh_travel', 'contact@skyhigh.com', 'agency_temp_pass', 1);

UPDATE [Users] 
SET TelephoneNo = '+123456789' 
WHERE Email = 'contact@skyhigh.com';

INSERT INTO Destinations ([Name], City, [Description], CreatedBy)
VALUES (
'Eiffel Tower Experience', 
'Paris', 
'A breathtaking tour of the iron lady with skip-the-line access.',
 (SELECT Id FROM [Users] WHERE UserName = 'admin01')
);

INSERT INTO Destinations ([Name], City, [Description], CreatedBy)
VALUES ( 'Grand Canyon Helicopter Tour', 'Las Vegas', 'A luxury flight over the West Rim with a champagne toast.', 
(SELECT Id FROM [Users] WHERE UserName = 'skyhigh_travel') );


INSERT INTO Destinations ([Name], City, [Description], CreatedBy)
VALUES
('coral','germany', 'A luxury flight over the West Rim with a champagne toast.', 
(SELECT Id FROM [Users] WHERE UserName = 'skyhigh_travel') );

DELETE FROM Destinations WHERE [Name] = 'coral';
 -- Verification: Check that the destination is gone 
SELECT * FROM Destinations;

UPDATE Destinations SET [Name] = 'Eiffel Tower Experience' WHERE [Name] = 'coral';


SELECT 
    d.[Name] AS DestinationName, 
    d.City, 
    u.FirstName + ' ' + u.LastName AS CreatorName, -- Concatenates First and Last Name
    u.UserName AS CreatorHandle,
    u.Email AS ContactEmail
FROM Destinations d
INNER JOIN [Users] u ON d.CreatedBy = u.Id;

alter table destinations add description varchar(50);

select  * from users where role=1

drop table destinations;