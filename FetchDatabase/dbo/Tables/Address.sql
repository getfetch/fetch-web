CREATE TABLE [dbo].[Address]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Line1] VARCHAR(255) NOT NULL, 
    [Line2] VARCHAR(255) NULL, 
    [City] VARCHAR(255) NOT NULL, 
    [State] CHAR(2) NOT NULL, 
    [Zip] VARCHAR(15) NOT NULL, 
    [Longitude] DECIMAL(10, 6) NULL, 
    [Latitude] DECIMAL(10, 6) NULL
)
