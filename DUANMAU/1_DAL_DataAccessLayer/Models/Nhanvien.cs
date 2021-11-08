using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("NHANVIEN")]
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Hangs = new HashSet<Hang>();
            Khachhangs = new HashSet<Khachhang>();
        }

        [Key]
        [Column("MANV")]
        [StringLength(20)]
        public string Manv { get; set; }
        [Required]
        [Column("EMAIL")]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [Column("TENNV")]
        [StringLength(50)]
        public string Tennv { get; set; }
        [Required]
        [Column("DIACHI")]
        [StringLength(50)]
        public string Diachi { get; set; }
        [Column("VAITRO")]
        public bool Vaitro { get; set; }
        [Column("TINHTRANG")]
        public bool Tinhtrang { get; set; }
        [Required]
        [Column("MATKHAU")]
        [StringLength(50)]
        public string Matkhau { get; set; }

        [InverseProperty(nameof(Hang.ManvNavigation))]
        public virtual ICollection<Hang> Hangs { get; set; }
        [InverseProperty(nameof(Khachhang.ManvNavigation))]
        public virtual ICollection<Khachhang> Khachhangs { get; set; }
    }
}
