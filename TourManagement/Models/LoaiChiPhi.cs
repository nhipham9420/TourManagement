using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourManagement.Models
{
    public class LoaiChiPhi
    {
        public LoaiChiPhi() { }

        [Key]
        public int LoaiChiPhiId { get; set; }

        public string TenLoaiChiPhi { get; set; }

        public virtual List<ChiPhi> ChiPhis { get; set; }
    }
}
