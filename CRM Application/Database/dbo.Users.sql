CREATE TABLE [dbo].[Users] (
    [Id]              INT           NOT NULL,
    [Username]        VARCHAR (64)  NOT NULL,
    [Password]        VARBINARY (1024) NOT NULL,
    [PermissionLevel] INT           DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

