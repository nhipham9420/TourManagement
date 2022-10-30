using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class ChiTietTourRepository : GenericRepository<ChiTietTour>
    {
        public List<ChiTietTour> GetByTourId(int id)
        {
            return dbcontext.Set<ChiTietTour>()
                .Where(ct => ct.TourId.Equals(id))
                .OrderBy(ct => ct.ThuTuDiaDiem)
                .ToList();

        }
    }
}
