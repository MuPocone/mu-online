USE MuOnline
GO

IF(NOT EXISTS (SELECT * FROM [INFORMATION_SCHEMA].[SCHEMATA] AS [t] WHERE [t].[SCHEMA_NAME] = 'site'))
	BEGIN
		EXEC sp_executesql N'CREATE SCHEMA site'
		PRINT 'Schema site CRIADO com sucesso!'
	END
ELSE	
	PRINT 'Schema site já existe!'
GO

--DROP TABLE [site].[Noticias];
--DROP TABLE [site].[Usuario];
--DROP TABLE [site].[Perfil];
--GO

IF(NOT EXISTS (SELECT * FROM [INFORMATION_SCHEMA].[TABLES] AS [t] WHERE [t].[TABLE_NAME] = 'Perfil'))
	BEGIN
		CREATE TABLE [site].[Perfil] (
			[Id] INT NOT NULL,
			[Descricao] VARCHAR(30) NOT NULL
			CONSTRAINT PK_Perfil PRIMARY KEY ([Id])
		)
		PRINT 'Tabela [Perfil] CRIADA com sucesso!'
		INSERT INTO [site].[Perfil] (Descricao) VALUES ('Usuario'), ('GM'), ('Admin')
	END
ELSE
	PRINT 'Tabela [Perfil] já existe!'	
GO

IF(NOT EXISTS (SELECT * FROM [INFORMATION_SCHEMA].[TABLES] AS [t] WHERE [t].[TABLE_NAME] = 'Usuario'))
	BEGIN
		CREATE TABLE [site].[Usuario] (
			[Id] INT NOT NULL IDENTITY(1,1),
			[AggregateId] UNIQUEIDENTIFIER NOT NULL,
			[Login] VARCHAR(10) NOT NULL,
			[Senha] VARCHAR(20) NOT NULL,
			[Nome] VARCHAR(30) NULL,
			[Email] VARCHAR(80) NOT NULL,
			[Telefone] VARCHAR(15) NULL,
			[DataNascimento] DATETIME NULL,
			[DataCriacao] DATETIME NOT NULL,
			[EmailConfirmado] BIT NOT NULL,
			[Ativo] BIT NOT NULL,
			[PerfilId] INT NOT NULL
			CONSTRAINT PK_Usuario PRIMARY KEY ([Id])
			CONSTRAINT PK_Usuario_Perfil FOREIGN KEY ([PerfilId]) REFERENCES [site].[Perfil] ([Id])
		)
		PRINT 'Tabela [Usuario] CRIADA com sucesso!'
	END
ELSE
	PRINT 'Tabela [Usuario] já existe!'	
GO

IF(NOT EXISTS (SELECT * FROM [INFORMATION_SCHEMA].[TABLES] AS [t] WHERE [t].[TABLE_NAME] = 'Noticias'))
	BEGIN
		CREATE TABLE [site].[Noticias] (
			[Id] INT NOT NULL IDENTITY(1,1),
			[AggregateId] UNIQUEIDENTIFIER NOT NULL,
			[Titulo] VARCHAR(255) NOT NULL,
			[SubTitulo] VARCHAR(255) NULL,
			[Noticia] VARCHAR(MAX) NOT NULL,
			[UsuarioId] INT NOT NULL
			CONSTRAINT PK_Noticia PRIMARY KEY ([Id]),
			CONSTRAINT PK_Noticia_Usuario FOREIGN KEY ([UsuarioId]) REFERENCES [site].[Usuario] ([Id])
		)
		PRINT 'Tabela [Noticias] CRIADA com sucesso!'
	END
ELSE
	PRINT 'Tabela [Noticias] já existe!'	
GO 

