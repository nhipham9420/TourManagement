using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class Doan
    {
        public Doan() { }

        [Key]
        public int DoanId { get; set; }

        public string TenDoan { get; set; }

        public DateTime NgayDi { get; set; }

        public DateTime NgayVe { get; set; }

        public string NoiDung { get; set; }

        public int TourId { get; set; }
        [ForeignKey("TourId")]
        public virtual Tour Tour { get; set; }

        [NotMapped]
        public string TenTour { get { return Tour.TenTour; } }

        [NotMapped]
        public int TongKhach { get; set; }

        [NotMapped]
        public int TongNhanVien { get; set; }

        [NotMapped]
        public decimal TongDoanhSo { get; set; }

        public virtual List<ChiTietDoan> ChiTietDoans { get; set; }
        public virtual List<PhanCong> PhanCongs { get; set; }
        public virtual List<ChiPhi> ChiPhis { get; set; }
    }
}
