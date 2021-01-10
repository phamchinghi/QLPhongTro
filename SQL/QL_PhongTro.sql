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


-- Create tables section -------------------------------------------------  PHẢI SET DATABASE LẠI LÀ MẤY CÁI ĐIỆN NƯỚC NẰM RIÊNG 1 BẢNG KHÔNG CÓ DỊCH VỤ GÌ HẾT

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

insert into dbo.Phòng values
--('P101','T01',5,20,'Nam',2500000,N'Trống'),
('P102','T01',5,20,'Nam',2500000,N'Trống'),
('P103','T01',5,20,'Nam',2500000,N'Trống'),
('P104','T01',5,20,'Nam',2500000,N'Trống'),
('P105','T01',5,20,'Ðông',2500000,N'Trống'),
('P106','T01',6,25,'Ðông',2800000,N'Trống'),
('P107','T01',6,25,'Ðông',2800000,N'Trống'),
('P108','T01',5,20,'Ðông',2500000,N'Trống'),
('P201','T02',6,30,'Nam',3000000,N'Trống'),
('P202','T02',6,30,'Nam',3000000,N'Trống'),
('P203','T02',6,25,'Nam',3000000,N'Trống'),
('P204','T02',5,20,'Nam',2500000,N'Trống'),
('P205','T02',6,25,'Ðông',2500000,N'Trống'),
('P206','T02',5,20,'Ðông',2500000,N'Trống'),
('P207','T02',5,20,'Ðông',2500000,N'Trống'),
('P208','T02',5,20,'Ðông',2500000,N'Trống'),
('P301','T03',6,35,'Nam',3500000,N'Trống'),
('P302','T03',6,35,'Nam',3500000,N'Trống'),
('P303','T03',6,35,'Nam',3500000,N'Trống'),
('P304','T03',6,35,'Nam',3500000,N'Trống')
go
Select [Mã phòng],[Mã loại phòng] from dbo.[Phòng]
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

alter table [Thiết bị]
	 add [Mã phòng] char(5)
go

select [Ma thiết bị],TenTB from dbo.[Thiết bị]

alter table [Thiết bị]
	add [DVT] nvarchar(10)
go

alter table [Thiết bị]
	add [Đơn giá] int
go
ALTER TABLE [Thiết bị] ADD CONSTRAINT [Thuộc 4] FOREIGN KEY ([Mã phòng]) REFERENCES [Phòng] ([Mã phòng]) ON UPDATE NO ACTION  ON DELETE NO ACTION
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
 [Giới tính] nvarchar(4) NOT NULL,
 [Mã phòng] char(5)
)
go

alter table [Khách hàng]
	alter column [Năm sinh] Datetime
-- Add keys for table Khách hàng

ALTER TABLE [Khách hàng] ADD CONSTRAINT [PK_Khách hàng] PRIMARY KEY ([Mã KH])
go


alter table [Khách hàng]
 add [Mã phòng] char(5)
 go

ALTER TABLE [Khách hàng] ADD CONSTRAINT [Thuộc 3] FOREIGN KEY ([Mã phòng]) REFERENCES [Phòng] ([Mã phòng]) ON UPDATE NO ACTION  ON DELETE NO ACTION
go
--xong table khách hàng

ALTER TABLE [Khách hàng]
DROP CONSTRAINT [Thuộc 3];

insert into dbo.[Khách hàng]([Mã KH],[Tên KH],[Năm sinh],[Sđt],[CMND],[Quê quán],[Giới tính],[Mã phòng])
	values('KH11','nghigssdg','12/5/2000',1962575203,369821452,'BT','Nam','P103')
insert into dbo.HOPDONG([Mã KH],[Mã phòng])
	values('KH11','P201')
go

--Tạo view cho ds khách trọ
create view DSKhachHang as
	select [Mã KH],[Mã phòng],[Tên KH],[Năm sinh],[Sđt],[Giới tính] ,[Quê quán], CMND from dbo.[Khách hàng]
go



