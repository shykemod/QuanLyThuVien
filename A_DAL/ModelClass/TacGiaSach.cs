using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass
{
    [Table("TacGiaSach")]
    public partial class TacGiaSach
    {
        [Key]
        [Column("barCodeSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCodeSach { get; set; } = null!;
        [Key]
        [Column("hoTen")]
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("BarCodeSach")]
        [InverseProperty("TacGiaSaches")]
        public virtual Sach BarCodeSachNavigation { get; set; } = null!;
    }
}
