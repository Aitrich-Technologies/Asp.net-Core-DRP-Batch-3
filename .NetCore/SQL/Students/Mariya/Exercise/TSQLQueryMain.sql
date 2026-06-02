create database Tourbookingsystem
go
use Tourbookingsystem
go

CREATE TABLE Agency
(
    AgencyID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Address VARCHAR(100),
    ContactNumber VARCHAR(20)
);
DROP TABLE Agency
go
create proc Agency_insert
(
 @id as int,
 @name as varchar(50),
 @address as varchar(100),
 @contactNumber as varchar(20))
 
  as
  begin
  insert into Agency(AgencyID,name,Address,ContactNumber)
values (@id,@name,@address,@contactNumber)
end
go

EXEC Agency_insert 1,"Flyhigh",'Cochin kerala',8304814282;

GO
CREATE proc Agency_Update
(
@id as int,
@name as varchar(100),
@address as varchar(250),
@contactNumber as varchar(20)
)
as
begin
update Agency set name = @name,Address= @address where Agencyid = @id
end
GO
EXEC Agency_update 1,' Travel Partners ',' Very Good ', 9876542344;
SELECT * FROM Agency
DROP PROC Agency_Delete

GO
CREATE PROC Agency_Delete
(
    @id as INT
)
AS
BEGIN
    DELETE FROM Agency
    WHERE AgencyID = @id
END
GO

EXEC Agency_Delete 3

SELECT * FROM Agency;

GO
CREATE PROC Agency_Delete
(
    @id INT
)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Agency WHERE AgencyID = @id)
    BEGIN
        DELETE FROM Agency
        WHERE AgencyID = @id;

        PRINT 'Record deleted successfully.';
    END
    ELSE
    BEGIN
        PRINT 'AgencyID not found.';
    END
    GO

    Drop table 


CREATE TABLE Customer
(
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    Email VARCHAR(50) UNIQUE,
    Phone VARCHAR(20)
);

Drop table Customer


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

Drop table Tour

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
Drop  table Booking

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

Drop table Customer_Registration

CREATE TABLE Student
(
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(50),
    Department VARCHAR(50),
    Age INT
);
GO
CREATE PROC GetComputerScienceStudents
AS
BEGIN
    SELECT *
    FROM Student
    WHERE Department = 'Computer Science';
END
GO

EXEC GetComputerScienceStudents;

create table professor
(
  ProfessorID INT PRIMARY KEY,
    ProfessorName VARCHAR(100) NOT NULL,
    Department VARCHAR(100)
);

CREATE TABLE Course
(
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(100) NOT NULL
);

CREATE TABLE ProfessorCourse
(
    ProfessorID INT,
    CourseID INT,
    
    PRIMARY KEY (ProfessorID, CourseID),
    
    FOREIGN KEY (ProfessorID)
        REFERENCES Professor(ProfessorID),
        
    FOREIGN KEY (CourseID)
        REFERENCES Course(CourseID)
);

INSERT INTO Professor VALUES
(1, 'John Smith', 'Computer Science'),
(2, 'Mary Johnson', 'Computer Science'),
(3, 'David Wilson', 'Electronics');

INSERT INTO Course VALUES
(101, 'Database Management System'),
(102, 'Computer Networks'),
(103, 'Data Structures');


INSERT INTO ProfessorCourse VALUES
(1, 101),
(2, 101),
(2, 102),
(3, 102);

GO
CREATE PROC GetProfessorsByCourse
(
    @CourseName VARCHAR(100)
)
AS
BEGIN
    SELECT P.ProfessorID,
           P.ProfessorName,
           C.CourseName
    FROM Professor P
    INNER JOIN ProfessorCourse PC
        ON P.ProfessorID = PC.ProfessorID
    INNER JOIN Course C
        ON PC.CourseID = C.CourseID
    WHERE C.CourseName = @CourseName;
END
GO

EXEC GetProfessorsByCourse 'Database Management System';

CREATE TABLE Student
(
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(100)
);

CREATE TABLE Subject
(
    SubjectID INT PRIMARY KEY,
    SubjectName VARCHAR(100)
);

CREATE TABLE Faculty
(
    FacultyID INT PRIMARY KEY,
    FacultyName VARCHAR(100)
);

CREATE TABLE Registration
(
    StudentID INT,
    SubjectID INT,
    FacultyID INT,

    FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
    FOREIGN KEY (SubjectID) REFERENCES Subject(SubjectID),
    FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);

INSERT INTO Student VALUES
(1,'Rahul'),
(2,'Anjali');

INSERT INTO Subject VALUES
(101,'Database Management System'),
(102,'Computer Networks');

INSERT INTO Faculty VALUES
(201,'John Smith'),
(202,'Mary Johnson');

INSERT INTO Registration VALUES
(1,101,201),
(1,102,202),
(2,101,201);

GO
CREATE PROC GetStudentSubjectFaculty
AS
BEGIN
    SELECT
        S.StudentID,
        S.StudentName,
        SU.SubjectName,
        P.FacultyName
    FROM Student S
    INNER JOIN Registration R
        ON S.StudentID = R.StudentID
    INNER JOIN Subject SU
        ON R.SubjectID = SU.SubjectID
    INNER JOIN Faculty P
        ON R.FacultyID = P.FacultyID;
END
GO

EXEC GetStudentSubjectFaculty;

