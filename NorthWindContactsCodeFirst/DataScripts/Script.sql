USE [NorthWindAzureForInserts]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 7/15/2019 4:40:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ContactType]    Script Date: 7/15/2019 4:40:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactType](
	[ContactTypeIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[ContactTitle] [nvarchar](max) NULL,
 CONSTRAINT [PK_ContactType] PRIMARY KEY CLUSTERED 
(
	[ContactTypeIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 7/15/2019 4:40:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/15/2019 4:40:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerIdentifier] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[ContactName] [nvarchar](30) NULL,
	[ContactId] [int] NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[CountryIdentifier] [int] NULL,
	[Phone] [nvarchar](24) NULL,
	[Fax] [nvarchar](24) NULL,
	[ContactTypeIdentifier] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL CONSTRAINT [DF_Customers_ModifiedDate]  DEFAULT (getdate()),
 CONSTRAINT [PK_Customers_1] PRIMARY KEY CLUSTERED 
(
	[CustomerIdentifier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (1, N'Maria', N'Anders')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (2, N'Ana', N'Trujillo')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (3, N'Antonio', N'Moreno')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (4, N'Thomas', N'Hardy')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (5, N'Christina', N'Berglund')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (6, N'Hanna', N'Moos')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (7, N'Frédérique', N'Citeaux')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (8, N'Martín', N'Sommer')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (9, N'Laurence', N'Lebihan')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (10, N'Victoria', N'Ashworth')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (11, N'Patricio', N'Simpson')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (12, N'Francisco', N'Chang')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (13, N'Yang', N'Wang')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (14, N'Elizabeth', N'Brown')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (15, N'Sven', N'Ottlieb')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (16, N'Janine', N'Labrune')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (17, N'Ann', N'Devon')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (18, N'Roland', N'Mendel')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (19, N'Diego', N'Roel')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (20, N'Martine', N'Rancé')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (21, N'Maria', N'Larsson')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (22, N'Peter', N'Franken')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (23, N'Carine', N'Schmitt')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (24, N'Paolo', N'Accorti')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (25, N'Lino', N'Rodriguez')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (26, N'Eduardo', N'Saavedra')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (27, N'José', N'Pedro Freyre')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (28, N'Philip', N'Cramer')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (29, N'Daniel', N'Tonini')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (30, N'Annette', N'Roulet')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (31, N'Renate', N'Messner')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (32, N'Giovanni', N'Rovelli')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (33, N'Catherine', N'Dewey')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (34, N'Alexander', N'Feuer')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (35, N'Simon', N'Crowther')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (36, N'Yvonne', N'Moncada')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (37, N'Henriette', N'Pfalzheim')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (38, N'Marie', N'Bertrand')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (39, N'Guillermo', N'Fernández')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (40, N'Georg', N'Pipps')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (41, N'Isabel', N'de Castro')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (42, N'Horst', N'Kloss')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (43, N'Sergio', N'Gutiérrez')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (44, N'Maurizio', N'Moroni')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (45, N'Michael', N'Holz')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (46, N'Alejandra', N'Camino')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (47, N'Jonas', N'Bergulfsen')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (48, N'Hari', N'Kumar')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (49, N'Jytte', N'Petersen')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (50, N'Dominique', N'Perrier')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (51, N'Pascale', N'Cartrain')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (52, N'Karin', N'Josephs')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (53, N'Miguel', N'Angel Paolino')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (54, N'Palle', N'Ibsen')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (55, N'Mary', N'Saveley')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (56, N'Paul', N'Henriot')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (57, N'Rita', N'Müller')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (58, N'Pirkko', N'Koskitalo')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (59, N'Matti', N'Karttunen')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (60, N'Zbyszek', N'Piestrzeniewicz')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (61, N'Rene', N'Phillips')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (62, N'Elizabeth', N'Lincoln')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (63, N'Yoshi', N'Tannamuri')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (64, N'Jaime', N'Yorres')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (65, N'Patricia', N'McKenna')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (66, N'Manuel', N'Pereira')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (67, N'Jose', N'Pavarotti')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (68, N'Helen', N'Bennett')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (69, N'Carlos', N'González')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (70, N'Liu', N'Wong')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (71, N'Paula', N'Wilson')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (72, N'Felipe', N'Izquierdo')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (73, N'Howard', N'Snyder')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (74, N'Yoshi', N'Latimer')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (75, N'Fran', N'Wilson')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (76, N'Liz', N'Nixon')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (77, N'Jean', N'Fresnière')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (78, N'Mario', N'Pontes')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (79, N'Bernardo', N'Batista')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (80, N'Janete', N'Limeira')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (81, N'Pedro', N'Afonso')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (82, N'Aria', N'Cruz')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (83, N'André', N'Fonseca')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (84, N'Lúcia', N'Carvalho')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (85, N'Anabela', N'Domingues')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (86, N'Paula', N'Parente')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (87, N'Carlos', N'Hernández')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (88, N'John', N'Steel')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (89, N'Helvetius', N'Nagy')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (90, N'Karl', N'Jablonski')
INSERT [dbo].[Contacts] ([ContactId], [FirstName], [LastName]) VALUES (91, N'Art', N'Braunschweiger')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
SET IDENTITY_INSERT [dbo].[ContactType] ON 

INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (1, N'Accounting Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (2, N'Assistant Sales Agent')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (3, N'Assistant Sales Representative')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (4, N'Marketing Assistant')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (5, N'Marketing Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (6, N'Order Administrator')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (7, N'Owner')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (8, N'Owner/Marketing Assistant')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (9, N'Sales Agent')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (10, N'Sales Associate')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (11, N'Sales Manager')
INSERT [dbo].[ContactType] ([ContactTypeIdentifier], [ContactTitle]) VALUES (12, N'Sales Representative')
SET IDENTITY_INSERT [dbo].[ContactType] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (1, N'Argentina')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (2, N'Austria')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (3, N'Belgium')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (4, N'
Brazil')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (5, N'Canada')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (6, N'Denmark')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (7, N'Finland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (8, N'France')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (9, N'Germany')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (10, N'Ireland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (11, N'Italy')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (12, N'Mexico')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (13, N'Norway')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (14, N'Poland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (15, N'Portugal')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (16, N'Spain')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (17, N'Sweden')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (18, N'Switzerland')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (19, N'UK')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (20, N'USA')
INSERT [dbo].[Countries] ([CountryIdentifier], [Name]) VALUES (21, N'Venezuela')
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (1, N'Alfreds Futterkiste', N'Maria Anders', 1, N'Obere Sr. 570', N'Berlin', NULL, N'12209', 9, N'030-0074321', N'030-0076545', 1, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (2, N'Ana Trujillo Emparedados y helados', N'Ana Trujillo', 2, N'Avda. de la Constitución 2222', N'México D.F.', NULL, N'05021', 12, N'(5) 555-4729', N'(5) 555-3745', 7, CAST(N'2018-11-04 01:30:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (3, N'Antonio Moreno Taquería', N'Antonio Moreno', 3, N'Mataderos  231', N'México D.F.', NULL, N'05023', 12, N'(5) 555-3932', NULL, 7, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (4, N'Around the Horn', N'Thomas Hardy', 4, N'120 Hanover Sq.', N'London', NULL, N'WA1 1DP', 19, N'(171) 555-7788', N'(171) 555-6750', 12, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (5, N'Berglunds snabbköp', N'Christina Berglund', 5, N'Berguvsvägen  8', N'Luleå', NULL, N'S-958 22', 17, N'0921-12 34 65', N'0921-12 34 67', 6, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (6, N'Blauer See Delikatessen', N'Frédérique Citeaux', 7, N'Forsterstr. 57', N'Mannheim', NULL, N'68306', 9, N'0621-08460', N'0621-08924', 12, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (7, N'Blondesddsl père et fils', N'Frédérique Citeaux', 7, N'24, place Kléber', N'Strasbourg', NULL, N'67000', 8, N'88.60.15.31', N'88.60.15.32', 5, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (8, N'Bólido Comidas preparadas', N'Martín Sommer', 8, N'C/ Araquil, 67', N'Madrid', NULL, N'28023', 16, N'(91) 555 22 82', N'(91) 555 91 99', 7, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (9, N'Bon app', N'Victoria Ashworth', 9, N'12, rue des Bouchers', N'Marseille', NULL, N'13008', 1, N'91.24.45.40', N'91.24.45.41', 10, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (10, N'B''s Beverages', N'Victoria Ashworth', 10, N'Fauntleroy Circus', N'London', NULL, N'EC2 5NT', 12, N'(171) 555-1212', NULL, 12, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (11, N'Cactus Comidas para llevar', N'Patricio Simpson', 11, N'Cerrito 333', N'Buenos Aires', NULL, N'1010', 19, N'(1) 135-5555', N'(1) 135-4892', 9, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (12, N'Centro comercial Moctezuma', N'Francisco Chang', 12, N'Sierras de Granada 9993', N'México D.F.', NULL, N'05022', 1, N'(5) 555-3392', N'(5) 555-7293', 5, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (13, N'Chop-suey Chinese', N'Yang Wang', 13, N'Hauptstr. 29', N'Bern', NULL, N'3012', 12, N'0452-076545', NULL, 7, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (14, N'Consolidated Holdings', N'Elizabeth Brown', 14, N'Berkeley Gardens 12  Brewery', N'London', NULL, N'WX1 6LT', 19, N'(171) 555-2282', N'(171) 555-9199', 12, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (15, N'Drachenblut Delikatessen', N'Sven Ottlieb', 15, N'Walserweg 21', N'Aachen', NULL, N'52066', 9, N'0241-039123', N'0241-059428', 6, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (16, N'Du monde entier', N'Janine Labrune', 16, N'67, rue des Cinquante Otages', N'Nantes', NULL, N'44000', 8, N'40.67.88.88', N'40.67.89.89', 7, CAST(N'2018-07-04 13:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (17, N'Eastern Connection', N'Ann Devon', 17, N'35 King George', N'London', NULL, N'WX3 6FW', 19, N'(171) 555-0297', N'(171) 555-3373', 9, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (18, N'Ernst Handel', N'Roland Mendel', 18, N'Kirchgasse 6', N'Graz', NULL, N'8010', 2, N'7675-3425', N'7675-3426', 11, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (19, N'FISSA Fabrica Inter. Salchichas S.A.', N'Diego Roel', 19, N'C/ Moralzarzal, 86', N'Madrid', NULL, N'28034', 16, N'(91) 555 94 44', N'(91) 555 55 93', 1, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (20, N'Folies gourmandes', N'Martine Rancé', 20, N'184, chaussée de Tournai', N'Lille', NULL, N'59000', 8, N'20.16.10.16', N'20.16.10.17', 2, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (21, N'Folk och fä HB', N'Maria Larsson', 21, N'Åkergatan 24', N'Bräcke', NULL, N'S-844 67', 17, N'0695-34 67 21', NULL, 7, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (22, N'Frankenversand', N'Peter Franken', 22, N'Berliner Platz 43', N'München', NULL, N'80805', 9, N'089-0877310', N'089-0877451', 5, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (23, N'France restauration', N'Carine Schmitt', 23, N'54, rue Royale', N'Nantes', NULL, N'44000', 8, N'40.32.21.21', N'40.32.21.20', 5, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (24, N'Franchi S.p.A.', N'Paolo Accorti', 24, N'Via Monte Bianco 34', N'Torino', NULL, N'10100', 11, N'011-4988260', N'011-4988261', 12, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (25, N'Furia Bacalhau e Frutos do Mar', N'Lino Rodriguez', 25, N'Jardim das rosas n. 32', N'Lisboa', NULL, N'1675', 15, N'(1) 354-2534', N'(1) 354-2535', 11, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (26, N'Galería del gastrónomo', N'Eduardo Saavedra', 26, N'Rambla de Cataluña, 23', N'Barcelona', NULL, N'08022', 16, N'(93) 203 4560', N'(93) 203 4561', 5, CAST(N'2017-06-04 05:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (27, N'Godos Cocina Típica', N'José Pedro Freyre', 27, N'C/ Romero, 33', N'Sevilla', NULL, N'41101', 16, N'(95) 555 82 82', NULL, 11, CAST(N'2017-06-04 05:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (28, N'Königlich Essen', N'Philip Cramer', 28, N'Maubelstr. 90', N'Brandenburg', NULL, N'14776', 9, N'0555-09876', NULL, 10, CAST(N'2017-06-04 05:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (29, N'La corne d''abondance', N'Daniel Tonini', 29, N'67, avenue de l''Europe', N'Versailles', NULL, N'78000', 8, N'30.59.84.10', N'30.59.85.11', 12, CAST(N'2017-06-04 05:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (30, N'La maison d''Asie', N'Annette Roulet', 30, N'1 rue Alsace-Lorraine', N'Toulouse', NULL, N'31000', 8, N'61.77.61.10', N'61.77.61.11', 11, CAST(N'2017-06-04 05:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (31, N'Lehmanns Marktstand', N'Renate Messner', 31, N'Magazinweg 7', N'Frankfurt a.M.', NULL, N'60528', 9, N'069-0245984', N'069-0245874', 12, CAST(N'2017-06-04 05:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (32, N'Magazzini Alimentari Riuniti', N'Giovanni Rovelli', 32, N'Via Ludovico il Moro 22', N'Bergamo', NULL, N'24100', 11, N'035-640230', N'035-640231', 5, CAST(N'2017-06-04 05:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (33, N'Maison Dewey', N'Catherine Dewey', 33, N'Rue Joseph-Bens 532', N'Bruxelles', NULL, N'B-1180', 3, N'(02) 201 24 67', N'(02) 201 24 68', 9, CAST(N'2017-06-04 05:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (34, N'Morgenstern Gesundkost', N'Alexander Feuer', 34, N'Heerstr. 22', N'Leipzig', NULL, N'04179', 9, N'0342-023176', NULL, 4, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (35, N'North/South', N'Simon Crowther', 35, N'South House 300 Queensbridge', N'London', NULL, N'SW7 1RZ', 19, N'(171) 555-7733', N'(171) 555-2530', 10, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (36, N'Océano Atlántico Ltda.', N'Yvonne Moncada', 36, N'Ing. Gustavo Moncada 8585 Piso 20-A', N'Buenos Aires', NULL, N'1010', 1, N'(1) 135-5333', N'(1) 135-5535', 9, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (37, N'Ottilies Käseladen', N'Henriette Pfalzheim', 37, N'Mehrheimerstr. 369', N'Köln', NULL, N'50739', 9, N'0221-0644327', N'0221-0765721', 7, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (38, N'Paris spécialités', N'Marie Bertrand', 38, N'265, boulevard Charonne', N'Paris', NULL, N'75012', 8, N'(1) 42.34.22.66', N'(1) 42.34.22.77', 7, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (39, N'Pericles Comidas clásicas', N'Guillermo Fernández', 39, N'Calle Dr. Jorge Cash 321', N'México D.F.', NULL, N'05033', 12, N'(5) 552-3745', N'(5) 545-3745', 12, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (40, N'Piccolo und mehr', N'Georg Pipps', 40, N'Geislweg 14', N'Salzburg', NULL, N'5020', 2, N'6562-9722', N'6562-9723', 11, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (41, N'Princesa Isabel Vinhos', N'Isabel de Castro', 41, N'Estrada da saúde n. 58', N'Lisboa', NULL, N'1756', 15, N'(1) 356-5634', NULL, 12, CAST(N'2018-08-04 16:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (42, N'QUICK Stop', N'Horst Kloss', 42, N'Taucherstraße 10', N'Cunewalde', NULL, N'01307', 9, N'0372-035188', NULL, 1, CAST(N'2018-01-11 04:07:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (43, N'Rancho grande', N'Sergio Gutiérrez', 43, N'Av. del Libertador 900', N'Buenos Aires', NULL, N'1010', 1, N'(1) 123-5555', N'(1) 123-5556', 12, CAST(N'2018-01-11 04:07:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (44, N'Reggiani Caseifici', N'Maurizio Moroni', 44, N'Strada Provinciale 124', N'Reggio Emilia', NULL, N'42100', 11, N'0522-556721', N'0522-556722', 10, CAST(N'2018-01-11 04:07:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (45, N'Richter Supermarkt', N'Michael Holz', 45, N'Grenzacherweg 237', N'Genève', NULL, N'1203', 18, N'0897-034214', NULL, 11, CAST(N'2018-01-11 04:07:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (46, N'Romero y tomillo', N'Alejandra Camino', 46, N'Gran Vía, 1', N'Madrid', NULL, N'28001', 16, N'(91) 745 6200', N'(91) 745 6210', 1, CAST(N'2018-01-11 04:07:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (47, N'Santé Gourmet', N'Jonas Bergulfsen', 47, N'Erling Skakkes gate 78', N'Stavern', NULL, N'4110', 13, N'07-98 92 35', N'07-98 92 47', 7, CAST(N'2018-01-11 04:07:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (48, N'Seven Seas Imports', N'Hari Kumar', 48, N'90 Wadhurst Rd.', N'London', NULL, N'OX15 4NB', 19, N'(171) 555-1717', N'(171) 555-5646', 11, CAST(N'2018-01-11 04:07:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (49, N'Simons bistro', N'Jytte Petersen', 49, N'Vinbæltet 34', N'Kobenhavn', NULL, N'1734', 6, N'31 12 34 56', N'31 13 35 57', 7, CAST(N'2018-01-11 04:07:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (50, N'Spécialités du monde', N'Dominique Perrier', 50, N'25, rue Lauriston', N'Paris', NULL, N'75016', 8, N'(1) 47.55.60.10', N'(1) 47.55.60.20', 5, CAST(N'2018-09-11 09:11:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (51, N'Suprêmes délices', N'Pascale Cartrain', 51, N'Boulevard Tirou, 255', N'Charleroi', NULL, N'B-6000', 3, N'(071) 23 67 22 20', N'(071) 23 67 22 21', 1, CAST(N'2018-09-11 09:11:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (52, N'Toms Spezialitäten', N'Karin Josephs', 52, N'Luisenstr. 48', N'Münster', NULL, N'44087', 9, N'0251-031259', N'0251-035695', 5, CAST(N'2018-09-11 09:11:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (53, N'Tortuga Restaurante', N'Miguel Angel Paolino', 53, N'Avda. Azteca 123', N'México D.F.', NULL, N'05033', 12, N'(5) 555-2933', NULL, 7, CAST(N'2018-09-11 09:11:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (54, N'Vaffeljernet', N'Palle Ibsen', 54, N'Smagsloget 45', N'Århus', NULL, N'8200', 6, N'86 21 32 43', N'86 22 33 44', 11, CAST(N'2018-09-11 09:11:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (55, N'Victuailles en stock', N'Mary Saveley', 55, N'2, rue du Commerce', N'Lyon', NULL, N'69004', 8, N'78.32.54.86', N'78.32.54.87', 9, CAST(N'2018-09-11 09:11:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (56, N'Vins et alcools Chevalier', N'Paul Henriot', 56, N'59 rue de l''Abbaye', N'Reims', NULL, N'51100', 8, N'26.47.15.10', N'26.47.15.11', 1, CAST(N'2018-09-11 09:11:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (57, N'Die Wandernde Kuh', N'Rita Müller', 57, N'Adenauerallee 900', N'Stuttgart', NULL, N'70563', 9, N'0711-020361', N'0711-035428', 12, CAST(N'2017-02-11 06:55:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (58, N'Wartian Herkku', N'Pirkko Koskitalo', 58, N'Torikatu 38', N'Oulu', NULL, N'90110', 7, N'981-443655', N'981-443655', 1, CAST(N'2017-02-11 06:55:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (59, N'Wilman Kala', N'Matti Karttunen', 59, N'Keskuskatu 45', N'Helsinki', NULL, N'21240', 20, N'90-224 8858', N'90-224 8858', 8, CAST(N'2017-02-11 06:55:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (60, N'Wolski  Zajazd', N'Zbyszek Piestrzeniewicz', 60, N'ul. Filtrowa 68', N'Warszawa', NULL, N'01-012', 14, N'(26) 642-7012', N'(26) 642-7012', 7, CAST(N'2017-02-11 06:55:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (61, N'Old World Delicatessen', N'Rene Phillips', 61, N'2743 Bering St.', N'Anchorage', N'AK', N'99508', 20, N'(907) 555-7584', N'(907) 555-2880', 12, CAST(N'2017-02-11 06:55:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (62, N'Bottom-Dollar Markets', N'Elizabeth Lincoln', 62, N'23 Tsawassen Blvd.', N'Tsawassen', N'BC', N'T2F 8M4', 5, N'(604) 555-4729', N'(604) 555-3745', 1, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (63, N'Laughing Bacchus Wine Cellars', N'Yoshi Tannamuri', 63, N'1900 Oak St.', N'Vancouver', N'BC', N'V3F 2K1', 5, N'(604) 555-3392', N'(604) 555-7293', 4, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (64, N'Let''s Stop N Shop', N'Jaime Yorres', 64, N'87 Polk St. Suite 5', N'San Francisco', N'CA', N'94117', 20, N'(415) 555-5938', NULL, 7, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (65, N'Hungry Owl All-Night Grocers', N'Patricia McKenna', 65, N'8 Johnstown Road', N'Cork', N'Co. Cork', NULL, 20, N'2967 542', N'2967 3333', 10, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (66, N'GROSELLA-Restaurante', N'Manuel Pereira', 66, N'5ª Ave. Los Palos Grandes', N'Caracas', N'DF', N'1081', 21, N'(2) 283-2951', N'(2) 283-3397', 7, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (67, N'Save-a-lot Markets', N'Jose Pavarotti', 67, N'187 Suffolk Ln.', N'Boise', N'ID', N'83720', 20, N'(208) 555-8097', NULL, 12, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (68, N'Island Trading', N'Helen Bennett', 68, N'Garden House Crowther Way', N'Cowes', N'Isle of Wight', N'PO31 7PJ', 19, N'(198) 555-8888', NULL, 5, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (69, N'LILA-Supermercado', N'Carlos González', 69, N'Carrera 52 con Ave. Bolívar #65-98 Llano Largo', N'Barquisimeto', N'Lara', N'3508', 21, N'(9) 331-6954', N'(9) 331-7256', 1, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (70, N'The Cracker Box', N'Liu Wong', 70, N'55 Grizzly Peak Rd.', N'Butte', N'MT', N'59801', 20, N'(406) 555-5834', N'(406) 555-8083', 4, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (71, N'Rattlesnake Canyon Grocery', N'Paula Wilson', 71, N'2817 Milton Dr.', N'Albuquerque', N'NM', N'87110', 20, N'(505) 555-5939', N'(505) 555-3620', 3, CAST(N'2016-02-03 09:35:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (72, N'LINO-Delicateses', N'Felipe Izquierdo', 72, N'Ave. 5 de Mayo Porlamar', N'I. de Margarita', N'Nueva Esparta', N'4980', 21, N'(8) 34-56-12', N'(8) 34-93-93', 7, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (73, N'Great Lakes Food Market', N'Howard Snyder', 73, N'2732 Baker Blvd.', N'Eugene', N'OR', N'97403', 20, N'(503) 555-7555', NULL, 5, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (74, N'Hungry Coyote Import Store', N'Yoshi Latimer', 74, N'City Center Plaza 516 Main St.', N'Elgin', N'OR', N'97827', 20, N'(503) 555-6874', N'(503) 555-2376', 12, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (75, N'Lonesome Pine Restaurant', N'Fran Wilson', 75, N'89 Chiaroscuro Rd.', N'Portland', N'OR', N'97219', 20, N'(503) 555-9573', N'(503) 555-9646', 11, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (76, N'The Big Cheese', N'Liz Nixon', 76, N'89 Jefferson Way Suite 2', N'Portland', N'OR', N'97201', 20, N'(503) 555-3612', NULL, 5, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (77, N'Mère Paillarde', N'Jean Fresnière', 77, N'43 rue St. Laurent', N'Montréal', N'Québec', N'H1J 1C3', 5, N'(514) 555-8054', N'(514) 555-8055', 4, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (78, N'Hanari Carnes', N'Mario Pontes', 78, N'Rua do Paço, 67', N'Rio de Janeiro', N'RJ', N'05454-876', 4, N'(21) 555-0091', N'(21) 555-8765', 1, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (79, N'Que Delícia', N'Bernardo Batista', 79, N'Rua da Panificadora, 12', N'Rio de Janeiro', N'RJ', N'02389-673', 4, N'(21) 555-4252', N'(21) 555-4545', 1, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (80, N'Ricardo Adocicados', N'Janete Limeira', 80, N'Av. Copacabana, 267', N'Rio de Janeiro', N'RJ', N'02389-890', 4, N'(21) 555-3412', NULL, 2, CAST(N'2018-07-03 04:22:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (81, N'Comércio Mineiro', N'Pedro Afonso', 81, N'Av. dos Lusíadas, 23', N'Sao Paulo', N'SP', N'05432-043', 4, N'(11) 555-7647', NULL, 10, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (82, N'Familia Arquibaldo', N'Aria Cruz', 82, N'Rua Orós, 92', N'Sao Paulo', N'SP', N'05442-030', 4, N'(11) 555-9857', NULL, 4, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (83, N'Gourmet Lanchonetes', N'André Fonseca', 83, N'Av. Brasil, 442', N'Campinas', N'SP', N'04876-786', 4, N'(11) 555-9482', NULL, 10, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (84, N'Queen Cozinha', N'Lúcia Carvalho', 84, N'Alameda dos Canàrios, 891', N'Sao Paulo', N'SP', N'05487-020', 4, N'(11) 555-1189', NULL, 4, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (85, N'Tradição Hipermercados', N'Anabela Domingues', 85, N'Av. Inês de Castro, 414', N'Sao Paulo', N'SP', N'05634-030', 4, N'(11) 555-2167', N'(11) 555-2168', 12, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (86, N'Wellington Importadora', N'Paula Parente', 86, N'Rua do Mercado, 12', N'Resende', N'SP', N'08737-363', 4, N'(14) 555-8122', NULL, 11, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (87, N'HILARION-Abastos', N'Carlos Hernández', 87, N'Carrera 22 con Ave. Carlos Soublette #8-35', N'San Cristóbal', N'Táchira', N'5022', 21, N'(5) 555-1340', N'(5) 555-1948', 12, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (88, N'Lazy K Kountry Store', N'John Steel', 88, N'12 Orchestra Terrace', N'Walla Walla', N'WA', N'99362', 20, N'(509) 555-7969', N'(509) 555-6221', 5, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (89, N'Trail''s Head Gourmet Provisioners', N'Helvetius Nagy', 89, N'722 DaVinci Blvd.', N'Kirkland', N'WA', N'98034', 20, N'(206) 555-8257', N'(206) 555-2174', 10, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (90, N'White Clover Markets', N'Karl Jablonski', 90, N'305 - 14th Ave. S. Suite 3B', N'Seattle', N'WA', N'98128', 20, N'(206) 555-4112', N'(206) 555-4115', 7, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
INSERT [dbo].[Customers] ([CustomerIdentifier], [CompanyName], [ContactName], [ContactId], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [Phone], [Fax], [ContactTypeIdentifier], [ModifiedDate]) VALUES (91, N'Split Rail Beer & Ale', N'Art Braunschweiger', 91, N'P.O. Box 555', N'Lander', N'WY', N'82520', 20, N'(307) 555-4680', N'(307) 555-6525', 11, CAST(N'2018-02-03 01:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Customers] OFF
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Contacts] FOREIGN KEY([ContactId])
REFERENCES [dbo].[Contacts] ([ContactId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Contacts]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_ContactType] FOREIGN KEY([ContactTypeIdentifier])
REFERENCES [dbo].[ContactType] ([ContactTypeIdentifier])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_ContactType]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_Countries] FOREIGN KEY([CountryIdentifier])
REFERENCES [dbo].[Countries] ([CountryIdentifier])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Countries]
GO