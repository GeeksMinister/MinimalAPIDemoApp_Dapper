CREATE PROCEDURE [dbo].[spPerson_Get]
	@Id int
AS
begin
	select [Id], [FirstName], [LastName], [Age], [Phone], [City], [Email] 
	from dbo.[Person]
	where Id = @Id;
end

