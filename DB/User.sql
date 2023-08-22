IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='User' and xtype='U')
	 CREATE TABLE [dbo].[User](Username VARCHAR(50) NOT NULL ,Password VARCHAR(MAX) NOT NULL,
	 PRIMARY KEY (Username));
GO

IF NOT EXISTS(SELECT 1 FROM dbo.[User] WHERE Username = 'usuario_fiap')
	INSERT [dbo].[User] values ('usuario_fiap', 'senha_fiap')