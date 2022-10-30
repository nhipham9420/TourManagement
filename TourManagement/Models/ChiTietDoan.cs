using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class ChiTietDoan
    {
        public ChiTietDoan() { }

        [Key]
        public int ChiTietDoanId { get; set; }

        public int DoanId { get; set; }
        [ForeignKey("DoanId")]
        public virtual Doan Doan { get; set; }


        public int KhachId { get; set; }
        [ForeignKey("KhachId")]
        public virtual Khach Khach { get; set; }

        [NotMapped]
        public string HoTen { get {return Khach.HoTen; } }

        [NotMapped]
        public string Cmnd { get {return Khach.Cmnd; } }
    }
}
