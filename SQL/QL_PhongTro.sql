create database QuanLyPhongTro
go
use QuanLyPhongTro
go

/*
Created: 18/12/2020
Modified: 09/01/2021
Model: Microsoft SQL Server 2017
Database: MS SQL Server 2017
*/


-- Create tables section -------------------------------------------------

-- Table Phòng
CREATE TABLE [Phòng]
(
 [Mã phòng] Char(5) NOT NULL,
 [Mã loại phòng] Char(5) NOT NULL,
 [SucChua] Int NOT NULL,
 [DTSD] Int NOT NULL,
 [Huong] Char(4) NULL,
 [Giá phòng] Int NOT NULL default 0,
 [Trạng thái] Nvarchar(10) NOT NULL--đã thuê, còn trống, đã cọc
)
go

insert into dbo.Phòng values('P101','T01',5,20,'Nam',2500000,N'Trống')
go
-- Add keys for table Phòng

ALTER TABLE [Phòng] ADD CONSTRAINT [PK_Phòng] PRIMARY KEY ([Mã phòng])
go


-- Table Thống kê
CREATE TABLE [Thống kê]
(
 [Số phiếu TK] Char(5) NOT NULL,
 [Số hóa đơn] Int NULL
)
go
-- Add keys for table Thống kê

ALTER TABLE [Thống kê] ADD CONSTRAINT [PK_Thống kê] PRIMARY KEY ([Số phiếu TK])
go


-- Table Thiết bị
CREATE TABLE [Thiết bị]
(
 [Ma thiết bị] Char(5) NOT NULL,
 [TenTB] Nvarchar(30) NOT NULL,
 [Mã loại TB] Char(5) NOT NULL
)
go
-- Add keys for table Thiết bị

ALTER TABLE [Thiết bị] ADD CONSTRAINT [PK_Thiết bị] PRIMARY KEY ([Ma thiết bị])
go


-- Table Khách hàng
CREATE TABLE [Khách hàng]
(
 [Mã KH] Char(5)  NOT NULL,
 [Tên KH] Nvarchar(30) NOT NULL,
 [Năm sinh] Date NOT NULL,
 [Sđt] Char(10) NOT NULL,
 [CMND] Char(9) NOT NULL,
 [Quê quán] Nvarchar(50) NOT NULL,
 [Giới tính] bit NOT NULL
)
go
-- Add keys for table Khách hàng

ALTER TABLE [Khách hàng] ADD CONSTRAINT [PK_Khách hàng] PRIMARY KEY ([Mã KH])
go
insert into dbo.[Khách hàng] 
	values('KH12','djfhkj','12/5/2000',1962575203,369821452,'BT',0)
go

--Tạo view cho ds khách trọ
create view DSKhachHang as
	select [Mã KH],[Tên KH],[Năm sinh],[Sđt],IIF([Giới tính] = 0,'NAM', N'Nữ') AS [Giới tính],[Quê quán], CMND from dbo.[Khách hàng]
go

--tạo view cho trang chủ
create view Trangchu as
select dbo.[Khách hàng].[Mã KH],[Mã phòng],[Tên KH],[Năm sinh],[Sđt],IIF([Giới tính] = 0,'NAM', N'Nữ') AS [Giới tính],[Quê quán], CMND
	from dbo.[Khách hàng] inner join dbo.HOPDONG on dbo.[Khách hàng].[Mã KH] = dbo.HOPDONG.[Mã KH]
go
select * from Trangchu
go
--tạo proc
create proc proc_ThemKH(@makh Char(5),@tenkh Nvarchar(30), @namsinh Date,@Sdt Char(10),@CMND Char(9),@quequan Nvarchar(50),@gioitinh bit) as
	insert into dbo.[Khách hàng] values(@makh,@tenkh,@namsinh,@Sdt,@CMND,@quequan,@gioitinh)
go
exec proc_ThemKH 'KH12' ,'skudfg','12/3/2000','0953214875','Nam','BT','126587932'

select * from DSKhachHang
-- Table Loại thiết bị
CREATE TABLE [Loại thiết bị]
(
 [Mã loại TB] Char(5) NOT NULL,
 [Tên loại TB] Nvarchar(30) NOT NULL
)
go
-- Add keys for table Loại thiết bị

ALTER TABLE [Loại thiết bị] ADD CONSTRAINT [PK_Loại thiết bị] PRIMARY KEY ([Mã loại TB])
go


-- Table Hóa đơn
CREATE TABLE [Hóa đơn]
(
 [Số hóa đơn] Int IDENTITY NOT NULL,
 [Mã DV] Char(5) NOT NULL,
 [SoHD] Int NOT NULL,
 [Số điện tháng trước] Int NOT NULL,
 [Số điện tháng này] Int NOT NULL,
 [Số nước tháng trước] Int NOT NULL,
 [Số nước tháng này] Int NOT NULL,
 [Tổng tiền] Int NOT NULL,
 [Ngày lập hóa đơn] Date NOT NULL
)
go
-- Add keys for table Hóa đơn

ALTER TABLE [Hóa đơn] ADD CONSTRAINT [PK_Hóa đơn] PRIMARY KEY ([Số hóa đơn])
go


