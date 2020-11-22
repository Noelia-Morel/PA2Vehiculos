USE [master]
GO

/****** Object:  Database [EDA3Vehiculos]    Script Date: 21/11/2020 22:44:59 ******/
CREATE DATABASE [EDA3Vehiculos]
 CONTAINMENT = NONE
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EDA3Vehiculos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

USE [EDA3Vehiculos]
GO

/****** Object:  Table [dbo].[Clientes]    Script Date: 21/11/2020 22:46:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[DNI] [bigint] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [EDA3Vehiculos]
GO

/****** Object:  Table [dbo].[Vehiculos]    Script Date: 21/11/2020 22:47:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Vehiculos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](50) NOT NULL,
	[Modelo] [nvarchar](50) NOT NULL,
	[Dominio] [nvarchar](10) NOT NULL,
	[AnioFabricacion] [date] NOT NULL,
	[NroMotor] [nvarchar](50) NOT NULL,
	[FechaIngreso] [date] NOT NULL,
	[ValuacionIngreso] [bigint] NOT NULL,
	[FechaVenta] [date] NOT NULL,
	[PrecioVenta] [bigint] NOT NULL,
	[ClienteId] [int] NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO

ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Clientes]
GO

