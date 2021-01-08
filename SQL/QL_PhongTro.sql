/*
Created: 18/12/2020
Modified: 06/01/2021
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
 [Mã KH] Char(5) NULL
)
go

-- Create indexes for table Phòng

CREATE INDEX [IX_Thuộc] ON [Phòng] ([Mã loại phòng])
go

CREATE INDEX [IX_Relationship25] ON [Phòng] ([Mã KH])
go

-- Add keys for table Phòng

ALTER TABLE [Phòng] ADD CONSTRAINT [PK_Phòng] PRIMARY KEY ([Mã phòng])
go

-- Table Thống kê

CREATE TABLE [Thống kê]
(
 [Số phiếu TK] Char(5) NOT NULL,
 [MaNV] Char(5) NOT NULL
)
go

-- Create indexes for table Thống kê

CREATE INDEX [IX_Lập1] ON [Thống kê] ([MaNV])
go

-- Add keys for table Thống kê

ALTER TABLE [Thống kê] ADD CONSTRAINT [PK_Thống kê] PRIMARY KEY ([Số phiếu TK])
go

-- Table Thiết bị

CREATE TABLE [Thiết bị]
(
 [Ma thiết bị] Char(5) NOT NULL,
 [TenTB] Nvarchar(30) NULL,
 [Mã loại TB] Char(5) NOT NULL
)
go

-- Create indexes for table Thiết bị

CREATE INDEX [IX_Thuộc 2] ON [Thiết bị] ([Mã loại TB])
go

-- Add keys for table Thiết bị

ALTER TABLE [Thiết bị] ADD CONSTRAINT [PK_Thiết bị] PRIMARY KEY ([Ma thiết bị])
go

-- Table Khách hàng

CREATE TABLE [Khách hàng]
(
 [Mã KH] Char(5) NOT NULL,
 [Tên KH] Nvarchar(20) NULL,
 [Năm sinh] Datetime NULL,
 [Sđt] Char(10) NULL,
 [CMND] Char(9) NULL,
 [Quê quán] Nvarchar(50) NULL,
 [Giới tính] Nvarchar(4) NULL
)
go
select * from [Khách hàng]
insert into [Khách hàng]([Mã KH],[Tên KH],[Năm sinh],Sđt,CMND,[Quê quán],[Giới tính]) values 
('KH09',N'Nhã Mèo',14/3/2000,'0123456789','365987421',N'Bến Tre','Nam')

alter table [Khách hàng]
alter column [Năm sinh] date
-- Add keys for table Khách hàng

ALTER TABLE [Khách hàng] ADD CONSTRAINT [PK_Khách hàng] PRIMARY KEY ([Mã KH])
go

-- Table Loại thiết bị

CREATE TABLE [Loại thiết bị]
(
 [Mã loại TB] Char(5) NOT NULL,
 [Tên loại TB] Nvarchar(30) NULL
)
go

-- Add keys for table Loại thiết bị

ALTER TABLE [Loại thiết bị] ADD CONSTRAINT [PK_Loại thiết bị] PRIMARY KEY ([Mã loại TB])
go

-- Table Hóa đơn

CREATE TABLE [Hóa đơn]
(
 [Số hóa đơn] Char(5)  NOT NULL,
 [MaNV] Char(5) NOT NULL,
 [Mã DV] Char(5) NULL,
 [SoHD] Char(5) NULL
)
go

-- Create indexes for table Hóa đơn

CREATE INDEX [IX_Lập] ON [Hóa đơn] ([MaNV])
go

CREATE INDEX [IX_Relationship23] ON [Hóa đơn] ([Mã DV])
go

CREATE INDEX [IX_Relationship27] ON [Hóa đơn] ([SoHD])
go

-- Add keys for table Hóa đơn

ALTER TABLE [Hóa đơn] ADD CONSTRAINT [PK_Hóa đơn] PRIMARY KEY ([Số hóa đơn])
go

-- Table Loại phòng

CREATE TABLE [Loại phòng]
(
 [Mã loại phòng] Char(5) NOT NULL,
 [TenLP] Nvarchar(20) NULL
)
go

-- Add keys for table Loại phòng

ALTER TABLE [Loại phòng] ADD CONSTRAINT [PK_Loại phòng] PRIMARY KEY ([Mã loại phòng])
go

-- Table Nhân viên QL

CREATE TABLE [Nhân viên QL]
(
 [MaNV] Char(5) NOT NULL,
 [Tên NV] Nvarchar(20) NULL
)
go

-- Add keys for table Nhân viên QL

ALTER TABLE [Nhân viên QL] ADD CONSTRAINT [PK_Nhân viên QL] PRIMARY KEY ([MaNV])
go

-- Table DỊch vụ

CREATE TABLE [DỊch vụ]
(
 [Mã DV] Char(5) NOT NULL,
 [Tên DV] Nvarchar(20) NULL,
 [DVT] Nvarchar(10) NULL,
 [Giá DV] Money NOT NULL
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
 [MaNV] Char(5) NULL
)
go

-- Create indexes for table Tài khoản

CREATE INDEX [IX_Relationship35] ON [Tài khoản] ([MaNV])
go

-- Add keys for table Tài khoản

ALTER TABLE [Tài khoản] ADD CONSTRAINT [PK_Tài khoản] PRIMARY KEY ([User name])
go

-- Table CT_TrangBi

CREATE TABLE [CT_TrangBi]
(
 [Mã phòng] Char(5) NOT NULL,
 [Ma thiết bị] Char(5) NOT NULL,
 [SL trang bi] Int DEFAULT 0 NULL,
 [Ngay TB] Datetime NULL,
 [DVT] Nvarchar(10) NULL
)
go

-- Add keys for table CT_TrangBi

ALTER TABLE [CT_TrangBi] ADD CONSTRAINT [PK_CT_TrangBi] PRIMARY KEY ([Mã phòng],[Ma thiết bị])
go

-- Table HOPDONG

CREATE TABLE [HOPDONG]
(
 [SoHD] Char(5)  NOT NULL,
 [NgayLapHD] Datetime NULL,
 [ThoiHanHD] Datetime NULL,
 [Mã KH] Char(5) NULL,
 [Mã phòng] Char(5) NULL,
 [MaNV] Char(5) NULL
)
go
alter table [HOPDONG]
alter column [ThoiHanHD] date

set dateformat dmy
-- Create indexes for table HOPDONG

CREATE INDEX [IX_Relationship25] ON [HOPDONG] ([Mã KH])
go

CREATE INDEX [IX_Relationship26] ON [HOPDONG] ([Mã phòng])
go

CREATE INDEX [IX_Relationship28] ON [HOPDONG] ([MaNV])
go

-- Add keys for table HOPDONG

ALTER TABLE [HOPDONG] ADD CONSTRAINT [PK_HOPDONG] PRIMARY KEY ([SoHD])
go

-- Create foreign keys (relationships) section ------------------------------------------------- 


ALTER TABLE [Thiết bị] ADD CONSTRAINT [Thuộc 2] FOREIGN KEY ([Mã loại TB]) REFERENCES [Loại thiết bị] ([Mã loại TB]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Phòng] ADD CONSTRAINT [Thuộc] FOREIGN KEY ([Mã loại phòng]) REFERENCES [Loại phòng] ([Mã loại phòng]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Thống kê] ADD CONSTRAINT [Lập1] FOREIGN KEY ([MaNV]) REFERENCES [Nhân viên QL] ([MaNV]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Hóa đơn] ADD CONSTRAINT [Lập] FOREIGN KEY ([MaNV]) REFERENCES [Nhân viên QL] ([MaNV]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Tài khoản] ADD CONSTRAINT [Có] FOREIGN KEY ([MaNV]) REFERENCES [Nhân viên QL] ([MaNV]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Hóa đơn] ADD CONSTRAINT [nằm trong] FOREIGN KEY ([Mã DV]) REFERENCES [DỊch vụ] ([Mã DV]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [CT_TrangBi] ADD CONSTRAINT [Relationship23] FOREIGN KEY ([Mã phòng]) REFERENCES [Phòng] ([Mã phòng]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [CT_TrangBi] ADD CONSTRAINT [Relationship24] FOREIGN KEY ([Ma thiết bị]) REFERENCES [Thiết bị] ([Ma thiết bị]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [HOPDONG] ADD CONSTRAINT [Lập2] FOREIGN KEY ([Mã KH]) REFERENCES [Khách hàng] ([Mã KH]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [HOPDONG] ADD CONSTRAINT [Thuê] FOREIGN KEY ([Mã phòng]) REFERENCES [Phòng] ([Mã phòng]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Hóa đơn] ADD CONSTRAINT [Có1] FOREIGN KEY ([SoHD]) REFERENCES [HOPDONG] ([SoHD]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [HOPDONG] ADD CONSTRAINT [Ký] FOREIGN KEY ([MaNV]) REFERENCES [Nhân viên QL] ([MaNV]) ON UPDATE NO ACTION ON DELETE NO ACTION
go


ALTER TABLE [Phòng] ADD CONSTRAINT [Relationship25] FOREIGN KEY ([Mã KH]) REFERENCES [Khách hàng] ([Mã KH]) ON UPDATE NO ACTION ON DELETE NO ACTION
go




