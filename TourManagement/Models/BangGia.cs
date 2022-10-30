using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.DAL;

namespace TourManagement.Models
{
    public class BangGia
    {
        public BangGia() { }

        [Key]
        public int BangGiaId { get; set; }


        [Column(TypeName = "decimal(18,0)")]
        public decimal GiaTour { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        public DateTime ThoiGianBatDau { get; set; }


        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [DataType(DataType.Date)]
        public DateTime ThoiGianKetThuc { get; set; }


        public int TourId { get; set; }
        [ForeignKey("TourId")]
        public virtual Tour Tour { get; set; }
    }
}
