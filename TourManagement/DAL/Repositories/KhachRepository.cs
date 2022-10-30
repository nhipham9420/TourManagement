using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class KhachRepository : GenericRepository<Khach>
    {
        public List<Khach> Search(string searchString)
        {
            return dbcontext.Set<Khach>()
            .Where(k =>
                k.HoTen.Contains(searchString) ||
                k.Cmnd.Contains(searchString) ||
                k.GioiTinh.Contains(searchString) ||
                k.DiaChi.Contains(searchString) ||
                k.QuocTich.Contains(searchString) ||
                k.SoDienThoai.Contains(searchString))
            .ToList();

        }
    }
}
