create database travelmanagement
use travelmanagement;
create table users
(
       Id UNIQUEIDENTIFIER DEFAULT NEWID() PRIMARY KEY,
    FirstName VARCHAR(50) NOT NULL,
    LastName VARCHAR(50) NOT NULL,
    Gender VARCHAR(10) NULL,
    DateOfBirth DATE NULL,
    [Role] INT NOT NULL DEFAULT 2, -- 2 for Customer
    UserName VARCHAR(50) NOT NULL UNIQUE,
    Email VARCHAR(100) NOT NULL UNIQUE,
    TelephoneNo VARCHAR(20) NULL,
    [Password] VARCHAR(200) NOT NULL,
    CreatedAt DATETIME DEFAULT GETUTCDATE()

);
create table Destinations
(
  
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

INSERT INTO Destinations ([Name], City, [Description], CreatedBy) VALUES ( 'Grand Canyon Helicopter Tour', 'Las Vegas', 'A luxury flight over the West Rim with a champagne toast.', (SELECT Id FROM [Users] WHERE UserName = 'skyhigh_travel') );

SELECT 
    d.[Name] AS DestinationName, 
    d.City, 
    u.FirstName + ' ' + u.LastName AS CreatorName, -- Concatenates First and Last Name
    u.UserName AS CreatorHandle,
    u.Email AS ContactEmail
FROM Destinations d
INNER JOIN [Users] u ON d.CreatedBy = u.Id;

DELETE FROM Destinations WHERE [Name] = 'Eiffel Tower Experience';

select * from Destinations

alter table Destinations add description varchar(100)

select * from users where Role=1

drop table Destinations






