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
    public partial class fThemLopTinChi : Form
    {
        LopTinChi lopTinChi;
        private EFDbContext _context;
        private EFDbContext db = new EFDbContext();
        public fThemLopTinChi()
        {
            InitializeComponent();
            _context = new EFDbContext();
        }

        private void btCancelLopTC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSaveLopTC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLopTC.Text))
            {
                toolTip1.Show("Hãy nhập mã lớp tín chỉ?", txtMaLopTC, 0, 0, 1000);
                txtMaLopTC.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaMon.Text))
            {
                toolTip1.Show("Hãy nhập mã môn?", cbMaMon, 0, 0, 1000);
                cbMaMon.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaSoGV.Text))
            {
                toolTip1.Show("Hãy nhập mã số giảng viên", cbMaSoGV, 0, 0, 1000);
                cbMaSoGV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHocKy.Text))
            {
                toolTip1.Show("Hãy nhập học kỳ?", txtHocKy, 0, 0, 1000);
                txtHocKy.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNamHoc.Text))
            {
                toolTip1.Show("Hãy nhập năm học?", txtNamHoc, 0, 0, 1000);
                txtNamHoc.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa?", cbMaKhoa, 0, 0, 1000);
                cbMaKhoa.Focus();
                return;
            }

            try
            {
                lopTinChi = new LopTinChi();

                {
                    lopTinChi.MaLopTC = txtMaLopTC.Text;
                    lopTinChi.MaMon = Convert.ToInt64(cbMaMon.SelectedValue);
                    lopTinChi.MaSoGV = Convert.ToInt64(cbMaSoGV.SelectedValue);
                    lopTinChi.HocKy = txtHocKy.Text;
                    lopTinChi.NamHoc = (short)Convert.ToInt64(txtNamHoc.Text);
                    lopTinChi.KhoaID = Convert.ToInt64(cbMaKhoa.SelectedValue);

                };
                using (var db = new EFDbContext())
                {
                    db.LopTinChis.Add(lopTinChi);
                    db.SaveChanges();
                }

                // Xóa trống và thiết lập lại các điều khiển
                txtMaLopTC.Text = null;
                cbMaMon.Text = null;
                cbMaSoGV.Text = null;
                txtHocKy.Text = null;
                txtNamHoc.Text = null;
                cbMaKhoa.Text = null;

                toolTip1.Show("Lưu thành công!", btSaveLopTC, 0, 0, 1000);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại? Error: " + ex.InnerException);
            }
            txtMaLopTC.Focus();
        }

        private void fThemLopTinChi_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void fThemLopTinChi_Load(object sender, EventArgs e)
        {
            cbMaKhoa.DisplayMember = "TenKhoa";
            cbMaKhoa.ValueMember = "KhoaID";
            cbMaKhoa.DataSource = db.Khoas.Select(p => new
            {
                p.KhoaID,
                p.TenKhoa
            }).ToList();
            cbMaKhoa.Text = null;

            cbMaSoGV.DisplayMember = "TenGV";
            cbMaSoGV.ValueMember = "MaSoGV";
            cbMaSoGV.DataSource = db.GiangViens.Select(p => new
            {
                p.MaSoGV,
                p.TenGV

            }).ToList();
            cbMaSoGV.Text = null;

            cbMaMon.DisplayMember = "TenMon";
            cbMaMon.ValueMember = "MaMon";
            cbMaMon.DataSource = db.MonHocs.Select(p => new
            {
                p.MaMon,
                p.TenMon

            }).ToList();
            cbMaMon.Text = null;
        }

        private void txtMaLopTC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLopTC.Text))
            {
                toolTip1.Show("Hãy nhập mã lớp tín chỉ?", txtMaLopTC, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtMaLopTC.Text.Length > 255)
            {
                toolTip1.Show("Mã lớp tín chỉ <=255 ?", txtMaLopTC, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbMaMon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaMon.Text))
            {
                toolTip1.Show("Hãy nhập mã môn?", cbMaMon, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (cbMaMon.Text.Length > 255)
            {
                toolTip1.Show("Mã môn <=255 ?", cbMaMon, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbMaSoGV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaSoGV.Text))
            {
                toolTip1.Show("Hãy nhập mã số giáo viên?", cbMaSoGV, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (cbMaSoGV.Text.Length > 255)
            {
                toolTip1.Show("Mã số giáo viên <=255 ?", cbMaSoGV, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtHocKy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaMon.Text))
            {
                toolTip1.Show("Hãy nhập học kỳ?", txtHocKy, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtNamHoc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamHoc.Text))
            {
                toolTip1.Show("Hãy nhập năm học?", txtNamHoc, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtNamHoc.Text.Length > 10)
            {
                toolTip1.Show("Năm học <=10 ?", txtNamHoc, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbMaKhoa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa?", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
            
        }
    }
}