-- Table Loại phòng
CREATE TABLE [Loại phòng]
(
 [Mã loại phòng] Char(5) NOT NULL,
 [TenLP] Nvarchar(20) NOT NULL
)
go

insert into dbo.[Loại phòng] values('T01',N'Tầng 1')
go
-- Add keys for table Loại phòng

ALTER TABLE [Loại phòng] ADD CONSTRAINT [PK_Loại phòng] PRIMARY KEY ([Mã loại phòng])
go
-- Table DỊch vụ
CREATE TABLE [DỊch vụ]
(
 [Mã DV] Char(5) NOT NULL,
 [Tên DV] Nvarchar(20) NOT NULL,
 [DVT] Nvarchar(10) NOT NULL,
 [Giá DV] Int NOT NULL
)
go
-- Add keys for table DỊch vụ

ALTER TABLE [DỊch vụ] ADD CONSTRAINT [PK_DỊch vụ] PRIMARY KEY ([Mã DV])
go


-- Table Tài khoản
CREATE TABLE [Tài khoản]
(
 [User name] Nvarchar(20) NOT NULL,
 [Password] Nvarchar(20) NOT NULL,
 [Tên người dùng] Nvarchar(30) NOT NULL
)
go
-- Add keys for table Tài khoản

ALTER TABLE [Tài khoản] ADD CONSTRAINT [PK_Tài khoản] PRIMARY KEY ([User name])
go

insert into dbo.[Tài khoản]([User name], Password,[Tên người dùng])
	values('nghi','nghi',N'Phạm Chí Nghị')
go

CREATE TRIGGER [Trigger1]
  ON [Tài khoản]
  AFTER INSERT
  AS
go

CREATE PROC _GetAccount
@userName nvarchar(20),
@password nvarchar(20)
AS 
BEGIN
	SELECT * FROM dbo.[Tài khoản] WHERE [User name] = @userName and [Password] = @password
END
go

exec dbo._GetAccount @username = 'nghi', @password = 'nghi'
go

-- Table CT_TrangBi
CREATE TABLE [CT_TrangBi]
(
 [Mã phòng] Char(5) NOT NULL,
 [Ma thiết bị] Char(5) NOT NULL,
 [SL trang bi] Int DEFAULT 0 NOT NULL,
 [Ngày trang bị] Date NOT NULL,
 [DVT] Nvarchar(10) NOT NULL
)
go
-- Add keys for table CT_TrangBi

ALTER TABLE [CT_TrangBi] ADD CONSTRAINT [PK_CT_TrangBi] PRIMARY KEY ([Mã phòng],[Ma thiết bị])
go


-- Table HOPDONG
CREATE TABLE [HOPDONG]
(
 [SoHD] Int IDENTITY NOT NULL,
 [Mã KH] Char(5) NOT NULL,
 [Mã phòng] Char(5) NOT NULL,
 [NgayLapHD] Date NOT NULL,
 [NgayhethanHD] Date NOT NULL
)
go
alter table HOPDONG
 alter column [SoHD] int IDENTITY(1,1)

insert into dbo.HOPDONG values('KH12','P101','12/12/2019','12/12/2020')
go
-- Add keys for table HOPDONG

ALTER TABLE [HOPDONG] ADD CONSTRAINT [PK_HOPDONG] PRIMARY KEY ([SoHD])
go



ALTER TABLE [Thiết bị] ADD CONSTRAINT [Thuộc 2] FOREIGN KEY ([Mã loại TB]) REFERENCES [Loại thiết bị] ([Mã loại TB]) ON UPDATE NO ACTION  ON DELETE NO ACTION
go


ALTER TABLE [Phòng] ADD CONSTRAINT [Thuộc] FOREIGN KEY ([Mã loại phòng]) REFERENCES [Loại phòng] ([Mã loại phòng]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Hóa đơn] ADD CONSTRAINT [nằm trong] FOREIGN KEY ([Mã DV]) REFERENCES [DỊch vụ] ([Mã DV]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [CT_TrangBi] ADD CONSTRAINT [co] FOREIGN KEY ([Mã phòng]) REFERENCES [Phòng] ([Mã phòng]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [CT_TrangBi] ADD CONSTRAINT [co2] FOREIGN KEY ([Ma thiết bị]) REFERENCES [Thiết bị] ([Ma thiết bị]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [HOPDONG] ADD CONSTRAINT [Lập] FOREIGN KEY ([Mã KH]) REFERENCES [Khách hàng] ([Mã KH]) ON UPDATE NO ACTION ON DELETE Cascade
go


ALTER TABLE [HOPDONG] ADD CONSTRAINT [Thuê] FOREIGN KEY ([Mã phòng]) REFERENCES [Phòng] ([Mã phòng]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Hóa đơn] ADD CONSTRAINT [Có1] FOREIGN KEY ([SoHD]) REFERENCES [HOPDONG] ([SoHD]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Thống kê] ADD CONSTRAINT [tk] FOREIGN KEY ([Số hóa đơn]) REFERENCES [Hóa đơn] ([Số hóa đơn]) ON UPDATE NO ACTION ON DELETE NO ACTION
go




