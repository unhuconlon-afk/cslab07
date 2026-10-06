using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab08_QuanLyHocSinh
{
    [Table("Lop")]
    public class Lop
    {
        [Key]
        [StringLength(10)]
        public string MaLop { get; set; } = string.Empty;

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; } = string.Empty;

        public virtual ICollection<HocSinh> HocSinhs { get; set; } = new List<HocSinh>();

        public override string ToString()
        {
            return TenLop;
        }
    }
}
