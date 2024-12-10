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
    public partial class fThemLopDanhNghia : Form
    {
        private LopDanhNghia lopdanhnghia = new LopDanhNghia();
        private EFDbContext _context;
        private EFDbContext db = new EFDbContext();
        public fThemLopDanhNghia()
        {
            InitializeComponent();
            _context = new EFDbContext();
        }

        private void btCancelLopDN_Click(object sender, EventArgs e)
        {
            Close();
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
                toolTip1.Show("Hãy nhập mã số  giảng viên?", cbMaSoGV, 0, 0, 1000);
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
                toolTip1.Show("Hãy nhập mã khoa giảng viên?", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (cbMaKhoa.Text.Length > 100)
            {
                toolTip1.Show("Mã khoa giảng viên <= 100 ký tự?", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fThemLopDanhNghia_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
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
                // Tạo lớp danh nghĩa mới
                lopdanhnghia = new LopDanhNghia();

                {
                    //MaSoGV = Convert.ToInt64(txtMaGV.Text),
                    lopdanhnghia.MaLopDN = txtMaLopDN.Text;
                    lopdanhnghia.MaSoGV = Convert.ToInt64(cbMaSoGV.SelectedValue);
                    lopdanhnghia.SoLuongSV = Convert.ToInt32(txtSoLuongSV.Text);
                    lopdanhnghia.NamNhapHocCuaSV = Convert.ToInt16(txtNamNhapHocCuaSV.Text);
                    lopdanhnghia.KhoaID = Convert.ToInt64(cbMaKhoa.SelectedValue);
                };

                using (var db = new EFDbContext())
                {
                    db.LopDanhNghias.Add(lopdanhnghia); // Thêm lớp danh nghĩa vào bối cảnh mô hình
                    db.SaveChanges(); // Lưu các thay đổi vào csdl
                }

                // Xóa trống và thiết lập lại các điều khiển
                //txtMaGV.Text = null;
                txtMaLopDN.Text = null;
                cbMaSoGV.Text = null;
                txtSoLuongSV.Text = null;
                txtNamNhapHocCuaSV.Text = null;
                cbMaKhoa.Text = null;

                toolTip1.Show("Lưu thành công!", btSaveLopDN, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại? Error: " + ex.InnerException);
            }
            txtMaLopDN.Focus();
        }

        private void fThemLopDanhNghia_Load(object sender, EventArgs e)
        {
            cbMaKhoa.DisplayMember = "TenKhoa";
            cbMaKhoa.ValueMember = "KhoaID";
            cbMaKhoa.DataSource = db.Khoas.Select(p => new
            {
                p.KhoaID,
                p.TenKhoa
            }).ToList();
            cbMaKhoa.Text = null;

            cbMaSoGV.DisplayMember = "MaSoGV";
            cbMaSoGV.ValueMember = "MaSoGV";
            cbMaSoGV.DataSource = db.GiangViens.Select(p => new
            {
                p.MaSoGV,

            }).ToList();
            cbMaSoGV.Text = null;
        }
    }
}
