using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab08_QuanLyHocSinh
{
    [Table("HocSinh")]
    public class HocSinh
    {
        [Key]
        [StringLength(10)]
        public string MaHS { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string TenHS { get; set; } = string.Empty;

        public DateTime NgaySinh { get; set; } = DateTime.Now;

        [StringLength(150)]
        public string? DiaChi { get; set; }

        [Required]
        [StringLength(10)]
        [ForeignKey("Lop")]
        public string MaLop { get; set; } = string.Empty;

        public float DTB { get; set; } = 0.0f;

        public virtual Lop? Lop { get; set; }
    }
}
