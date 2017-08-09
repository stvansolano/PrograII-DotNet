/*** USE [SQLprogra2Azure] ***/
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [Nombre]          NVARCHAR (MAX) NOT NULL,
    [PrimerApellido]  NVARCHAR (MAX) NOT NULL,
    [SegundoApellido] NVARCHAR (MAX) NOT NULL,
    [Telefono]        NVARCHAR (MAX) NULL
);