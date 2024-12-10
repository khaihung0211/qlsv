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
    public partial class fQlyKhoa : Form
    {
        public fQlyKhoa()
        {
            InitializeComponent();
        }

        private void txtSearchKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btNewKhoa_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemKhoa"))
                return;
            fThemKhoa f = new fThemKhoa();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fQlyKhoa_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dgvKhoa.DataSource = db.Khoas.Select(c=>new {c.KhoaID, c.MaKhoa,c.TenKhoa}).ToList();
            }
        }

        private void btFindKhoa_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dgvKhoa.DataSource = db.Khoas.Select(c=> new { c.KhoaID, c.MaKhoa,c.TenKhoa }).Where
                (c=>c.TenKhoa.Contains(txtSearchKhoa.Text)).ToList();
            }
        }

        private void dgvKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhoa.Columns[e.ColumnIndex].Name == "DeleteKhoa")
            {
                try
                {
                    string MaKhoa = ((string)dgvKhoa.Rows[e.RowIndex].Cells["MaKhoa"].Value);
                    using (var db = new EFDbContext())
                    {
                        Khoa Khoas = db.Khoas.Single(c => c.MaKhoa == MaKhoa);
                        if (MessageBox.Show("Bạn muốn xóa khoa " + Khoas.MaKhoa, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            db.Khoas.Remove(Khoas);
                            db.SaveChanges();
                            fQlyKhoa_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }

            if (dgvKhoa.Columns[e.ColumnIndex].Name == "EditKhoa")
            {
                if (Utility.IsOpeningForm("fSuaKhoa"))
                    return;
                fSuaKhoa f = new fSuaKhoa(Convert.ToInt64(dgvKhoa.Rows[e.RowIndex].Cells["KhoaID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }
    }
}
