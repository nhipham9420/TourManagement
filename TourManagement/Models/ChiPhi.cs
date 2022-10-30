using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.DAL;

namespace TourManagement.Models
{
    public class ChiPhi
    {
        public ChiPhi() { }

        [Key]
        public int ChiPhiId { get; set; }


        [Column(TypeName = "decimal(18,0)")]
        public decimal ThanhTien { get; set; }


        public int LoaiChiPhiId { get; set; }
        [ForeignKey("LoaiChiPhiId")]
        public virtual LoaiChiPhi LoaiChiPhi { get; set; }
        [NotMapped]
        public string TenLoaiChiPhi { get { return LoaiChiPhi.TenLoaiChiPhi; } }


        public int DoanId { get; set; }
        [ForeignKey("DoanId")]
        public virtual Doan Doan { get; set; }     
        [NotMapped]
        public string TenDoan { get { return Doan.TenDoan; } }
    }
}
