using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class ChiTietDoanRepository : GenericRepository<ChiTietDoan>
    {
        public List<ChiTietDoan> GetByDoanId(int id)
        {
            return dbcontext.Set<ChiTietDoan>()
                .Where(ct => ct.DoanId.Equals(id))
                .ToList();
        }
    }
}
