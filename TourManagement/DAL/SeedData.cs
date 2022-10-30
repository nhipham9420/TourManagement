using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public static class SeedData 
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiTour>().HasData(
                new LoaiTour { LoaiTourId = 1, TenLoaiTour = "Du lịch di động" },
                new LoaiTour { LoaiTourId = 2, TenLoaiTour = "Du lịch kết hợp nghề nghiệp" },
                new LoaiTour { LoaiTourId = 3, TenLoaiTour = "Du lịch xã hội và gia đình" },
                new LoaiTour { LoaiTourId = 4, TenLoaiTour = "Du lịch ẩm thực" });

             modelBuilder.Entity<Tour>().HasData(
                 new Tour { TourId = 1, TenTour = "Tour A", LoaiTourId = 4, DacDiem = "4 ngày 3 đêm"  },
                 new Tour { TourId = 2, TenTour = "Tour B", LoaiTourId = 3, DacDiem = null  },
                 new Tour { TourId = 3, TenTour = "Tour C", LoaiTourId = 2, DacDiem = "3 ngày 2 đêm"  });

            modelBuilder.Entity<BangGia>().HasData(
                new BangGia { BangGiaId = 1, TourId = 1, ThoiGianBatDau = DateTime.Now.Date, ThoiGianKetThuc = DateTime.Now.AddMonths(1).Date, GiaTour = 3000000 },
                new BangGia { BangGiaId = 2, TourId = 2, ThoiGianBatDau = DateTime.Now.Date, ThoiGianKetThuc = DateTime.Now.AddMonths(1).AddDays(15).Date, GiaTour = 3500000 },
                new BangGia { BangGiaId = 3, TourId = 3, ThoiGianBatDau = DateTime.Now.Date, ThoiGianKetThuc = DateTime.Now.AddDays(15).Date, GiaTour = 4000000 }
                );

            modelBuilder.Entity<DiaDiem>().HasData(
                new DiaDiem { DiaDiemId = 1, TenDiaDiem = "Sài Gòn" },
                new DiaDiem { DiaDiemId = 2, TenDiaDiem = "Nha Trang" },
                new DiaDiem { DiaDiemId = 3, TenDiaDiem = "Đà Lạt" },
                new DiaDiem { DiaDiemId = 4, TenDiaDiem = "Phú Quốc" },
                new DiaDiem { DiaDiemId = 5, TenDiaDiem = "Phan Thiết" },
                new DiaDiem { DiaDiemId = 6, TenDiaDiem = "Sapa" }
                );

            modelBuilder.Entity<ChiTietTour>().HasData(
                new ChiTietTour { ChiTietTourId = 1, TourId = 1, DiaDiemId = 1, ThuTuDiaDiem = 1},
                new ChiTietTour { ChiTietTourId = 2, TourId = 1, DiaDiemId = 2, ThuTuDiaDiem = 2},
                new ChiTietTour { ChiTietTourId = 3, TourId = 1, DiaDiemId = 3, ThuTuDiaDiem = 3},
                new ChiTietTour { ChiTietTourId = 4, TourId = 1, DiaDiemId = 4, ThuTuDiaDiem = 4},

                new ChiTietTour { ChiTietTourId = 5, TourId = 2, DiaDiemId = 6, ThuTuDiaDiem = 1},
                new ChiTietTour { ChiTietTourId = 6, TourId = 2, DiaDiemId = 5, ThuTuDiaDiem = 2},
                new ChiTietTour { ChiTietTourId = 7, TourId = 2, DiaDiemId = 4, ThuTuDiaDiem = 3},

                new ChiTietTour { ChiTietTourId = 8, TourId = 3, DiaDiemId = 3, ThuTuDiaDiem = 1},
                new ChiTietTour { ChiTietTourId = 9, TourId = 3, DiaDiemId = 6, ThuTuDiaDiem = 2}
                );

            modelBuilder.Entity<Doan>().HasData(
                new Doan { DoanId = 1, TourId = 1, TenDoan = "Đoàn 1", NgayDi = DateTime.Now.Date, NgayVe = DateTime.Now.AddDays(4).Date, NoiDung = null },
                new Doan { DoanId = 2, TourId = 1, TenDoan = "Đoàn 2", NgayDi = DateTime.Now.Date, NgayVe = DateTime.Now.AddDays(4).Date, NoiDung = null  },
                new Doan { DoanId = 3, TourId = 1, TenDoan = "Đoàn 3", NgayDi = DateTime.Now.Date, NgayVe = DateTime.Now.AddDays(4).Date, NoiDung = null  },

                new Doan { DoanId = 4, TourId = 2, TenDoan = "Đoàn 4", NgayDi = DateTime.Now.Date, NgayVe = DateTime.Now.AddDays(5).Date, NoiDung = null  },
                new Doan { DoanId = 5, TourId = 2, TenDoan = "Đoàn 5", NgayDi = DateTime.Now.Date, NgayVe = DateTime.Now.AddDays(5).Date, NoiDung = null  },
                new Doan { DoanId = 6, TourId = 2, TenDoan = "Đoàn 6", NgayDi = DateTime.Now.Date, NgayVe = DateTime.Now.AddDays(5).Date, NoiDung = null  },

                new Doan { DoanId = 7, TourId = 3, TenDoan = "Đoàn 7", NgayDi = DateTime.Now.Date, NgayVe = DateTime.Now.AddDays(3).Date, NoiDung = null  },
                new Doan { DoanId = 8, TourId = 3, TenDoan = "Đoàn 8", NgayDi = DateTime.Now.Date, NgayVe = DateTime.Now.AddDays(3).Date, NoiDung = null  }
                );

            modelBuilder.Entity<Khach>().HasData(
                new Khach { KhachId = 1, HoTen = "Nguyễn Văn A", SoDienThoai = "0123456789", Cmnd = "121234567", GioiTinh = "Nữ", DiaChi = "Long An", QuocTich = "Vietnam" },
                new Khach { KhachId = 2, HoTen = "Nguyễn Văn B", SoDienThoai = "0123456788", Cmnd = "121234566", GioiTinh = "Nam", DiaChi = "Kiên Giang", QuocTich = "Vietnam" },
                new Khach { KhachId = 3, HoTen = "Nguyễn Văn C", SoDienThoai = "0123456787", Cmnd = "121234565", GioiTinh = "Nữ", DiaChi = "Mỹ Tho", QuocTich = "Vietnam" },
                new Khach { KhachId = 4, HoTen = "Nguyễn Văn D", SoDienThoai = "0123456786", Cmnd = "121234564", GioiTinh = "Nam", DiaChi = "Củ Chi", QuocTich = "Vietnam" },
                new Khach { KhachId = 5, HoTen = "Nguyễn Văn E", SoDienThoai = "0123456785", Cmnd = "121234563", GioiTinh = "Nữ", DiaChi = "Bến Tre", QuocTich = "Vietnam" },
                new Khach { KhachId = 6, HoTen = "Nguyễn Văn F", SoDienThoai = "0123456784", Cmnd = "121234562", GioiTinh = "Nữ", DiaChi = "Long An", QuocTich = "Vietnam" },
                new Khach { KhachId = 7, HoTen = "Nguyễn Văn G", SoDienThoai = "0123456783", Cmnd = "121234561", GioiTinh = "Nam", DiaChi = "Kiên Giang", QuocTich = "Vietnam" },
                new Khach { KhachId = 8, HoTen = "Nguyễn Văn H", SoDienThoai = "0123456782", Cmnd = "121234560", GioiTinh = "Nữ", DiaChi = "Bến Tre", QuocTich = "Vietnam" },
                new Khach { KhachId = 9, HoTen = "Nguyễn Văn I", SoDienThoai = "0123456781", Cmnd = "121234559", GioiTinh = "Nam", DiaChi = "Củ Chi", QuocTich = "Vietnam" },
                new Khach { KhachId = 10, HoTen = "Nguyễn Văn K", SoDienThoai = "0123456780", Cmnd = "121234558", GioiTinh = "Nữ", DiaChi = "Mỹ Tho", QuocTich = "Vietnam" }
                );

            modelBuilder.Entity<ChiTietDoan>().HasData(
                new ChiTietDoan { ChiTietDoanId = 1, DoanId = 1, KhachId = 1 },
                new ChiTietDoan { ChiTietDoanId = 2, DoanId = 1, KhachId = 2 },
                new ChiTietDoan { ChiTietDoanId = 3, DoanId = 1, KhachId = 3 },
                new ChiTietDoan { ChiTietDoanId = 4, DoanId = 1, KhachId = 4 },

                new ChiTietDoan { ChiTietDoanId = 5, DoanId = 2, KhachId = 3 },
                new ChiTietDoan { ChiTietDoanId = 6, DoanId = 2, KhachId = 4 },
                new ChiTietDoan { ChiTietDoanId = 7, DoanId = 2, KhachId = 5 },
                new ChiTietDoan { ChiTietDoanId = 8, DoanId = 2, KhachId = 6 },

                new ChiTietDoan { ChiTietDoanId = 9, DoanId = 3, KhachId = 7 },
                new ChiTietDoan { ChiTietDoanId = 10, DoanId = 3, KhachId = 8 }
                );

            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien { NhanVienId = 1, HoTen = "Lê Văn A", GioiTinh = "Nam", SoDienThoai = "0198765432" },
                new NhanVien { NhanVienId = 2, HoTen = "Lê Văn B", GioiTinh = "Nữ", SoDienThoai = "0198765433" },
                new NhanVien { NhanVienId = 3, HoTen = "Lê Văn C", GioiTinh = "Nam", SoDienThoai = "0198765434" },
                new NhanVien { NhanVienId = 4, HoTen = "Lê Văn D", GioiTinh = "Nữ", SoDienThoai = "0198765435" },
                new NhanVien { NhanVienId = 5, HoTen = "Lê Văn E", GioiTinh = "Nam", SoDienThoai = "0198765436" },
                new NhanVien { NhanVienId = 6, HoTen = "Lê Văn F", GioiTinh = "Nữ", SoDienThoai = "0198765437" },
                new NhanVien { NhanVienId = 7, HoTen = "Lê Văn G", GioiTinh = "Nam", SoDienThoai = "0198765438" }
                );

            modelBuilder.Entity<PhanCong>().HasData(
                new PhanCong { PhanCongId = 1, DoanId = 1, NhanVienId = 1, NhiemVu = "Lái xe" },
                new PhanCong { PhanCongId = 2, DoanId = 1, NhanVienId = 2, NhiemVu = "Hướng dẫn viên" },
                new PhanCong { PhanCongId = 3, DoanId = 1, NhanVienId = 3, NhiemVu = "Thông dịch viên" },
                new PhanCong { PhanCongId = 4, DoanId = 1, NhanVienId = 4, NhiemVu = "Phục vụ" },

                new PhanCong { PhanCongId = 5, DoanId = 2, NhanVienId = 5, NhiemVu = "Lái xe" },
                new PhanCong { PhanCongId = 6, DoanId = 2, NhanVienId = 6, NhiemVu = "Hướng dẫn viên" },

                new PhanCong { PhanCongId = 7, DoanId = 3, NhanVienId = 3, NhiemVu = "Lái xe" },
                new PhanCong { PhanCongId = 8, DoanId = 3, NhanVienId = 4, NhiemVu = "Phục vụ" }
                );

            modelBuilder.Entity<LoaiChiPhi>().HasData(
                new LoaiChiPhi { LoaiChiPhiId = 1, TenLoaiChiPhi = "Chi phí ăn uống"},
                new LoaiChiPhi { LoaiChiPhiId = 2, TenLoaiChiPhi = "Chi phí phương tiện"},
                new LoaiChiPhi { LoaiChiPhiId = 3, TenLoaiChiPhi = "Chi phí khác"}
                );

            modelBuilder.Entity<ChiPhi>().HasData(
                new ChiPhi { ChiPhiId = 1, DoanId = 1, LoaiChiPhiId = 1, ThanhTien = 1000000 },
                new ChiPhi { ChiPhiId = 2, DoanId = 1, LoaiChiPhiId = 2, ThanhTien = 1000000 },
                new ChiPhi { ChiPhiId = 3, DoanId = 1, LoaiChiPhiId = 3, ThanhTien = 1000000 },

                new ChiPhi { ChiPhiId = 4, DoanId = 2, LoaiChiPhiId = 1, ThanhTien = 700000 },
                new ChiPhi { ChiPhiId = 5, DoanId = 2, LoaiChiPhiId = 2, ThanhTien = 500000 },
                new ChiPhi { ChiPhiId = 6, DoanId = 2, LoaiChiPhiId = 3, ThanhTien = 1000000 },

                new ChiPhi { ChiPhiId = 7, DoanId = 3, LoaiChiPhiId = 1, ThanhTien = 1200000 },
                new ChiPhi { ChiPhiId = 8, DoanId = 3, LoaiChiPhiId = 2, ThanhTien = 700000 },
                new ChiPhi { ChiPhiId = 9, DoanId = 3, LoaiChiPhiId = 3, ThanhTien = 50000 }
                );
        }
    } 
}

