IF(db_id(N'aula01') IS NULL)
BEGIN 
CREATE DATABASE aula01
END
GO

USE aula01
GO
BEGIN
	IF NOT EXISTS (SELECT * FROM sysobjects WHERE NAME = 'Usuario' AND xtype='U')
	    CREATE TABLE [aula01].dbo.[Usuario] (
	        IdUsuario INT NOT NULL IDENTITY (1,1),
			Nome VARCHAR (50),
			Email VARCHAR (50),
			Senha VARCHAR (200),
			PRIMARY KEY(IdUsuario)
	    );
END

SELECT * FROM USUARIO