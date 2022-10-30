using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class LoaiTour
    {
        public LoaiTour() { }

        [Key]
        public int LoaiTourId { get; set; }

        public string  TenLoaiTour { get; set; }

        public virtual List<Tour> Tours { get; set; }
    }
}
