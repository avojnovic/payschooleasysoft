/****** Object:  Table [dbo].[Nivels]    Script Date: 10/09/2012 16:06:47 ******/
SET IDENTITY_INSERT [Nivels] ON
INSERT [Nivels] ([Id], [Descripcion], [MontoMatricula], [Descuento]) VALUES (1, N'Nivel1', 100, 0)
INSERT [Nivels] ([Id], [Descripcion], [MontoMatricula], [Descuento]) VALUES (2, N'Nivel2', 50, 0)
INSERT [Nivels] ([Id], [Descripcion], [MontoMatricula], [Descuento]) VALUES (3, N'Nive3', 50, 0)
INSERT [Nivels] ([Id], [Descripcion], [MontoMatricula], [Descuento]) VALUES (4, N'Nivel4', 50, 0)
SET IDENTITY_INSERT [Nivels] OFF
/****** Object:  Table [dbo].[Matriculas]    Script Date: 10/09/2012 16:06:47 ******/
/****** Object:  Table [dbo].[Cuotas]    Script Date: 10/09/2012 16:06:47 ******/
/****** Object:  Table [dbo].[Recargos]    Script Date: 10/09/2012 16:06:47 ******/
/****** Object:  Table [dbo].[Facturas]    Script Date: 10/09/2012 16:06:47 ******/
/****** Object:  Table [dbo].[UserTypes]    Script Date: 10/09/2012 16:06:47 ******/
SET IDENTITY_INSERT [UserTypes] ON
INSERT [UserTypes] ([Id], [Descripcion], [Borrado]) VALUES (1, N'Tutor', 0)
SET IDENTITY_INSERT [UserTypes] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 10/09/2012 16:06:47 ******/
SET IDENTITY_INSERT [Users] ON
INSERT [Users] ([Id], [Dni], [Nombre], [Apellido], [Email], [Psw], [Telefono], [Direccion], [TipoUsuario_Id]) VALUES (3, N'34432323', N'Marcelo', N'Mauri', N'admin@fasta.edu.ar', N'admin', NULL, NULL, 1)
SET IDENTITY_INSERT [Users] OFF
/****** Object:  Table [dbo].[Cursoes]    Script Date: 10/09/2012 16:06:47 ******/
/****** Object:  Table [dbo].[Alumnoes]    Script Date: 10/09/2012 16:06:47 ******/
SET IDENTITY_INSERT [Alumnoes] ON
INSERT [Alumnoes] ([Id], [Dni], [Nombre], [Apellido], [FechaNacimiento], [NroMatricula], [Borrado], [Usuario_Id], [Nivel_Id]) VALUES (2, N'32156412', N'Carlos', N'Gimenez', CAST(0x0000808600000000 AS DateTime), 321564, 0, 3, 1)
INSERT [Alumnoes] ([Id], [Dni], [Nombre], [Apellido], [FechaNacimiento], [NroMatricula], [Borrado], [Usuario_Id], [Nivel_Id]) VALUES (3, N'231321321', N'pepe', N'asdas', CAST(0x0000808600000000 AS DateTime), 321321, 0, 3, 1)
SET IDENTITY_INSERT [Alumnoes] OFF
/****** Object:  Table [dbo].[Pagoes]    Script Date: 10/09/2012 16:06:47 ******/
/****** Object:  Table [dbo].[Inscripcions]    Script Date: 10/09/2012 16:06:47 ******/
