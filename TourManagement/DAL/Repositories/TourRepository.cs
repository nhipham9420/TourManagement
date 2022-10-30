using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class TourRepository : GenericRepository<Tour>
    {
        public List<Tour> Search(string searchString)
        {

            return dbcontext.Set<Tour>()
            .Where(t =>
                t.TenTour.Contains(searchString) ||
                t.LoaiTour.TenLoaiTour.Contains(searchString) ||
                t.DacDiem.Contains(searchString))
            .ToList();

        }
    }
}
