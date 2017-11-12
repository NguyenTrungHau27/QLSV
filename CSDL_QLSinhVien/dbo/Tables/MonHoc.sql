CREATE TABLE [dbo].[MonHoc] (
    [MaMH]       NVARCHAR (10) NOT NULL,
    [TenMH]      NVARCHAR (50) NULL,
    [TinChi]     INT           NULL,
    [TongSoTiet] INT           NULL,
    CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED ([MaMH] ASC)
);

