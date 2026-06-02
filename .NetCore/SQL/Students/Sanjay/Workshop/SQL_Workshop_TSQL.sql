create database Tour_management;

USE Tour_management;

create table Agency(
Agency_id int PRIMARY KEY NOT NULL,
name varchar(100),
remarks varchar(250));

GO
CREATE proc Agency_Insert
(
@v_name as varchar(100),
@v_remarks as varchar(250)
)
as
declare @v_id as int
begin
select @v_id= (select isnull(max(Agency_id),0)+1 from Agency)
insert into Agency (Agency_id,name,remarks)
values (@v_id,@v_name,@v_remarks)
end
GO

EXEC Agency_Insert 'Travel Pro', 'Leading agency for international tours';
EXEC  Agency_Insert  'Just Travel','Specializes in adventure and trekking tours';
EXEC  Agency_Insert  'Make Travel','Focuse heritage experiences';


GO
CREATE proc Agency_Update
(
@v_id as int,
@v_name as varchar(100),
@v_remarks as varchar(250)
)
as
begin
update Agency set name = @v_name,remarks = @v_remarks where Agency_id = @v_id
end
GO
EXEC Agency_Update 1,' Travel Partner ',' Very Good ';



GO
CREATE proc Agency_Delete
(
@v_id as int
)
as
begin
delete from Agency  where Agency_id = @v_id
end
GO
EXEC Agency_Delete 1;


GO
CREATE proc deleteProc
(
@v_tname varchar(50),
@v_fname varchar(20),
@v_id int
) AS
BEGIN
EXEC ('delete from ' + @v_tname + ' where ' + @v_fname + '=' +@v_id)
END
GO
EXEC deleteProc 'Agency','Agency_id',2;


GO
CREATE proc SelectProc
(
@v_name varchar(50)
)
AS
BEGIN
exec('Select * From Agency where name=' + @v_name)
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


EXEC SelectProc1 'Agency';
EXEC SelectProc1 'Agency','Agency_id= 4';
EXEC SelectProc1 'Agency', 'remarks LIKE ''%tour%''';


GO
CREATE  FUNCTION	dbo.Agency_id()
RETURNS  BIGINT
AS
BEGIN
DECLARE @Agency_id AS BIGINT
SELECT @Agency_id =(SELECT ISNULL(MAX(Agency_id),0)+1 from Agency)
RETURN (@Agency_id)
END
GO

INSERT INTO Agency (Agency_id, name, remarks)
VALUES (dbo.Agency_id(), 'New Horizons Travel', 'Specializes in luxury cruises');


GO
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

		SELECT dbo.Get_fullname(name, remarks)as Full_name FROM Agency;


GO
	CREATE  FUNCTION dbo.GetTable
	(
	@Name VARCHAR(30)
	)
	RETURNS	Table
	AS
	RETURN 
               (
	SELECT * FROM Agency WHERE name = @Name
	)
              GO
			  SELECT * from dbo.GetTable('Make Travel')
