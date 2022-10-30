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
    public class BUSLoaiChiPhi
    {
        private LoaiChiPhiRepository loaichiphiRepository;
        public BUSLoaiChiPhi() 
        { 
            this.loaichiphiRepository = new LoaiChiPhiRepository();
        }

        public BUSLoaiChiPhi(LoaiChiPhiRepository loaichiphiRepository)
        {
            this.loaichiphiRepository = loaichiphiRepository;
        }

        public LoaiChiPhi Insert(LoaiChiPhi obj)
        {
            return loaichiphiRepository.Insert(obj);
        }

        public int Update(LoaiChiPhi obj)
        {
            return loaichiphiRepository.Update(obj);
        }

        public int Delete(LoaiChiPhi obj)
        {
            return loaichiphiRepository.Delete(obj);
        }

        public List<LoaiChiPhi> GetAll()
        {
            return loaichiphiRepository.GetAll();
        }
    }
}
