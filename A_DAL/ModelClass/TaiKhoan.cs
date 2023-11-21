﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass
{
    [Table("TaiKhoan")]
    [Index("IdNhanVien", Name = "UQ__TaiKhoan__214E8259445E1430", IsUnique = true)]
    public partial class TaiKhoan
    {
        [Key]
        [Column("idTaiKhoan")]
        public Guid IdTaiKhoan { get; set; }
        [Column("userName")]
        [StringLength(50)]
        [Unicode(false)]
        public string? UserName { get; set; }
        [Column("passWord")]
        [StringLength(50)]
        [Unicode(false)]
        public string? PassWord { get; set; }
        [Column("idNhanVien")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdNhanVien { get; set; }
        [Column("role")]
        public bool? Role { get; set; }

        [ForeignKey("IdNhanVien")]
        [InverseProperty("TaiKhoan")]
        public virtual NhanVien? IdNhanVienNavigation { get; set; }
    }
}
