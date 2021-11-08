using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("KHACHHANG")]
    public partial class Khachhang
    {
        [Key]
        [Column("DIENTHOAI")]
        [StringLength(15)]
        public string Dienthoai { get; set; }
        [Required]
        [Column("TENKHACH")]
        [StringLength(50)]
        public string Tenkhach { get; set; }
        [Required]
        [Column("DIACHI")]
        [StringLength(100)]
        public string Diachi { get; set; }
        [Required]
        [Column("PHAI")]
        [StringLength(5)]
        public string Phai { get; set; }
        [Required]
        [Column("MANV")]
        [StringLength(20)]
        public string Manv { get; set; }

        [ForeignKey(nameof(Manv))]
        [InverseProperty(nameof(Nhanvien.Khachhangs))]
        public virtual Nhanvien ManvNavigation { get; set; }
    }
}
