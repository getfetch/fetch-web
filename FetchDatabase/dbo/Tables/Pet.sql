CREATE TABLE [dbo].[Pet] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [Type]           VARCHAR (25) NOT NULL,
    [Name]           VARCHAR (50) NOT NULL,
    [OrganizationId] INT          NOT NULL,
    [Breed]          VARCHAR (50) NOT NULL,
    [Description]    TEXT         NOT NULL,
    [AtRisk]         BIT          DEFAULT ((0)) NOT NULL,
    [Age]            VARCHAR (15) NOT NULL,
    [Sex]            CHAR (1)     NOT NULL,
    [Size]           VARCHAR (10) NOT NULL,
    [Status] VARCHAR(10) NOT NULL DEFAULT 'available', 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Pet_Organization] FOREIGN KEY ([OrganizationId]) REFERENCES [dbo].[Organization] ([Id])
);


