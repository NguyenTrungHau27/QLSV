--Thêm vào bảng "Đăng Ký"
CREATE PROC AddToDK(
	@classID nvarchar(10),
	@mssv nvarchar(10),
	@time date)
AS
BEGIN
	IF(EXISTS(SELECT * FROM DangKy WHERE MaLop = @classID AND MaSinhVien = @mssv AND NgayDangKy = @time))
		PRINT N'Đã đăng ký rồi'
	ELSE
		INSERT INTO DangKy VALUES(@classID,@mssv,@time)
END
