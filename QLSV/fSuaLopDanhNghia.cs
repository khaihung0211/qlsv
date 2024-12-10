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
    public partial class fSuaLopDanhNghia : Form
    {
        private EFDbContext db;
        private LopDanhNghia lopDanhNghias;
        private long LopDNID;

        public fSuaLopDanhNghia(long LopDNID)
        {
            InitializeComponent();
            this.LopDNID = LopDNID;
            db = new EFDbContext();
        }

        private void btCancelLopDN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSaveLopDN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLopDN.Text))
            {
                toolTip1.Show("Hãy nhập mã lớp định nghĩa?", txtMaLopDN, 0, 0, 1000);
                txtMaLopDN.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cbMaSoGV.Text))
            {
                toolTip1.Show("Hãy nhập mã số giảng viên?", cbMaSoGV, 0, 0, 1000);
                cbMaSoGV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa?", cbMaKhoa, 0, 0, 1000);
                cbMaKhoa.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuongSV.Text))
            {
                toolTip1.Show("Hãy nhập số lượng sinh viên?", txtSoLuongSV, 0, 0, 1000);
                txtSoLuongSV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNamNhapHocCuaSV.Text))
            {
                toolTip1.Show("Hãy nhập năm nhập học?", txtNamNhapHocCuaSV, 0, 0, 1000);
                txtNamNhapHocCuaSV.Focus();
                return;
            }
            try
            {
                lopDanhNghias.MaLopDN = txtMaLopDN.Text;
                lopDanhNghias.MaSoGV = Convert.ToInt64(cbMaSoGV.SelectedValue);
                lopDanhNghias.SoLuongSV = Convert.ToInt32(txtSoLuongSV.Text);
                lopDanhNghias.NamNhapHocCuaSV = Convert.ToInt16(txtNamNhapHocCuaSV.Text);
                lopDanhNghias.KhoaID = Convert.ToInt64(cbMaKhoa.SelectedValue);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSaveLopDN, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveLopDN, 0, 0, 1000);
            }
            txtMaLopDN.Focus();
        }

        private void txtMaLopDN_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLopDN.Text))
            {
                toolTip1.Show("Hãy nhập mã lớp danh nghĩa?", txtMaLopDN, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtMaLopDN.Text.Length > 100)
            {
                toolTip1.Show("Mã lớp danh nghĩa  <= 100 ký tự?", txtMaLopDN, 0, 0, 1000);
                e.Cancel = true;
            }
        }



        private void cbMaSoGV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaSoGV.Text))
            {
                toolTip1.Show("Hãy nhập mã số giảng viên?", cbMaSoGV, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (cbMaSoGV.Text.Length > 100)
            {
                toolTip1.Show("Mã  giảng viên <= 100 ký tự?", cbMaSoGV, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtSoLuongSV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSoLuongSV.Text))
            {
                toolTip1.Show("Hãy nhập số luộng sinh viên?", txtSoLuongSV, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtSoLuongSV.Text.Length > 100)
            {
                toolTip1.Show("Số lượng sinh viên <= 100 ký tự?", txtSoLuongSV, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtNamNhapHocCuaSV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamNhapHocCuaSV.Text))
            {
                toolTip1.Show("Hãy nhập năm nhập học của  sinh viên?", txtNamNhapHocCuaSV, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtNamNhapHocCuaSV.Text.Length > 100)
            {
                toolTip1.Show("Năm nhập học  <= 100 ký tự?", txtSoLuongSV, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbMaKhoa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa ?", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (cbMaKhoa.Text.Length > 100)
            {
                toolTip1.Show("Mã khoa <= 100 ký tự?", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fSuaGiangVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void fSuaLopDanhNghia_Load(object sender, EventArgs e)
        {
            lopDanhNghias = db.LopDanhNghias.Find(LopDNID);

            if (lopDanhNghias != null)
            {
                Text += " - Mã Lớp Danh Nghĩa  " + lopDanhNghias.MaLopDN.ToString();

                txtMaLopDN.Text = lopDanhNghias.MaLopDN;
                cbMaSoGV.DisplayMember = "TenGV";
                cbMaSoGV.ValueMember = "MaSoGV";
                cbMaSoGV.DataSource = db.GiangViens.ToList();
                cbMaSoGV.SelectedValue = lopDanhNghias.MaSoGV;
                txtSoLuongSV.Text = lopDanhNghias.SoLuongSV.ToString();
                txtNamNhapHocCuaSV.Text = lopDanhNghias.NamNhapHocCuaSV.ToString();
                cbMaKhoa.DisplayMember = "TenKhoa";
                cbMaKhoa.ValueMember = "KhoaID";
                cbMaKhoa.DataSource = db.Khoas.ToList();
                cbMaKhoa.SelectedValue = lopDanhNghias.KhoaID;
            }

        }
    }
}
