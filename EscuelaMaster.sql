USE [master]
GO

/****** Object:  Database [EscuelaMaster]    Script Date: 17/03/2022 08:40:56 a. m. ******/
CREATE DATABASE [EscuelaMaster]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EscuelaMaster', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EscuelaMaster.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EscuelaMaster_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EscuelaMaster_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EscuelaMaster].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EscuelaMaster] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EscuelaMaster] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EscuelaMaster] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EscuelaMaster] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EscuelaMaster] SET ARITHABORT OFF 
GO

ALTER DATABASE [EscuelaMaster] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EscuelaMaster] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EscuelaMaster] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EscuelaMaster] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EscuelaMaster] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EscuelaMaster] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EscuelaMaster] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EscuelaMaster] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EscuelaMaster] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EscuelaMaster] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EscuelaMaster] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EscuelaMaster] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EscuelaMaster] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EscuelaMaster] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EscuelaMaster] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EscuelaMaster] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EscuelaMaster] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EscuelaMaster] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [EscuelaMaster] SET  MULTI_USER 
GO

ALTER DATABASE [EscuelaMaster] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EscuelaMaster] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EscuelaMaster] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EscuelaMaster] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EscuelaMaster] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EscuelaMaster] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [EscuelaMaster] SET QUERY_STORE = OFF
GO

ALTER DATABASE [EscuelaMaster] SET  READ_WRITE 
GO

