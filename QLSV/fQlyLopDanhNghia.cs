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
    public partial class fQlyLopDanhNghia : Form
    {
        private long KhoaID;
        public fQlyLopDanhNghia()
        {
            InitializeComponent();
        }

        private void btNewLopDN_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fLopDanhNghia"))
                return;
            fThemLopDanhNghia f = new fThemLopDanhNghia();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fQlyLopDanhNghia_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var query = from lopDanhNghia in db.LopDanhNghias
                            join khoa in db.Khoas on lopDanhNghia.KhoaID equals khoa.KhoaID
                            select new
                            {
                                lopDanhNghia.LopDNID,
                                lopDanhNghia.MaLopDN,
                                lopDanhNghia.MaSoGV,
                                lopDanhNghia.SoLuongSV,
                                lopDanhNghia.NamNhapHocCuaSV,
                                maKhoa = khoa.TenKhoa
                            };

                dgvLopDN.DataSource = query.ToList();
            }
        }

        private void dgvLopDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLopDN.Columns[e.ColumnIndex].Name == "btDeleteLopDN")
            {
                try
                {

                    long LopDNID = ((long)dgvLopDN.Rows[e.RowIndex].Cells["LopDNID"].Value);
                    using (var db = new EFDbContext())
                    {
                        LopDanhNghia LopDanhNghias = db.LopDanhNghias.Single(c => c.LopDNID == LopDNID);
                        if (MessageBox.Show("Bạn muốn xóa lớp danh nghĩa mã số " + LopDanhNghias.LopDNID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            db.LopDanhNghias.Remove(LopDanhNghias);
                            db.SaveChanges();
                            fQlyLopDanhNghia_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }

            }
            if (dgvLopDN.Columns[e.ColumnIndex].Name == "btEditLopDN")
            {
                if (Utility.IsOpeningForm("fSuaLopDanhNghia"))
                    return;
                fSuaLopDanhNghia f = new fSuaLopDanhNghia(Convert.ToInt64(dgvLopDN.Rows[e.RowIndex].Cells["LopDNID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void btFindLopDN_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var query = from lopDanhNghia in db.LopDanhNghias
                            join khoa in db.Khoas on lopDanhNghia.KhoaID equals khoa.KhoaID
                            select new
                            {
                                lopDanhNghia.LopDNID,
                                lopDanhNghia.MaLopDN,
                                lopDanhNghia.MaSoGV,
                                lopDanhNghia.SoLuongSV,
                                lopDanhNghia.NamNhapHocCuaSV,
                                maKhoa = khoa.TenKhoa
                            };

                dgvLopDN.DataSource = query.Where(c => c.MaLopDN.Contains(txtMaLopDN.Text)).ToList();
            }
        }
    }
}
