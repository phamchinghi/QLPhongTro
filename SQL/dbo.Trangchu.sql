create view Trangchu as
select dbo.[Khách hàng].[Mã KH],dbo.[Khách hàng].[Mã phòng],[Tên KH] as[Họ tên],[Năm sinh],[Sđt],[Giới tính] AS [Giới tính],[Quê quán], CMND
	from dbo.[Khách hàng] inner join dbo.HOPDONG on dbo.[Khách hàng].[Mã KH] = dbo.HOPDONG.[Mã KH]