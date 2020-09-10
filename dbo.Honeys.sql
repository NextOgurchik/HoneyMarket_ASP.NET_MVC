CREATE TABLE [dbo].[Honeys] (
    [Id]       INT            IDENTITY (1, 1) NULL,
    [Name]     NVARCHAR (MAX) NULL,
    [Producer] NVARCHAR (MAX) NULL,
    [Price]    INT            NOT NULL,
    CONSTRAINT [PK_dbo.Honeys] PRIMARY KEY CLUSTERED ([Id] ASC)
);

