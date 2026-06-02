create database companymanagement;

GO
USE companymanagement
GO

create table Company_masters(
id int PRIMARY KEY,
Name varchar(20),
Remarks varchar(20));

GO
create proc Company_master_insert
(@Name as varchar(20),@Remarks as varchar(20))
AS 
declare @id AS int
BEGIN 
SELECT @id = (SELECT ISNULL(MAX(id),0)+1
FROM Company_masters)

INSERT INTO Company_masters(id, Name, Remarks)
values (@id, @Name, @Remarks)
END
GO

EXEC Company_master_insert 'Alfin','Moderate';

SELECT * FROM Company_masters;

GO

CREATE proc Company_master_update
(@id AS int,
@Name AS varchar(20), 
@Remarks varchar(20))
AS
BEGIN
UPDATE Company_masters SET Name = @Name,Remarks = @Remarks where id = @id
END 
GO

EXEC Company_master_update 1,'Arya v.a','Very Bad';

SELECT * FROM Company_masters;

drop proc Company_master_update;
drop database Newcompanymanagement;

GO
CREATE PROC [dbo].[deleteProc]
(@id int)
AS
BEGIN
EXEC ('delete from '+'Company_masters' + ' where '  +'id'+ '=' +@id)
END
EXEC deleteproc 2

