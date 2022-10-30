using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourManagement.DAL;
using TourManagement.Models;

namespace TourManagement.BUS
{
    public class BUSTour
    {
        private TourRepository tourRepository;
        private BangGiaRepository banggiaRepository;
        private DoanRepository doanRepository;
        private ChiTietDoanRepository chitietdoanRepository;
        private ChiPhiRepository chiphiRepository;
        private PhanCongRepository phancongRepository;        

        public BUSTour() 
        {
            this.tourRepository = new TourRepository();
            this.banggiaRepository = new BangGiaRepository();
            this.doanRepository = new DoanRepository();
            this.chitietdoanRepository = new ChiTietDoanRepository();
            this.chiphiRepository = new ChiPhiRepository();
            this.phancongRepository = new PhanCongRepository();
        }
        public BUSTour(TourRepository tourRepository,
            BangGiaRepository banggiaRepository,
            DoanRepository doanRepository,
            ChiTietDoanRepository chitietdoanRepository,
            ChiPhiRepository chiphiRepository,
            PhanCongRepository phancongRepository)
        {
            this.tourRepository = tourRepository;
            this.banggiaRepository= banggiaRepository;
            this.doanRepository= doanRepository;
            this.chitietdoanRepository = chitietdoanRepository;
            this.chiphiRepository= chiphiRepository;
            this.phancongRepository= phancongRepository;           
        }

        public List<Tour> GetAll()
        {
            return tourRepository.GetAll();
        }

        public List<Tour> Search(string searchString)
        {
            return tourRepository.Search(searchString);
        }

        public Tour Insert(Tour obj)
        {
            return tourRepository.Insert(obj);
        }

        public int Update(Tour obj)
        {
            return tourRepository.Update(obj);
        }

        public int Delete(Tour obj)
        {
            return tourRepository.Delete(obj);
        }

        public List<Tour> ThongKe()
        {
            List<Tour> ketqua = new List<Tour>();

            List<Tour> tmp = tourRepository.GetAll();

            foreach (Tour tour in tmp)
            {
                List<Doan> doantheotour = doanRepository.GetByTourId(tour.TourId);

                tour.TongDoan = doantheotour.Count();

                tour.GiaTour = banggiaRepository.GetByTourId(tour.TourId).Select(g => g.GiaTour).FirstOrDefault();

                List<ChiPhi> chiphitheodoan = new List<ChiPhi>();

                List<ChiTietDoan> khachtheodoan = new List<ChiTietDoan>();

                List<PhanCong> phancongtheodoan = new List<PhanCong>();

                foreach (Doan doan in doantheotour)
                {
                    List<ChiPhi> chiphi = chiphiRepository.GetByDoanId(doan.DoanId);

                    List<ChiTietDoan> chitiet = chitietdoanRepository.GetByDoanId(doan.DoanId);

                    List<PhanCong> phancong = phancongRepository.GetByDoanId(doan.DoanId);

                    chiphitheodoan.AddRange(chiphi);

                    khachtheodoan.AddRange(chitiet);

                    phancongtheodoan.AddRange(phancong);
                }                

                tour.TongKhach = khachtheodoan.Count();

                tour.TongDoanhSo = chiphitheodoan.Sum(cp => cp.ThanhTien) + (tour.TongKhach * tour.GiaTour);

                tour.TongNhanVien = phancongtheodoan.Count();

                ketqua.Add(tour);
            }

            return ketqua;
        }

        public Tour ThongKe(int id)
        {
            Tour tour = tourRepository.GetById(id);

                List<Doan> doantheotour = doanRepository.GetByTourId(tour.TourId);

                tour.TongDoan = doantheotour.Count();

                tour.GiaTour = banggiaRepository.GetByTourId(tour.TourId).Select(g => g.GiaTour).FirstOrDefault();

                List<ChiPhi> chiphitheodoan = new List<ChiPhi>();

                List<ChiTietDoan> khachtheodoan = new List<ChiTietDoan>();

                List<PhanCong> phancongtheodoan = new List<PhanCong>();

                foreach (Doan doan in doantheotour)
                {
                    List<ChiPhi> chiphi = chiphiRepository.GetByDoanId(doan.DoanId);

                    List<ChiTietDoan> chitiet = chitietdoanRepository.GetByDoanId(doan.DoanId);

                    List<PhanCong> phancong = phancongRepository.GetByDoanId(doan.DoanId);

                    chiphitheodoan.AddRange(chiphi);

                    khachtheodoan.AddRange(chitiet);

                    phancongtheodoan.AddRange(phancong);
                }                

                tour.TongKhach = khachtheodoan.Count();

                tour.TongDoanhSo = chiphitheodoan.Sum(cp => cp.ThanhTien) + (tour.TongKhach * tour.GiaTour);

                tour.TongNhanVien = phancongtheodoan.Count();
            

            return tour;
        }

    }
}
