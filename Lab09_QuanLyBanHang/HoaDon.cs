using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab09_QuanLyBanHang
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHD { get; set; }

        public DateTime NgayLapHD { get; set; } = DateTime.Now;

        [Required]
        [StringLength(100)]
        public string KhachHang { get; set; } = string.Empty;

        public double TongTien { get; set; } = 0.0;

        public virtual ICollection<CTHoaDon> CTHoaDons { get; set; } = new List<CTHoaDon>();
    }
}
