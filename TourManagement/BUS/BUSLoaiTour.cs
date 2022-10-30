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
    public class BUSLoaiTour
    {
        private LoaiTourRepository loaitourRepository;
        public BUSLoaiTour()
        { 
            this.loaitourRepository = new LoaiTourRepository();
        }

        public BUSLoaiTour(LoaiTourRepository loaitourRepository)
        {
            this.loaitourRepository = loaitourRepository;
        }

        public List<LoaiTour> GetAll()
        {
            return loaitourRepository.GetAll();
        }

        public LoaiTour Insert(LoaiTour obj)
        {
            return loaitourRepository.Insert(obj);
        }

        public int Update(LoaiTour obj)
        {
            return loaitourRepository.Update(obj);
        }

        public int Delete(LoaiTour obj)
        {
            return loaitourRepository.Delete(obj);
        }
    }
}
