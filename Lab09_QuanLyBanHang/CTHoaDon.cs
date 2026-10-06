using System.ComponentModel.DataAnnotations.Schema;

namespace Lab09_QuanLyBanHang
{
    [Table("CTHoaDon")]
    public class CTHoaDon
    {
        public int MaHD { get; set; }

        public int MaHH { get; set; }

        public int SoLuong { get; set; } = 1;

        [ForeignKey("MaHD")]
        public virtual HoaDon? HoaDon { get; set; }

        [ForeignKey("MaHH")]
        public virtual HangHoa? HangHoa { get; set; }
    }
}
