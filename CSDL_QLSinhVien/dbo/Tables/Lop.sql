CREATE TABLE [dbo].[Lop] (
    [MaLop]         NVARCHAR (10) NOT NULL,
    [MaMH]          NVARCHAR (10) NULL,
    [PhongHoc]      NVARCHAR (10) NULL,
    [NgayBatDauHoc] DATE          NULL,
    [NgayKetThuc]   DATE          NULL,
    [TietBatDau]    INT           NULL,
    [MaGV]          NVARCHAR (10) NULL,
    [DaDangKy]      INT           NULL,
    [SoLuong]       INT           NULL,
    CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED ([MaLop] ASC),
    CONSTRAINT [FK_Lop_GiangVien] FOREIGN KEY ([MaGV]) REFERENCES [dbo].[GiangVien] ([MaGV]),
    CONSTRAINT [FK_Lop_MonHoc] FOREIGN KEY ([MaMH]) REFERENCES [dbo].[MonHoc] ([MaMH])
);

