namespace Lab09_QuanLyBanHang
{
    /// <summary>
    /// Định nghĩa class chứa hàng hóa đang chọn theo mục 4.1 giáo trình LAB 09
    /// </summary>
    public class HangChonMua
    {
        public int MaHH { get; set; }
        public string TenHH { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public double ThanhTien
        {
            get { return SoLuong * DonGia; }
        }
    }
}
