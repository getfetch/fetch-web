CREATE TABLE [dbo].[Organization]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [AddressId] INT NOT NULL, 
    [Name] VARCHAR(50) NOT NULL, 
    [Type] VARCHAR(10) NOT NULL, 
    [MainContactId] INT NOT NULL, 
    [Phone] VARCHAR(25) NULL, 
    [Email] VARCHAR(255) NULL, 
    CONSTRAINT [FK_Organization_Address] FOREIGN KEY ([AddressId]) REFERENCES [Address]([Id]), 
    CONSTRAINT [FK_Organization_MainContact] FOREIGN KEY ([MainContactId]) REFERENCES [User]([Id])
)
