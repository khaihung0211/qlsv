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
    public partial class fSuaGiangVien : Form
    {
        private EFDbContext db;
        GiangVien GiangViens;
        long KhoaID;
        long MaSoGV;

        public fSuaGiangVien(long KhoaID)
        {
            InitializeComponent();
            this.KhoaID = KhoaID;
            db = new EFDbContext();
        }

        private void btCancelGiangVien_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void btSaveGiangVien_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTenGV.Text))
            {
                toolTip1.Show("Hãy nhập tên giảng viên?", txtTenGV, 0, 0, 1000);
                txtTenGV.Focus();
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                toolTip1.Show("Hãy nhập email giảng viên?", txtEmail, 0, 0, 1000);
                txtEmail.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHocVi.Text))
            {
                toolTip1.Show("Hãy nhập học vị giảng viên?", txtHocVi, 0, 0, 1000);
                txtHocVi.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa giảng viên?", cbMaKhoa, 0, 0, 1000);
                cbMaKhoa.Focus();
                return;
            }

            try
            {
                GiangViens.TenGV = txtTenGV.Text;
                GiangViens.NgaySinh = dtpNgaySinh.Value.Date;
                GiangViens.Email = txtEmail.Text;
                GiangViens.HocVi = txtHocVi.Text;
                GiangViens.GioiTinh = ckGioiTinh.CheckState == CheckState.Checked;
                GiangViens.KhoaID = Convert.ToInt64(cbMaKhoa.SelectedValue);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSaveGiangVien, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveGiangVien, 0, 0, 1000);
            }
            txtTenGV.Focus();
        }



        private void txtTenGV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenGV.Text))
            {
                toolTip1.Show("Hãy nhập tên giảng viên?", txtTenGV, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtTenGV.Text.Length > 100)
            {
                toolTip1.Show("Tên giảng viên <= 100 ký tự?", txtTenGV, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                toolTip1.Show("Hãy nhập email giảng viên?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                toolTip1.Show("Email giảng viên <= 100 ký tự?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtHocVi_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHocVi.Text))
            {
                toolTip1.Show("Hãy nhập học vị giảng viên?", txtHocVi, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtHocVi.Text.Length > 100)
            {
                toolTip1.Show("Học vị giảng viên <= 100 ký tự?", txtHocVi, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbMaKhoa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenGV.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa giảng viên?", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (cbMaKhoa.Text.Length > 100)
            {
                toolTip1.Show("Mã khoa giảng viên <= 100 ký tự?", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fSuaGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void fSuaGiangVien_Load(object sender, EventArgs e)
        {
            GiangViens = db.GiangViens.Find(KhoaID);

            if (GiangViens != null)
            {
                Text += " - Mã Giảng viên " + GiangViens.MaSoGV.ToString();

                txtTenGV.Text = GiangViens.TenGV;
                dtpNgaySinh.Text = GiangViens.NgaySinh.ToString();
                txtEmail.Text = GiangViens.Email;
                txtHocVi.Text = GiangViens.HocVi;
                cbMaKhoa.DisplayMember = "TenKhoa";
                cbMaKhoa.ValueMember = "KhoaID";
                ckGioiTinh.CheckState = GiangViens.GioiTinh == true ? CheckState.Checked : CheckState.Unchecked;
                cbMaKhoa.DataSource = db.Khoas.ToList();
                cbMaKhoa.SelectedValue = GiangViens.KhoaID;
            }
        }
    }
}

