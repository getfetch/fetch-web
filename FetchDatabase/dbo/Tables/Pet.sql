CREATE TABLE [dbo].[Pet]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Type] VARCHAR(25) NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [OrganizationId] INT NOT NULL, 
    [Breed] VARCHAR(50) NOT NULL, 
    [Description] TEXT NOT NULL, 
    [AtRisk] BIT NOT NULL DEFAULT 0, 
    [Age] VARCHAR(15) NOT NULL, 
    [Sex] CHAR NOT NULL, 
    [Size] VARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_Pet_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [Organization]([Id])
)
