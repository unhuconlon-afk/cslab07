-- =============================================
-- CSDL LAB 09 - QUẢN LÝ BÁN HÀNG (LINQ + REPORT)
-- Môn: Lập trình Windows (FIT - HCMUP)
-- GV: ThS. Lương Trần Hy Hiến
-- =============================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QLBH')
BEGIN
    ALTER DATABASE QLBH SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QLBH;
END
GO

CREATE DATABASE QLBH;
GO

USE QLBH;
GO

-- 1. Bảng HangHoa (MaHH tự tăng)
CREATE TABLE HangHoa (
    MaHH INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    TenHH NVARCHAR(100) NOT NULL,
    DonGia FLOAT NOT NULL DEFAULT 0
);
GO

-- 2. Bảng HoaDon (MaHD tự tăng, NgayLapHD mặc định thời điểm hiện tại)
CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    NgayLapHD DATETIME NOT NULL DEFAULT GETDATE(),
    KhachHang NVARCHAR(100) NOT NULL,
    TongTien FLOAT NOT NULL DEFAULT 0
);
GO

-- 3. Bảng CTHoaDon (Chi tiết hóa đơn)
CREATE TABLE CTHoaDon (
    MaHD INT NOT NULL,
    MaHH INT NOT NULL,
    SoLuong INT NOT NULL DEFAULT 1,
    CONSTRAINT PK_CTHoaDon PRIMARY KEY (MaHD, MaHH),
    CONSTRAINT FK_CTHoaDon_HoaDon FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) ON DELETE CASCADE,
    CONSTRAINT FK_CTHoaDon_HangHoa FOREIGN KEY (MaHH) REFERENCES HangHoa(MaHH)
);
GO

-- 4. Dữ liệu mẫu (Seed Data)
INSERT INTO HangHoa (TenHH, DonGia) VALUES
(N'Coca Cola Lon 330ml', 10000),
(N'Pepsi Không Calo 330ml', 10000),
(N'Mì Hảo Hảo Tôm Chua Cay', 4500),
(N'Bánh Mì Tươi Chà Bông', 15000),
(N'Sữa Tươi Tiệt Trùng Vinamilk 220ml', 9500),
(N'Cà Phê Sữa Hòa Tan G7 (Hộp 18 gói)', 58000),
(N'Snack Khoai Tây O''Star 90g', 18000),
(N'Nước Khoáng Lavie 500ml', 6000);
GO
