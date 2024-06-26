USE [master]
GO
/****** Object:  Database [promedic]    Script Date: 15.05.2024 15:59:14 ******/
CREATE DATABASE [promedic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'promedic', FILENAME = N'/var/opt/mssql/data/promedic.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'promedic_log', FILENAME = N'/var/opt/mssql/data/promedic_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [promedic] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [promedic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [promedic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [promedic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [promedic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [promedic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [promedic] SET ARITHABORT OFF 
GO
ALTER DATABASE [promedic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [promedic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [promedic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [promedic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [promedic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [promedic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [promedic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [promedic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [promedic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [promedic] SET  ENABLE_BROKER 
GO
ALTER DATABASE [promedic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [promedic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [promedic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [promedic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [promedic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [promedic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [promedic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [promedic] SET RECOVERY FULL 
GO
ALTER DATABASE [promedic] SET  MULTI_USER 
GO
ALTER DATABASE [promedic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [promedic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [promedic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [promedic] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [promedic] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [promedic] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'promedic', N'ON'
GO
ALTER DATABASE [promedic] SET QUERY_STORE = ON
GO
ALTER DATABASE [promedic] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [promedic]
GO
/****** Object:  Table [dbo].[tbl_dzialy]    Script Date: 15.05.2024 15:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_dzialy](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nazwa] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_historia_konserwacji]    Script Date: 15.05.2024 15:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_historia_konserwacji](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[sprzet_id] [bigint] NOT NULL,
	[pracownik_id] [bigint] NOT NULL,
	[koszt] [decimal](10, 2) NOT NULL,
	[data_rozpoczecia] [datetime] NOT NULL,
	[data_zakonczenia] [datetime] NULL,
	[opis] [nvarchar](max) NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_tbl_historia_konserwacji] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_klient]    Script Date: 15.05.2024 15:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_klient](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[imie] [nvarchar](255) NULL,
	[nazwisko] [nvarchar](255) NULL,
	[active] [bit] NULL,
	[pesel] [nvarchar](11) NULL,
	[ulica] [nvarchar](255) NULL,
	[nr_domu] [int] NULL,
	[lokal] [int] NULL,
	[kod_pocztowy] [nvarchar](6) NULL,
	[miejscowosc] [nvarchar](255) NULL,
	[email] [nvarchar](255) NULL,
	[numer_telefonu] [nvarchar](255) NULL,
 CONSTRAINT [PK__tbl_klie__3213E83FDC97BAE1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_pracownicy]    Script Date: 15.05.2024 15:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_pracownicy](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[imie] [nvarchar](255) NULL,
	[nazwisko] [nvarchar](255) NULL,
	[active] [bit] NULL,
	[email] [nvarchar](255) NULL,
	[telefon] [nvarchar](255) NULL,
	[pesel] [nvarchar](11) NULL,
	[ulica] [nvarchar](255) NULL,
	[nr_domu] [int] NULL,
	[lokal] [int] NULL,
	[kod_pocztowy] [nvarchar](6) NULL,
	[miejscowosc] [nvarchar](255) NULL,
	[data_zatrudnienia] [date] NULL,
	[data_zwolnienia] [date] NULL,
	[zarobek] [decimal](10, 2) NULL,
	[dzial_id] [bigint] NULL,
	[stanowisko_id] [bigint] NULL,
 CONSTRAINT [PK__tbl_prac__3213E83F90F5B75F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_sprzet]    Script Date: 15.05.2024 15:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_sprzet](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nazwa] [nvarchar](255) NULL,
	[numer_inwentarzowy] [nvarchar](255) NULL,
	[data_zakupu] [date] NULL,
	[numer_faktury] [nvarchar](255) NULL,
	[numer_identyfikacyjny] [nvarchar](255) NULL,
	[czy_serwis] [bit] NULL,
	[czy_w_drodze] [bit] NULL,
	[data_likwidacji] [date] NULL,
	[status] [int] NULL,
	[typ_sprzetu_id] [bigint] NULL,
	[cena_za_dzien] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_stanowiska]    Script Date: 15.05.2024 15:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_stanowiska](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nazwa] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_typ_sprzetu]    Script Date: 15.05.2024 15:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_typ_sprzetu](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nazwa] [nvarchar](255) NULL,
	[opis] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_wypozyczenie]    Script Date: 15.05.2024 15:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_wypozyczenie](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[sprzet_id] [bigint] NULL,
	[data_start] [date] NULL,
	[data_koniec] [date] NULL,
	[klient_id] [bigint] NULL,
	[pracownik_id] [bigint] NULL,
	[uwagi] [nvarchar](max) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK__tbl_wypo__3213E83F01B2580F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_historia_konserwacji]  WITH CHECK ADD  CONSTRAINT [FK_tbl_historia_konserwacji_pracownik] FOREIGN KEY([pracownik_id])
REFERENCES [dbo].[tbl_pracownicy] ([id])
GO
ALTER TABLE [dbo].[tbl_historia_konserwacji] CHECK CONSTRAINT [FK_tbl_historia_konserwacji_pracownik]
GO
ALTER TABLE [dbo].[tbl_historia_konserwacji]  WITH CHECK ADD  CONSTRAINT [FK_tbl_historia_konserwacji_sprzet] FOREIGN KEY([sprzet_id])
REFERENCES [dbo].[tbl_sprzet] ([id])
GO
ALTER TABLE [dbo].[tbl_historia_konserwacji] CHECK CONSTRAINT [FK_tbl_historia_konserwacji_sprzet]
GO
ALTER TABLE [dbo].[tbl_pracownicy]  WITH CHECK ADD  CONSTRAINT [FK__tbl_praco__dzial__73BA3083] FOREIGN KEY([dzial_id])
REFERENCES [dbo].[tbl_dzialy] ([id])
GO
ALTER TABLE [dbo].[tbl_pracownicy] CHECK CONSTRAINT [FK__tbl_praco__dzial__73BA3083]
GO
ALTER TABLE [dbo].[tbl_pracownicy]  WITH CHECK ADD  CONSTRAINT [FK__tbl_praco__stano__74AE54BC] FOREIGN KEY([stanowisko_id])
REFERENCES [dbo].[tbl_stanowiska] ([id])
GO
ALTER TABLE [dbo].[tbl_pracownicy] CHECK CONSTRAINT [FK__tbl_praco__stano__74AE54BC]
GO
ALTER TABLE [dbo].[tbl_sprzet]  WITH CHECK ADD FOREIGN KEY([typ_sprzetu_id])
REFERENCES [dbo].[tbl_typ_sprzetu] ([id])
GO
USE [master]
GO
ALTER DATABASE [promedic] SET  READ_WRITE 
GO
