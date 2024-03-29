USE [payschooleasysoft_SchoolDb]
GO
/****** Object:  Table [dbo].[Recargos]    Script Date: 02/22/2013 09:56:29 ******/

/****** Object:  Table [dbo].[Nivels]    Script Date: 02/22/2013 09:56:29 ******/
SET IDENTITY_INSERT [dbo].[Nivels] ON
INSERT [dbo].[Nivels] ([Id], [Descripcion],[EdadMinima],[EdadMaxima],[Descuento],[RecargoPrimerVencimiento],[RecargoSegundoVencimiento]) VALUES (1, N'Inicial',0,8,3,3,5)
INSERT [dbo].[Nivels] ([Id], [Descripcion],[EdadMinima],[EdadMaxima],[Descuento],[RecargoPrimerVencimiento],[RecargoSegundoVencimiento]) VALUES (2, N'Primario',9,14,3,3,5)
INSERT [dbo].[Nivels] ([Id], [Descripcion],[EdadMinima],[EdadMaxima],[Descuento],[RecargoPrimerVencimiento],[RecargoSegundoVencimiento]) VALUES (3, N'Secundario',15,18,5,3,5)

SET IDENTITY_INSERT [dbo].[Nivels] OFF

/****** Object:  Table [dbo].[Cuotas]    Script Date: 02/22/2013 09:56:29 ******/

