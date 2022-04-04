CREATE PROCEDURE [dbo].[spPerson_Update]
    @Id int,
    @FirstName NVARCHAR(50), 
    @LastName NVARCHAR(50), 
    @Age TINYINT, 
    @Phone VARCHAR(20), 
    @City NVARCHAR(50), 
    @Email VARCHAR(320)
AS
begin
	update dbo.[Person] set
	FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Email = @Email, City = @City
	where Id = @Id;
end