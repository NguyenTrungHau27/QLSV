CREATE TABLE [dbo].[DangKy] (
    [MaLop]      NVARCHAR (10) NOT NULL,
    [MaSinhVien] NVARCHAR (10) NOT NULL,
    [NgayDangKy] DATE          CONSTRAINT [DF_DangKy_NgayDangKy] DEFAULT (getdate()) NOT NULL,
    CONSTRAINT [PK_DangKy] PRIMARY KEY CLUSTERED ([MaLop] ASC, [MaSinhVien] ASC, [NgayDangKy] ASC),
    CONSTRAINT [FK_DangKy_Lop] FOREIGN KEY ([MaLop]) REFERENCES [dbo].[Lop] ([MaLop]),
    CONSTRAINT [FK_DangKy_SinhVien] FOREIGN KEY ([MaSinhVien]) REFERENCES [dbo].[SinhVien] ([MaSinhVien])
);

