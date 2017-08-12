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