CREATE PROCEDURE [dbo].[spPerson_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Age tinyint,
	@Phone varchar(20),
	@Email varchar(320),
	@City nvarchar(50)
AS
begin
	insert into dbo.[Person] (FirstName, LastName, Age, Phone, Email, City)
	output inserted.Id, inserted.FirstName, inserted.LastName, inserted.Age, inserted.Phone, inserted.Email, inserted.City
	values (@FirstName, @LastName, @Age, @Phone, @Email, @City);
end