--Kiểm tra sỉ số lớp
CREATE PROC CheckClass
	@id nvarchar(10)
AS
	SELECT MaLop AS N'Lớp',COUNT(MaLop) AS N'Số lượng'
	FROM DangKy
	WHERE MaLop = @id
	GROUP BY MaLop
