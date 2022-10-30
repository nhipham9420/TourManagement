using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class PhanCongRepository : GenericRepository<PhanCong>
    {
        public List<PhanCong> GetByDoanId(int id)
        {

            return dbcontext.Set<PhanCong>()
                .Where(pc => pc.DoanId.Equals(id) || pc.NhanVienId.Equals(id))
                .ToList();

        }

        public List<PhanCong> GetByNhanVienId(int id)
        {

            return dbcontext.Set<PhanCong>()
                .Where(pc => pc.NhanVienId.Equals(id))
                .ToList();

        }
    }
}
