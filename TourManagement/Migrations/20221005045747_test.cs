using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TourManagement.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaDiems",
                columns: table => new
                {
                    DiaDiemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDiaDiem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDiems", x => x.DiaDiemId);
                });

            migrationBuilder.CreateTable(
                name: "Khachs",
                columns: table => new
                {
                    KhachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cmnd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuocTich = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khachs", x => x.KhachId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiChiPhis",
                columns: table => new
                {
                    LoaiChiPhiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiChiPhi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiChiPhis", x => x.LoaiChiPhiId);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTours",
                columns: table => new
                {
                    LoaiTourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiTour = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTours", x => x.LoaiTourId);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    NhanVienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.NhanVienId);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    TourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DacDiem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiTourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_Tours_LoaiTours_LoaiTourId",
                        column: x => x.LoaiTourId,
                        principalTable: "LoaiTours",
                        principalColumn: "LoaiTourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BangGias",
                columns: table => new
                {
                    BangGiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaTour = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    ThoiGianBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangGias", x => x.BangGiaId);
                    table.ForeignKey(
                        name: "FK_BangGias_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietTours",
                columns: table => new
                {
                    ChiTietTourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThuTuDiaDiem = table.Column<int>(type: "int", nullable: false),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    DiaDiemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietTours", x => x.ChiTietTourId);
                    table.ForeignKey(
                        name: "FK_ChiTietTours_DiaDiems_DiaDiemId",
                        column: x => x.DiaDiemId,
                        principalTable: "DiaDiems",
                        principalColumn: "DiaDiemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietTours_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doans",
                columns: table => new
                {
                    DoanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayDi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayVe = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoiDung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doans", x => x.DoanId);
                    table.ForeignKey(
                        name: "FK_Doans_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiPhis",
                columns: table => new
                {
                    ChiPhiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThanhTien = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    LoaiChiPhiId = table.Column<int>(type: "int", nullable: false),
                    DoanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiPhis", x => x.ChiPhiId);
                    table.ForeignKey(
                        name: "FK_ChiPhis_Doans_DoanId",
                        column: x => x.DoanId,
                        principalTable: "Doans",
                        principalColumn: "DoanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiPhis_LoaiChiPhis_LoaiChiPhiId",
                        column: x => x.LoaiChiPhiId,
                        principalTable: "LoaiChiPhis",
                        principalColumn: "LoaiChiPhiId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietDoans",
                columns: table => new
                {
                    ChiTietDoanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoanId = table.Column<int>(type: "int", nullable: false),
                    KhachId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietDoans", x => x.ChiTietDoanId);
                    table.ForeignKey(
                        name: "FK_ChiTietDoans_Doans_DoanId",
                        column: x => x.DoanId,
                        principalTable: "Doans",
                        principalColumn: "DoanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietDoans_Khachs_KhachId",
                        column: x => x.KhachId,
                        principalTable: "Khachs",
                        principalColumn: "KhachId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhanCongs",
                columns: table => new
                {
                    PhanCongId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhiemVu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoanId = table.Column<int>(type: "int", nullable: false),
                    NhanVienId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhanCongs", x => x.PhanCongId);
                    table.ForeignKey(
                        name: "FK_PhanCongs_Doans_DoanId",
                        column: x => x.DoanId,
                        principalTable: "Doans",
                        principalColumn: "DoanId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PhanCongs_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "NhanVienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiaDiems",
                columns: new[] { "DiaDiemId", "TenDiaDiem" },
                values: new object[,]
                {
                    { 1, "Sài Gòn" },
                    { 2, "Nha Trang" },
                    { 3, "Đà Lạt" },
                    { 4, "Phú Quốc" },
                    { 5, "Phan Thiết" },
                    { 6, "Sapa" }
                });

            migrationBuilder.InsertData(
                table: "Khachs",
                columns: new[] { "KhachId", "Cmnd", "DiaChi", "GioiTinh", "HoTen", "QuocTich", "SoDienThoai" },
                values: new object[,]
                {
                    { 10, "121234558", "Mỹ Tho", "Nữ", "Nguyễn Văn K", "Vietnam", "0123456780" },
                    { 8, "121234560", "Bến Tre", "Nữ", "Nguyễn Văn H", "Vietnam", "0123456782" },
                    { 7, "121234561", "Kiên Giang", "Nam", "Nguyễn Văn G", "Vietnam", "0123456783" },
                    { 6, "121234562", "Long An", "Nữ", "Nguyễn Văn F", "Vietnam", "0123456784" },
                    { 9, "121234559", "Củ Chi", "Nam", "Nguyễn Văn I", "Vietnam", "0123456781" },
                    { 4, "121234564", "Củ Chi", "Nam", "Nguyễn Văn D", "Vietnam", "0123456786" },
                    { 3, "121234565", "Mỹ Tho", "Nữ", "Nguyễn Văn C", "Vietnam", "0123456787" },
                    { 2, "121234566", "Kiên Giang", "Nam", "Nguyễn Văn B", "Vietnam", "0123456788" },
                    { 1, "121234567", "Long An", "Nữ", "Nguyễn Văn A", "Vietnam", "0123456789" },
                    { 5, "121234563", "Bến Tre", "Nữ", "Nguyễn Văn E", "Vietnam", "0123456785" }
                });

            migrationBuilder.InsertData(
                table: "LoaiChiPhis",
                columns: new[] { "LoaiChiPhiId", "TenLoaiChiPhi" },
                values: new object[,]
                {
                    { 1, "Chi phí ăn uống" },
                    { 2, "Chi phí phương tiện" },
                    { 3, "Chi phí khác" }
                });

            migrationBuilder.InsertData(
                table: "LoaiTours",
                columns: new[] { "LoaiTourId", "TenLoaiTour" },
                values: new object[,]
                {
                    { 4, "Du lịch ẩm thực" },
                    { 3, "Du lịch xã hội và gia đình" },
                    { 2, "Du lịch kết hợp nghề nghiệp" },
                    { 1, "Du lịch di động" }
                });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "NhanVienId", "GioiTinh", "HoTen", "SoDienThoai" },
                values: new object[,]
                {
                    { 6, "Nữ", "Lê Văn F", "0198765437" },
                    { 1, "Nam", "Lê Văn A", "0198765432" },
                    { 2, "Nữ", "Lê Văn B", "0198765433" },
                    { 3, "Nam", "Lê Văn C", "0198765434" },
                    { 4, "Nữ", "Lê Văn D", "0198765435" },
                    { 5, "Nam", "Lê Văn E", "0198765436" },
                    { 7, "Nam", "Lê Văn G", "0198765438" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "DacDiem", "LoaiTourId", "TenTour" },
                values: new object[] { 3, "3 ngày 2 đêm", 2, "Tour C" });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "DacDiem", "LoaiTourId", "TenTour" },
                values: new object[] { 2, null, 3, "Tour B" });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "DacDiem", "LoaiTourId", "TenTour" },
                values: new object[] { 1, "4 ngày 3 đêm", 4, "Tour A" });

            migrationBuilder.InsertData(
                table: "BangGias",
                columns: new[] { "BangGiaId", "GiaTour", "ThoiGianBatDau", "ThoiGianKetThuc", "TourId" },
                values: new object[,]
                {
                    { 3, 4000000m, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Local), 3 },
                    { 2, 3500000m, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Local), 2 },
                    { 1, 3000000m, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Local), 1 }
                });

            migrationBuilder.InsertData(
                table: "ChiTietTours",
                columns: new[] { "ChiTietTourId", "DiaDiemId", "ThuTuDiaDiem", "TourId" },
                values: new object[,]
                {
                    { 8, 3, 1, 3 },
                    { 9, 6, 2, 3 },
                    { 4, 4, 4, 1 },
                    { 5, 6, 1, 2 },
                    { 6, 5, 2, 2 },
                    { 7, 4, 3, 2 },
                    { 3, 3, 3, 1 },
                    { 2, 2, 2, 1 },
                    { 1, 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Doans",
                columns: new[] { "DoanId", "NgayDi", "NgayVe", "NoiDung", "TenDoan", "TourId" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), null, "Đoàn 1", 1 },
                    { 4, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), null, "Đoàn 4", 2 },
                    { 5, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), null, "Đoàn 5", 2 },
                    { 2, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), null, "Đoàn 2", 1 },
                    { 8, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), null, "Đoàn 8", 3 },
                    { 7, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 8, 0, 0, 0, 0, DateTimeKind.Local), null, "Đoàn 7", 3 },
                    { 6, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Local), null, "Đoàn 6", 2 },
                    { 3, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Local), new DateTime(2022, 10, 9, 0, 0, 0, 0, DateTimeKind.Local), null, "Đoàn 3", 1 }
                });

            migrationBuilder.InsertData(
                table: "ChiPhis",
                columns: new[] { "ChiPhiId", "DoanId", "LoaiChiPhiId", "ThanhTien" },
                values: new object[,]
                {
                    { 1, 1, 1, 1000000m },
                    { 9, 3, 3, 50000m },
                    { 8, 3, 2, 700000m },
                    { 7, 3, 1, 1200000m },
                    { 5, 2, 2, 500000m },
                    { 4, 2, 1, 700000m },
                    { 6, 2, 3, 1000000m },
                    { 2, 1, 2, 1000000m },
                    { 3, 1, 3, 1000000m }
                });

            migrationBuilder.InsertData(
                table: "ChiTietDoans",
                columns: new[] { "ChiTietDoanId", "DoanId", "KhachId" },
                values: new object[,]
                {
                    { 7, 2, 5 },
                    { 10, 3, 8 },
                    { 9, 3, 7 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 5, 2, 3 },
                    { 6, 2, 4 },
                    { 4, 1, 4 },
                    { 8, 2, 6 },
                    { 1, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "PhanCongs",
                columns: new[] { "PhanCongId", "DoanId", "NhanVienId", "NhiemVu" },
                values: new object[,]
                {
                    { 1, 1, 1, "Lái xe" },
                    { 5, 2, 5, "Lái xe" },
                    { 7, 3, 3, "Lái xe" },
                    { 4, 1, 4, "Phục vụ" },
                    { 3, 1, 3, "Thông dịch viên" },
                    { 2, 1, 2, "Hướng dẫn viên" },
                    { 6, 2, 6, "Hướng dẫn viên" },
                    { 8, 3, 4, "Phục vụ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangGias_TourId",
                table: "BangGias",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhis_DoanId",
                table: "ChiPhis",
                column: "DoanId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiPhis_LoaiChiPhiId",
                table: "ChiPhis",
                column: "LoaiChiPhiId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDoans_DoanId",
                table: "ChiTietDoans",
                column: "DoanId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietDoans_KhachId",
                table: "ChiTietDoans",
                column: "KhachId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTours_DiaDiemId",
                table: "ChiTietTours",
                column: "DiaDiemId");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietTours_TourId",
                table: "ChiTietTours",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Doans_TourId",
                table: "Doans",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCongs_DoanId",
                table: "PhanCongs",
                column: "DoanId");

            migrationBuilder.CreateIndex(
                name: "IX_PhanCongs_NhanVienId",
                table: "PhanCongs",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_LoaiTourId",
                table: "Tours",
                column: "LoaiTourId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangGias");

            migrationBuilder.DropTable(
                name: "ChiPhis");

            migrationBuilder.DropTable(
                name: "ChiTietDoans");

            migrationBuilder.DropTable(
                name: "ChiTietTours");

            migrationBuilder.DropTable(
                name: "PhanCongs");

            migrationBuilder.DropTable(
                name: "LoaiChiPhis");

            migrationBuilder.DropTable(
                name: "Khachs");

            migrationBuilder.DropTable(
                name: "DiaDiems");

            migrationBuilder.DropTable(
                name: "Doans");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "LoaiTours");
        }
    }
}
