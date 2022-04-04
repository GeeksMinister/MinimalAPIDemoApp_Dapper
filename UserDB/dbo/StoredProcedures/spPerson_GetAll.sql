CREATE PROCEDURE [dbo].[spPerson_GetAll]

AS
begin
	select [Id], [FirstName], [LastName], [Age], [Phone], [City], [Email] 
	from dbo.[Person];
end

--begin
--select p.*, i.* from Person as p
--join 
--(
--	select * from Interest
--)
--as i on i.PersonId = p.Id
--join 
--(
--	select * from Link
--)
--as l on l.InterestId = i.PersonId
