using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.DAL;
using TourManagement.Models;

namespace TourManagement.BUS
{
    public class BUSChiTietTour
    {
        private ChiTietTourRepository chitiettourRepository;
        public BUSChiTietTour() 
        {
            this.chitiettourRepository = new ChiTietTourRepository();
        }

        public BUSChiTietTour(ChiTietTourRepository chitiettourRepository)
        {
            this.chitiettourRepository =  chitiettourRepository;
        }

        public ChiTietTour Insert(ChiTietTour obj)
        {
            return chitiettourRepository.Insert(obj);
        }

        public int Update(ChiTietTour obj)
        {
            return chitiettourRepository.Update(obj);
        }

        public int Delete(ChiTietTour obj)
        {
            return chitiettourRepository.Delete(obj);
        }

        public List<ChiTietTour> GetByTourId(int id)
        {
            return chitiettourRepository.GetByTourId(id);
        }
    }
}
