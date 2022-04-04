CREATE PROCEDURE [dbo].[spPerson_Search]
	@searchTerm varchar(50)
AS
begin
	set nocount on;
	SELECT [Id], [FirstName], [LastName], [Age], [Phone], [City], [Email]
	from Person
	where FirstName like '%' + @searchTerm + '%'
		or LastName like '%' + @searchTerm + '%';
end