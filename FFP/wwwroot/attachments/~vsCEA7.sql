USE [master]
GO
/****** Object:  Database [ffpdb]    Script Date: 7/14/2024 4:42:14 PM ******/
CREATE DATABASE [ffpdb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ffpdb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ffpdb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ffpdb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ffpdb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ffpdb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ffpdb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ffpdb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ffpdb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ffpdb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ffpdb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ffpdb] SET ARITHABORT OFF 
GO
ALTER DATABASE [ffpdb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ffpdb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ffpdb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ffpdb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ffpdb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ffpdb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ffpdb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ffpdb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ffpdb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ffpdb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ffpdb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ffpdb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ffpdb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ffpdb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ffpdb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ffpdb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ffpdb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ffpdb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ffpdb] SET  MULTI_USER 
GO
ALTER DATABASE [ffpdb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ffpdb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ffpdb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ffpdb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ffpdb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ffpdb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ffpdb] SET QUERY_STORE = OFF
GO
USE [ffpdb]
GO
/****** Object:  Table [dbo].[Addresses]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Country] [nvarchar](max) NOT NULL,
	[City] [nvarchar](max) NOT NULL,
	[Street] [nvarchar](max) NOT NULL,
	[AppartmentNo] [nvarchar](max) NULL,
	[ZipCode] [nvarchar](max) NULL,
 CONSTRAINT [PK_Addresses] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdminRoles]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_AdminRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[EncPassword] [nvarchar](max) NOT NULL,
	[AdminRoleId] [int] NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[SecondName] [nvarchar](max) NULL,
	[ThirdName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[BirthDate] [date] NULL,
	[PersonalPhotoPath] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Nationality] [nvarchar](max) NOT NULL,
	[AddressId] [int] NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Admins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Admins_Email] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Admins_PhoneNumber] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Admins_Username] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clubs]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clubs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LogoPath] [nvarchar](max) NULL,
 CONSTRAINT [PK_Clubs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leagues]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leagues](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Leagues] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Matches]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Matches](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Club1Id] [int] NOT NULL,
	[Club2Id] [int] NOT NULL,
	[Club1Goals] [int] NOT NULL,
	[Club2Goals] [int] NOT NULL,
	[LeagueId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Matches] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchesRatings]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchesRatings](
	[Id] [int] NOT NULL,
	[Value] [decimal](18, 0) NOT NULL,
	[MatchId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Comment] [nvarchar](max) NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_MatchesRatings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchRatingReports]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchRatingReports](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[MatchRatingId] [int] NOT NULL,
	[ReportTypeId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_MatchRatingReports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatchSaves]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatchSaves](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[MatchId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_MatchSaves] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostCommentLikes]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostCommentLikes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PostCommentId] [int] NOT NULL,
	[Date] [date] NOT NULL,
 CONSTRAINT [PK_PostCommentLikes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostCommentReports]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostCommentReports](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PostCommentId] [int] NOT NULL,
	[ReportTypeId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostCommentReports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostComments]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostComments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[PostId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostComments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostLikes]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostLikes](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[PostId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostLikes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostReports]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostReports](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[PostId] [int] NOT NULL,
	[ReportTypeId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostReports] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[HTMLContent] [nvarchar](max) NOT NULL,
	[PosterPath] [nvarchar](max) NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostSaves]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostSaves](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PostId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL,
 CONSTRAINT [PK_PostSaves] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Predictions]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Predictions](
	[Id] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[MatchId] [int] NOT NULL,
	[PredictedWinnerClub] [int] NOT NULL,
 CONSTRAINT [PK_Predictions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReportTypes]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReportTypes](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ReportTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[EncPassword] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhotoPath] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Users_Email] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Users_Username] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserSaves]    Script Date: 7/14/2024 4:42:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSaves](
	[Id] [int] NOT NULL,
	[SavingUserId] [int] NOT NULL,
	[SavedUserId] [int] NOT NULL,
	[DateTime] [datetime] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Admins] ADD  CONSTRAINT [DF_Admins_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Matches] ADD  CONSTRAINT [DF_Matches_Club1Goals]  DEFAULT ((0)) FOR [Club1Goals]
GO
ALTER TABLE [dbo].[Matches] ADD  CONSTRAINT [DF_Matches_Club2Goals]  DEFAULT ((0)) FOR [Club2Goals]
GO
ALTER TABLE [dbo].[Matches] ADD  CONSTRAINT [DF_Matches_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[MatchesRatings] ADD  CONSTRAINT [DF_MatchesRatings_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[MatchRatingReports] ADD  CONSTRAINT [DF_MatchRatingReports_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[MatchSaves] ADD  CONSTRAINT [DF_MatchSaves_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[PostCommentLikes] ADD  CONSTRAINT [DF_PostCommentLikes_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[PostCommentReports] ADD  CONSTRAINT [DF_PostCommentReports_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[PostComments] ADD  CONSTRAINT [DF_PostComments_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[PostLikes] ADD  CONSTRAINT [DF_PostLikes_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[PostReports] ADD  CONSTRAINT [DF_PostReports_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[Posts] ADD  CONSTRAINT [DF_Posts_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[PostSaves] ADD  CONSTRAINT [DF_PostSaves_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[UserSaves] ADD  CONSTRAINT [DF_UserSaves_DateTime]  DEFAULT (getdate()) FOR [DateTime]
GO
ALTER TABLE [dbo].[Admins]  WITH CHECK ADD  CONSTRAINT [FK_Admins_Addresses1] FOREIGN KEY([AddressId])
REFERENCES [dbo].[Addresses] ([id])
GO
ALTER TABLE [dbo].[Admins] CHECK CONSTRAINT [FK_Admins_Addresses1]
GO
ALTER TABLE [dbo].[Admins]  WITH CHECK ADD  CONSTRAINT [FK_Admins_AdminRoles1] FOREIGN KEY([AdminRoleId])
REFERENCES [dbo].[AdminRoles] ([Id])
GO
ALTER TABLE [dbo].[Admins] CHECK CONSTRAINT [FK_Admins_AdminRoles1]
GO
ALTER TABLE [dbo].[Matches]  WITH CHECK ADD  CONSTRAINT [FK_Matches_Club1Id_Clubs] FOREIGN KEY([Club1Id])
REFERENCES [dbo].[Clubs] ([Id])
GO
ALTER TABLE [dbo].[Matches] CHECK CONSTRAINT [FK_Matches_Club1Id_Clubs]
GO
ALTER TABLE [dbo].[Matches]  WITH CHECK ADD  CONSTRAINT [FK_Matches_Club2Id_Clubs] FOREIGN KEY([Club2Id])
REFERENCES [dbo].[Clubs] ([Id])
GO
ALTER TABLE [dbo].[Matches] CHECK CONSTRAINT [FK_Matches_Club2Id_Clubs]
GO
ALTER TABLE [dbo].[Matches]  WITH CHECK ADD  CONSTRAINT [FK_Matches_Leagues] FOREIGN KEY([LeagueId])
REFERENCES [dbo].[Leagues] ([Id])
GO
ALTER TABLE [dbo].[Matches] CHECK CONSTRAINT [FK_Matches_Leagues]
GO
ALTER TABLE [dbo].[MatchesRatings]  WITH CHECK ADD  CONSTRAINT [FK_MatchesRatings_Matches] FOREIGN KEY([MatchId])
REFERENCES [dbo].[Matches] ([Id])
GO
ALTER TABLE [dbo].[MatchesRatings] CHECK CONSTRAINT [FK_MatchesRatings_Matches]
GO
ALTER TABLE [dbo].[MatchesRatings]  WITH CHECK ADD  CONSTRAINT [FK_MatchesRatings_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[MatchesRatings] CHECK CONSTRAINT [FK_MatchesRatings_Users]
GO
ALTER TABLE [dbo].[MatchRatingReports]  WITH CHECK ADD  CONSTRAINT [FK_MatchRatingReports_MatchesRatings] FOREIGN KEY([MatchRatingId])
REFERENCES [dbo].[MatchesRatings] ([Id])
GO
ALTER TABLE [dbo].[MatchRatingReports] CHECK CONSTRAINT [FK_MatchRatingReports_MatchesRatings]
GO
ALTER TABLE [dbo].[MatchRatingReports]  WITH CHECK ADD  CONSTRAINT [FK_MatchRatingReports_ReportTypes] FOREIGN KEY([ReportTypeId])
REFERENCES [dbo].[ReportTypes] ([Id])
GO
ALTER TABLE [dbo].[MatchRatingReports] CHECK CONSTRAINT [FK_MatchRatingReports_ReportTypes]
GO
ALTER TABLE [dbo].[MatchRatingReports]  WITH CHECK ADD  CONSTRAINT [FK_MatchRatingReports_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[MatchRatingReports] CHECK CONSTRAINT [FK_MatchRatingReports_Users]
GO
ALTER TABLE [dbo].[MatchSaves]  WITH CHECK ADD  CONSTRAINT [FK_MatchSaves_Matches] FOREIGN KEY([MatchId])
REFERENCES [dbo].[Matches] ([Id])
GO
ALTER TABLE [dbo].[MatchSaves] CHECK CONSTRAINT [FK_MatchSaves_Matches]
GO
ALTER TABLE [dbo].[MatchSaves]  WITH CHECK ADD  CONSTRAINT [FK_MatchSaves_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[MatchSaves] CHECK CONSTRAINT [FK_MatchSaves_Users]
GO
ALTER TABLE [dbo].[PostCommentLikes]  WITH CHECK ADD  CONSTRAINT [FK_PostCommentLikes_PostComments] FOREIGN KEY([PostCommentId])
REFERENCES [dbo].[PostComments] ([Id])
GO
ALTER TABLE [dbo].[PostCommentLikes] CHECK CONSTRAINT [FK_PostCommentLikes_PostComments]
GO
ALTER TABLE [dbo].[PostCommentLikes]  WITH CHECK ADD  CONSTRAINT [FK_PostCommentLikes_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[PostCommentLikes] CHECK CONSTRAINT [FK_PostCommentLikes_Users]
GO
ALTER TABLE [dbo].[PostCommentReports]  WITH CHECK ADD  CONSTRAINT [FK_PostCommentReports_PostComments] FOREIGN KEY([PostCommentId])
REFERENCES [dbo].[PostComments] ([Id])
GO
ALTER TABLE [dbo].[PostCommentReports] CHECK CONSTRAINT [FK_PostCommentReports_PostComments]
GO
ALTER TABLE [dbo].[PostCommentReports]  WITH CHECK ADD  CONSTRAINT [FK_PostCommentReports_ReportTypes] FOREIGN KEY([ReportTypeId])
REFERENCES [dbo].[ReportTypes] ([Id])
GO
ALTER TABLE [dbo].[PostCommentReports] CHECK CONSTRAINT [FK_PostCommentReports_ReportTypes]
GO
ALTER TABLE [dbo].[PostCommentReports]  WITH CHECK ADD  CONSTRAINT [FK_PostCommentReports_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[PostCommentReports] CHECK CONSTRAINT [FK_PostCommentReports_Users]
GO
ALTER TABLE [dbo].[PostComments]  WITH CHECK ADD  CONSTRAINT [FK_PostComments_Posts] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([Id])
GO
ALTER TABLE [dbo].[PostComments] CHECK CONSTRAINT [FK_PostComments_Posts]
GO
ALTER TABLE [dbo].[PostComments]  WITH CHECK ADD  CONSTRAINT [FK_PostComments_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[PostComments] CHECK CONSTRAINT [FK_PostComments_Users]
GO
ALTER TABLE [dbo].[PostLikes]  WITH CHECK ADD  CONSTRAINT [FK_PostLikes_Posts] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([Id])
GO
ALTER TABLE [dbo].[PostLikes] CHECK CONSTRAINT [FK_PostLikes_Posts]
GO
ALTER TABLE [dbo].[PostLikes]  WITH CHECK ADD  CONSTRAINT [FK_PostLikes_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[PostLikes] CHECK CONSTRAINT [FK_PostLikes_Users]
GO
ALTER TABLE [dbo].[PostReports]  WITH CHECK ADD  CONSTRAINT [FK_PostReports_Posts] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([Id])
GO
ALTER TABLE [dbo].[PostReports] CHECK CONSTRAINT [FK_PostReports_Posts]
GO
ALTER TABLE [dbo].[PostReports]  WITH CHECK ADD  CONSTRAINT [FK_PostReports_ReportTypes] FOREIGN KEY([ReportTypeId])
REFERENCES [dbo].[ReportTypes] ([Id])
GO
ALTER TABLE [dbo].[PostReports] CHECK CONSTRAINT [FK_PostReports_ReportTypes]
GO
ALTER TABLE [dbo].[PostReports]  WITH CHECK ADD  CONSTRAINT [FK_PostReports_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[PostReports] CHECK CONSTRAINT [FK_PostReports_Users]
GO
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_Posts_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_Posts_Users]
GO
ALTER TABLE [dbo].[PostSaves]  WITH CHECK ADD  CONSTRAINT [FK_PostSaves_Posts] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([Id])
GO
ALTER TABLE [dbo].[PostSaves] CHECK CONSTRAINT [FK_PostSaves_Posts]
GO
ALTER TABLE [dbo].[PostSaves]  WITH CHECK ADD  CONSTRAINT [FK_PostSaves_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[PostSaves] CHECK CONSTRAINT [FK_PostSaves_Users]
GO
ALTER TABLE [dbo].[Predictions]  WITH CHECK ADD  CONSTRAINT [FK_Predictions_Matches] FOREIGN KEY([MatchId])
REFERENCES [dbo].[Matches] ([Id])
GO
ALTER TABLE [dbo].[Predictions] CHECK CONSTRAINT [FK_Predictions_Matches]
GO
ALTER TABLE [dbo].[Predictions]  WITH CHECK ADD  CONSTRAINT [FK_Predictions_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Predictions] CHECK CONSTRAINT [FK_Predictions_Users]
GO
ALTER TABLE [dbo].[UserSaves]  WITH CHECK ADD  CONSTRAINT [FK_UserSaves_Users] FOREIGN KEY([SavingUserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserSaves] CHECK CONSTRAINT [FK_UserSaves_Users]
GO
ALTER TABLE [dbo].[UserSaves]  WITH CHECK ADD  CONSTRAINT [FK_UserSaves_Users1] FOREIGN KEY([SavedUserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[UserSaves] CHECK CONSTRAINT [FK_UserSaves_Users1]
GO
USE [master]
GO
ALTER DATABASE [ffpdb] SET  READ_WRITE 
GO
