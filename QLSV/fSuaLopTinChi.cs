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

    public partial class fSuaLopTinChi : Form
    {

        string MaLopTC;
        short NamHoc;
        private long LopTCID;
        private EFDbContext db = new EFDbContext();
        LopTinChi lopTinChi;
        private string value;
        private long v;

        //private long v;

        public fSuaLopTinChi(long LopTCID)
        {
            InitializeComponent();
            this.MaLopTC = MaLopTC;
            this.LopTCID = LopTCID;

        }


        /* public fSuaLopTinChi(string value)
         {
             this.value = value;
         }

         public fSuaLopTinChi(long v)
         {
             this.v = v;
         }*/

        private void fSuaLopTinChi_Load(object sender, EventArgs e)
        {
            lopTinChi = db.LopTinChis.Find(LopTCID);

            if (lopTinChi != null)
            {
                Text += " - Mã Lớp Tín Chỉ " + lopTinChi.MaLopTC.ToString();

                txtMaLopTC.Text = lopTinChi.MaLopTC;

                cbMaMon.DisplayMember = "TenMon";
                cbMaMon.ValueMember = "MaMon";
                cbMaMon.DataSource = db.MonHocs.ToList();


                cbMaSoGV.DisplayMember = "TenGV";
                cbMaSoGV.ValueMember = "MaSoGv";
                cbMaSoGV.DataSource = db.GiangViens.ToList();

                txtHocKy.Text = lopTinChi.HocKy;
                txtNamHoc.Text = lopTinChi.NamHoc.ToString();

                cbMaKhoa.DisplayMember = "TenKhoa";
                cbMaKhoa.ValueMember = "KhoaID";
                cbMaKhoa.DataSource = db.Khoas.ToList();
            }

        }

        private void btCancelLopTC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fSuaLopTinChi_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btSaveLopTC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLopTC.Text))
            {
                toolTip1.Show("Hãy nhập mã lớp tín chỉ? ", txtMaLopTC, 0, 0, 1000);
                txtMaLopTC.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaMon.Text))
            {
                toolTip1.Show("Hãy nhập mã môn? ", cbMaMon, 0, 0, 1000);
                cbMaMon.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaSoGV.Text))
            {
                toolTip1.Show("Hãy nhập tên giảng viên? ", cbMaSoGV, 0, 0, 1000);
                cbMaSoGV.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHocKy.Text))
            {
                toolTip1.Show("Hãy nhập học kỳ? ", txtHocKy, 0, 0, 1000);
                txtHocKy.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNamHoc.Text))
            {
                toolTip1.Show("Hãy nhập năm học? ", txtNamHoc, 0, 0, 1000);
                txtNamHoc.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa? ", cbMaKhoa, 0, 0, 1000);
                cbMaKhoa.Focus();
                return;
            }

            try
            {
                lopTinChi.MaLopTC = txtMaLopTC.Text;
                lopTinChi.MaMon = Convert.ToInt64(cbMaMon.SelectedValue);
                lopTinChi.MaSoGV = Convert.ToInt64(cbMaSoGV.SelectedValue);
                lopTinChi.HocKy = txtHocKy.Text;
                lopTinChi.NamHoc = Convert.ToInt16(txtNamHoc.Text);
                lopTinChi.KhoaID = Convert.ToInt64(cbMaKhoa.SelectedValue);
                db.SaveChanges();
                toolTip1.Show("Lưu thành công!", btSaveLopTC, 0, 0, 1000);

            }
            catch (Exception ex)
            {
                toolTip1.Show("Lỗi, lưu thất bại? " + ex.Message, btSaveLopTC, 0, 0, 1000);
            }
            txtMaLopTC.Focus();
        }

        private void txtMaLopTC_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLopTC.Text))
            {
                toolTip1.Show("Hãy nhập mã lớp tín chỉ? ", txtMaLopTC, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtMaLopTC.Text.Length > 10)
            {
                toolTip1.Show("Mã lớp tín chỉ <=10? ", txtMaLopTC, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbMaMon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaMon.Text))
            {
                toolTip1.Show("Hãy nhập mã môn? ", cbMaMon, 0, 0, 1000);
                e.Cancel = true;
            }
            /*else if (cbMaMon.Text.Length > 10)
            {
                toolTip1.Show("Mã môn <=10? ", cbMaMon, 0, 0, 1000);
                e.Cancel = true;
            }*/
        }

        private void cbMaSoGV_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaMon.Text))
            {
                toolTip1.Show("Hãy nhập mã số giảng viên? ", cbMaSoGV, 0, 0, 1000);
                e.Cancel = true;
            }
            /* else if (cbMaSoGV.Text.Length > 10)
             {
                 toolTip1.Show("Mã giảng viên <=10? ", cbMaSoGV, 0, 0, 1000);
                 e.Cancel = true;
             }*/
        }

        private void txtHocKy_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHocKy.Text))
            {
                toolTip1.Show("Hãy nhập học kỳ? ", txtHocKy, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtHocKy.Text.Length > 10)
            {
                toolTip1.Show("Học kỳ <=10? ", txtHocKy, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtNamHoc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamHoc.Text))
            {
                toolTip1.Show("Hãy nhập năm học? ", txtNamHoc, 0, 0, 1000);
                e.Cancel = true;
            }

        }

        private void cbMaKhoa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa? ", cbMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }

        }

        
    }
}
