CREATE TABLE [dbo].[SinhVien] (
    [MaSinhVien] NVARCHAR (10) NOT NULL,
    [Ho]         NVARCHAR (50) NULL,
    [Ten]        NVARCHAR (10) NULL,
    [NgaySinh]   DATETIME      NULL,
    [NoiSinh]    NVARCHAR (50) NULL,
    [DiaChi]     NVARCHAR (50) NULL,
    [DienThoai]  NVARCHAR (20) NULL,
    [NienKhoa]   NVARCHAR (20) NULL,
    [MaKhoa]     NVARCHAR (10) NULL,
    CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED ([MaSinhVien] ASC),
    CONSTRAINT [FK_SinhVien_Khoa] FOREIGN KEY ([MaKhoa]) REFERENCES [dbo].[Khoa] ([MaKhoa])
);

