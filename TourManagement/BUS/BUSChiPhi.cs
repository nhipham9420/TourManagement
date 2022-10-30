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
    public class BUSChiPhi
    {
        private ChiPhiRepository chiphiRepository;
        private DoanRepository doanRepository;
        private TourRepository tourRepository;
        private BangGiaRepository banggiaRepository;
        private ChiTietDoanRepository chitietdoanRepository;
        public BUSChiPhi()
        {
            this.chiphiRepository = new ChiPhiRepository();
            this.doanRepository = new DoanRepository();
            this.tourRepository = new TourRepository();
            this.banggiaRepository = new BangGiaRepository();
            this.chitietdoanRepository = new ChiTietDoanRepository();
        }
        public BUSChiPhi(ChiPhiRepository chiphiRepository,
            DoanRepository doanRepository,
            TourRepository tourRepository,
            BangGiaRepository banggiaRepository,
            ChiTietDoanRepository chitietdoanRepository)
        {
            this.chiphiRepository = chiphiRepository;
            this.doanRepository = doanRepository;
            this.tourRepository = tourRepository;
            this.banggiaRepository = banggiaRepository;
            this.chitietdoanRepository = chitietdoanRepository;
        }

        public List<ChiPhi> GetAll()
        {
            return chiphiRepository.GetAll();
        }

        public ChiPhi Insert(ChiPhi obj)
        {
            return chiphiRepository.Insert(obj);
        }

        public int Update(ChiPhi obj)
        {
            return chiphiRepository.Update(obj);
        }

        public int Delete(ChiPhi obj)
        {
            return chiphiRepository.Delete(obj);
        }

        public List<ChiPhi> GetByDoanId(int id)
        {
            return chiphiRepository.GetByDoanId(id);
        }

        public List<ChiPhi> GetByLoaiChiPhiId(int id)
        {
            return chiphiRepository.GetByLoaiChiPhiId(id);
        }

        public List<ChiPhi> GetByDoanIdAndLoaiId(int doanid, int loaichiphiid)
        {

            return chiphiRepository.GetByDoanIdAndLoaiId(doanid, loaichiphiid);

        }

        public List<DTOThongKeDoanhSo> DoanhSoChart (DateTime startDateInput, DateTime endDateInput)
        {
            List<DTOThongKeDoanhSo> ketqua = new List<DTOThongKeDoanhSo>();

            var doan = (
                       from d in doanRepository.GetAll()
                       where d.NgayDi >= startDateInput
                       && d.NgayVe <= endDateInput
                       select new
                       {
                          NgayDi = d.NgayDi,
                          NgayVe = d.NgayVe,
                          TongDoanhSo = chiphiRepository.GetByDoanId(d.DoanId).Sum(t => t.ThanhTien) 
                                        + (chitietdoanRepository.GetByDoanId(d.DoanId).Count() 
                                        * banggiaRepository.GetByTourId(d.TourId).FirstOrDefault().GiaTour),
                          d.TourId,
                          d.DoanId
                       }).ToList();
            

            DateTime tmpDate = startDateInput.Date;

            while(DateTime.Compare(tmpDate, startDateInput) >= 0 && DateTime.Compare(tmpDate, endDateInput) <=0 )
            {
                DTOThongKeDoanhSo tmp = new DTOThongKeDoanhSo();

                tmp.Year = tmpDate.Year;

                tmp.Month = tmpDate.Month;

                var conlai = (from t in doan
                          where t.NgayDi >= tmpDate
                          select new
                          {
                              t.NgayDi,
                              t.NgayVe,
                              t.TourId,
                              t.DoanId,
                              t.TongDoanhSo
                          }).ToList();

                tmp.TongDoanhSo = conlai.Where(t => t.NgayDi <= tmpDate.AddMonths(1)).Sum(t => t.TongDoanhSo);

                ketqua.Add(tmp);

                tmpDate = tmpDate.AddMonths(1);
            }
            return ketqua;
        }
       
    }
}
