USE testlibro
GO
CREATE TABLE [autor]
(
	[id_author] INT PRIMARY KEY IDENTITY(1,1),
	[nombre] VARCHAR(100) NOT NULL
)
GO
CREATE TABLE [libro]
(
	[id_libro] INT PRIMARY KEY IDENTITY(1,1),
	[titulo] VARCHAR(100) NOT NULL,
	[fecha_edicion] DATETIME NOT NULL
 )
GO
CREATE TABLE [autor_libro]
(
	[id_autor] INT FOREIGN KEY REFERENCES [autor]([id_author])NOT NULL,
	[id_libro] INT FOREIGN KEY REFERENCES [libro]([id_libro]) NOT NULL
)
GO