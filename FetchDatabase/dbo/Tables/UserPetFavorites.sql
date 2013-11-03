CREATE TABLE [dbo].[UserPetFavorites]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [UserId] INT NOT NULL, 
    [PetId] INT NOT NULL, 
    [Comment] TEXT NULL, 
    CONSTRAINT [FK_UserPetFavorites_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id]), 
    CONSTRAINT [FK_UserPetFavorites_Pet] FOREIGN KEY ([PetId]) REFERENCES [Pet]([Id])
)
