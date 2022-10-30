using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class NhanVienRepository : GenericRepository<NhanVien>
    {
        public List<NhanVien> Search(string searchString)
        {
            return dbcontext.Set<NhanVien>()
            .Where(nv =>
                nv.HoTen.Contains(searchString) ||
                nv.GioiTinh.Contains(searchString) ||
                nv.SoDienThoai.Contains(searchString))
            .ToList();

        }
    }
}
