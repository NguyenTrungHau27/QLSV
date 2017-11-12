create proc TestXemLichThi(@MSSV nvarchar(10))
as
begin
	Select Thi.*, MonHoc.TenMH
	From Thi,Lop,MonHoc 
	WHERE MonHoc.MaMH = Lop.MaMH and Lop.MaLop = Thi.MaLop and MaSinhVien =@MSSV
end
