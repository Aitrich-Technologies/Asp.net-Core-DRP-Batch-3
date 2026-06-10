create database AgencyManagement;
go
use AgencyManagement
go

create table Agency(
AgencyID int primary key not null,
Name varchar (100),
Remarks varchar (250)
);

go
create proc Agency_insert(
@Name as varchar(100),
@Remarks as varchar(250)
)
as
declare
@AgencyID as int
begin
select @AgencyID =  (select isnull(max (AgencyID),0)+1 from Agency)
insert into Agency (AgencyID,Name,Remarks)
values(@AgencyID,@Name,@REmarks)
end
go

EXEC Agency_Insert 'Travel Pro', 'Leading agency for international tours';
EXEC  Agency_Insert  'Just Travel','Specializes in adventure and trekking tours';
EXEC  Agency_Insert  'Make Travel','Focuse heritage experiences';
select * from Agency;

go
create proc Agency_Update(
@AgencyID int,
@Name as varchar(100),
@Remarks as varchar(250)
)
as
begin
update Agency 
set name = @Name,
Remarks = @Remarks 
where AgencyID = @AgencyID 
end
go

EXEC Agency_Update 1,' Travel Partner ',' Very Good ';
select * from Agency;

go
create proc Agency_Delete(
@AgencyID as int
)
as
begin
delete from Agency where AgencyID = @AgencyID
end
go

EXEC Agency_Delete 1;
select * from Agency;

go
CREATE PROC deleteProc
( @Name VARCHAR(50),
@v_fname VARCHAR(20), 
@v_id INT ) 
AS 

BEGIN DECLARE @sql VARCHAR(200) 
SET @sql = 
'DELETE FROM ' + @Name + ' WHERE ' + @v_fname +
' = ' + CONVERT(VARCHAR, @v_id) 
EXEC(@sql) 
END 
GO

EXEC deleteProc 'Agency', 'AgencyID', 2;

go
CREATE PROC SelectProc
(
    @v_name VARCHAR(50)
)
AS
BEGIN
    EXEC(
        'SELECT * FROM Agency WHERE Name = '''
        + @v_name + ''''
    )
END
GO

EXEC SelectProc 'Make Travel';

go
CREATE PROC SelectProc1 (
@v_tname VARCHAR(50), -- Table Name 
@v_condition VARCHAR(200) = NULL ) 
AS 
BEGIN 
DECLARE @sql NVARCHAR(MAX); 
SET @sql = 'SELECT * FROM ' + @v_tname; 
IF @v_condition IS NOT NULL 
SET @sql = @sql + ' WHERE ' + @v_condition; 
EXEC(@sql);
END 
GO
EXEC SelectProc1 'Agency'; 
EXEC SelectProc1 'Agency', 'AgencyID = 2';
EXEC SelectProc1 'Agency', 'Remarks LIKE ''%tour%''';

GO
CREATE FUNCTION dbo.Agency_id()
RETURNS BIGINT 
AS 
BEGIN 
DECLARE @AgencyID BIGINT;
SELECT @AgencyID =
( SELECT ISNULL(MAX(AgencyID),0)+1 FROM Agency )
RETURN (@AgencyID)
END
GO 

INSERT INTO Agency 
( AgencyID, Name, Remarks ) 
VALUES 
( 
dbo.Agency_id(), 
'New Horizons Travel', 
'Specializes in luxury cruises'
); 
SELECT * FROM Agency;

GO
CREATE FUNCTION dbo.Get_fullname 
( @field1 VARCHAR(50),
@field2 VARCHAR(50) ) 
RETURNS VARCHAR(100) 
AS 
BEGIN
RETURN (@field1 + ', ' + @field2) 
END 
GO

SELECT dbo.Get_fullname
( Name, Remarks ) 
AS Full_name FROM Agency;

GO
CREATE FUNCTION dbo.GetTable 
( @Name VARCHAR(30) ) 
RETURNS TABLE 
AS 
RETURN 
( SELECT * FROM Agency WHERE Name = @Name )

GO

SELECT * FROM dbo.GetTable('Make Travel');
GO









