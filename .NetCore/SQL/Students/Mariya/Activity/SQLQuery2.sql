create database MATHEMATICALMANAGEMENT;
create function addnumbers
(
    @D int,
    @C int
)
returns int

AS
BEGIN
Return @D + @C

END 
GO
SELECT dbo.addnumbers(10,20 )as result



   
