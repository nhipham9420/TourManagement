using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class Khach
    {
        public Khach() { }

        [Key]
        public int KhachId { get; set; }

        public string HoTen { get; set; }

        public string SoDienThoai { get; set; }

        public string Cmnd { get; set; }

        public string GioiTinh { get; set; }

        public string DiaChi { get; set; }

        public string QuocTich { get; set; }

        public virtual List<ChiTietDoan> ChiTietDoans { get; set; }
    }
}
