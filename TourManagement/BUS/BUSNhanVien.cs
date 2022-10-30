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
    public class BUSNhanVien
    {
        private NhanVienRepository nhanvienRepository;
        private DoanRepository doanRepository;
        private PhanCongRepository phancongRepository;  
        public BUSNhanVien() 
        {
            this.nhanvienRepository = new NhanVienRepository();
            this.doanRepository = new DoanRepository();
            this.phancongRepository = new PhanCongRepository();
        }

        public BUSNhanVien(NhanVienRepository nhanvienRepository,
            DoanRepository doanRepository,
            PhanCongRepository phancongRepository)
        {
            this.nhanvienRepository = nhanvienRepository;
            this.doanRepository = doanRepository;
            this.phancongRepository = phancongRepository; 
        }

        public List<NhanVien> GetAll()
        {
            return nhanvienRepository.GetAll();
        }

        public List<NhanVien> Search(string searchString)
        {
            return nhanvienRepository.Search(searchString);
        }

        public NhanVien Insert(NhanVien obj)
        {
            return nhanvienRepository.Insert(obj);
        }

        public int Update(NhanVien obj)
        {
            return nhanvienRepository.Update(obj);
        }

        public int Delete(NhanVien obj)
        {
            return nhanvienRepository.Delete(obj);
        }

       public List<DTOThongKeNhanVien> NhanVienChart(int id, DateTime ngaydi, DateTime ngayve)
        {
            List<DTOThongKeNhanVien> ketqua = new List<DTOThongKeNhanVien>();

            var phancong = (from pc in phancongRepository.GetAll()
                                       join d in doanRepository.GetAll()
                                       on pc.DoanId equals d.DoanId into g
                                       from n in g.DefaultIfEmpty()
                                       where pc.NhanVienId == id
                                       && n.NgayDi >= ngaydi
                                       && n.NgayVe <= ngayve
                                       select new
                                       {
                                           pc.NhanVienId,
                                           pc.DoanId,
                                           n.NgayDi,
                                           n.NgayVe                                           
                                       }).ToList();

                DateTime tmpDate = ngaydi.Date;

                while (DateTime.Compare(tmpDate, ngaydi) >= 0 && DateTime.Compare(tmpDate, ngayve) <= 0)
                {   
                    DTOThongKeNhanVien tmp = new DTOThongKeNhanVien();

                    tmp.Month = tmpDate.Month;
                    
                    tmp.Year = tmpDate.Year;
                    
                    var conlai = (from p in phancong
                                    where p.NgayDi >= tmpDate
                                    select new
                                       {
                                           p.NhanVienId,
                                           p.DoanId,
                                           p.NgayDi,
                                           p.NgayVe                                           
                                       }).ToList();

                    tmp.TongTourPhanCong = conlai.Count(pc => pc.NgayDi <= tmpDate.AddMonths(1));

                    ketqua.Add(tmp);
                    
                    tmpDate = tmpDate.AddMonths(1);

                }            

            return ketqua;
        }
    }
}
