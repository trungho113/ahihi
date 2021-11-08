using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("HANG")]
    public partial class Hang
    {
        [Key]
        [Column("MAHANG")]
        [StringLength(50)]
        public string Mahang { get; set; }
        [Column("SOLUONG")]
        public int Soluong { get; set; }
        [Column("DONGIABAN")]
        public double Dongiaban { get; set; }
        [Column("DONGIANHAP")]
        public double Dongianhap { get; set; }
        [Required]
        [Column("GHICHU")]
        [StringLength(20)]
        public string Ghichu { get; set; }
        [Required]
        [Column("MANV")]
        [StringLength(20)]
        public string Manv { get; set; }
        [Required]
        [Column("TENHANG")]
        [StringLength(50)]
        public string Tenhang { get; set; }
        [Required]
        [Column("HINHANHSP")]
        [StringLength(400)]
        public string Hinhanhsp { get; set; }

        [ForeignKey(nameof(Manv))]
        [InverseProperty(nameof(Nhanvien.Hangs))]
        public virtual Nhanvien ManvNavigation { get; set; }
    }
}
