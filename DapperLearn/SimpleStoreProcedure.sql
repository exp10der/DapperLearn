CREATE PROCEDURE GetUserById @userId AS INT
AS
    SELECT  *
    FROM    dbo.Users
    WHERE   Id = @userId;
GO