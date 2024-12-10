using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLSV.Migrations
{
    /// <inheritdoc />
    public partial class Migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoas",
                columns: table => new
                {
                    KhoaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhoa = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TenKhoa = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoas", x => x.KhoaID);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    TaiKhoanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleID = table.Column<byte>(type: "tinyint", maxLength: 6, nullable: false),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.TaiKhoanID);
                });

            migrationBuilder.CreateTable(
                name: "GiangViens",
                columns: table => new
                {
                    MaSoGV = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenGV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HocVi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KhoaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiangViens", x => x.MaSoGV);
                    table.ForeignKey(
                        name: "FK_GiangViens_Khoas_KhoaID",
                        column: x => x.KhoaID,
                        principalTable: "Khoas",
                        principalColumn: "KhoaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonHocs",
                columns: table => new
                {
                    MaMon = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMon = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoTinChi = table.Column<int>(type: "int", nullable: false),
                    SoTietLT = table.Column<int>(type: "int", nullable: false),
                    SoTietTH = table.Column<int>(type: "int", nullable: false),
                    KhoaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHocs", x => x.MaMon);
                    table.ForeignKey(
                        name: "FK_MonHocs_Khoas_KhoaID",
                        column: x => x.KhoaID,
                        principalTable: "Khoas",
                        principalColumn: "KhoaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LopDanhNghias",
                columns: table => new
                {
                    LopDNID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLopDN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaSoGV = table.Column<long>(type: "bigint", nullable: false),
                    KhoaID = table.Column<long>(type: "bigint", nullable: false),
                    SoLuongSV = table.Column<int>(type: "int", nullable: false),
                    NamNhapHocCuaSV = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopDanhNghias", x => x.LopDNID);
                    table.ForeignKey(
                        name: "FK_LopDanhNghias_GiangViens_MaSoGV",
                        column: x => x.MaSoGV,
                        principalTable: "GiangViens",
                        principalColumn: "MaSoGV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LopDanhNghias_Khoas_KhoaID",
                        column: x => x.KhoaID,
                        principalTable: "Khoas",
                        principalColumn: "KhoaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LopTinChis",
                columns: table => new
                {
                    LopTCID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaLopTC = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaMon = table.Column<long>(type: "bigint", nullable: false),
                    MaSoGV = table.Column<long>(type: "bigint", nullable: false),
                    HocKy = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NamHoc = table.Column<short>(type: "smallint", nullable: false),
                    KhoaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopTinChis", x => x.LopTCID);
                    table.ForeignKey(
                        name: "FK_LopTinChis_GiangViens_MaSoGV",
                        column: x => x.MaSoGV,
                        principalTable: "GiangViens",
                        principalColumn: "MaSoGV",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LopTinChis_Khoas_KhoaID",
                        column: x => x.KhoaID,
                        principalTable: "Khoas",
                        principalColumn: "KhoaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LopTinChis_MonHocs_MaMon",
                        column: x => x.MaMon,
                        principalTable: "MonHocs",
                        principalColumn: "MaMon",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SinhViens",
                columns: table => new
                {
                    MaSoSV = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSV = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    LopDNID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhViens", x => x.MaSoSV);
                    table.ForeignKey(
                        name: "FK_SinhViens_LopDanhNghias_LopDNID",
                        column: x => x.LopDNID,
                        principalTable: "LopDanhNghias",
                        principalColumn: "LopDNID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BangDiems",
                columns: table => new
                {
                    LopTCID = table.Column<long>(type: "bigint", nullable: false),
                    MaSoSV = table.Column<long>(type: "bigint", nullable: false),
                    DiemChuyenCan = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DiemGiuaKy = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    DiemThiCuoiKy = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TiLeDiemQuaTrinh = table.Column<short>(type: "smallint", nullable: false),
                    TiLeDiemThiCuoiKy = table.Column<short>(type: "smallint", nullable: false),
                    DiemTB = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BangDiems", x => new { x.LopTCID, x.MaSoSV });
                    table.ForeignKey(
                        name: "FK_BangDiems_LopTinChis_LopTCID",
                        column: x => x.LopTCID,
                        principalTable: "LopTinChis",
                        principalColumn: "LopTCID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BangDiems_SinhViens_MaSoSV",
                        column: x => x.MaSoSV,
                        principalTable: "SinhViens",
                        principalColumn: "MaSoSV",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Khoas",
                columns: new[] { "KhoaID", "MaKhoa", "TenKhoa" },
                values: new object[,]
                {
                    { 1L, "CNTT", "Khoa Công nghệ thông tin" },
                    { 2L, "KT", "Khoa Kinh tế" },
                    { 3L, "NNA", "Khoa Ngôn ngữ Anh" },
                    { 4L, "XD", "Khoa Xây dựng" },
                    { 5L, "CB", "Khoa Cơ bản" },
                    { 6L, "QTKD", "Khoa Quản trị kinh doanh" }
                });

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "TaiKhoanID", "Email", "MatKhau", "RoleID", "TinhTrang" },
                values: new object[,]
                {
                    { -1, "admin@gmail.com", "111", (byte)1, true },
                    { 1, "nguyenvana@gmail.com", "111", (byte)2, true },
                    { 2, "tranthib@gmail.com", "111", (byte)2, true },
                    { 3, "levanc@gmail.com", "111", (byte)2, true },
                    { 4, "nguyenthid@gmail.com", "111", (byte)2, true }
                });

            migrationBuilder.InsertData(
                table: "GiangViens",
                columns: new[] { "MaSoGV", "Email", "GioiTinh", "HocVi", "KhoaID", "NgaySinh", "TenGV" },
                values: new object[,]
                {
                    { 1L, "nguyenvana@gmail.com", true, "Thạc sĩ", 1L, new DateTime(1990, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyễn Văn A" },
                    { 2L, "tranthib@gmail.com", false, "Tiến sĩ", 2L, new DateTime(1985, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trần Thị B" },
                    { 3L, "levanc@gmail.com", true, "Phó giáo sư", 3L, new DateTime(1978, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lê Văn C" },
                    { 4L, "nguyenthid@gmail.com", false, "Thạc sĩ", 4L, new DateTime(1992, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyễn Thị D" },
                    { 5L, "phamvane@gmail.com", true, "Tiến sĩ", 5L, new DateTime(1980, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phạm Văn E" },
                    { 6L, "vuthif@gmail.com", false, "Giáo sư", 6L, new DateTime(1988, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vũ Thị F" }
                });

            migrationBuilder.InsertData(
                table: "MonHocs",
                columns: new[] { "MaMon", "KhoaID", "SoTietLT", "SoTietTH", "SoTinChi", "TenMon" },
                values: new object[,]
                {
                    { 1L, 1L, 45, 0, 3, "Lập trình Windows" },
                    { 2L, 2L, 60, 0, 4, "Kế toán tài chính" },
                    { 3L, 3L, 45, 0, 3, "Văn học Anh" },
                    { 4L, 4L, 60, 30, 4, "Kỹ thuật xây dựng" },
                    { 5L, 5L, 45, 0, 3, "Toán cao cấp" },
                    { 6L, 6L, 45, 0, 3, "Quản trị nhân sự" }
                });

            migrationBuilder.InsertData(
                table: "LopDanhNghias",
                columns: new[] { "LopDNID", "KhoaID", "MaLopDN", "MaSoGV", "NamNhapHocCuaSV", "SoLuongSV" },
                values: new object[,]
                {
                    { 1L, 1L, "22ĐHTT06", 1L, (short)2022, 60 },
                    { 2L, 2L, "21ĐHKT01", 2L, (short)2021, 50 },
                    { 3L, 3L, "20ĐHNA03", 3L, (short)2020, 40 },
                    { 4L, 4L, "22ĐHXD02", 4L, (short)2022, 55 },
                    { 5L, 5L, "19ĐHQT04", 5L, (short)2019, 45 },
                    { 6L, 6L, "21ĐHQT02", 6L, (short)2021, 60 }
                });

            migrationBuilder.InsertData(
                table: "LopTinChis",
                columns: new[] { "LopTCID", "HocKy", "KhoaID", "MaLopTC", "MaMon", "MaSoGV", "NamHoc" },
                values: new object[,]
                {
                    { 1L, "2", 2L, "22ĐHKT01", 2L, 2L, (short)2024 },
                    { 2L, "1", 1L, "23ĐHTT01", 1L, 1L, (short)2023 },
                    { 3L, "2", 3L, "22ĐHNA01", 3L, 3L, (short)2024 },
                    { 4L, "1", 4L, "23ĐHXD01", 4L, 4L, (short)2023 },
                    { 5L, "2", 5L, "22ĐHQT01", 5L, 5L, (short)2024 },
                    { 6L, "1", 6L, "23ĐHTT06", 6L, 6L, (short)2023 }
                });

            migrationBuilder.InsertData(
                table: "SinhViens",
                columns: new[] { "MaSoSV", "DiaChi", "Email", "GioiTinh", "LopDNID", "NgaySinh", "SoDienThoai", "TenSV", "TrangThai" },
                values: new object[,]
                {
                    { 1L, "Số 10, Đường Trần Hưng Đạo, Quận 1, Thành phố Hồ Chí Minh", "annv@gmail.com", true, 1L, new DateTime(2004, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "0827983728", "Nguyễn Văn An", true },
                    { 2L, "Số 5, Đường Lê Lợi, Quận Hải Châu, Thành phố Đà Nẵng", "bichtt@gmail.com", false, 2L, new DateTime(2003, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "0912345678", "Trần Thị Bích", true },
                    { 3L, "Số 15, Đường Phan Đình Phùng, Quận Ba Đình, Hà Nội", "chaulm@gmail.com", false, 1L, new DateTime(2002, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "0938765432", "Lê Minh Châu", true },
                    { 4L, "Số 20, Đường Nguyễn Trãi, Quận Thanh Xuân, Hà Nội", "datpq@gmail.com", true, 3L, new DateTime(2001, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "0987654321", "Phạm Quốc Đạt", true },
                    { 5L, "Số 25, Đường Lý Tự Trọng, Quận Ninh Kiều, Thành phố Cần Thơ", "hoath@gmail.com", false, 2L, new DateTime(2004, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "0856738291", "Hoàng Thị Hoa", true },
                    { 6L, "Số 8, Đường Trường Sa, Quận Ngũ Hành Sơn, Thành phố Đà Nẵng", "hungvd@gmail.com", true, 1L, new DateTime(2003, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "0827364529", "Vũ Đức Hùng", true },
                    { 7L, "Số 12, Đường Nguyễn Huệ, Quận 1, Thành phố Hồ Chí Minh", "landt@gmail.com", false, 2L, new DateTime(2002, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "0918374652", "Đặng Thị Lan", true },
                    { 8L, "Số 30, Đường Lê Duẩn, Quận 1, Thành phố Hồ Chí Minh", "liembt@gmail.com", true, 3L, new DateTime(2001, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "0908765432", "Bùi Thanh Liêm", true },
                    { 9L, "Số 50, Đường Điện Biên Phủ, Quận Bình Thạnh, Thành phố Hồ Chí Minh", "maidt@gmail.com", false, 1L, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0927364518", "Đỗ Thị Mai", true },
                    { 10L, "Số 18, Đường Nguyễn Thị Minh Khai, Quận 1, Thành phố Hồ Chí Minh", "namnt@gmail.com", true, 2L, new DateTime(2002, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "0938472651", "Ngô Thanh Nam", true }
                });

            migrationBuilder.InsertData(
                table: "BangDiems",
                columns: new[] { "LopTCID", "MaSoSV", "DiemChuyenCan", "DiemGiuaKy", "DiemTB", "DiemThiCuoiKy", "TiLeDiemQuaTrinh", "TiLeDiemThiCuoiKy" },
                values: new object[,]
                {
                    { 1L, 1L, 10m, 9m, 9.15m, 9m, (short)50, (short)50 },
                    { 1L, 2L, 7m, 5m, 7.3m, 9m, (short)50, (short)50 },
                    { 1L, 3L, 9m, 10m, 7.85m, 6m, (short)50, (short)50 },
                    { 2L, 1L, 8m, 9m, 7.85m, 7m, (short)50, (short)50 },
                    { 2L, 2L, 9m, 9m, 9m, 9m, (short)50, (short)50 },
                    { 2L, 3L, 10m, 8.8m, 9.18m, 9.2m, (short)50, (short)50 },
                    { 3L, 1L, 8m, 8m, 8m, 8m, (short)50, (short)50 },
                    { 3L, 2L, 10m, 7m, 7.45m, 7m, (short)50, (short)50 },
                    { 3L, 3L, 8m, 6.5m, 6.23m, 5.5m, (short)50, (short)50 },
                    { 4L, 1L, 10m, 7m, 7.95m, 8m, (short)50, (short)50 },
                    { 4L, 2L, 10m, 9m, 9.15m, 9m, (short)50, (short)50 },
                    { 4L, 3L, 9m, 7.8m, 7.98m, 7.8m, (short)50, (short)50 },
                    { 5L, 1L, 8m, 10m, 7.7m, 6m, (short)50, (short)50 },
                    { 5L, 3L, 7m, 4.5m, 5.43m, 5.6m, (short)50, (short)50 },
                    { 5L, 8L, 10m, 6.8m, 7.18m, 6.6m, (short)50, (short)50 },
                    { 6L, 2L, 4m, 5m, 6.35m, 8m, (short)50, (short)50 },
                    { 6L, 7L, 5m, 5.5m, 6.18m, 7m, (short)50, (short)50 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BangDiems_MaSoSV",
                table: "BangDiems",
                column: "MaSoSV");

            migrationBuilder.CreateIndex(
                name: "IX_GiangViens_KhoaID",
                table: "GiangViens",
                column: "KhoaID");

            migrationBuilder.CreateIndex(
                name: "IX_LopDanhNghias_KhoaID",
                table: "LopDanhNghias",
                column: "KhoaID");

            migrationBuilder.CreateIndex(
                name: "IX_LopDanhNghias_MaSoGV",
                table: "LopDanhNghias",
                column: "MaSoGV");

            migrationBuilder.CreateIndex(
                name: "IX_LopTinChis_KhoaID",
                table: "LopTinChis",
                column: "KhoaID");

            migrationBuilder.CreateIndex(
                name: "IX_LopTinChis_MaMon",
                table: "LopTinChis",
                column: "MaMon");

            migrationBuilder.CreateIndex(
                name: "IX_LopTinChis_MaSoGV",
                table: "LopTinChis",
                column: "MaSoGV");

            migrationBuilder.CreateIndex(
                name: "IX_MonHocs_KhoaID",
                table: "MonHocs",
                column: "KhoaID");

            migrationBuilder.CreateIndex(
                name: "IX_SinhViens_LopDNID",
                table: "SinhViens",
                column: "LopDNID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BangDiems");

            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "LopTinChis");

            migrationBuilder.DropTable(
                name: "SinhViens");

            migrationBuilder.DropTable(
                name: "MonHocs");

            migrationBuilder.DropTable(
                name: "LopDanhNghias");

            migrationBuilder.DropTable(
                name: "GiangViens");

            migrationBuilder.DropTable(
                name: "Khoas");
        }
    }
}
