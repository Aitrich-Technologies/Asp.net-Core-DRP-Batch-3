create database tour_management;

use tour_management;


create table agency(
agency_id int primary key not null,
name  varchar(100),
remarks varchar(250)
);

go
create proc agency_insert
(
@v_name as varchar(100),
@v_remarks as varchar(250)
)
as
declare @v_id as int
begin
select @v_id= (select isnull(max(agency_id),0)+1 from agency)
insert into agency (agency_id,name,remarks)
values (@v_id,@v_name,@v_remarks)
end
GO

EXEC  agency_insert  'Travel Pro', 'Leading agency for international tours';
EXEC  agency_insert  'Just Travel','Specializes in adventure and trekking tours';
EXEC  agency_insert  'Make Travel','Focuse heritage experiences';


go
CREATE proc agency_Update
(
@v_id as int,
@v_name as varchar(100),
@v_remarks as varchar(250)
)
as
begin
update agency set name = @v_name,remarks = @v_remarks where agency_id = @v_id
end
GO

EXEC agency_Update 1,' Travel Partner ',' Very Good ';

go
CREATE proc agency_Delete
(
@v_id as int
)
as
begin
delete from agency  where agency_id = @v_id
end
GO

EXEC agency_Delete 1;

go
CREATE proc deleteProc
(
@v_tname varchar(50),
@v_fname varchar(20),
@v_id int
) 
AS
BEGIN
EXEC ('delete from ' + @v_tname + ' where ' + @v_fname + '=' +@v_id)
END
GO


EXEC deleteProc 'agency','agency_id',2;

go
CREATE proc SelectProc
(
@v_name varchar(50)
)
AS
BEGIN
exec('Select * From agency where name=' + @v_name)
END
GO

CREATE PROC SelectProc1
(
  @v_tname VARCHAR(50),   -- Table name
  @v_condition VARCHAR(200) = NULL  -- Optional WHERE condition
)
AS
BEGIN
 DECLARE @sql NVARCHAR(MAX);
 SET @sql = 'SELECT * FROM ' + @v_tname;
 IF @v_condition IS NOT NULL
 SET @sql = @sql + ' WHERE ' + @v_condition;
 EXEC(@sql);
 END
 GO

EXEC SelectProc1 'agency';
EXEC SelectProc1 'agency','agency_id= 4';
EXEC SelectProc1 'agency', 'remarks LIKE ''%tour%''';


go
CREATE  FUNCTION dbo.agency_id()
RETURNS  BIGINT
AS
BEGIN
DECLARE @agency_id AS BIGINT
SELECT @agency_id =(SELECT ISNULL(MAX(agency_id),0)+1 from agency)
RETURN (@agency_id)
END
GO

INSERT INTO agency (agency_id, name, remarks)
VALUES (dbo.agency_id(), 'New Horizons Travel', 'Specializes in luxury cruises');


go
CREATE  FUNCTION dbo.Get_fullname
(
@field1 VARCHAR(50), 
@field2 VARCHAR(50)
)
RETURNS	VARCHAR(100)
BEGIN
RETURN (@field1 + ', ' + @field2)
END
GO


SELECT dbo.Get_fullname(name, remarks)as Full_name FROM agency;


go
CREATE  FUNCTION dbo.GetTable
(
@Name VARCHAR(30)
)
RETURNS	Table
AS
RETURN 
(	
SELECT * FROM agency WHERE name = @Name
)
GO

go
SELECT * from dbo.GetTable('Make Travel')
