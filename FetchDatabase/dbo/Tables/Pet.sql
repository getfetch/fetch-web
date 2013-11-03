CREATE TABLE [dbo].[Pet]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Type] VARCHAR(25) NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [OrganizationId] INT NOT NULL, 
    [Breed] VARCHAR(50) NOT NULL, 
    [Description] TEXT NOT NULL, 
    [AtRisk] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Pet_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [Organization]([Id])
)
