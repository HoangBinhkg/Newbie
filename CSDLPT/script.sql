USE [master]
GO
/****** Object:  Database [QLDSV]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE DATABASE [QLDSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLDSV.mdf' , SIZE = 16384KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLDSV_log.ldf' , SIZE = 63424KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLDSV] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLDSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLDSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLDSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLDSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLDSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLDSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLDSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLDSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLDSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLDSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLDSV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLDSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLDSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLDSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLDSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLDSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLDSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLDSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLDSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLDSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLDSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLDSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLDSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLDSV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLDSV', N'ON'
GO
/****** Object:  Login [ZERO\Bình]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [ZERO\Bình] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [thaibinh]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [thaibinh] WITH PASSWORD=N'bË³¤æ¨àèø.®|ÁQ`
ßÁAhK7', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [thaibinh] DISABLE
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLSERVERAGENT]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [NT SERVICE\SQLSERVERAGENT] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\ReportServer]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [NT SERVICE\ReportServer] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT Service\MSSQLSERVER]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [NT Service\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [hoangbinh]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [hoangbinh] WITH PASSWORD=N'É_~¸E1Â	$°*PCí&l÷ØBë#0úÜ', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [hoangbinh] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [HB]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [HB] WITH PASSWORD=N'¬{`y=Ï¿@´$ïæë4þE­TßýOýn¨!K', DEFAULT_DATABASE=[QLDSV], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [HB] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [distributor_admin]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [distributor_admin] WITH PASSWORD=N'e9PsÚÈ·ù¢7$23Xï@|¬©ê&¼#º	ñ\', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [distributor_admin] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'òß°kÃ¡Ó£j¿6ä½4µïøx:C³6ÓÈYM', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'êØ.9@«\¡ºÕK6fé¬ùÃ(û©×', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
ALTER AUTHORIZATION ON DATABASE::[QLDSV] TO [sa]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [ZERO\Bình]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLSERVERAGENT]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQLSERVER]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [HB]
GO
ALTER SERVER ROLE [processadmin] ADD MEMBER [HB]
GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [HB]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [distributor_admin]
GO
USE [QLDSV]
GO
/****** Object:  User [HoangBinh]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE USER [HoangBinh] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[HoangBinh]
GO
/****** Object:  User [GV02]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE USER [GV02] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [GV01]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE USER [GV01] FOR LOGIN [hoangbinh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [08THA101]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE USER [08THA101] FOR LOGIN [thaibinh] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [SV]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE ROLE [SV]
GO
/****** Object:  DatabaseRole [PGV]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE ROLE [PGV]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE ROLE [MSmerge_PAL_role]
GO
/****** Object:  DatabaseRole [MSmerge_623057983EBA4AA5A514E338C3BAE4E5]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE ROLE [MSmerge_623057983EBA4AA5A514E338C3BAE4E5]
GO
/****** Object:  DatabaseRole [MSmerge_38F91DC734B6458795844F6FAA4CBEDB]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE ROLE [MSmerge_38F91DC734B6458795844F6FAA4CBEDB]
GO
/****** Object:  DatabaseRole [KHOA]    Script Date: 6/22/2015 10:58:44 AM ******/
CREATE ROLE [KHOA]
GO
ALTER AUTHORIZATION ON ROLE::[SV] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[PGV] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_PAL_role] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_623057983EBA4AA5A514E338C3BAE4E5] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_38F91DC734B6458795844F6FAA4CBEDB] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[KHOA] TO [dbo]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [HoangBinh]
GO
ALTER ROLE [KHOA] ADD MEMBER [GV02]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV02]
GO
ALTER ROLE [PGV] ADD MEMBER [GV01]
GO
ALTER ROLE [db_owner] ADD MEMBER [GV01]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [GV01]
GO
ALTER ROLE [SV] ADD MEMBER [08THA101]
GO
ALTER ROLE [db_owner] ADD MEMBER [08THA101]
GO
ALTER ROLE [db_datareader] ADD MEMBER [08THA101]
GO
ALTER ROLE [db_owner] ADD MEMBER [SV]
GO
ALTER ROLE [db_datareader] ADD MEMBER [SV]
GO
ALTER ROLE [db_owner] ADD MEMBER [PGV]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [PGV]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_623057983EBA4AA5A514E338C3BAE4E5]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_38F91DC734B6458795844F6FAA4CBEDB]
GO
ALTER ROLE [db_owner] ADD MEMBER [KHOA]
GO
GRANT CONNECT TO [08THA101] AS [dbo]
GO
GRANT CONNECT TO [GV01] AS [dbo]
GO
GRANT CONNECT TO [GV02] AS [dbo]
GO
GRANT CONNECT TO [HoangBinh] AS [dbo]
GO
/****** Object:  Schema [HoangBinh]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE SCHEMA [HoangBinh] AUTHORIZATION [HoangBinh]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE SCHEMA [MSmerge_PAL_role] AUTHORIZATION [MSmerge_PAL_role]
GO
/****** Object:  StoredProcedure [dbo].[SP_BangDiem_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_BangDiem_1Khoa]
@malop char(8), @mamh char(6), @lan smallInt
as
begin
select MASV,HO + ' ' + TEN as HOTEN
into #Tam
from SINHVIEN
where MALOP = @malop
select * from #Tam
left join (select MASV,MAMH,LAN,max (DIEM) as DIEM from DIEM group by MASV, MAMH,LAN)BANGDIEM 
on BANGDIEM.MASV = #Tam.MASV 
AND BANGDIEM.MAMH = @mamh and BANGDIEM.LAN = @lan
end
GO
ALTER AUTHORIZATION ON [dbo].[SP_BangDiem_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_BangDiem_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_BangDiem_2Khoa]
@malop char(8), @mamh char(6), @lan smallInt
as
begin
select MASV,HOTEN = HO + ' ' + TEN
into #Tam1
from SINHVIEN
where MALOP = @malop
select MASV,HOTEN = HO + ' ' + TEN into #Tam2
from LINK1.QLDSV.DBO.SINHVIEN
where MALOP = @malop
select * from #Tam1
left join (select MASV,MAMH,LAN,max (DIEM) as DIEM from DIEM group by MASV, MAMH,LAN) BANGDIEM 
on BANGDIEM.MASV = #Tam1.MASV 
AND BANGDIEM.MAMH = @mamh and BANGDIEM.LAN = @lan
UNION
select * from #Tam2
left join (select MASV,MAMH,LAN,max (DIEM) as DIEM from LINK1.QLDSV.DBO.DIEM group by MASV, MAMH,LAN)BANGDIEM2 
on BANGDIEM2.MASV = #Tam2.MASV 
AND BANGDIEM2.MAMH = @mamh and BANGDIEM2.LAN = @lan
end
GO
ALTER AUTHORIZATION ON [dbo].[SP_BangDiem_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_inDSSV_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_inDSSV_1Khoa] 
@malop char(8)
as
begin
if exists(select MALOP from LOP where MALOP = @malop)
select TENLOP = (select TENLOP from LOP where MALOP = @malop),HOTEN = HO + ' ' + TEN,PHAI,NGAYSINH,NOISINH,DIACHI from SINHVIEN where MALOP = @malop
end
GO
ALTER AUTHORIZATION ON [dbo].[SP_inDSSV_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_inDSSV_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_inDSSV_2Khoa] 
@malop char(8)
as
begin
if exists(select MALOP from LOP where MALOP = @malop)
select TENLOP = (select TENLOP from LOP where MALOP = @malop),HOTEN = HO + ' ' + TEN,PHAI,NGAYSINH,NOISINH,DIACHI from SINHVIEN where MALOP = @malop
else
select TENLOP = (select TENLOP from LOP where MALOP = @malop),HOTEN = HO + ' ' + TEN,PHAI,NGAYSINH,NOISINH,DIACHI from LINK1.QLDSV.DBO.SINHVIEN where MALOP = @malop
end
GO
ALTER AUTHORIZATION ON [dbo].[SP_inDSSV_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_Load_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_Load_1Khoa]
AS
	BEGIN
		SELECT * FROM KHOA
	END	
GO
ALTER AUTHORIZATION ON [dbo].[SP_Load_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_Load_DSSV]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Load_DSSV]
AS
BEGIN 
				SELECT MASV,HOTEN= HO + ' ' + TEN FROM SINHVIEN
		UNION
		SELECT MASV,HOTEN= HO + ' ' + TEN FROM LINK1.QLDSV.DBO.SINHVIEN
END

GO
ALTER AUTHORIZATION ON [dbo].[SP_Load_DSSV] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_Load_Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_Load_Khoa]
AS
	BEGIN
		SELECT * FROM KHOA
	UNION
		SELECT * FROM LINK1.QLDSV.DBO.KHOA
	END
GO
ALTER AUTHORIZATION ON [dbo].[SP_Load_Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_Load_LOP_DIEM]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SP_Load_LOP_DIEM]
@lan smallint,
@MAMH char(6)
AS
	BEGIN
		SELECT MASV,MAMH,LAN,DIEM FROM DIEM WHERE LAN = @LAN AND MAMH = @MAMH
	UNION
		SELECT MASV,MAMH,LAN,DIEM FROM LINK1.QLDSV.DBO.DIEM WHERE DIEM.LAN = @LAN AND DIEM.MAMH = @MAMH
	END
GO
ALTER AUTHORIZATION ON [dbo].[SP_Load_LOP_DIEM] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_Load_MonHoc]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_Load_MonHoc]
as
begin
select MAMH,TENMH from MONHOC
end
GO
ALTER AUTHORIZATION ON [dbo].[SP_Load_MonHoc] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadDSLop]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadDSLop]
@makh nchar(8)
AS
BEGIN
	SELECT * FROM LOP WHERE makh = @makh
	UNION
	SELECT * FROM LINK1.QLDSV.DBO.LOP WHERE makh = @makh
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadDSLop] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadDSLop_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadDSLop_1Khoa]
@makh nchar(8)
AS
BEGIN
	SELECT * FROM LOP WHERE makh = @makh
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadDSLop_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadLop]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadLop]
@makh char(4)
AS
BEGIN
	SELECT MALOP,TENLOP,MAKH 
		FROM LOP WHERE MAKH = @makh
	UNION
	SELECT MALOP,TENLOP,MAKH 
		FROM LINK1.QLDSV.DBO.LOP WHERE MAKH = @makh
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadLop] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadLop_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadLop_1Khoa]
@makh char(4)
AS
BEGIN
	SELECT MALOP,TENLOP,MAKH FROM LOP WHERE MAKH = @makh
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadLop_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadSV]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadSV]
@malop char(8)
AS
	BEGIN
		IF exists(SELECT MALOP FROM LOP WHERE MALOP = @malop)
			SELECT MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC 
				FROM SINHVIEN 
					WHERE MALOP = @malop
		ELSE
			SELECT MASV,HO,TEN,PHAI,MALOP,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC 
				FROM LINK1.QLDSV.DBO.SINHVIEN 
					WHERE MALOP = @malop
	END
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadSV] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadSV_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadSV_1Khoa]
@malop char(8)
AS
	BEGIN
		IF exists(SELECT MALOP FROM LOP WHERE MALOP = @malop)
				SELECT MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC 
				FROM SINHVIEN WHERE MALOP = @malop
	END
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadSV_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadSV_Edit]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_LoadSV_Edit]
@malop char(8), @masv char(8)
AS
BEGIN
	IF exists(SELECT MALOP FROM LOP WHERE MALOP = @malop)
		SELECT HO,TEN,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC 
			FROM SINHVIEN 
				WHERE MALOP = @malop and MASV = @masv
	ELSE
		SELECT HO,TEN,PHAI,NGAYSINH,NOISINH,DIACHI,GHICHU,NGHIHOC 
			FROM LINK1.QLDSV.DBO.SINHVIEN 
				WHERE MALOP = @malop and MASV = @masv
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadSV_Edit] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadSVLop_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LoadSVLop_1Khoa] 
@malop char(8)
AS
BEGIN
	IF exists(SELECT MALOP FROM LOP WHERE MALOP = @malop)
		SELECT MASV, HOTEN = HO + ' ' + TEN 
		FROM SINHVIEN 
			WHERE MALOP = @malop
end
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadSVLop_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_LoadTenLop]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SP_LoadTenLop]
@malop char(8)
AS
	BEGIN
		IF exists(SELECT MALOP FROM LOP WHERE MALOP = @malop)
			SELECT TENLOP 
				FROM Lop 
					WHERE MALOP = @malop
		ELSE
			SELECT TenLop 
				FROM LINK1.QLDSV.DBO.LOP 
					WHERE MALOP = @malop
	END
GO
ALTER AUTHORIZATION ON [dbo].[SP_LoadTenLop] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaDiem_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_SuaDiem_1Khoa]
@masv char(8), @mamh char(6), @lan smallInt,@diem float

as
BEGIN
if(@lan = 1)
BEGIN
if not exists(select * from DIEM where MASV = @maSV and LAN = 2)
	UPDATE DIEM SET DIEM = @DIEM WHERE MASV = @maSV and LAN = 1 
		else
			RAISERROR('Đã có Điểm Rồi',16,1)
END
	ELSE
	BEGIN
	if exists(select * from DIEM where MASV = @maSV and LAN = 1 and diem <5)
	UPDATE DIEM SET DIEM = @DIEM WHERE MASV = @maSV and LAN = 2 
		else
			RAISERROR('Đã có Điểm Rồi',16,1)
			END
			END
GO
ALTER AUTHORIZATION ON [dbo].[SP_SuaDiem_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaDiem_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_SuaDiem_2Khoa]
@masv char(8), @mamh char(6), @lan smallInt,@diem float

as



BEGIN
if(@lan = 1)
BEGIN
if not exists(select * from DIEM where MASV = @maSV and LAN = 2)
	UPDATE DIEM SET DIEM = @DIEM WHERE MASV = @maSV and LAN = 1 
		else
			RAISERROR('Đã có Điểm Rồi',16,1)
END
	ELSE
	BEGIN
	if exists(select * from DIEM where MASV = @maSV and LAN = 1 and diem <5)
	UPDATE DIEM SET DIEM = @DIEM WHERE MASV = @maSV and LAN = 2 
		else
			RAISERROR('Đã có Điểm Rồi',16,1)
			END
			END




BEGIN
if(@lan = 1)
BEGIN
if not exists(select * from LINK1.QLDSV.DBO.DIEM where MASV = @maSV and LAN = 2)
	UPDATE LINK1.QLDSV.DBO.DIEM SET DIEM = @DIEM WHERE MASV = @maSV and LAN = 1 
		else
			RAISERROR('Đã có Điểm Rồi',16,1)
END
	ELSE
	BEGIN
	if exists(select * from LINK1.QLDSV.DBO.DIEM where MASV = @maSV and LAN = 1 and diem <5)
	UPDATE LINK1.QLDSV.DBO.DIEM SET DIEM = @DIEM WHERE MASV = @maSV and LAN = 2 
		else
			RAISERROR('Đã có Điểm Rồi',16,1)
			END
			END








GO
ALTER AUTHORIZATION ON [dbo].[SP_SuaDiem_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaLop_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SuaLop_1Khoa]
 @malop char(8),@tenlop nvarchar(80) 
AS
SET XACT_ABORT ON
BEGIN TRANSACTION
if exists (select * from LOP where MALOP = @malop)
UPDATE LOP SET TENLOP = @tenlop WHERE MALOP = @malop 
COMMIT TRAN


GO
ALTER AUTHORIZATION ON [dbo].[SP_SuaLop_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaLop_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SuaLop_2Khoa]
 @malop char(8),@tenlop nvarchar(80) 
AS
SET XACT_ABORT ON
BEGIN TRANSACTION
if exists (select * from LOP where MALOP = @malop)
UPDATE LOP SET TENLOP = @tenlop WHERE MALOP = @malop
if exists (select * from LINK1.QLDSV.DBO.LOP where MALOP = @malop)
UPDATE LINK1.QLDSV.DBO.LOP SET TENLOP = @tenlop WHERE MALOP = @malop  
COMMIT TRAN
GO
ALTER AUTHORIZATION ON [dbo].[SP_SuaLop_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaMonHoc]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[SP_SuaMonHoc]
 @mamh char(6),@tenmh nvarchar(40) 
AS
SET XACT_ABORT ON
BEGIN TRANSACTION
UPDATE MONHOC SET TENMH = @tenmh WHERE MAMH = @mamh 
COMMIT TRAN
GO
ALTER AUTHORIZATION ON [dbo].[SP_SuaMonHoc] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaSV_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_SuaSV_1Khoa]
  @masv char(8),@ho nvarchar(40),@ten nvarchar(10),@malop char(8),@phai bit,
  @ngaysinh datetime,@noisinh nvarchar(40), @diachi nvarchar(80), @ghichu text, @nghihoc bit
AS
SET XACT_ABORT ON
BEGIN
BEGIN TRY
	if exists(select masv from SINHVIEN where MASV = @masv)
	UPDATE SINHVIEN SET HO = @ho,TEN = @ten,MALOP=@malop,PHAI=@phai,NGAYSINH=@ngaysinh,NOISINH=@noisinh, DIACHI=@diachi,GHICHU=@ghichu,NGHIHOC=@nghihoc 
	WHERE Masv = @masv
	else print 'Lớp của sinh viên này không tồn tại '  
END TRY
BEGIN CATCH


END CATCH
END 

GO
ALTER AUTHORIZATION ON [dbo].[SP_SuaSV_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_SuaSV_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_SuaSV_2Khoa]
  @masv char(8),@ho nvarchar(40),@ten nvarchar(10),@malop char(8),@phai bit,
  @ngaysinh datetime,@noisinh nvarchar(40), @diachi nvarchar(80), @ghichu text, @nghihoc bit
AS
SET XACT_ABORT ON
BEGIN
BEGIN TRY
	if exists(select masv from SINHVIEN where MASV = @masv)
	UPDATE SINHVIEN SET HO = @ho,TEN = @ten,MALOP=@malop,PHAI=@phai,NGAYSINH=@ngaysinh,NOISINH=@noisinh, DIACHI=@diachi,GHICHU=@ghichu,NGHIHOC=@nghihoc 
	WHERE Masv = @masv
	else print 'Lớp của sinh viên này không tồn tại '  
END TRY
BEGIN CATCH


END CATCH

BEGIN TRY


	if exists(select masv from LINK1.QLDSV.DBO.SINHVIEN where MASV = @masv)
	UPDATE LINK1.QLDSV.DBO.SINHVIEN SET HO = @ho,TEN = @ten,MALOP=@malop,PHAI=@phai,NGAYSINH=@ngaysinh,NOISINH=@noisinh, DIACHI=@diachi,GHICHU=@ghichu,NGHIHOC=@nghihoc 
	WHERE Masv = @masv
	else print 'Lớp của sinh viên này không tồn tại '  


END TRY

BEGIN CATCH


END CATCH
END 

GO
ALTER AUTHORIZATION ON [dbo].[SP_SuaSV_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemDiem_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ThemDiem_1Khoa]
@masv char(8), @mamh char(6), @lan smallInt,@diem float

as
BEGIN
if(@lan = 1)
BEGIN
if not exists(select * from DIEM where MASV = @maSV and MAMH = @mamh and MAMH = @mamh AND LAN = @lan)
	INSERT INTO DIEM(MASV,MAMH,LAN,DIEM) 
		VALUES (@masv,@mamh,@lan,@diem)
		else
			RAISERROR('LỖI',16,1)
END
	ELSE
	BEGIN
	if exists(select * from DIEM where MASV = @maSV  and MAMH = @mamh and LAN = 1 and diem <5)
		INSERT INTO DIEM(MASV,MAMH,LAN,DIEM) 
		VALUES (@masv,@mamh,@lan,@diem)
		else
			RAISERROR('LỖI',16,1)
			END
			END
GO
ALTER AUTHORIZATION ON [dbo].[SP_ThemDiem_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemDiem_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_ThemDiem_2Khoa]
@masv char(8), @mamh char(6), @lan smallInt,@diem float

as
SET XACT_ABORT ON
BEGIN
if(@lan = 1)
BEGIN
if not exists(select * from DIEM where MASV = @maSV and MAMH = @mamh and MAMH = @mamh AND LAN = @lan)
	INSERT INTO DIEM(MASV,MAMH,LAN,DIEM) 
		VALUES (@masv,@mamh,@lan,@diem)
		else
			RAISERROR('LỖI',16,1)
END
	ELSE
	BEGIN
	if exists(select * from DIEM where MASV = @maSV  and MAMH = @mamh and LAN = 1 and diem <5)
		INSERT INTO DIEM(MASV,MAMH,LAN,DIEM) 
		VALUES (@masv,@mamh,@lan,@diem)
		else
			RAISERROR('LỖI',16,1)
			END


if(@lan = 1)
BEGIN
if not exists(select * from LINK1.QLDSV.DBO.DIEM where MASV = @maSV  and MAMH = @mamh and LAN = @lan and diem <=5)
	INSERT INTO LINK1.QLDSV.DBO.DIEM(MASV,MAMH,LAN,DIEM) 
		VALUES (@masv,@mamh,@lan,@diem)
		else
			RAISERROR('LỖI',16,1)
END
	ELSE
	BEGIN
	if exists(select * from LINK1.QLDSV.DBO.DIEM where MASV = @maSV  and MAMH = @mamh and LAN = 1 and diem <=5)
		INSERT INTO LINK1.QLDSV.DBO.DIEM(MASV,MAMH,LAN,DIEM) 
		VALUES (@masv,@mamh,@lan,@diem)
		else
			RAISERROR('LỖI',16,1)
			END
END



GO
ALTER AUTHORIZATION ON [dbo].[SP_ThemDiem_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemLop]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_ThemLop]
  @malop char(8),
  @tenlop nvarchar(80), 
  @makh char(4)
AS
BEGIN
		IF exists (SELECT * FROM KHOA WHERE MAKH = @makh)
			INSERT INTO LOP(MALOP,TENLOP,MAKH) VALUES (@malop,@tenlop, @makh )
		IF exists (SELECT * FROM LINK1.QLDSV.DBO.KHOA WHERE MAKH = @makh)
			INSERT INTO LINK1.QLDSV.DBO.LOP(MALOP,TENLOP,MAKH) VALUES (@malop,@tenlop, @makh )  
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_ThemLop] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemLop_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_ThemLop_1Khoa]
  @malop char(8),
  @tenlop nvarchar(80), 
  @makh char(4)
	AS
	SET XACT_ABORT ON
	BEGIN TRANSACTION
	INSERT INTO LOP(MALOP,TENLOP,MAKH) VALUES (@malop,@tenlop, @makh )  
	COMMIT TRAN
 


GO
ALTER AUTHORIZATION ON [dbo].[SP_ThemLop_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemMonHoc]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[SP_ThemMonHoc]
  @mamh char(6),@tenmh nvarchar(40)
AS
SET XACT_ABORT ON
BEGIN TRANSACTION
INSERT INTO MONHOC(MAMH,TENMH) VALUES (@mamh,@tenmh )  
COMMIT TRAN
GO
ALTER AUTHORIZATION ON [dbo].[SP_ThemMonHoc] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemSV]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_ThemSV]
  @masv char(8),@ho nvarchar(40),@ten nvarchar(10),@malop char(8),@phai bit,
  @ngaysinh datetime,@noisinh nvarchar(40), @diachi nvarchar(80), @ghichu text, @nghihoc bit
AS
SET XACT_ABORT ON
BEGIN TRANSACTION
--and (not exists(select MASV from LINK1.QLDSV.DBO.SINHVIEN where MASV = @masv))
if (not exists(select MASV from SINHVIEN where MASV = @masv))
INSERT INTO SINHVIEN(MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH, DIACHI,GHICHU,NGHIHOC) 
VALUES (@masv,@ho,@ten,@malop,@phai,@ngaysinh,@noisinh,@diachi,@ghichu,@nghihoc)
else print 'Lớp của sinh viên này không tồn tại '  
COMMIT TRAN
GO
ALTER AUTHORIZATION ON [dbo].[SP_ThemSV] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemSV_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[SP_ThemSV_2Khoa]
  @masv char(8),@ho nvarchar(40),@ten nvarchar(10),@malop char(8),@phai bit,
  @ngaysinh datetime,@noisinh nvarchar(40), @diachi nvarchar(80), @ghichu text, @nghihoc bit
AS
SET XACT_ABORT ON
BEGIN
BEGIN TRY
-- and (not exists(select MASV from LINK1.QLDSV.DBO.SINHVIEN where MASV = @masv))
if (not exists(select MASV from SINHVIEN where MASV = @masv))
	INSERT INTO SINHVIEN(MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH, DIACHI,GHICHU,NGHIHOC) 
	VALUES (@masv,@ho,@ten,@malop,@phai,@ngaysinh,@noisinh,@diachi,@ghichu,@nghihoc)
	else print 'Lớp của sinh viên này không tồn tại '  
END TRY
BEGIN CATCH


END CATCH

BEGIN TRY
	if not exists(select MASV from LINK1.QLDSV.DBO.SINHVIEN where MASV = @masv)
	INSERT INTO LINK1.QLDSV.DBO.SINHVIEN(MASV,HO,TEN,MALOP,PHAI,NGAYSINH,NOISINH, DIACHI,GHICHU,NGHIHOC) 
	VALUES (@masv,@ho,@ten,@malop,@phai,@ngaysinh,@noisinh,@diachi,@ghichu,@nghihoc)
	else print 'Lứp của sinh viên này không tồn tại ' 

END TRY

BEGIN CATCH


END CATCH
END 

GO
ALTER AUTHORIZATION ON [dbo].[SP_ThemSV_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_TIMDSLOP]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_TIMDSLOP]
	@MALOP nvarchar(8)
	as
		if exists (select * from LOP where MALOP = @MALOP)
			select MASV, HO, TEN, TENLOP= (select TENLOP from LOP where MALOP = @MALOP)
			from SINHVIEN where MALOP = @MALOP
			else
			if exists (select * from LINK1. QLDSV.DBO.LOP where MALOP = @MALOP)
			select MASV, HO, TEN, TENLOP= (select TENLOP from LINK1. QLDSV.DBO.LOP where MALOP = @MALOP)
			from LINK1. QLDSV.DBO.SINHVIEN where MALOP = @MALOP
		else 
			raiserror ('Ma lop khong co!',16,1)
GO
ALTER AUTHORIZATION ON [dbo].[SP_TIMDSLOP] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_TIMSV_1KHOA]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TIMSV_1KHOA]
@masv nchar(10)
 AS
		BEGIN
			SELECT * FROM SINHVIEN WHERE masv = @masv
    	UNION ALL
			SELECT * FROM LINK1.QLDSV.DBO.SINHVIEN WHERE SINHVIEN.masv = @masv
		END
GO
ALTER AUTHORIZATION ON [dbo].[SP_TIMSV_1KHOA] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaDiem_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaDiem_1Khoa]
@masv char(8), @mamh char(6), @lan smallInt
 AS
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
   if (@lan = 2)
		DELETE FROM DIEM WHERE MASV = @masv and MAMH = @mamh and LAN =@lan
		if not exists(select * from DIEM where MASV = @masv and MAMH = @mamh and LAN = 2) and (@lan = 1)
				DELETE FROM DIEM WHERE MASV = @masv and MAMH = @mamh and LAN =@lan
  COMMIT
END TRY
BEGIN CATCH
		ROLLBACK
		DECLARE @ErrorMessage VARCHAR(2000)
		SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)

END CATCH



GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaDiem_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaDiem_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_XoaDiem_2Khoa] 
@masv char(8), @mamh char(6),@lan smallInt
 AS

BEGIN TRY
	if (@lan = 2)
		DELETE FROM DIEM WHERE MASV = @masv and MAMH = @mamh and LAN =@lan
		if not exists(select * from DIEM where MASV = @masv and MAMH = @mamh and LAN = 2) and (@lan = 1)
				DELETE FROM DIEM WHERE MASV = @masv and MAMH = @mamh and LAN =@lan

				if (@lan = 2)
		DELETE FROM LINK1.QLDSV.DBO.DIEM WHERE MASV = @masv and MAMH = @mamh and LAN =@lan
		if not exists(select * from LINK1.QLDSV.DBO.DIEM where MASV = @masv and MAMH = @mamh and LAN = 2) and (@lan = 1)
				DELETE FROM LINK1.QLDSV.DBO.DIEM WHERE MASV = @masv and MAMH = @mamh and LAN =@lan

END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'L?i: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)

END CATCH
GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaDiem_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaLop]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaLop]
 @malop char(8)
 AS

BEGIN TRY
	if exists(select * from SINHVIEN where MALOP = @malop)
   DELETE FROM SINHVIEN WHERE MALOP = @malop
	if exists(select * from LOP where MALOP = @malop)
   DELETE FROM LOP WHERE MALOP = @malop

   if exists(select * from LINK1.QLDSV.DBO.SINHVIEN where MALOP = @malop)
   DELETE FROM LINK1.QLDSV.DBO.SINHVIEN WHERE MALOP = @malop
   if exists(select * from LINK1.QLDSV.DBO.LOP where MALOP = @malop)
   DELETE FROM LINK1.QLDSV.DBO.LOP WHERE MALOP = @malop
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'L?i: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)

END CATCH
GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaLop] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaLop_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaLop_1Khoa]
 @malop char(8)
 AS
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
   if exists(select * from LOP where MALOP = @malop)
		DELETE FROM SINHVIEN WHERE MALOP = @malop
		DELETE FROM LOP WHERE MALOP = @malop
  COMMIT
END TRY
BEGIN CATCH
		ROLLBACK
		DECLARE @ErrorMessage VARCHAR(2000)
		SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)

END CATCH

GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaLop_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaLop_2Khoa_2]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaLop_2Khoa_2]
 @malop char(8)
 AS
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
   if exists(select * from SINHVIEN where MALOP = @malop)
   DELETE FROM SINHVIEN WHERE MALOP = @malop
   if exists(select * from LOP where MALOP = @malop)
   DELETE FROM LOP WHERE MALOP = @malop
  COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH

BEGIN TRY
   if exists(select * from LINK1.QLDSV.DBO.SINHVIEN where MALOP = @malop)
   DELETE FROM LINK1.QLDSV.DBO.SINHVIEN WHERE MALOP = @malop
   if exists(select * from LINK1.QLDSV.DBO.LOP where MALOP = @malop)
   DELETE FROM LINK1.QLDSV.DBO.LOP WHERE MALOP = @malop
  COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH
GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaLop_2Khoa_2] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaLop_2Khoa_3]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaLop_2Khoa_3]
 @malop char(8)
 AS
SET XACT_ABORT ON
BEGIN DISTRIBUTED TRANSACTION
BEGIN TRY
   if exists(select * from SINHVIEN where MALOP = @malop)
   DELETE FROM SINHVIEN WHERE MALOP = @malop
   if exists(select * from LOP where MALOP = @malop)
   DELETE FROM LOP WHERE MALOP = @malop
  COMMIT TRANSACTION
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH

BEGIN TRY
   if exists(select * from LINK1.QLDSV.DBO.SINHVIEN where MALOP = @malop)
		DELETE FROM LINK1.QLDSV.DBO.SINHVIEN WHERE MALOP = @malop
   if exists(select * from LINK1.QLDSV.DBO.LOP where MALOP = @malop)
		DELETE FROM LINK1.QLDSV.DBO.LOP WHERE MALOP = @malop
  COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH
GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaLop_2Khoa_3] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaLopD]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaLopD]
 @malop char(8)
 AS
BEGIN
   DELETE FROM LOP WHERE MALOP = @malop
END
GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaLopD] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaMonHoc]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaMonHoc]
 @mamh char(6)
 AS
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
   if exists(select * from MONHOC where MAMH = @mamh)
   DELETE FROM DIEM WHERE MAMH = @mamh
   DELETE FROM MONHOC WHERE MAMH = @mamh
  COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)

END CATCH
GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaMonHoc] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaSV]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaSV]
 @masv char(8)
 AS
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
   if exists(select * from DIEM where MASV = @masv)
   DELETE FROM DIEM WHERE MASV = @masv
   if exists(select * from SINHVIEN where MASV = @masv)
   DELETE FROM SINHVIEN WHERE MASV = @masv
   
  COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH

BEGIN TRY
   if exists(select * from LINK1.QLDSV.DBO.DIEM where MASV = @masv)
   DELETE FROM LINK1.QLDSV.DBO.DIEM WHERE MASV = @masv
   if exists(select * from LINK1.QLDSV.DBO.SINHVIEN where MASV = @masv)
   DELETE FROM LINK1.QLDSV.DBO.SINHVIEN WHERE MASV = @masv
   
  COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH
GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaSV] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaSV_1Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaSV_1Khoa]
 @masv char(8)
 AS
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
   if exists(select * from DIEM where MASV = @masv)
   DELETE FROM DIEM WHERE MASV = @masv
   if exists(select * from SINHVIEN where MASV = @masv)
   DELETE FROM SINHVIEN WHERE MASV = @masv
   
  COMMIT
END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)

END CATCH

GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaSV_1Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaSV_2Khoa]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_XoaSV_2Khoa]
 @masv char(8)
 AS
SET XACT_ABORT ON
BEGIN
BEGIN TRY
   if exists(select * from DIEM where MASV = @masv)
   DELETE FROM DIEM WHERE MASV = @masv
   if exists(select * from SINHVIEN where MASV = @masv)
   DELETE FROM SINHVIEN WHERE MASV = @masv

END TRY
BEGIN CATCH
   ROLLBACK
   DECLARE @ErrorMessage VARCHAR(2000)
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH

BEGIN TRY
   if exists(select * from LINK1.QLDSV.DBO.DIEM where MASV = @masv)
   DELETE FROM LINK1.QLDSV.DBO.DIEM WHERE MASV = @masv
   if exists(select * from LINK1.QLDSV.DBO.SINHVIEN where MASV = @masv)
   DELETE FROM LINK1.QLDSV.DBO.SINHVIEN WHERE MASV = @masv
   
END TRY
BEGIN CATCH
   ROLLBACK
   SELECT @ErrorMessage = 'Lỗi: ' + ERROR_MESSAGE()
   RAISERROR(@ErrorMessage, 16, 1)
END CATCH
end
GO
ALTER AUTHORIZATION ON [dbo].[SP_XoaSV_2Khoa] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[TAO_LOGIN]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[TAO_LOGIN]
  @LGNAME VARCHAR(50),
  @PASS VARCHAR(50),
  @USRNAME VARCHAR(50),
 @ROLE VARCHAR(50)
AS
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLDSV'
   IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1
 
  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USRNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END

IF (@ROLE ='ADMIN' or @ROLE ='ADMIN_KHOA')
BEGIN
  EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  EXEC sp_addsrvrolemember @LGNAME, 'DBCreator'
  EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
  EXEC sp_addrolemember 'ADMIN', @USRNAME
END
ELSE  -- THUOC NHOM KHAC
BEGIN
   EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
  EXEC sp_addrolemember 'USER', @USRNAME
END
RETURN 0  -- THANH CONG

GO
ALTER AUTHORIZATION ON [dbo].[TAO_LOGIN] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[DIEM]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DIEM](
	[MASV] [char](8) NOT NULL,
	[MAMH] [char](6) NOT NULL,
	[LAN] [smallint] NOT NULL,
	[DIEM] [float] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_DIEM] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC,
	[MAMH] ASC,
	[LAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[DIEM] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[GIANGVIEN]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIANGVIEN](
	[magv] [nchar](10) NOT NULL,
	[ho] [nvarchar](50) NULL,
	[ten] [nvarchar](50) NULL,
	[loai] [bit] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_GIANGVIEN] PRIMARY KEY CLUSTERED 
(
	[magv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER AUTHORIZATION ON [dbo].[GIANGVIEN] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHOA](
	[MAKH] [char](4) NOT NULL,
	[TENKH] [varchar](50) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[KHOA] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[LOP]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOP](
	[MALOP] [char](8) NOT NULL,
	[TENLOP] [varchar](80) NULL,
	[MAKH] [char](4) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_LOP] PRIMARY KEY CLUSTERED 
(
	[MALOP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[LOP] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[MONHOC]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONHOC](
	[MAMH] [char](6) NOT NULL,
	[TENMH] [varchar](40) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_MONHOC] PRIMARY KEY CLUSTERED 
(
	[MAMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[MONHOC] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 6/22/2015 10:58:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [char](8) NOT NULL,
	[HO] [varchar](40) NULL,
	[TEN] [varchar](10) NULL,
	[MALOP] [char](8) NOT NULL,
	[PHAI] [bit] NULL,
	[NGAYSINH] [datetime] NULL,
	[NOISINH] [varchar](40) NULL,
	[DIACHI] [varchar](80) NULL,
	[GHICHU] [text] NULL,
	[NGHIHOC] [bit] NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER AUTHORIZATION ON [dbo].[SINHVIEN] TO  SCHEMA OWNER 
GO
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA102', N'CSDL  ', 1, 4, N'3cb7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA102', N'CTDL  ', 1, 4, N'25f12cff-aa14-e511-825e-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA102', N'CTDL  ', 2, 6, N'992a7d05-ab14-e511-825e-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA102', N'LTCB  ', 1, 3, N'3fb7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA102', N'TRR1  ', 1, 7, N'd671969c-4408-e511-8259-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA102', N'VB    ', 1, 3, N'41b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA102', N'VB    ', 2, 5, N'42b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA103', N'CSDL  ', 1, 9, N'43b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA103', N'CTDL  ', 1, 4, N'26f12cff-aa14-e511-825e-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA103', N'CTDL  ', 2, 6, N'9a2a7d05-ab14-e511-825e-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA103', N'LTCB  ', 1, 6, N'45b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA103', N'TRR1  ', 1, 7, N'3c14ad8f-4408-e511-8259-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'08THA103', N'VB    ', 1, 8, N'47b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA010', N'CTDL  ', 1, 4, N'e40b9e50-ab0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA010', N'CTDL  ', 2, 5, N'bb1fe187-ab0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA020', N'CTDL  ', 1, 4, N'2a2da95b-ab0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA020', N'CTDL  ', 2, 6, N'bc1fe187-ab0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA021', N'CTDL  ', 1, 6, N'2b2da95b-ab0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA022', N'CTDL  ', 1, 5, N'f9551901-ac0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA090', N'CTDL  ', 1, 3, N'ad366e18-ac0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101', N'CSDL  ', 1, 4, N'fbede525-9e0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA101', N'CSDL  ', 2, 9, N'49fd6397-9e0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA102', N'CSDL  ', 1, 9, N'6b30069e-9e0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA102', N'CTDL  ', 1, 5, N'75701286-a80a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA103', N'CSDL  ', 1, 4, N'7d34f1e2-a20a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA103', N'CTDL  ', 1, 4, N'b335f0b2-a80a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA104', N'CTDL  ', 1, 5, N'e3191796-aa0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA114', N'CTDL  ', 1, 4, N'4e4d6f7a-bf0a-e511-825d-c01885c3791e')
INSERT [dbo].[DIEM] ([MASV], [MAMH], [LAN], [DIEM], [rowguid]) VALUES (N'09THA115', N'CTDL  ', 1, 4, N'399db6c2-bf0a-e511-825d-c01885c3791e')
INSERT [dbo].[GIANGVIEN] ([magv], [ho], [ten], [loai], [rowguid]) VALUES (N'GV01      ', N'Hoàng', N'Bình', 1, N'c2d9cc26-1907-e511-8257-c01885c3791e')
INSERT [dbo].[GIANGVIEN] ([magv], [ho], [ten], [loai], [rowguid]) VALUES (N'GV02      ', N'Huỳnh', N'Thảo', 0, N'c3d9cc26-1907-e511-8257-c01885c3791e')
INSERT [dbo].[GIANGVIEN] ([magv], [ho], [ten], [loai], [rowguid]) VALUES (N'GV03      ', N'Hồng', N'Ngọc', 0, N'70363433-370a-e511-825b-c01885c3791e')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [rowguid]) VALUES (N'CNTT', N'Cong Nghe Thong Tin', N'20b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [rowguid]) VALUES (N'QTKD', N'Quan Tri Kinh Doanh', N'21b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[KHOA] ([MAKH], [TENKH], [rowguid]) VALUES (N'VT  ', N'Vien Thong', N'22b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'C09THA1 ', N'Cao Dang Chinh Qui 1  CNTT  Khoa 12', N'CNTT', N'b4af28cc-ea0b-e511-825d-c01885c3791e')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'C10THA1 ', N'Cao Dang Chinh Quy 1 CNTT Khoa 10', N'CNTT', N'29b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'C12THA1 ', N'Cao Dang Chinh Qui 1  CNTT  Khoa 12', N'CNTT', N'b29f2e80-0c08-e511-8259-c01885c3791e')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D08-HTTT', N'Dai Hoc Chinh Qui 1  CNTT  Khoa 08 ', N'CNTT', N'2ab7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D08VTA1 ', N'Dai Hoc Chinh Qui 1  VT  Khoa 08 ', N'VT  ', N'2bb7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D09THA1 ', N'Dai Hoc Chinh Qui 1  CNTT  Khoa 09', N'CNTT', N'2cb7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D09VTA1 ', N'Dai Hoc Chinh Qui 1  VT  Khoa 09', N'VT  ', N'2db7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D10THA1 ', N'Dai Hoc Chinh Qui 1  CNTT  Khoa 11', N'CNTT', N'85a1afc2-4a08-e511-8259-c01885c3791e')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D10VTA1 ', N'Dai Hoc Chinh Qui 1  VT  Khoa 10', N'VT  ', N'af2b5a32-0b08-e511-8259-c01885c3791e')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D11VTA1 ', N'Dai Hoc Chinh Qui 1  VT  Khoa 10', N'VT  ', N'dab0e42e-eb0b-e511-825d-c01885c3791e')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D12THA1 ', N'Dai Hoc Chinh Qui 1  CNTT  Khoa 11', N'CNTT', N'50c92ec9-4a08-e511-8259-c01885c3791e')
INSERT [dbo].[LOP] ([MALOP], [TENLOP], [MAKH], [rowguid]) VALUES (N'D13THA1 ', N'Dai Hoc Chinh Qui 1  CNTT  Khoa 11', N'CNTT', N'4fc92ec9-4a08-e511-8259-c01885c3791e')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CSDL  ', N'Co So Du Lieu', N'24b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'CTDL  ', N'Cau Truc Du Lieu', N'23b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'LTCB  ', N'Lap trinh can ban', N'26b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'MMT   ', N'Mang May Tinh 1', N'f85574f0-ed0b-e511-825d-c01885c3791e')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'TRR1  ', N'Toan Roi Rac 1', N'0619edff-4308-e511-8259-c01885c3791e')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'TRR2  ', N'Toan Roi Rac 2', N'c7deb6d8-ed0b-e511-825d-c01885c3791e')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'TRR4  ', N'Toan Roi Rac 4', N'8fe1d00f-4408-e511-8259-c01885c3791e')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'TRR5  ', N'Toan Roi Rac 3', N'acf25417-4408-e511-8259-c01885c3791e')
INSERT [dbo].[MONHOC] ([MAMH], [TENMH], [rowguid]) VALUES (N'VB    ', N'Lap Trinh Visual Basic Nang Cao', N'25b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08THA101', N'tr?n nguyên', N'hà', N'D08VTA1 ', 0, CAST(0x0000883300000000 AS DateTime), N'PHU TAN', N'22 Cà mau', N' ', 0, N'3a6304f7-b314-e511-825e-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08THA102', N'Le Thi', N'Van', N'D08-HTTT', 1, CAST(0x0000A4AE00000000 AS DateTime), N'Sai Gon', N'123 Tran Binh Trong', N'', 0, N'30b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08THA103', N'Le Van', N'Hao', N'D08-HTTT', 1, CAST(0x0000854700000000 AS DateTime), N'Phu Yen', N'', N'', 0, N'2eb7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08THA191', N'b', N'a', N'D08-HTTT', 1, CAST(0x0000A4EE00000000 AS DateTime), N'true', N'true', N'true', 1, N'd5ace32f-b414-e511-825e-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08THA192', N'a', N'a', N'D08-HTTT', 1, CAST(0x0000A4EE00000000 AS DateTime), N'true', N'true', N'true', 1, N'93cd1084-b414-e511-825e-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08VTA101', N'Nguyeãn ', N'Haèng', N'D08VTA1 ', 1, CAST(0x00006C5500000000 AS DateTime), N'Haø noäi', N'11 Leâ Vaên Syõ', N'', 0, N'31b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'08VTA102', N'Voõ Vaên', N'Phaùt', N'D08VTA1 ', 1, CAST(0x00006CEB00000000 AS DateTime), N'Phuù Yeân', N'246 Phaân Ñình Phuøng', N' ', 0, N'32b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA010', N'a', N'a', N'C10THA1 ', 0, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'5575f2f9-6d09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA011', N'a', N'a', N'C10THA1 ', 0, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'43c2f9d9-f20b-e511-825d-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA020', N'a', N'a', N'C10THA1 ', 0, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'9e72f514-6e09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA021', N'a', N'a', N'C10THA1 ', 1, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'3f604289-6f09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA022', N'a', N'a', N'C10THA1 ', 1, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'fb309c90-6f09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA090', N'a', N'a', N'C10THA1 ', 1, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'f6f91c89-6d09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA101', N'Le Thi', N'Van', N'D08-HTTT', 1, CAST(0x0000A4AE00000000 AS DateTime), N'Ha Noi', N'Ngo Quyen', N'', 0, N'35b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA102', N'Traàn', N'Ninh', N'D09THA1 ', 1, CAST(0x00006D2A00000000 AS DateTime), N'Saøi goøn', N'222 Lyù Thaùi Toå', N' ', 0, N'34b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA103', N'Nguyen Thi Yen', N'Lan', N'D09THA1 ', 1, CAST(0x0000A4AE00000000 AS DateTime), N'Khanh Hoa', N'333 HHT, BT', N'', 0, N'33b7e442-fc9c-e211-9904-001bfb1b6c2f')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA104', N'Nguyen Thi Yen', N'Lan', N'D09THA1 ', 1, CAST(0x0000A4AE00000000 AS DateTime), N'Khanh Hang', N'333 HHT, BT', N'', 0, N'3ffa12b0-5d09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA105', N'Nguyeãn Thò Yeán', N'Lan', N'D09THA1 ', 0, CAST(0x00006D4A00000000 AS DateTime), N'Khaùnh Hoøa', N'333 HHT, BT', NULL, 0, N'40fa12b0-5d09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA106', N'a', N'a', N'D09THA1 ', 1, CAST(0x00006D4A00000000 AS DateTime), N'true', N'sadsadasd', N'true', 1, N'96b48d9a-6409-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA107', N'a', N'a', N'D09THA1 ', 1, CAST(0x00006D4A00000000 AS DateTime), N'true', N'sadsadasd', N'true', 1, N'580108a1-6409-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA111', N'B', N'a', N'D08-HTTT', 0, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'834e12e5-6709-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA114', N'a', N'a', N'C10THA1 ', 1, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'43747053-6d09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA115', N'a', N'a', N'C10THA1 ', 0, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'f1f42577-6c09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA119', N'B', N'a', N'D08-HTTT', 0, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'4e7ce68a-b214-e511-825e-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA12 ', N'a', N'a', N'C10THA1 ', 1, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'4c1fab5d-6d09-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA162', N'a', N'a', N'D08-HTTT', 1, CAST(0x0000A4EE00000000 AS DateTime), N'true', N'true', N'true', 1, N'f97be050-b314-e511-825e-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA411', N'a', N'a', N'C10THA1 ', 0, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'540cfd7a-6909-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA412', N'a', N'a', N'C10THA1 ', 0, CAST(0x00006D4C00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'e4ac2ea4-6909-e511-825a-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA413', N'a', N'a', N'C10THA1 ', 1, CAST(0x0000A4AE00000000 AS DateTime), N'true', N'saaa', N'true', 1, N'8bc14cf4-4d0b-e511-825d-c01885c3791e')
INSERT [dbo].[SINHVIEN] ([MASV], [HO], [TEN], [MALOP], [PHAI], [NGAYSINH], [NOISINH], [DIACHI], [GHICHU], [NGHIHOC], [rowguid]) VALUES (N'09THA999', N'09THA999', N'09THA999', N'D09THA1 ', 1, CAST(0x0000860900000000 AS DateTime), N'rachgia', N'rachgia', N'khong', 1, N'eba042b6-bd0a-e511-825d-c01885c3791e')
/****** Object:  Index [MSmerge_index_450100644]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_450100644] ON [dbo].[DIEM]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_2000726180]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_2000726180] ON [dbo].[GIANGVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1989582126]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1989582126] ON [dbo].[KHOA]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_565577053]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_565577053] ON [dbo].[LOP]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_MONHOC]    Script Date: 6/22/2015 10:58:45 AM ******/
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [IX_MONHOC] UNIQUE NONCLUSTERED 
(
	[TENMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_402100473]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_402100473] ON [dbo].[MONHOC]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_maloptenho]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE NONCLUSTERED INDEX [IX_maloptenho] ON [dbo].[SINHVIEN]
