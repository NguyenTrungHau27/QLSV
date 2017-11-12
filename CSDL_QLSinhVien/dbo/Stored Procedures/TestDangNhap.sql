create proc TestDangNhap(@MSSV nvarchar(10),@PASS nvarchar(50))
as
begin
	select ID 
	from TaiKhoan
	where ID = @MSSV and Pass = @PASS
end
