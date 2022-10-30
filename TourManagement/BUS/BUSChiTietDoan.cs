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
    public class BUSChiTietDoan
    {
        private ChiTietDoanRepository chitietdoanRepository;

        public BUSChiTietDoan() 
        {
            this.chitietdoanRepository = new ChiTietDoanRepository();
        }

        public BUSChiTietDoan(ChiTietDoanRepository chitietdoanRepository)
        {
            this.chitietdoanRepository = chitietdoanRepository;
        }

        public ChiTietDoan Insert(ChiTietDoan obj)
        {
            return chitietdoanRepository.Insert(obj);
        }

        public int Update(ChiTietDoan obj)
        {
            return chitietdoanRepository.Update(obj);
        }

        public int Delete(ChiTietDoan obj)
        {
            return chitietdoanRepository.Delete(obj);
        }

        public List<ChiTietDoan> GetByDoanId(int id)
        {
            return chitietdoanRepository.GetByDoanId(id);
        }
    }
}