(
	[MALOP] ASC,
	[TEN] ASC,
	[HO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_SINHVIEN]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE NONCLUSTERED INDEX [IX_SINHVIEN] ON [dbo].[SINHVIEN]
(
	[TEN] ASC,
	[HO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_SINHVIEN_1]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE NONCLUSTERED INDEX [IX_SINHVIEN_1] ON [dbo].[SINHVIEN]
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_SINHVIEN_2]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE NONCLUSTERED INDEX [IX_SINHVIEN_2] ON [dbo].[SINHVIEN]
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_TENHO]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE NONCLUSTERED INDEX [IX_TENHO] ON [dbo].[SINHVIEN]
(
	[TEN] ASC,
	[HO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [MSmerge_index_1909581841]    Script Date: 6/22/2015 10:58:45 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [MSmerge_index_1909581841] ON [dbo].[SINHVIEN]
(
	[rowguid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DIEM] ADD  CONSTRAINT [MSmerge_df_rowguid_8F44607F68094C2A85F461E77AABE37C]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[GIANGVIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_66072B625D1746FCA26FBC8864E85155]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[KHOA] ADD  CONSTRAINT [MSmerge_df_rowguid_A5A237FBC6B6439EA5D8EFAB4563E768]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LOP] ADD  CONSTRAINT [MSmerge_df_rowguid_53AEEEF94F43457BABB3FB2E240A84C0]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[MONHOC] ADD  CONSTRAINT [MSmerge_df_rowguid_BD58171D43584F1DBDFE95F7EA5AC03B]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[SINHVIEN] ADD  CONSTRAINT [MSmerge_df_rowguid_104898C024A44FF294D7F560B5AADA8C]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[DIEM]  WITH CHECK ADD  CONSTRAINT [FK_DIEM_MONHOC1] FOREIGN KEY([MAMH])
REFERENCES [dbo].[MONHOC] ([MAMH])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_MONHOC1]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [FK_DIEM_SINHVIEN] FOREIGN KEY([MASV])
REFERENCES [dbo].[SINHVIEN] ([MASV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [FK_DIEM_SINHVIEN]
GO
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK ADD  CONSTRAINT [FK_SINHVIEN_LOP] FOREIGN KEY([MALOP])
REFERENCES [dbo].[LOP] ([MALOP])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SINHVIEN] CHECK CONSTRAINT [FK_SINHVIEN_LOP]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_DIEM_DIEM] CHECK  (([DIEM]>=(0) AND [DIEM]<=(10) OR [diem]=(-1)))
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [CK_DIEM_DIEM]
GO
ALTER TABLE [dbo].[DIEM]  WITH NOCHECK ADD  CONSTRAINT [CK_DIEM_LAN] CHECK  (([LAN]=(1) OR [LAN]=(2)))
GO
ALTER TABLE [dbo].[DIEM] CHECK CONSTRAINT [CK_DIEM_LAN]
GO
USE [master]
GO
ALTER DATABASE [QLDSV] SET  READ_WRITE 
GO
