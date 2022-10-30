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
    public class BUSDiaDiem
    {
        private DiaDiemRepository diadiemRepository;

        public BUSDiaDiem() 
        {
            this.diadiemRepository = new DiaDiemRepository();            
        }

        public BUSDiaDiem(DiaDiemRepository diadiemRepository)
        {
            this.diadiemRepository = diadiemRepository;  
        }

        public List<DiaDiem> GetAll()
        {
            return diadiemRepository.GetAll();
        }

        public DiaDiem Insert(DiaDiem obj)
        {
            return diadiemRepository.Insert(obj);
        }

        public int Update(DiaDiem obj)
        {
            return diadiemRepository.Update(obj);
        }

        public int Delete(DiaDiem obj)
        {
            return diadiemRepository.Delete(obj);
        }
    }
}
