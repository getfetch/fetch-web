CREATE TABLE [dbo].[OrganizationUser]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [OrganizationId] INT NOT NULL, 
    [UserId] INT NOT NULL, 
    CONSTRAINT [FK_OrganizationUser_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [Organization]([Id]), 
    CONSTRAINT [FK_OrganizationUser_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
