using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.DAL;
using TourManagement.Models;

namespace TourManagement.BUS
{
    public class BUSKhach
    {
        private KhachRepository khachRepository;

        public BUSKhach()
        {
            khachRepository = new KhachRepository();
        }

        public BUSKhach(KhachRepository khachRepository)
        {
            this.khachRepository = khachRepository;
        }

        public Khach Insert(Khach obj)
        {
            return khachRepository.Insert(obj);
        }

        public int Update(Khach obj)
        {
            return khachRepository.Update(obj);
        }

        public int Delete(Khach obj)
        {
            return khachRepository.Delete(obj);
        }

        public List<Khach> GetAll()
        {
            return khachRepository.GetAll();
        }

        public List<Khach> Search(string searchString)
        {
            return khachRepository.Search(searchString);
        }
    }
}
