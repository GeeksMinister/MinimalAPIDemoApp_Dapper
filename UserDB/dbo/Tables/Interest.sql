CREATE TABLE [dbo].[Interest]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(150) NOT NULL, 
    [Description] NVARCHAR(350) NULL, 
    [PersonId] INT NOT NULL, 
    CONSTRAINT [PersonInterest] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]) 
)
