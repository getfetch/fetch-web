CREATE TABLE [dbo].[PetFinderOrganization]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [OrganizationId] INT NOT NULL, 
    [PetFInderId] VARCHAR(10) NOT NULL, 
    CONSTRAINT [FK_PetFinderOrganization_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [Organization]([Id])
)
