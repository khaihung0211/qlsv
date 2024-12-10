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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    public partial class fSuaMonHoc : Form
    {
        private MonHoc monHoc;
        private long MaMon;
        private EFDbContext db = new EFDbContext();
        public fSuaMonHoc(long MaMon)
        {
            InitializeComponent();
            this.MaMon = MaMon;
        }

        private void btSaveMonHoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                toolTip1.Show("Hãy nhập tên môn học?", txtTenMon, 0, 0, 1000);
                txtTenMon.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoTinChi.Text))
            {
                toolTip1.Show("Hãy nhập số tín chỉ của môn học?", txtSoTinChi, 0, 0, 1000);
                txtSoTinChi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoTietLT.Text))
            {
                toolTip1.Show("Hãy nhập số tiết lý thuyết của môn học?", txtSoTietLT, 0, 0, 1000);
                txtSoTietLT.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập khoa?", cbMaKhoa, 0, 0, 1000);
                cbMaKhoa.Focus();
                return;
            }

            try
            {
                monHoc.TenMon = txtTenMon.Text;
                monHoc.SoTinChi = Convert.ToInt32(txtSoTinChi.Text);
                monHoc.SoTietLT = Convert.ToInt32(txtSoTietLT.Text);
                monHoc.SoTietTH = Convert.ToInt32(txtSoTietTH.Text);
                monHoc.KhoaID = Convert.ToInt64(cbMaKhoa.SelectedValue);

                db.SaveChanges();


                toolTip1.Show("Lưu thành công.", btSaveMonHoc, 0, 0, 1000);
                Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveMonHoc, 0, 0, 1000);
            }
        }

        private void fSuaMonHoc_Load(object sender, EventArgs e)
        {
            monHoc = db.MonHocs.Find(MaMon);
            monHoc = db.MonHocs.Single(p => p.MaMon == MaMon);
            Text += " - SỬA MÔN HỌC " + monHoc.MaMon.ToString();
            txtTenMon.Text = monHoc.TenMon;
            txtSoTinChi.Text = monHoc.SoTinChi.ToString();
            txtSoTietLT.Text = monHoc.SoTietLT.ToString();
            txtSoTietTH.Text = monHoc.SoTietTH.ToString();
            cbMaKhoa.DisplayMember = "TenKhoa";
            cbMaKhoa.ValueMember = "KhoaID";
            cbMaKhoa.DataSource = db.Khoas.ToList();
            cbMaKhoa.SelectedValue = monHoc.KhoaID;
        }

        private void btCancelMonHoc_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTenMon_Validating(object sender, CancelEventArgs e)
        {
            //kiem tra xem mon hoc do co trong database chua
            var exists = db.MonHocs.SingleOrDefault(mh => mh.TenMon == txtTenMon.Text.Trim() && mh.MaMon != MaMon);
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                toolTip1.Show("Hãy nhập tên môn học?", txtTenMon, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtTenMon.Text.Length > 100)
            {
                toolTip1.Show("Tên môn học - tối đa 100 ký tự?", txtTenMon, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (exists != null)
            {
                toolTip1.Show("Tên môn học đã tồn tại", txtTenMon, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtSoTinChi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTinChi.Text))
            {
                toolTip1.Show("Hãy nhập số tín chỉ của môn học?", txtSoTinChi, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (!int.TryParse(txtSoTinChi.Text, out _))
            {
                toolTip1.Show("Số tín chỉ của môn học phải là số nguyên", txtSoTinChi, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtSoTietLT_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTietLT.Text))
            {
                toolTip1.Show("Hãy nhập số tiết lý thuyết môn học?", txtSoTietLT, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (!int.TryParse(txtSoTietLT.Text, out _))
            {
                toolTip1.Show("Số tiết lý thuyết của môn học phải là số nguyên", txtSoTietLT, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtSoTietTH_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoTietTH.Text))
            {
                toolTip1.Show("Hãy nhập số tiết thực hành môn học?", txtSoTietTH, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (!int.TryParse(txtSoTietTH.Text, out _))
            {
                toolTip1.Show("Số tiết thực hành của môn học phải là số nguyên", txtSoTietTH, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbMaKhoa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập Khoa của môn học", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fSuaMonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
