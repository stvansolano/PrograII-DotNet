/*** USE [SQLprogra2Azure] ***/
USE [Cafeteria]
GO
CREATE TABLE [dbo].[Clientes] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]          NVARCHAR (MAX) NOT NULL,
    [PrimerApellido]  NVARCHAR (MAX) NOT NULL,
    [SegundoApellido] NVARCHAR (MAX) NOT NULL,
    [Telefono]        NVARCHAR (MAX) NULL
);
GO
INSERT INTO Clientes (Nombre, PrimerApellido, SegundoApellido, Telefono) VALUES ('Esteban', 'Solano', 'Granados', '555-5555')
GO
CREATE TABLE [dbo].[Productos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Precio] [float] NULL,
 CONSTRAINT [PK_Productos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT INTO Productos (Nombre, Cantidad, Descripcion, Precio) VALUES ('Cafe cappuchino', '10', 'Cafe cappuchino sencillo', 1000)
