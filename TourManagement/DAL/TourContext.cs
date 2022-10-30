using Microsoft.EntityFrameworkCore;
using TourManagement.Models;

namespace TourManagement.DAL
{
    public class TourContext : DbContext
    {
        public TourContext()
        {
        }

        public TourContext(DbContextOptions<TourContext> options) : base(options)
        {

        }

        public DbSet<LoaiTour> LoaiTours { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<BangGia> BangGias { get; set; }
        public DbSet<ChiTietTour> ChiTietTours { get; set; }
        public DbSet<DiaDiem> DiaDiems { get; set; }
        public DbSet<Doan> Doans { get; set; }
        public DbSet<Khach> Khachs { get; set; }
        public DbSet<ChiTietDoan> ChiTietDoans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<PhanCong> PhanCongs { get; set; }
        public DbSet<LoaiChiPhi> LoaiChiPhis { get; set; }
        public DbSet<ChiPhi> ChiPhis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Add Seed data from ModelBuilderExtentions - SeedData.cs
            modelBuilder.Seed();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=.\TH;Database=TourData;Trusted_Connection=True");
        }
    }
}
