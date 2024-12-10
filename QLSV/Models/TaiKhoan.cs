using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.Models
{
    internal class TaiKhoan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaiKhoanID { get; set; }

        [StringLength(255)]
        public string Email { get; set; }

        [StringLength(100)]
        public string MatKhau { get; set; }

        [StringLength(6)]
        public byte RoleID { get; set; }

        public bool TinhTrang { get; set; }
    }
}
