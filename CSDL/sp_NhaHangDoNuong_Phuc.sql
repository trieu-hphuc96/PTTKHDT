use NhaHangDoNuong

----------------------------------------------------------------------------------------------
go
--Lấy danh sách nguyên liệu
create proc sp_LoadIngredient
as
	select * from NguyenLieu

----------------------------------------------------------------------------------------------
go
--Tìm kiếm nguyên liệu
create proc sp_SearchIngredient
			@keyword nvarchar(50)
as
	select distinct *
	from nguyenlieu
	where MANL like '%'+@keyword+'%' or TENNL like '%'+@keyword+'%' or donvi like '%'+@keyword+'%' or hsd like '%'+@keyword+'%'