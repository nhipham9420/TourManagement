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
    public class BUSDoan
    {
        private BangGiaRepository banggiaRepository;
        private DoanRepository doanRepository;
        private ChiPhiRepository chiphiRepository;
        private ChiTietDoanRepository chitietdoanRepository;
        private PhanCongRepository phancongRepository;
        public BUSDoan() 
        { 
            this.banggiaRepository = new BangGiaRepository();
            this.doanRepository = new DoanRepository();
            this.chiphiRepository = new ChiPhiRepository();
            this.chitietdoanRepository = new ChiTietDoanRepository();
            this.phancongRepository = new PhanCongRepository();
        }

        public BUSDoan(
            BangGiaRepository banggiaRepository,
            DoanRepository doanRepository,
            ChiPhiRepository chiphiRepository,
            ChiTietDoanRepository chitietdoanRepository,
            PhanCongRepository phancongRepository)
        {
            this.banggiaRepository = banggiaRepository;
            this.doanRepository = doanRepository;
            this.chiphiRepository = chiphiRepository;
            this.chitietdoanRepository = chitietdoanRepository;
            this.phancongRepository = phancongRepository;
        }

        public List<Doan> GetAll()
        {
            return doanRepository.GetAll();
        }

        public List<Doan> GetByTourId(int id)
        {
            return doanRepository.GetByTourId(id);
        }

        public List<Doan> Search(string searchString)
        {
            return doanRepository.Search(searchString);
        }

        public Doan Insert(Doan obj)
        {
            return doanRepository.Insert(obj);
        }

        public int Update(Doan obj)
        {
            return doanRepository.Update(obj);
        }

        public int Delete(Doan obj)
        {
            return doanRepository.Delete(obj);
        } 

        public List<Doan> ThongKeDoanTheoTour(int tourid, DateTime ngaydi, DateTime ngayve)
        {
            List<Doan> ketqua = new List<Doan>();

            List<Doan> doantheotour = doanRepository.ThongKeDoanTheoTour(tourid, ngaydi, ngayve);

            foreach (Doan doan in doantheotour)
            {
                List<ChiTietDoan> khachtheodoan = chitietdoanRepository.GetByDoanId(doan.DoanId);

                List<ChiPhi> chiphitheodoan = chiphiRepository.GetByDoanId(doan.DoanId);

                List<PhanCong> nhanvientheodoan = phancongRepository.GetByDoanId(doan.DoanId);

                doan.TongKhach = khachtheodoan.Count();

                doan.TongNhanVien = nhanvientheodoan.Count();

                decimal GiaTour = banggiaRepository.GetByTourId(doan.TourId).Select(g => g.GiaTour).FirstOrDefault();

                doan.TongDoanhSo = chiphitheodoan.Sum(c => c.ThanhTien) + (doan.TongKhach * GiaTour);

                ketqua.Add(doan);
            }

            return ketqua;
        }        

        public List<Doan> ThongKeDoan(DateTime ngaydi, DateTime ngayve)
        {
            List<Doan> ketqua = new List<Doan>();

            List<Doan> doantheomocthoigian = doanRepository.ThongKeDoan(ngaydi, ngayve);

            foreach (Doan doan in doantheomocthoigian)
            {
                List<ChiTietDoan> khachtheodoan = chitietdoanRepository.GetByDoanId(doan.DoanId);

                List<ChiPhi> chiphitheodoan = chiphiRepository.GetByDoanId(doan.DoanId);

                List<PhanCong> nhanvientheodoan = phancongRepository.GetByDoanId(doan.DoanId);

                doan.TongKhach = khachtheodoan.Count();

                doan.TongNhanVien = nhanvientheodoan.Count();

                decimal GiaTour = banggiaRepository.GetByTourId(doan.TourId).Select(g => g.GiaTour).FirstOrDefault();

                doan.TongDoanhSo = chiphitheodoan.Sum(c => c.ThanhTien) + (doan.TongKhach * GiaTour);

                ketqua.Add(doan);
            }

            return ketqua;
        }

        public Doan ThongKeDoan(int doanid, DateTime ngaydi, DateTime ngayve)
        {
            Doan ketqua = new Doan();

            ketqua = doanRepository.ThongKeDoan(doanid, ngaydi, ngayve);

            if(ketqua != null)
            {
                List<ChiTietDoan> khachtheodoan = chitietdoanRepository.GetByDoanId(ketqua.DoanId);

                List<ChiPhi> chiphitheodoan = chiphiRepository.GetByDoanId(ketqua.DoanId);

                List<PhanCong> nhanvientheodoan = phancongRepository.GetByDoanId(ketqua.DoanId);
            
                ketqua.TongKhach = khachtheodoan.Count();

                decimal GiaTour = banggiaRepository.GetByTourId(ketqua.TourId).Select(g => g.GiaTour).FirstOrDefault();

                ketqua.TongDoanhSo = chiphitheodoan.Sum(c => c.ThanhTien) + (ketqua.TongKhach * GiaTour);

                ketqua.TongNhanVien = nhanvientheodoan.Count();
            }

            return ketqua;
        }

        public List<Doan> ThongKeDoan(int tourid, int doanid, DateTime ngaydi, DateTime ngayve)
        {
            List<Doan> ketqua = new List<Doan>();

            List<Doan> doantheotour = doanRepository.ThongKeDoan(tourid, doanid, ngaydi, ngayve);

            foreach (Doan doan in doantheotour)
            {
                List<ChiTietDoan> khachtheodoan = chitietdoanRepository.GetByDoanId(doan.DoanId);

                List<ChiPhi> chiphitheodoan = chiphiRepository.GetByDoanId(doan.DoanId);

                List<PhanCong> nhanvientheodoan = phancongRepository.GetByDoanId(doan.DoanId);

                doan.TongKhach = khachtheodoan.Count();

                doan.TongNhanVien = nhanvientheodoan.Count();

                doan.TongDoanhSo = chiphitheodoan.Sum(c => c.ThanhTien);

                ketqua.Add(doan);
            }

            return ketqua;
        }

    }
}
