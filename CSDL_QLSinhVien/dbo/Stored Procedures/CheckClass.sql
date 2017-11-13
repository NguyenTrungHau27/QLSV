--Kiểm tra sỉ số lớp
CREATE PROC CheckClass
	@id nvarchar(10)
AS
	SELECT COUNT(MaLop) AS N'Số lượng'
	FROM DangKy
	WHERE MaLop = @id
