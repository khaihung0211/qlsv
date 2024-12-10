using QLSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fQlyLopTinChi : Form
    {
        LopTinChi lopTinChi;
        private EFDbContext db;
        public fQlyLopTinChi()
        {
            InitializeComponent();
            db = new EFDbContext();
        }

        private void btNewLopTC_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemLopTinChi"))
                return;
            fThemLopTinChi f = new fThemLopTinChi();
            f.Show();
        }

        private void dgvLopTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLopTC.Columns[e.ColumnIndex].Name == "DeleteLopTC")
            {
                try
                {
                    long LopTCID = Convert.ToInt64(dgvLopTC.Rows[e.RowIndex].Cells["LopTCID"].Value);
                    using (var db = new EFDbContext())
                    {
                        LopTinChi LopTinChis = db.LopTinChis.Single(c => c.LopTCID == LopTCID);
                        if (MessageBox.Show("Bạn muốn xóa lớp tín chỉ " + LopTinChis.MaLopTC, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                             == DialogResult.Yes)
                        {
                            db.LopTinChis.Remove(LopTinChis);
                            db.SaveChanges();
                            fQlyLopTinChi_Activated(sender, e);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }

            if (dgvLopTC.Columns[e.ColumnIndex].Name == "EditLopTC")
            {
                if (Utility.IsOpeningForm("fSuaLopTinChi"))
                    return;
                fSuaLopTinChi f = new fSuaLopTinChi(Convert.ToInt64(dgvLopTC.Rows[e.RowIndex].Cells["LopTCID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }

        }

        private void fQlyLopTinChi_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var query = from lopTinChi in db.LopTinChis
                            join khoa in db.Khoas on lopTinChi.KhoaID equals khoa.KhoaID
                            join giangvien in db.GiangViens on lopTinChi.MaSoGV equals giangvien.MaSoGV
                            join MonHoc in db.MonHocs on lopTinChi.MaMon equals MonHoc.MaMon
                            select new
                            {
                                lopTinChi.LopTCID,
                                lopTinChi.MaLopTC,
                                MaMon = MonHoc.TenMon,
                                MaSoGV = giangvien.TenGV,
                                lopTinChi.HocKy,
                                lopTinChi.NamHoc,
                                KhoaID = khoa.TenKhoa
                            };
                dgvLopTC.DataSource = query.ToList();
            }
        }

        private void btFindLopTC_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var query = from lopTinChi in db.LopTinChis
                            join khoa in db.Khoas on lopTinChi.KhoaID equals khoa.KhoaID
                            join giangvien in db.GiangViens on lopTinChi.MaSoGV equals giangvien.MaSoGV
                            join MonHoc in db.MonHocs on lopTinChi.MaMon equals MonHoc.MaMon
                            select new
                            {
                                lopTinChi.LopTCID,
                                lopTinChi.MaLopTC,
                                MaMon = MonHoc.TenMon,
                                MaSoGV = giangvien.TenGV,
                                lopTinChi.HocKy,
                                lopTinChi.NamHoc,
                                KhoaID = khoa.TenKhoa
                            };
                dgvLopTC.DataSource = query.Where(c => c.MaLopTC.Contains(txtSearchLopTC.Text)).ToList();
            }
        }
    }
}
