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
    public class BUSBangGia
    {
        private BangGiaRepository banggiaRepository;

        public BUSBangGia()
        {
            this.banggiaRepository = new BangGiaRepository();
        }
        public BUSBangGia(BangGiaRepository repository)
        {
            this.banggiaRepository = repository;
        }

        public BangGia Insert(BangGia obj)
        {
            return banggiaRepository.Insert(obj);
        }

        public int Update(BangGia obj)
        {
            return banggiaRepository.Update(obj);
        }

        public int Delete(BangGia obj)
        {
            return banggiaRepository.Delete(obj);
        }

        public List<BangGia> GetByTourId(int id)
        {
            return banggiaRepository.GetByTourId(id);
        }
    }
}
