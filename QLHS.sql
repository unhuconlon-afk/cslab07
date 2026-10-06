-- =============================================
-- CSDL LAB 08 - QUẢN LÝ HỌC SINH (LINQ TO SQL)
-- Môn: Lập trình Windows (FIT - HCMUP)
-- GV: ThS. Lương Trần Hy Hiến
-- =============================================

USE master;
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QLHS')
BEGIN
    ALTER DATABASE QLHS SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE QLHS;
END
GO

CREATE DATABASE QLHS;
GO

USE QLHS;
GO

-- 1. Bảng Lop
CREATE TABLE Lop (
    MaLop NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL
);
GO

-- 2. Bảng HocSinh
CREATE TABLE HocSinh (
    MaHS NVARCHAR(10) NOT NULL PRIMARY KEY,
    TenHS NVARCHAR(50) NOT NULL,
    NgaySinh DATETIME NOT NULL,
    DiaChi NVARCHAR(150) NULL,
    MaLop NVARCHAR(10) NOT NULL,
    DTB FLOAT NOT NULL DEFAULT 0.0,
    CONSTRAINT FK_HocSinh_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop) ON DELETE CASCADE
);
GO

-- 3. Dữ liệu mẫu (Seed Data)
INSERT INTO Lop (MaLop, TenLop) VALUES 
('10A1', N'Lớp 10 Chuyên Toán'),
('10A2', N'Lớp 10 Chuyên Tin'),
('11B1', N'Lớp 11 Tự Nhiên 1'),
('12C1', N'Lớp 12 Luyện Thi Đại Học');
GO

INSERT INTO HocSinh (MaHS, TenHS, NgaySinh, DiaChi, MaLop, DTB) VALUES 
('HS001', N'Nguyễn Văn An', '2008-03-15', N'123 Nguyễn Trãi, Quận 5, TP.HCM', '10A1', 8.75),
('HS002', N'Trần Thị Bích', '2008-06-20', N'45 Lê Lợi, Quận 1, TP.HCM', '10A1', 9.20),
('HS003', N'Lê Hoàng Cường', '2008-10-05', N'78 CMT8, Quận 3, TP.HCM', '10A2', 7.50),
('HS004', N'Phạm Ngọc Dung', '2007-01-12', N'12 Hai Bà Trưng, Quận 1, TP.HCM', '11B1', 8.10),
('HS005', N'Võ Minh Đức', '2006-09-28', N'90 Hoàng Văn Thụ, Q. Phú Nhuận', '12C1', 6.80);
GO
