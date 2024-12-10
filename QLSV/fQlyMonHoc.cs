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
using System.Xml.Linq;

namespace QLSV
{
    public partial class fQlyMonHoc : Form
    {
        public fQlyMonHoc()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fSuaMonHoc"))
                    return;
                fSuaMonHoc f = new fSuaMonHoc(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MaMon"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long MaMon = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MaMon"].Value);
                    using (var db = new EFDbContext())
                    {
                        MonHoc monHoc = db.MonHocs.Single(c => c.MaMon == MaMon);
                        if (MessageBox.Show("Bạn muốn xóa môn học " + monHoc.TenMon, "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.MonHocs.Remove(monHoc);
                            db.SaveChanges();
                            fQlyMonHoc_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }

        private void btNewMonHoc_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemMonHoc"))
                return;
            fThemMonHoc f = new fThemMonHoc();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fQlyMonHoc_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var query = from monHoc in db.MonHocs
                            join khoa in db.Khoas on monHoc.KhoaID equals khoa.KhoaID
                            select new
                            {
                                monHoc.MaMon,
                                monHoc.TenMon,
                                monHoc.SoTinChi,
                                monHoc.SoTietLT,
                                monHoc.SoTietTH,
                                KhoaID = khoa.TenKhoa
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void btFindMonHoc_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var query = from monHoc in db.MonHocs
                            join khoa in db.Khoas on monHoc.KhoaID equals khoa.KhoaID
                            select new
                            {
                                monHoc.MaMon,
                                monHoc.TenMon,
                                monHoc.SoTinChi,
                                monHoc.SoTietLT,
                                monHoc.SoTietTH,
                                KhoaID = khoa.TenKhoa
                            };
                var filteredQuery = query.Where(mh => mh.TenMon.Contains(txtSearchMonHoc.Text));
                dataGridView1.DataSource = query.Where(c => c.TenMon.Contains(txtSearchMonHoc.Text)).ToList();
            }

        }
    }
}
