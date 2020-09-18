CREATE TABLE [dbo].[Users]
(
	[UserId]       INT          IDENTITY (1, 1) NOT NULL,
	[UserName]     VARCHAR (50) NOT NULL,
	[UserPassword] VARCHAR (50) NOT NULL,
	CONSTRAINT [PK_Users] PRIMARY KEY NONCLUSTERED ([UserId] ASC)
);

CREATE TABLE [dbo].[Emails]
(
	[EmailId] INT NOT NULL IDENTITY,
	[UserId] INT NOT NULL,
	[EmailName] VARCHAR(50) NOT NULL,
	CONSTRAINT [PK_Emails] PRIMARY KEY CLUSTERED ([EmailID] ASC),
	CONSTRAINT [FK_Emails_Users] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([UserID])
);

CREATE TABLE [dbo].[Sites]
(
	[SiteId] INT NOT NULL IDENTITY,
	[EmailId] INT NOT NULL,
	[SiteName] VARCHAR(50) NOT NULL,
	[SiteUserName] VARCHAR(50) NOT NULL,
	[SitePassword] VARCHAR(50) NOT NULL,
	CONSTRAINT [PK_Sites] PRIMARY KEY CLUSTERED ([SiteId] ASC),
	CONSTRAINT [PK_Sites_Emails] FOREIGN KEY ([EmailId]) REFERENCES [dbo].[Emails] ([EmailId])
);