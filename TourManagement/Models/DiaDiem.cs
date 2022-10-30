using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class DiaDiem
    {
        public DiaDiem() { }

        [Key]
        public int DiaDiemId { get; set; }

        public string TenDiaDiem { get; set; }

        public virtual List<ChiTietTour> ChiTietTours { get; set; }
    }
}
