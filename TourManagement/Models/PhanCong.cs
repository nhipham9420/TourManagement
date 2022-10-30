using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class PhanCong
    {
        public PhanCong() { }

        [Key]
        public int PhanCongId { get; set; }

        public string NhiemVu { get; set; }

        public int DoanId { get; set; }
        [ForeignKey("DoanId")]
        public virtual Doan Doan { get; set; }

        public int NhanVienId { get; set; }
        [ForeignKey("NhanVienId")]
        public virtual NhanVien NhanVien { get; set; }

        [NotMapped]
        public string HoTen { get {return NhanVien.HoTen;} }
    }
}
