using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.DAL;
using TourManagement.Models;

namespace TourManagement.BUS
{
    public class BUSPhanCong
    {
        private PhanCongRepository phancongRepository;

        public BUSPhanCong() 
        { 
            this.phancongRepository = new PhanCongRepository();
        }

        public BUSPhanCong(PhanCongRepository phancongRepository)
        {
            this.phancongRepository = phancongRepository;
        }

        public List<PhanCong> GetByDoanId(int id)
        {
            return phancongRepository.GetByDoanId(id);
        }

        public List<PhanCong> GetByNhanVienId(int id)
        {
            return phancongRepository.GetByNhanVienId(id);
        }

        public PhanCong Insert(PhanCong obj)
        {
            return phancongRepository.Insert(obj);
        }

        public int Update(PhanCong obj)
        {
            return phancongRepository.Update(obj);
        }

        public int Delete(PhanCong obj)
        {
            return phancongRepository.Delete(obj);
        }
    }
}
