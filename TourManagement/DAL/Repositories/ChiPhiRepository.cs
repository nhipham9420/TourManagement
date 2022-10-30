using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class ChiPhiRepository : GenericRepository<ChiPhi>
    {
        public List<ChiPhi> GetByDoanId(int id)
        {

            return dbcontext.Set<ChiPhi>()
                .Where(cp => cp.DoanId.Equals(id))
                .ToList();

        }

        public List<ChiPhi> GetByLoaiChiPhiId(int id)
        {

            return dbcontext.Set<ChiPhi>()
                .Where(cp => cp.LoaiChiPhiId.Equals(id))
                .ToList();

        }

        public List<ChiPhi> GetByDoanIdAndLoaiId(int doanid, int loaichiphiid)
        {

            return dbcontext.Set<ChiPhi>()
                .Where(cp => cp.DoanId == doanid && cp.LoaiChiPhiId == loaichiphiid)
                .ToList();

        }
    }
}
