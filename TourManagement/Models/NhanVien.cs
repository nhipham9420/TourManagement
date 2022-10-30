using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class NhanVien
    {
        public NhanVien() { }

        [Key]
        public int NhanVienId { get; set; }

        public string HoTen { get; set; }

        public string GioiTinh { get; set; }

        public string SoDienThoai { get; set; }

        [NotMapped]
        public int TongTourPhanCong { get; set; }

        [NotMapped]
        public int Month { get; set; }

        [NotMapped]
        public int Year { get; set; }

        public virtual List<PhanCong> PhanCongs { get; set; }
    }
}
