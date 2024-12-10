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
    public partial class fQlyGiangVien : Form
    {
        private long KhoaID;
        public fQlyGiangVien()
        {
            InitializeComponent();
        }
      
        private void btNewGiangVien_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemGiangVien"))
                return;
            fThemGiangVien f = new fThemGiangVien();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fQlyGiangVien_Activated(object sender, EventArgs e)
        {

            using (var db = new EFDbContext())
            {
                var query = from giangVien in db.GiangViens
                            join khoa in db.Khoas on giangVien.KhoaID equals khoa.KhoaID
                            select new
                            {
                                giangVien.MaSoGV,
                                giangVien.TenGV,
                                giangVien.NgaySinh,
                                giangVien.GioiTinh,
                                giangVien.Email,
                                giangVien.HocVi,
                                maKhoa = khoa.TenKhoa
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteGiangVien")
            {
                try
                {
                    long MaSoGV = ((long)dataGridView1.Rows[e.RowIndex].Cells["MaSoGv"].Value);
                    using (var db = new EFDbContext())
                    {
                        GiangVien Giangviens = db.GiangViens.Single(c => c.MaSoGV == MaSoGV);
                        if (MessageBox.Show("Bạn muốn xóa giảng viên mã số " + Giangviens.MaSoGV, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            db.GiangViens.Remove(Giangviens);
                            db.SaveChanges();
                            fQlyGiangVien_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }

            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "EditGiangVien")
            {
                if (Utility.IsOpeningForm("fSuaGiangVien"))
                    return;
                fSuaGiangVien f = new fSuaGiangVien(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MaSoGV"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }

        }

        private void btFindGiangVien_Click(object sender, EventArgs e)
        {
            /*using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.GiangViens.Select(c => new
                {
                    c.MaSoGV,
                    c.TenGV,
                    c.NgaySinh,
                    c.GioiTinh,
                    c.Email,
                    c.HocVi,
                    c.KhoaID
                }).Where(c=> c.TenGV.Contains(txtSearchGiangVien.Text)).ToList();
            }*/

            using (var db = new EFDbContext())
            {
                var query = from giangVien in db.GiangViens
                            join khoa in db.Khoas on giangVien.KhoaID equals khoa.KhoaID
                            select new
                            {
                                giangVien.MaSoGV,
                                giangVien.TenGV,
                                giangVien.NgaySinh,
                                giangVien.GioiTinh,
                                giangVien.Email,
                                giangVien.HocVi,
                                maKhoa = khoa.TenKhoa
                            };

                dataGridView1.DataSource = query.Where(c => c.TenGV.Contains(txtSearchGiangVien.Text)).ToList();
            }
        }

    }
}