--tạo view cho trang chủ
create view Trangchu as
select dbo.[Khách hàng].[Mã KH],dbo.[Khách hàng].[Mã phòng],[Tên KH] as[Họ tên],[Năm sinh],[Sđt],[Giới tính] AS [Giới tính],[Quê quán], CMND
	from dbo.[Khách hàng] inner join dbo.HOPDONG on dbo.[Khách hàng].[Mã KH] = dbo.HOPDONG.[Mã KH]
go

select   dbo.HOPDONG.[Mã phòng],dbo.[DỊch vụ].[Tên DV] ,dbo.[Hóa đơn].[Số điện tháng trước], dbo.[Hóa đơn].[Số điện tháng này],dbo.[Hóa đơn].[Số nước tháng trước],
		dbo.[Hóa đơn].[Số nước tháng này]
		from ((dbo.[Hóa đơn] 
				inner join dbo.[DỊch vụ] on dbo.[Hóa đơn].[Mã DV] = dbo.[DỊch vụ].[Mã DV])
				inner join dbo.HOPDONG on dbo.[Hóa đơn].SoHD = dbo.HOPDONG.SoHD)
go

select * from Trangchu
go

--tạo proc
create proc proc_ThemKH(@makh Char(5),@tenkh Nvarchar(30), @namsinh Date,@Sdt Char(10),@CMND Char(9),@quequan Nvarchar(50),@gioitinh nvarchar(4)) as
	insert into dbo.[Khách hàng] values(@makh,@tenkh,@namsinh,@Sdt,@CMND,@quequan,@gioitinh)
go

drop proc proc_ThemKH
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
 [SoHD] Int NOT NULL,
 [Số điện tháng trước] Int NOT NULL,
 [Số điện tháng này] Int NOT NULL,
 [Số nước tháng trước] Int NOT NULL,
 [Số nước tháng này] Int NOT NULL,
 [Tổng tiền] Int NOT NULL,
 [Ngày lập hóa đơn] Date NOT NULL
)
go

alter table [Hóa đơn]
	add [Mã điện] Char(5),
		[Mã nước] Char(5),
		[Mã wifi] Char(5),
		[Mã rác] Char(5),
		[Mã xe] Char(5);
go


alter table Xe
	add [Số lượng] int
-- Add keys for table Hóa đơn

ALTER TABLE [Hóa đơn] ADD CONSTRAINT [PK_Hóa đơn] PRIMARY KEY ([Số hóa đơn])
go

create view hoadon as
select dbo.HOPDONG.[Mã phòng],dbo.[Hóa đơn].[Ngày lập hóa đơn],[Số điện tháng trước],[Số điện tháng này],
		[Số nước tháng trước],[Số nước tháng này],([Số điện tháng này] - [Số điện tháng trước])*dbo.Điện.[Giá điện] as [Tiền điện],
		([Số nước tháng này]-[Số nước tháng trước])*dbo.Nước.[Giá nước] as [Tiền nước],
		dbo.Rác.[Giá rác],dbo.Wifi.[Giá wifi],dbo.Xe.[Giá xe], dbo.Phòng.[Giá phòng],
		 (([Số điện tháng này] - [Số điện tháng trước])*dbo.Điện.[Giá điện]) + (([Số nước tháng này]-[Số nước tháng trước])*dbo.Nước.[Giá nước]) + (dbo.Rác.[Giá rác]) + (dbo.Wifi.[Giá wifi]) + dbo.Xe.[Giá xe] + dbo.Phòng.[Giá phòng] as [tổng tiền]
	from (((((((dbo.[Hóa đơn] 
			inner join dbo.HOPDONG on dbo.HOPDONG.SoHD = dbo.[Hóa đơn].SoHD)
			inner join dbo.Điện on dbo.[Hóa đơn].[Mã điện] = dbo.Điện.[Mã điện])
			inner join dbo.Nước on dbo.[Hóa đơn].[Mã nước] = dbo.Nước.[Mã nước])
			inner join dbo.Rác on dbo.[Hóa đơn].[Mã rác] = dbo.Rác.[Mã rác])
			inner join dbo.Wifi on dbo.[Hóa đơn].[Mã wifi] = dbo.Wifi.[Mã wifi])
			inner join dbo.Xe on dbo.[Hóa đơn].[Mã xe] = dbo.Xe.[Mã xe])
			inner join dbo.Phòng on dbo.HOPDONG.[Mã phòng] = dbo.Phòng.[Mã phòng])
