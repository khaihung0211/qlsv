using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QLSV.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    internal class EFDbContext : DbContext
    {
        public DbSet<Khoa> Khoas { get; set; }
        public DbSet<GiangVien> GiangViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<LopDanhNghia> LopDanhNghias { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<LopTinChi> LopTinChis { get; set; }
        public DbSet<BangDiem> BangDiems { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public decimal DiemChuyenCan { get; private set; }
        public decimal DiemGiuaKy { get; private set; }
        public decimal DiemThiCuoiKy { get; private set; }

        public void ConfigureServices(IServiceCollection services) => services.AddDbContext<EFDbContext>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        public EFDbContext()
        {
            //
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiangVien>()
                .HasOne(gv => gv.Khoa)
                .WithMany(k => k.GiangViens)
                .HasForeignKey(gv => gv.KhoaID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<MonHoc>()
                .HasOne(mh => mh.Khoa)
                .WithMany(k => k.MonHocs)
                .HasForeignKey(mh => mh.KhoaID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LopDanhNghia>()
                .HasOne(ldn => ldn.GiangVien)
                .WithMany()
                .HasForeignKey(ldn => ldn.MaSoGV)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LopDanhNghia>()
                .HasOne(ldn => ldn.Khoa)
                .WithMany(k => k.LopDanhNghias)
                .HasForeignKey(ldn => ldn.KhoaID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<SinhVien>()
                .HasOne(sv => sv.LopDanhNghia)
                .WithMany(ldn => ldn.SinhViens)
                .HasForeignKey(sv => sv.LopDNID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LopTinChi>()
                .HasOne(ltc => ltc.MonHoc)
                .WithMany(mh => mh.LopTinChis)
                .HasForeignKey(ltc => ltc.MaMon)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LopTinChi>()
                .HasOne(ltc => ltc.GiangVien)
                .WithMany()
                .HasForeignKey(ltc => ltc.MaSoGV)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LopTinChi>()
                .HasOne(ltc => ltc.Khoa)
                .WithMany(k => k.LopTinChis)
                .HasForeignKey(ltc => ltc.KhoaID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BangDiem>()
                .HasKey(bd => new { bd.LopTCID, bd.MaSoSV });

            modelBuilder.Entity<BangDiem>()
                .HasOne(bd => bd.LopTinChi)
                .WithMany(ltc => ltc.BangDiems)
                .HasForeignKey(bd => bd.LopTCID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BangDiem>()
                .HasOne(bd => bd.SinhVien)
                .WithMany()
                .HasForeignKey(bd => bd.MaSoSV)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Khoa>().HasData(
                new Khoa { KhoaID = 1, MaKhoa = "CNTT", TenKhoa = "Khoa Công nghệ thông tin" },
                new Khoa { KhoaID = 2, MaKhoa = "KT", TenKhoa = "Khoa Kinh tế" },
                new Khoa { KhoaID = 3, MaKhoa = "NNA", TenKhoa = "Khoa Ngôn ngữ Anh" },
                new Khoa { KhoaID = 4, MaKhoa = "XD", TenKhoa = "Khoa Xây dựng" },
                new Khoa { KhoaID = 5, MaKhoa = "CB", TenKhoa = "Khoa Cơ bản" },
                new Khoa { KhoaID = 6, MaKhoa = "QTKD", TenKhoa = "Khoa Quản trị kinh doanh" }
                );

            modelBuilder.Entity<GiangVien>().HasData(

                new GiangVien
                {
                    MaSoGV = 1,
                    TenGV = "Nguyễn Văn A",
                    NgaySinh = DateTime.Parse("1990-11-20"),
                    GioiTinh = true,
                    Email = "nguyenvana@gmail.com",
                    HocVi = "Thạc sĩ",
                    KhoaID = 1
                }, new GiangVien
                {
                    MaSoGV = 2,
                    TenGV = "Trần Thị B",
                    NgaySinh = DateTime.Parse("1985-03-15"),
                    GioiTinh = false,
                    Email = "tranthib@gmail.com",
                    HocVi = "Tiến sĩ",
                    KhoaID = 2
                },
                new GiangVien
                {
                    MaSoGV = 3,
                    TenGV = "Lê Văn C",
                    NgaySinh = DateTime.Parse("1978-07-22"),
                    GioiTinh = true,
                    Email = "levanc@gmail.com",
                    HocVi = "Phó giáo sư",
                    KhoaID = 3
                },

                new GiangVien
                {
                    MaSoGV = 4,
                    TenGV = "Nguyễn Thị D",
                    NgaySinh = DateTime.Parse("1992-10-30"),
                    GioiTinh = false,
                    Email = "nguyenthid@gmail.com",
                    HocVi = "Thạc sĩ",
                    KhoaID = 4
                },

                new GiangVien
                {
                    MaSoGV = 5,
                    TenGV = "Phạm Văn E",
                    NgaySinh = DateTime.Parse("1980-05-25"),
                    GioiTinh = true,
                    Email = "phamvane@gmail.com",
                    HocVi = "Tiến sĩ",
                    KhoaID = 5
                },

                new GiangVien
                {
                    MaSoGV = 6,
                    TenGV = "Vũ Thị F",
                    NgaySinh = DateTime.Parse("1988-12-05"),
                    GioiTinh = false,
                    Email = "vuthif@gmail.com",
                    HocVi = "Giáo sư",
                    KhoaID = 6
                });

            modelBuilder.Entity<MonHoc>().HasData(
                new MonHoc
                {
                    MaMon = 1,
                    TenMon = "Lập trình Windows",
                    SoTinChi = 3,
                    SoTietLT = 45,
                    SoTietTH = 0,
                    KhoaID = 1,
                }, new MonHoc
                {
                    MaMon = 2,
                    TenMon = "Kế toán tài chính",
                    SoTinChi = 4,
                    SoTietLT = 60,
                    SoTietTH = 0,
                    KhoaID = 2,
                },
                new MonHoc
                {
                    MaMon = 3,
                    TenMon = "Văn học Anh",
                    SoTinChi = 3,
                    SoTietLT = 45,
                    SoTietTH = 0,
                    KhoaID = 3,
                },

                new MonHoc
                {
                    MaMon = 4,
                    TenMon = "Kỹ thuật xây dựng",
                    SoTinChi = 4,
                    SoTietLT = 60,
                    SoTietTH = 30,
                    KhoaID = 4,
                },

                new MonHoc
                {
                    MaMon = 5,
                    TenMon = "Toán cao cấp",
                    SoTinChi = 3,
                    SoTietLT = 45,
                    SoTietTH = 0,
                    KhoaID = 5,
                },

                new MonHoc
                {
                    MaMon = 6,
                    TenMon = "Quản trị nhân sự",
                    SoTinChi = 3,
                    SoTietLT = 45,
                    SoTietTH = 0,
                    KhoaID = 6,
                });

            modelBuilder.Entity<LopDanhNghia>().HasData(
                new LopDanhNghia
                {
                    LopDNID = 1,
                    MaLopDN = "22ĐHTT06",
                    MaSoGV = 1,
                    KhoaID = 1,
                    SoLuongSV = 60,
                    NamNhapHocCuaSV = 2022
                },
                new LopDanhNghia
                {
                    LopDNID = 2,
                    MaLopDN = "21ĐHKT01",
                    MaSoGV = 2,
                    KhoaID = 2,
                    SoLuongSV = 50,
                    NamNhapHocCuaSV = 2021
                },

                new LopDanhNghia
                {
                    LopDNID = 3,
                    MaLopDN = "20ĐHNA03",
                    MaSoGV = 3,
                    KhoaID = 3,
                    SoLuongSV = 40,
                    NamNhapHocCuaSV = 2020
                },

                new LopDanhNghia
                {
                    LopDNID = 4,
                    MaLopDN = "22ĐHXD02",
                    MaSoGV = 4,
                    KhoaID = 4,
                    SoLuongSV = 55,
                    NamNhapHocCuaSV = 2022
                },

                new LopDanhNghia
                {
                    LopDNID = 5,
                    MaLopDN = "19ĐHQT04",
                    MaSoGV = 5,
                    KhoaID = 5,
                    SoLuongSV = 45,
                    NamNhapHocCuaSV = 2019
                },

                new LopDanhNghia
                {
                    LopDNID = 6,
                    MaLopDN = "21ĐHQT02",
                    MaSoGV = 6,
                    KhoaID = 6,
                    SoLuongSV = 60,
                    NamNhapHocCuaSV = 2021
                });

            modelBuilder.Entity<SinhVien>().HasData(
                new SinhVien() {
                    MaSoSV = 1,
                    TenSV = "Nguyễn Văn An",
                    NgaySinh = DateTime.Parse("2004-08-14"),
                    GioiTinh = true,
                    DiaChi = "Số 10, Đường Trần Hưng Đạo, Quận 1, Thành phố Hồ Chí Minh",
                    SoDienThoai = "0827983728",
                    Email = "annv@gmail.com",
                    TrangThai = true,
                    LopDNID = 1
                }, new SinhVien()
                {
                    MaSoSV = 2,
                    TenSV = "Trần Thị Bích",
                    NgaySinh = DateTime.Parse("2003-05-22"),
                    GioiTinh = false,
                    DiaChi = "Số 5, Đường Lê Lợi, Quận Hải Châu, Thành phố Đà Nẵng",
                    SoDienThoai = "0912345678",
                    Email = "bichtt@gmail.com",
                    TrangThai = true,
                    LopDNID = 2
                },
                new SinhVien()
                {
                    MaSoSV = 3,
                    TenSV = "Lê Minh Châu",
                    NgaySinh = DateTime.Parse("2002-09-30"),
                    GioiTinh = false,
                    DiaChi = "Số 15, Đường Phan Đình Phùng, Quận Ba Đình, Hà Nội",
                    SoDienThoai = "0938765432",
                    Email = "chaulm@gmail.com",
                    TrangThai = true,
                    LopDNID = 1
                },
                new SinhVien()
                {
                    MaSoSV = 4,
                    TenSV = "Phạm Quốc Đạt",
                    NgaySinh = DateTime.Parse("2001-12-15"),
                    GioiTinh = true,
                    DiaChi = "Số 20, Đường Nguyễn Trãi, Quận Thanh Xuân, Hà Nội",
                    SoDienThoai = "0987654321",
                    Email = "datpq@gmail.com",
                    TrangThai = true,
                    LopDNID = 3
                },
                new SinhVien()
                {
                    MaSoSV = 5,
                    TenSV = "Hoàng Thị Hoa",
                    NgaySinh = DateTime.Parse("2004-01-19"),
                    GioiTinh = false,
                    DiaChi = "Số 25, Đường Lý Tự Trọng, Quận Ninh Kiều, Thành phố Cần Thơ",
                    SoDienThoai = "0856738291",
                    Email = "hoath@gmail.com",
                    TrangThai = true,
                    LopDNID = 2
                },
                new SinhVien()
                {
                    MaSoSV = 6,
                    TenSV = "Vũ Đức Hùng",
                    NgaySinh = DateTime.Parse("2003-11-23"),
                    GioiTinh = true,
                    DiaChi = "Số 8, Đường Trường Sa, Quận Ngũ Hành Sơn, Thành phố Đà Nẵng",
                    SoDienThoai = "0827364529",
                    Email = "hungvd@gmail.com",
                    TrangThai = true,
                    LopDNID = 1
                },
                new SinhVien()
                {
                    MaSoSV = 7,
                    TenSV = "Đặng Thị Lan",
                    NgaySinh = DateTime.Parse("2002-04-11"),
                    GioiTinh = false,
                    DiaChi = "Số 12, Đường Nguyễn Huệ, Quận 1, Thành phố Hồ Chí Minh",
                    SoDienThoai = "0918374652",
                    Email = "landt@gmail.com",
                    TrangThai = true,
                    LopDNID = 2
                },
                new SinhVien()
                {
                    MaSoSV = 8,
                    TenSV = "Bùi Thanh Liêm",
                    NgaySinh = DateTime.Parse("2001-07-27"),
                    GioiTinh = true,
                    DiaChi = "Số 30, Đường Lê Duẩn, Quận 1, Thành phố Hồ Chí Minh",
                    SoDienThoai = "0908765432",
                    Email = "liembt@gmail.com",
                    TrangThai = true,
                    LopDNID = 3
                },
                new SinhVien()
                {
                    MaSoSV = 9,
                    TenSV = "Đỗ Thị Mai",
                    NgaySinh = DateTime.Parse("2003-10-02"),
                    GioiTinh = false,
                    DiaChi = "Số 50, Đường Điện Biên Phủ, Quận Bình Thạnh, Thành phố Hồ Chí Minh",
                    SoDienThoai = "0927364518",
                    Email = "maidt@gmail.com",
                    TrangThai = true,
                    LopDNID = 1
                },
                new SinhVien()
                {
                    MaSoSV = 10,
                    TenSV = "Ngô Thanh Nam",
                    NgaySinh = DateTime.Parse("2002-03-25"),
                    GioiTinh = true,
                    DiaChi = "Số 18, Đường Nguyễn Thị Minh Khai, Quận 1, Thành phố Hồ Chí Minh",
                    SoDienThoai = "0938472651",
                    Email = "namnt@gmail.com",
                    TrangThai = true,
                    LopDNID = 2
                });

            modelBuilder.Entity<LopTinChi>().HasData(
                new LopTinChi
                {
                    LopTCID = 1,
                    MaLopTC = "22ĐHKT01",
                    MaMon = 2,
                    MaSoGV = 2,
                    HocKy = "2",
                    NamHoc = 2024,
                    KhoaID = 2
                },
                new LopTinChi
                {
                    LopTCID = 2,
                    MaLopTC = "23ĐHTT01",
                    MaMon = 1,
                    MaSoGV = 1,
                    HocKy = "1",
                    NamHoc = 2023,
                    KhoaID = 1
                },

                new LopTinChi
                {
                    LopTCID = 3,
                    MaLopTC = "22ĐHNA01",
                    MaMon = 3,
                    MaSoGV = 3,
                    HocKy = "2",
                    NamHoc = 2024,
                    KhoaID = 3
                },

                new LopTinChi
                {
                    LopTCID = 4,
                    MaLopTC = "23ĐHXD01",
                    MaMon = 4,
                    MaSoGV = 4,
                    HocKy = "1",
                    NamHoc = 2023,
                    KhoaID = 4
                },

                new LopTinChi
                {
                    LopTCID = 5,
                    MaLopTC = "22ĐHQT01",
                    MaMon = 5,
                    MaSoGV = 5,
                    HocKy = "2",
                    NamHoc = 2024,
                    KhoaID = 5
                },

                new LopTinChi
                {
                    LopTCID = 6,
                    MaLopTC = "23ĐHTT06",
                    MaMon = 6,
                    MaSoGV = 6,
                    HocKy = "1",
                    NamHoc = 2023,
                    KhoaID = 6
                });

            modelBuilder.Entity<BangDiem>().HasData(
                new BangDiem
                {
                    LopTCID = 1,
                    MaSoSV = 1,
                    DiemChuyenCan = 10,
                    DiemGiuaKy = 9,
                    DiemThiCuoiKy = 9,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 9.15m
                }, new BangDiem
                {
                    LopTCID = 2,
                    MaSoSV = 1,
                    DiemChuyenCan = 8,
                    DiemGiuaKy = 9,
                    DiemThiCuoiKy = 7,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 7.85m
                }, new BangDiem
                {
                    LopTCID = 3,
                    MaSoSV = 1,
                    DiemChuyenCan = 8,
                    DiemGiuaKy = 8,
                    DiemThiCuoiKy = 8,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 8
                }, new BangDiem
                {
                    LopTCID = 4,
                    MaSoSV = 1,
                    DiemChuyenCan = 10,
                    DiemGiuaKy = 7,
                    DiemThiCuoiKy = 8,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 7.95m
                }, new BangDiem
                {
                    LopTCID = 5,
                    MaSoSV = 1,
                    DiemChuyenCan = 8,
                    DiemGiuaKy = 10,
                    DiemThiCuoiKy = 6,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 7.7m
                }, new BangDiem
                {
                    LopTCID = 1,
                    MaSoSV = 2,
                    DiemChuyenCan = 7,
                    DiemGiuaKy = 5,
                    DiemThiCuoiKy = 9,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 7.3m
                }, new BangDiem
                {
                    LopTCID = 2,
                    MaSoSV = 2,
                    DiemChuyenCan = 9,
                    DiemGiuaKy = 9,
                    DiemThiCuoiKy = 9,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 9
                }, new BangDiem
                {
                    LopTCID = 3,
                    MaSoSV = 2,
                    DiemChuyenCan = 10,
                    DiemGiuaKy = 7,
                    DiemThiCuoiKy = 7,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 7.45m
                }, new BangDiem
                {
                    LopTCID = 4,
                    MaSoSV = 2,
                    DiemChuyenCan = 10,
                    DiemGiuaKy = 9,
                    DiemThiCuoiKy = 9,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 9.15m
                }, new BangDiem
                {
                    LopTCID = 6,
                    MaSoSV = 2,
                    DiemChuyenCan = 4,
                    DiemGiuaKy = 5,
                    DiemThiCuoiKy = 8,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 6.35m
                }, new BangDiem
                {
                    LopTCID = 1,
                    MaSoSV = 3,
                    DiemChuyenCan = 9,
                    DiemGiuaKy = 10,
                    DiemThiCuoiKy = 6,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 7.85m
                }, new BangDiem
                {
                    LopTCID = 2,
                    MaSoSV = 3,
                    DiemChuyenCan = 10,
                    DiemGiuaKy = 8.8m,
                    DiemThiCuoiKy = 9.2m,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 9.18m
                }, new BangDiem
                {
                    LopTCID = 3,
                    MaSoSV = 3,
                    DiemChuyenCan = 8,
                    DiemGiuaKy = 6.5m,
                    DiemThiCuoiKy = 5.5m,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 6.23m
                }, new BangDiem
                {
                    LopTCID = 4,
                    MaSoSV = 3,
                    DiemChuyenCan = 9,
                    DiemGiuaKy = 7.8m,
                    DiemThiCuoiKy = 7.8m,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 7.98m
                }, new BangDiem
                {
                    LopTCID = 5,
                    MaSoSV = 3,
                    DiemChuyenCan = 7,
                    DiemGiuaKy = 4.5m,
                    DiemThiCuoiKy = 5.6m,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 5.43m
                }, new BangDiem
                {
                    LopTCID = 5,
                    MaSoSV = 8,
                    DiemChuyenCan = 10,
                    DiemGiuaKy = 6.8m,
                    DiemThiCuoiKy =6.6m,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 7.18m
                }, new BangDiem
                {
                    LopTCID = 6,
                    MaSoSV = 7,
                    DiemChuyenCan = 5,
                    DiemGiuaKy = 5.5m,
                    DiemThiCuoiKy = 7,
                    TiLeDiemQuaTrinh = 50,
                    TiLeDiemThiCuoiKy = 50,
                    DiemTB = 6.18m
                });

            modelBuilder.Entity<TaiKhoan>().HasData(
                new TaiKhoan
                {
                    TaiKhoanID = -1,
                    Email = "admin@gmail.com",
                    MatKhau = "111111",
                    RoleID = 1,
                    TinhTrang = true
                }, new TaiKhoan
                {
                    TaiKhoanID = 1,
                    Email = "nguyenvana@gmail.com",
                    MatKhau = "111111",
                    RoleID = 2,
                    TinhTrang = true
                }, new TaiKhoan
                {
                    TaiKhoanID = 2,
                    Email = "tranthib@gmail.com",
                    MatKhau = "111111",
                    RoleID = 2,
                    TinhTrang = true
                }, new TaiKhoan
                {
                    TaiKhoanID = 3,
                    Email = "levanc@gmail.com",
                    MatKhau = "111111",
                    RoleID = 2,
                    TinhTrang = true
                }, new TaiKhoan
                {
                    TaiKhoanID = 4,
                    Email = "nguyenthid@gmail.com",
                    MatKhau = "111111",
                    RoleID = 2,
                    TinhTrang = true
                });
        }


    }
}
