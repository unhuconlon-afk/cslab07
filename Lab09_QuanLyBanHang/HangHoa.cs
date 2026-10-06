using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab09_QuanLyBanHang
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHH { get; set; }

        [Required]
        [StringLength(100)]
        public string TenHH { get; set; } = string.Empty;

        public double DonGia { get; set; } = 0.0;

        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; } = new List<CTHoaDon>();

        public override string ToString()
        {
            return $"{TenHH} ({DonGia:#,##0} đ)";
        }
    }
}
