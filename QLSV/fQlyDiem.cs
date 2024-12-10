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

    public partial class fQlyDiem : Form
    {
        BangDiem bangDiem;
        public fQlyDiem()
        {
            InitializeComponent();
        }

        private void fQlyDiem_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var query = from bangDiem in db.BangDiems
                            join sinhVien in db.SinhViens on bangDiem.MaSoSV equals sinhVien.MaSoSV
                            join lopTinChi in db.LopTinChis on bangDiem.LopTCID equals lopTinChi.LopTCID
                            join lopDanhNghia in db.LopDanhNghias on sinhVien.LopDNID equals lopDanhNghia.LopDNID
                            join monHoc in db.MonHocs on lopTinChi.MaMon equals monHoc.MaMon
                            select new
                            {
                                lopTinChi.LopTCID,
                                lopTinChi.MaLopTC,
                                bangDiem.MaSoSV,
                                sinhVien.TenSV,
                                lopDanhNghia.MaLopDN,
                                monHoc.TenMon,
                                bangDiem.DiemChuyenCan,
                                bangDiem.DiemGiuaKy,
                                bangDiem.DiemThiCuoiKy,
                                bangDiem.TiLeDiemQuaTrinh,
                                bangDiem.TiLeDiemThiCuoiKy,
                                bangDiem.DiemTB
                            };

                dgvBangDiem.DataSource = query.ToList();
            }
        }

        private void dgvBangDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBangDiem.Columns[e.ColumnIndex].Name == "btDeleteBangDiem")
            {
                try
                {
                    long LopTCID = ((long)dgvBangDiem.Rows[e.RowIndex].Cells["LopTCID"].Value);
                    long MaSoSV = ((long)dgvBangDiem.Rows[e.RowIndex].Cells["MaSoSV"].Value);
                    using (var db = new EFDbContext())
                    {
                        BangDiem studentRecord = db.BangDiems.SingleOrDefault(c => c.MaSoSV == MaSoSV && c.LopTCID == LopTCID);

                        if (MessageBox.Show("Bạn muốn xóa điểm của sinh viên " + studentRecord.MaSoSV, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            db.BangDiems.Remove(studentRecord);
                            db.SaveChanges();
                            fQlyDiem_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }

            }
            if (dgvBangDiem.Columns[e.ColumnIndex].Name == "btEditBangDiem")
            {
                if (Utility.IsOpeningForm("fSuaBangDiem"))
                    return;
                fSuaBangDiem f = new fSuaBangDiem(Convert.ToInt64(dgvBangDiem.Rows[e.RowIndex].Cells["MaSoSV"].Value), Convert.ToInt64(dgvBangDiem.Rows[e.RowIndex].Cells["LopTCID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void btNewBangDiem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemBangDiem"))
                return;
            fThemBangDiem f = new fThemBangDiem();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

    }
}
