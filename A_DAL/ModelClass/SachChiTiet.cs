using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace A_DAL.DomainClass
{
    [Table("SachChiTiet")]
    public partial class SachChiTiet
    {
        public SachChiTiet()
        {
            PhieuMuonChiTiets = new HashSet<PhieuMuonChiTiet>();
            PhieuTraSaches = new HashSet<PhieuTraSach>();
        }

        [Key]
        [Column("barCodeMaSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string BarCodeMaSach { get; set; } = null!;
        [Column("barCodeSach")]
        [StringLength(13)]
        [Unicode(false)]
        public string? BarCodeSach { get; set; }
        [Column("tinhTrangSach")]
        [StringLength(50)]
        public string? TinhTrangSach { get; set; }
        [Column("lanTaiBan")]
        public int? LanTaiBan { get; set; }
        [Column("kichCo")]
        public string? KichCo { get; set; }
        [Column("namTaiBan", TypeName = "int")]
        [StringLength(20)]
        public int? NamTaiBan { get; set; }

        [Column("diemUyTinMin")]
        [StringLength(10)]
        public int? DiemUyTinMin { get; set; }
        [Column("idNXB")]
        [StringLength(10)]
        [Unicode(false)]
        public string? IdNxb { get; set; }

        [ForeignKey("BarCodeSach")]
        [InverseProperty("SachChiTiets")]
        public virtual Sach? BarCodeSachNavigation { get; set; }
        [ForeignKey("IdNxb")]
        [InverseProperty("SachChiTiets")]
        public virtual NhaXuatBan? IdNxbNavigation { get; set; }
        [InverseProperty("BarCodeMaSachNavigation")]
        public virtual ICollection<PhieuMuonChiTiet> PhieuMuonChiTiets { get; set; }
        [InverseProperty("BarCodeMaSachNavigation")]
        public virtual ICollection<PhieuTraSach> PhieuTraSaches { get; set; }
    }
}