go

--Thêm vào hợp đồng số lượng xe
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
-- Table điện
CREATE TABLE [Điện]
(
 [Mã DV] Char(5) NOT NULL,
 [DVT] Nvarchar(10) NOT NULL,
 [Giá điện] Int NOT NULL
)
go
insert into dbo.[Điện]([Mã điện],DVT,[Giá điện]) values ('DD','kwh','0')
go
--table nước
CREATE TABLE [Nước]
(
 [Mã nước] Char(5) NOT NULL,
 [DVT] Nvarchar(10) NOT NULL,
 [Giá nước] Int NOT NULL
)
go
insert into dbo.[Nước]([Mã nước],DVT,[Giá nước]) values('NN','m3','0')
go

--table rác
CREATE TABLE [Rác]
(
 [Mã rác] Char(5) NOT NULL,
 [DVT] Nvarchar(10) NOT NULL,
 [Giá rác] Int NOT NULL
)
go
insert into dbo.[Rác]([Mã rác],DVT,[Giá rác])values('RC','vnđ','0')
--table wifi
CREATE TABLE [Wifi]
(
 [Mã wifi] Char(5) NOT NULL,
 [DVT] Nvarchar(10) NOT NULL,
 [Giá wifi] Int NOT NULL
)
go
insert into dbo.Wifi([Mã wifi],DVT,[Giá wifi]) values('WF','vnđ','0')
go
--table xe
CREATE TABLE [Xe]
(
 [Mã xe] Char(5) NOT NULL,
 [DVT] Nvarchar(10) NOT NULL,
 [Giá xe] Int NOT NULL
)
go
insert into dbo.Xe([Mã xe],DVT,[Giá xe]) values('GX','chiếc','0')
go
-- Add primary keys for table
ALTER TABLE [Nước] ADD CONSTRAINT [PK_Nước] PRIMARY KEY ([Mã nước])
ALTER TABLE [Rác] ADD CONSTRAINT [PK_Rác] PRIMARY KEY ([Mã rác])
ALTER TABLE [Wifi] ADD CONSTRAINT [PK_Wifi] PRIMARY KEY ([Mã wifi])
ALTER TABLE [Xe] ADD CONSTRAINT [PK_Xe] PRIMARY KEY ([Mã xe])
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
insert into dbo.[Tài khoản]([User name], Password,[Tên người dùng])
	values('admin','admin',N'Phạm Lê Văn')
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

exec dbo._GetAccount @username = 'admin', @password = 'admin'
go

CREATE PROC _GetPassword
@password nvarchar(20)
AS 
BEGIN
	SELECT * FROM dbo.[Tài khoản] WHERE  [Password] = @password
END
go


exec dbo._GetPassword @password = 'admin'
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

alter table [CT_TrangBi]
	add [Đơn giá] int
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
 alter column [SoHD] int

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

ALTER TABLE [Hóa đơn] ADD CONSTRAINT [Có2] FOREIGN KEY ([Mã điện]) REFERENCES [Điện] ([Mã điện]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Hóa đơn] ADD CONSTRAINT [Có3] FOREIGN KEY ([Mã nước]) REFERENCES [Nước] ([Mã nước]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Hóa đơn] ADD CONSTRAINT [Có4] FOREIGN KEY ([Mã wifi]) REFERENCES [Wifi] ([Mã wifi]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Hóa đơn] ADD CONSTRAINT [Có5] FOREIGN KEY ([Mã rác]) REFERENCES [Rác] ([Mã rác]) ON UPDATE NO ACTION ON DELETE NO ACTION
go

ALTER TABLE [Hóa đơn] ADD CONSTRAINT [Có6] FOREIGN KEY ([Mã xe]) REFERENCES [Xe] ([Mã xe]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


