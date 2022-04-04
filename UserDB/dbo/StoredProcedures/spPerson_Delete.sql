CREATE PROCEDURE [dbo].[spPerson_Delete]
	@Id int
AS
begin
	delete dbo.[Person]
	where Id = @Id;
end