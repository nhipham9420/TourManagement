using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class BangGiaRepository : GenericRepository<BangGia>
    {
        public List<BangGia> GetByTourId(int id)
        {
            return dbcontext.Set<BangGia>()
                .Where(g => g.TourId.Equals(id))
                .OrderByDescending(g => g.ThoiGianKetThuc)
                .ToList();
        }
    }
}
