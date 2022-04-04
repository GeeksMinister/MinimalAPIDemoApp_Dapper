CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [Age] TINYINT NOT NULL, 
    [Phone] VARCHAR(20) NULL, 
    [City] NVARCHAR(50) NULL, 
    [Email] VARCHAR(320) NULL
)
