CREATE TABLE [dbo].[Employee] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [Phone]     VARCHAR (50) NOT NULL,
    [Email]     VARCHAR (50) NOT NULL,
    [BirthDate] DATETIME     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
