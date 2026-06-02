CREATE FUNCTION GetSquare
(
@num INT
)
RETURNS INT
AS
BEGIN
   RETURN @num * @num
END

SELECT dbo.GetSquare(5);

