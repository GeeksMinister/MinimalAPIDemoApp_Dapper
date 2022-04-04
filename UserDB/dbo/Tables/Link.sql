CREATE TABLE [dbo].[Link]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Url] VARCHAR(2048) NOT NULL, 
    [PersonId] INT NOT NULL, 
    [InterestId] INT NOT NULL, 
    CONSTRAINT [PersonLink] FOREIGN KEY ([PersonId]) REFERENCES [Person]([Id]),
    CONSTRAINT [InterestLink] FOREIGN KEY ([InterestId]) REFERENCES [Interest]([Id])
)
