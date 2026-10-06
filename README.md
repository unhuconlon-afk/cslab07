# CSLAB07: Windows Programming with C# - LAB 08 & LAB 09 (LINQ & REPORT)

## 📌 Giới thiệu tổng quan
Dự án được xây dựng theo chương trình môn học **Lập trình Windows với C#** (Khoa CNTT - Trường ĐH Sư Phạm TP.HCM, Giảng viên: ThS. Lương Trần Hy Hiến), bao gồm đầy đủ 2 bài thực hành:
1. **LAB 08 - LINQ**: Lập trình kết nối CSDL theo mô hình 2 lớp LINQ - Ứng dụng Quản lý Học sinh.
2. **LAB 09 - LINQ + REPORT**: Quản lý Bán hàng đơn giản & In/Xem trước hóa đơn bán hàng.
3. **CSLAB07 Launcher**: Menu trung tâm điều hướng và khởi chạy nhanh từng bài tập.

---

## 📂 Cấu trúc Solution (`cslab07.sln` / `cslab07.slnx`)
```text
cslab07/
├── cslab07_Launcher/              # Dashboard khởi chạy trực quan cả 2 Lab
│   ├── frmLauncher.cs             # Giao diện chọn bài thực hành
│   └── cslab07_Launcher.csproj
├── Lab08_QuanLyHocSinh/           # LAB 08: Quản lý Học sinh (LINQ)
│   ├── Lop.cs                     # Thực thể Lớp học
│   ├── HocSinh.cs                 # Thực thể Học sinh
│   ├── QLHSDataContext.cs         # DataContext LINQ to SQL / EF Core
│   ├── frmQLHocSinh.cs            # Form chính quản lý học sinh
│   └── Lab08_QuanLyHocSinh.csproj
├── Lab09_QuanLyBanHang/           # LAB 09: Quản lý Bán hàng (LINQ + Report)
│   ├── HangHoa.cs                 # Thực thể Hàng hóa
│   ├── HoaDon.cs                  # Thực thể Hóa đơn
│   ├── CTHoaDon.cs                # Thực thể Chi tiết hóa đơn
│   ├── HangChonMua.cs             # DTO hàng hóa đang chọn mua
│   ├── QLBHDataContext.cs         # DataContext LINQ to SQL / EF Core
│   ├── frmBanHang.cs              # Form nghiệp vụ bán hàng
│   ├── frmReport.cs               # Form in & xem trước hóa đơn bán hàng
│   └── Lab09_QuanLyBanHang.csproj
├── QLHS.sql                       # Script tạo CSDL SQL Server cho Lab 08
├── QLBH.sql                       # Script tạo CSDL SQL Server cho Lab 09
├── .gitignore                     # Cấu hình loại bỏ file rác bin/obj/cache
└── README.md                      # Tài liệu hướng dẫn chi tiết
```

---

## 🎯 Chi tiết các bài tập

### 1. LAB 08: Quản lý Học sinh (Mô hình 2 lớp LINQ)
- **Cơ sở dữ liệu**: Bảng `Lop` (MaLop, TenLop) và Bảng `HocSinh` (MaHS, TenHS, NgaySinh, DiaChi, MaLop, DTB).
- **DataContext**: Cung cấp đầy đủ cú pháp tương thích theo giáo trình:
  - `InsertOnSubmit(hs)`: Thêm học sinh.
  - `DeleteOnSubmit(hs)`: Xóa học sinh.
  - `SubmitChanges()`: Cập nhật thay đổi vào CSDL.
- **Thao tác LINQ**:
  - `Where()`, `Contains()`: Lọc theo lớp học (`cboLop`) và tìm kiếm gần đúng theo tên (`txtTenHS`).
  - `SingleOrDefault()`: Tìm kiếm đối tượng học sinh theo mã để thực hiện sửa/xóa.
  - `Count()`: Đếm tổng số học sinh theo điều kiện lọc.
  - `Average()`: Tính điểm trung bình chung của học sinh.
  - `Max()`, `Min()`: Tìm điểm trung bình cao nhất và thấp nhất.
  - `OrderBy()`, `OrderByDescending()`: Sắp xếp danh sách theo tên (A-Z) hoặc theo điểm giảm dần.
- **Tương tác giao diện**: Khi click chọn dòng trên `dgvHocSinh`, dữ liệu tự động đồng bộ lên các ô nhập liệu.

### 2. LAB 09: Quản lý Bán hàng & Report Hóa đơn
- **Cơ sở dữ liệu**: Bảng `HangHoa` (MaHH tự tăng, TenHH, DonGia), `HoaDon` (MaHD tự tăng, NgayLapHD, KhachHang, TongTien), `CTHoaDon` (MaHD, MaHH, SoLuong).
- **Nghiệp vụ giỏ hàng**:
  - Chọn mặt hàng (`cboHangHoa`), số lượng (`nudSoLuong`).
  - Nút **Thêm**: Nếu chưa có thì tạo mới `HangChonMua`, nếu đã có thì cập nhật số lượng.
  - Nút **Xóa mặt hàng**: Cho phép loại bỏ mặt hàng đã chọn khỏi giỏ.
  - Tính tổng tiền tự động bằng LINQ: `dsmua.Sum(p => p.SoLuong * p.DonGia)`.
- **Lập hóa đơn & In Report**:
  - Lưu thông tin khách hàng, hóa đơn mới và toàn bộ chi tiết hóa đơn vào CSDL.
  - Hiển thị Form Report (`frmReport`) xem trước phiếu thu/hóa đơn bán hàng.
  - Tích hợp in hóa đơn (`PrintDocument`) và xem trước khi in (`PrintPreviewDialog`).
  - Tự động chuyển đổi số tiền thành chữ tiếng Việt (ví dụ: `150,000 đ` -> `Một trăm năm mươi nghìn đồng`).

---

## 🚀 Hướng dẫn khởi chạy chương trình

### Cách 1: Chạy Launcher trung tâm (Khuyên dùng)
```bash
dotnet run --project cslab07_Launcher/cslab07_Launcher.csproj
```

### Cách 2: Chạy trực tiếp từng bài thực hành
- **Chạy LAB 08 (Quản lý Học sinh)**:
  ```bash
  dotnet run --project Lab08_QuanLyHocSinh/Lab08_QuanLyHocSinh.csproj
  ```
- **Chạy LAB 09 (Quản lý Bán hàng)**:
  ```bash
  dotnet run --project Lab09_QuanLyBanHang/Lab09_QuanLyBanHang.csproj
  ```

### Ghi chú CSDL:
- Dự án sử dụng SQLite cục bộ (`QLHS.db`, `QLBH.db`) với cơ chế tự động tạo CSDL và seed dữ liệu mẫu khi chạy lần đầu, đảm bảo ứng dụng chạy độc lập trên mọi máy tính mà không cần cấu hình SQL Server phức tạp.
- Script SQL Server gốc (`QLHS.sql`, `QLBH.sql`) được đính kèm sẵn trong thư mục gốc phục vụ cho nhu cầu import trực tiếp vào Microsoft SQL Server Management Studio (SSMS).
