using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class DoanRepository : GenericRepository<Doan>
    {
        public List<Doan> GetByTourId(int id)
        {

            return dbcontext.Set<Doan>()
                .Where(d => d.TourId.Equals(id))
                .ToList();

        }

        public List<Doan> Search(string searchString)
        {

            return dbcontext.Set<Doan>()
                .Where(d =>
                    d.TenDoan.Contains(searchString) ||
                    d.Tour.TenTour.Contains(searchString) ||
                    d.NoiDung.Contains(searchString))
                .ToList();

        }
        public List<Doan> ThongKeDoanTheoTour(int tourid, DateTime ngaydi, DateTime ngayve)
        {
            return  dbcontext.Set<Doan>()
                    .Where(doan => doan.NgayDi.Date >= ngaydi.Date
                        && doan.NgayVe.Date <= ngayve.Date
                        && doan.TourId == tourid)
                    .ToList();
        }
        public List<Doan> ThongKeDoan(DateTime ngaydi, DateTime ngayve)
        {
            return dbcontext.Set<Doan>()
                  .Where(doan => doan.NgayDi.Date >= ngaydi.Date
                   && doan.NgayVe.Date <= ngayve.Date)
                   .ToList();
        }

        

         public Doan ThongKeDoan(int doanid, DateTime ngaydi, DateTime ngayve)
        {
            return dbcontext.Set<Doan>()
                      .Where(doan => doan.NgayDi.Date >= ngaydi.Date
                       && doan.NgayVe.Date <= ngayve.Date
                       && doan.DoanId == doanid)
                       .FirstOrDefault();
        }


        public List<Doan> ThongKeDoan(int tourid, int doanid, DateTime ngaydi, DateTime ngayve)
        {
            return dbcontext.Set<Doan>()
                    .Where(d => d.NgayDi.Date >= ngaydi.Date
                        && d.NgayVe.Date <= ngayve.Date
                        && d.TourId == tourid
                        && d.DoanId == doanid)
                    .ToList();
        }
    }
}
