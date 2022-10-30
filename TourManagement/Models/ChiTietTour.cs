using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TourManagement.Models
{
    public class ChiTietTour
    {
        public ChiTietTour() { }

        [Key]
        public int ChiTietTourId { get; set; }

        public int ThuTuDiaDiem { get; set; }

        public int TourId { get; set; }
        [ForeignKey("TourId")]
        public virtual Tour Tour { get; set; }


        public int DiaDiemId { get; set; }
        [ForeignKey("DiaDiemId")]
        public virtual DiaDiem DiaDiem { get; set; }
        [NotMapped]
        public string TenDiaDiem { get {return DiaDiem.TenDiaDiem;} }
    }
}