SET IDENTITY_INSERT [dbo].[Cuotas] ON
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (1, 2013, 1, 200, '2013-01-01 00:00:00', '2013-01-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (2, 2013, 2, 200, '2013-02-01 00:00:00', '2013-02-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (3, 2013, 3, 200, '2013-03-01 00:00:00', '2013-03-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (4, 2013, 4, 200, '2013-04-01 00:00:00', '2013-04-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (5, 2013, 5, 200, '2013-05-01 00:00:00', '2013-05-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (6, 2013, 6, 200, '2013-06-01 00:00:00', '2013-06-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (7, 2013, 7, 200, '2013-07-01 00:00:00', '2013-07-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (8, 2013, 8, 200, '2013-08-01 00:00:00', '2013-08-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (9, 2013, 9, 200, '2013-09-01 00:00:00', '2013-09-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (10, 2013, 10, 200, '2013-10-01 00:00:00', '2013-10-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (11, 2013, 11, 200, '2013-11-01 00:00:00', '2013-11-10 00:00:00',1)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (12, 2013, 12, 200, '2013-12-01 00:00:00', '2013-12-10 00:00:00',1)

INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (13, 2013, 1, 200, '2013-01-01 00:00:00', '2013-01-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (14, 2013, 2, 200, '2013-02-01 00:00:00', '2013-02-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (15, 2013, 3, 200, '2013-03-01 00:00:00', '2013-03-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (16, 2013, 4, 200, '2013-04-01 00:00:00', '2013-04-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (17, 2013, 5, 200, '2013-05-01 00:00:00', '2013-05-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (18, 2013, 6, 200, '2013-06-01 00:00:00', '2013-06-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (19, 2013, 7, 200, '2013-07-01 00:00:00', '2013-07-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (20, 2013, 8, 200, '2013-08-01 00:00:00', '2013-08-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (21, 2013, 9, 200, '2013-09-01 00:00:00', '2013-09-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (22, 2013, 10, 200, '2013-10-01 00:00:00', '2013-10-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (23, 2013, 11, 200, '2013-11-01 00:00:00', '2013-11-10 00:00:00',2)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (24, 2013, 12, 200, '2013-12-01 00:00:00', '2013-12-10 00:00:00',2)

INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (25, 2013, 1, 200, '2013-01-01 00:00:00', '2013-01-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (26, 2013, 2, 200, '2013-02-01 00:00:00', '2013-02-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (27, 2013, 3, 200, '2013-03-01 00:00:00', '2013-03-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (28, 2013, 4, 200, '2013-04-01 00:00:00', '2013-04-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (29, 2013, 5, 200, '2013-05-01 00:00:00', '2013-05-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (30, 2013, 6, 200, '2013-06-01 00:00:00', '2013-06-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (31, 2013, 7, 200, '2013-07-01 00:00:00', '2013-07-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (32, 2013, 8, 200, '2013-08-01 00:00:00', '2013-08-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (33, 2013, 9, 200, '2013-09-01 00:00:00', '2013-09-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (34, 2013, 10, 200, '2013-10-01 00:00:00', '2013-10-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (35, 2013, 11, 200, '2013-11-01 00:00:00', '2013-11-10 00:00:00',3)
INSERT [dbo].[Cuotas] ([Id], [Anio], [Mes], [MontoCuota], [FechaVenc1], [FechaVenc2],[Nivel_Id]) VALUES (36, 2013, 12, 200, '2013-12-01 00:00:00', '2013-12-10 00:00:00',3)

SET IDENTITY_INSERT [dbo].[Cuotas] OFF
/****** Object:  Table [dbo].[Facturas]    Script Date: 02/22/2013 09:56:29 ******/

/****** Object:  Table [dbo].[Matriculas]    Script Date: 02/22/2013 09:56:29 ******/
SET IDENTITY_INSERT [dbo].[Matriculas] ON
INSERT [dbo].[Matriculas] ([Id], [Anio], [Monto], [Descuento],[Nivel_Id]) VALUES (1, 2013, 500, 10,1)
INSERT [dbo].[Matriculas] ([Id], [Anio], [Monto], [Descuento],[Nivel_Id]) VALUES (2, 2013, 500, 10,2)
INSERT [dbo].[Matriculas] ([Id], [Anio], [Monto], [Descuento],[Nivel_Id]) VALUES (3, 2013, 500, 10,3)
SET IDENTITY_INSERT [dbo].[Matriculas] OFF
/****** Object:  Table [dbo].[UserTypes]    Script Date: 02/22/2013 09:56:29 ******/
SET IDENTITY_INSERT [dbo].[UserTypes] ON
INSERT [dbo].[UserTypes] ([Id], [Descripcion], [Borrado]) VALUES (1, N'Admin', 0)
INSERT [dbo].[UserTypes] ([Id], [Descripcion], [Borrado]) VALUES (2, N'Tutor', 0)
SET IDENTITY_INSERT [dbo].[UserTypes] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 02/22/2013 09:56:29 ******/
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([Id], [Dni], [Nombre], [Apellido], [Email], [Psw], [Telefono], [Direccion], [TipoUsuario_Id]) VALUES (1, N'32656546', N'admin', N'admin', N'admin@admin.com', N'admin', N'564', N'465', 1)
INSERT [dbo].[Users] ([Id], [Dni], [Nombre], [Apellido], [Email], [Psw], [Telefono], [Direccion], [TipoUsuario_Id]) VALUES (2, N'56564560', N'tutor', N'tutor', N'tutor@tutor.com', N'tutor', N'564654', N'465654', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[Cursoes]    Script Date: 02/22/2013 09:56:29 ******/
SET IDENTITY_INSERT [dbo].[Cursoes] ON
INSERT [dbo].[Cursoes] ([Id], [Anio], [Cupo], [Nivel_Id]) VALUES (1, N'1ro', 10, 1)
INSERT [dbo].[Cursoes] ([Id], [Anio], [Cupo], [Nivel_Id]) VALUES (2, N'2do', 10, 1)
INSERT [dbo].[Cursoes] ([Id], [Anio], [Cupo], [Nivel_Id]) VALUES (3, N'1ro', 10, 2)
INSERT [dbo].[Cursoes] ([Id], [Anio], [Cupo], [Nivel_Id]) VALUES (4, N'2do', 10, 2)
INSERT [dbo].[Cursoes] ([Id], [Anio], [Cupo], [Nivel_Id]) VALUES (5, N'1ro', 10, 3)
INSERT [dbo].[Cursoes] ([Id], [Anio], [Cupo], [Nivel_Id]) VALUES (6, N'2do', 10, 3)
INSERT [dbo].[Cursoes] ([Id], [Anio], [Cupo], [Nivel_Id]) VALUES (7, N'3ro', 10, 3)

SET IDENTITY_INSERT [dbo].[Cursoes] OFF
/****** Object:  Table [dbo].[Alumnoes]    Script Date: 02/22/2013 09:56:29 ******/
SET IDENTITY_INSERT [dbo].[Alumnoes] ON
INSERT [dbo].[Alumnoes] ([Id], [Dni], [Nombre], [Apellido], [FechaNacimiento], [Borrado], [Usuario_Id]) VALUES (1, N'11111111', N'Alumno1', N'Apellido', '2000-01-10 00:00:00',  0, 2)
INSERT [dbo].[Alumnoes] ([Id], [Dni], [Nombre], [Apellido], [FechaNacimiento], [Borrado], [Usuario_Id]) VALUES (2, N'22222222', N'Alumno2', N'Apellido', '2005-01-10 00:00:00',  0, 2)
SET IDENTITY_INSERT [dbo].[Alumnoes] OFF
/****** Object:  Table [dbo].[Pagoes]    Script Date: 02/22/2013 09:56:29 ******/
/****** Object:  Table [dbo].[Inscripcions]    Script Date: 02/22/2013 09:56:29 ******/
