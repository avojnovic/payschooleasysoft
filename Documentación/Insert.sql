USE [SchoolDb]
GO
/****** Object:  Table [dbo].[Nivels]    Script Date: 02/21/2013 15:06:33 ******/
SET IDENTITY_INSERT [dbo].[Nivels] ON
INSERT [dbo].[Nivels] ([Id], [Descripcion], [MontoMatricula], [Descuento]) VALUES (1, N'Nivel 1', 100, 10)
INSERT [dbo].[Nivels] ([Id], [Descripcion], [MontoMatricula], [Descuento]) VALUES (2, N'Nivel 2', 200, 20)
INSERT [dbo].[Nivels] ([Id], [Descripcion], [MontoMatricula], [Descuento]) VALUES (3, N'Nivel 3', 100, 10)
INSERT [dbo].[Nivels] ([Id], [Descripcion], [MontoMatricula], [Descuento]) VALUES (4, N'Nivel 4', 100, 10)
SET IDENTITY_INSERT [dbo].[Nivels] OFF

SET IDENTITY_INSERT [dbo].[UserTypes] ON
INSERT [dbo].[UserTypes] ([Id], [Descripcion], [Borrado]) VALUES (1, N'Admin', 0)
INSERT [dbo].[UserTypes] ([Id], [Descripcion], [Borrado]) VALUES (2, N'Tutor', 0)
SET IDENTITY_INSERT [dbo].[UserTypes] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 02/21/2013 15:06:33 ******/
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([Id], [Dni], [Nombre], [Apellido], [Email], [Psw], [Telefono], [Direccion], [TipoUsuario_Id]) VALUES (2, N'32656546', N'admin', N'admin', N'admin@admin.com', N'admin', N'564', N'465', 1)
INSERT [dbo].[Users] ([Id], [Dni], [Nombre], [Apellido], [Email], [Psw], [Telefono], [Direccion], [TipoUsuario_Id]) VALUES (3, N'56564560', N'tutor', N'tutor', N'tutor@tutor.com', N'tutor', N'564654', N'465654', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[Cursoes]    Script Date: 02/21/2013 15:06:33 ******/
SET IDENTITY_INSERT [dbo].[Cursoes] ON
INSERT [dbo].[Cursoes] ([Id],[Anio], [Cupo], [Nivel_Id]) VALUES (1, N'1ro Nivel 1',10, 1)
INSERT [dbo].[Cursoes] ([Id],[Anio], [Cupo], [Nivel_Id]) VALUES (2, N'2do Nivel 1',20, 1)
INSERT [dbo].[Cursoes] ([Id],[Anio], [Cupo], [Nivel_Id]) VALUES (3, N'1ro Nivel 2',10, 2)
INSERT [dbo].[Cursoes] ([Id],[Anio], [Cupo], [Nivel_Id]) VALUES (4, N'2do Nivel 2',20, 2)
INSERT [dbo].[Cursoes] ([Id],[Anio], [Cupo], [Nivel_Id]) VALUES (5, N'1ro Nivel 3',10, 3)
INSERT [dbo].[Cursoes] ([Id],[Anio], [Cupo], [Nivel_Id]) VALUES (6, N'2do Nivel 3',20, 3)
INSERT [dbo].[Cursoes] ([Id],[Anio], [Cupo], [Nivel_Id]) VALUES (7, N'1ro Nivel 4',10, 4)
INSERT [dbo].[Cursoes] ([Id],[Anio], [Cupo], [Nivel_Id]) VALUES (8, N'2do Nivel 4',20, 4)
SET IDENTITY_INSERT [dbo].[Cursoes] OFF
/****** Object:  Table [dbo].[Alumnoes]    Script Date: 02/21/2013 15:06:33 ******/
SET IDENTITY_INSERT [dbo].[Alumnoes] ON
INSERT [dbo].[Alumnoes] ([Id], [Dni], [Nombre], [Apellido], [FechaNacimiento], [NroMatricula], [Borrado], [Usuario_Id]) VALUES (1, N'11111111', N'Alumno1', N'Apellido', CAST(0x0000812800000000 AS DateTime), 544, 0, NULL)
INSERT [dbo].[Alumnoes] ([Id], [Dni], [Nombre], [Apellido], [FechaNacimiento], [NroMatricula], [Borrado], [Usuario_Id]) VALUES (2, N'22222222', N'Alumno2', N'Apellido', CAST(0x0000812800000000 AS DateTime), 234, 0, NULL)
INSERT [dbo].[Alumnoes] ([Id], [Dni], [Nombre], [Apellido], [FechaNacimiento], [NroMatricula], [Borrado], [Usuario_Id]) VALUES (3, N'33333333', N'Alumno3', N'Apellido', CAST(0x0000812800000000 AS DateTime), 234, 0, NULL)
INSERT [dbo].[Alumnoes] ([Id], [Dni], [Nombre], [Apellido], [FechaNacimiento], [NroMatricula], [Borrado], [Usuario_Id]) VALUES (4, N'44444444', N'Alumno4', N'Apellido', CAST(0x0000A15D00000000 AS DateTime), 21330000, 0, NULL)
SET IDENTITY_INSERT [dbo].[Alumnoes] OFF
/****** Object:  Table [dbo].[Pagoes]    Script Date: 02/21/2013 15:06:33 ******/
/****** Object:  Table [dbo].[Inscripcions]    Script Date: 02/21/2013 15:06:33 ******/
