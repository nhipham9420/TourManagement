using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class Tour
    {
        public Tour() {}

        [Key]
        public int TourId { get; set; }

        public string TenTour { get; set; }

        public string DacDiem { get; set; }

        public int LoaiTourId { get; set; }
        [ForeignKey("LoaiTourId")]
        public virtual LoaiTour LoaiTour { get; set; }

        [NotMapped]
        public string TenLoaiTour { get { return LoaiTour.TenLoaiTour; } }

        [NotMapped]
        public int TongDoan { get; set; }

        [NotMapped]
        public int TongKhach { get; set; }

        [NotMapped]
        public decimal GiaTour { get; set; }

        [NotMapped]
        public int TongNhanVien { get; set; }

        [NotMapped]
        public decimal TongDoanhSo { get; set; }

        public virtual List<BangGia> BangGias { get; set; }
        public virtual List<ChiTietTour> ChiTietTours { get; set; }
        public virtual List<Doan> Doans { get; set; }
    }
}
