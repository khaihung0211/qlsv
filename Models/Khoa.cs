using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Models
{
    internal class Khoa
    {
        public Khoa()
        {
            this.GiangViens = new HashSet<GiangVien>();
            this.MonHocs = new HashSet<MonHoc>();
            this.LopDanhNghias = new HashSet<LopDanhNghia>();
            this.LopTinChis = new HashSet<LopTinChi>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long KhoaID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhoa { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKhoa { get; set; }

        [InverseProperty("Khoa")]
        public virtual ICollection<GiangVien> GiangViens { get; set; }

        [InverseProperty("Khoa")]
        public virtual ICollection<MonHoc> MonHocs { get; set; }

        [InverseProperty("Khoa")]
        public virtual ICollection<LopDanhNghia> LopDanhNghias { get; set; }

        [InverseProperty("Khoa")]
        public virtual ICollection<LopTinChi> LopTinChis { get; set; }
    }
}
