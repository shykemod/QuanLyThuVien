using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass
{
    [Table("TheLoaiSach")]
    public partial class TheLoaiSach
    {
        public TheLoaiSach()
        {
            ChiTietTheLoais = new HashSet<ChiTietTheLoai>();
        }

        [Key]
        [Column("viTriKeSach")]
        [StringLength(10)]
        [Unicode(false)]
        public string? ViTriKeSach { get; set; }
        [Column("tenTheLoai")]
        [StringLength(50)]
        public string? TenTheLoai { get; set; }
        

        [InverseProperty("IdTheLoaiNavigation")]
        public virtual ICollection<ChiTietTheLoai> ChiTietTheLoais { get; set; }
    }
}
