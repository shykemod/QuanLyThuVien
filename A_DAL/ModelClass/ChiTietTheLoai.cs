using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass
{
    [Table("chiTietTheLoai")]
    public partial class ChiTietTheLoai
    {
        [Key]
        [Column("viTriKeSach")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ViTriKeSach { get; set; }
        [Key]
        [Column("barCode")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCode { get; set; } = null!;

        [ForeignKey("barCode")]
        [InverseProperty("ChiTietTheLoais")]
        public virtual Sach BarCodeNavigation { get; set; } = null!;
        [ForeignKey("viTriKeSach")]
        [InverseProperty("ChiTietTheLoais")]
        public virtual TheLoaiSach IdTheLoaiNavigation { get; set; } = null!;
    }
}
