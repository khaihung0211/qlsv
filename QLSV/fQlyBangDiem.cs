using Microsoft.EntityFrameworkCore;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace QLSV
{
    public partial class fQlyBangDiem : Form
    {
        EFDbContext db = new EFDbContext();
        private long? KhoaID;
        public fQlyBangDiem()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void fQlyBangDiem_Load(object sender, EventArgs e)
        {
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "KhoaID";
            cbKhoa.DataSource = db.Khoas.Select(k => new
            {
                k.KhoaID,
                k.TenKhoa
            }).ToList();
            cbKhoa.Text = null;

            cbLopDanhNghia.DisplayMember = "MaLopDN";
            cbLopDanhNghia.ValueMember = "LopDNID";
            cbLopDanhNghia.DataSource = db.LopDanhNghias.Select(l => new
            {
                l.LopDNID,
                l.MaLopDN
            }).ToList();
            cbLopDanhNghia.Text = null;

            cbLopTinChi.DisplayMember = "MaLopTC";
            cbLopTinChi.ValueMember = "LopTCID";
            cbLopTinChi.DataSource = db.LopTinChis.Select(l => new
            {
                l.LopTCID,
                l.MaLopTC
            }).ToList();
            cbLopTinChi.Text = null;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                long khoaID = Convert.ToInt64(cbKhoa.SelectedValue);
                var lopDanhNghias = db.LopDanhNghias
                                     .Where(l => l.KhoaID == khoaID)
                                     .Select(l => new { l.LopDNID, l.MaLopDN })
                                     .ToList();


                cbLopDanhNghia.DisplayMember = "MaLopDN";
                cbLopDanhNghia.ValueMember = "LopDNID";
                cbLopDanhNghia.DataSource = lopDanhNghias;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            long khoaID = Convert.ToInt64(cbKhoa.SelectedValue);
            long lopDNID = Convert.ToInt64(cbLopDanhNghia.SelectedValue);

            var query = from bangDiem in db.BangDiems
                        join sinhVien in db.SinhViens on bangDiem.MaSoSV equals sinhVien.MaSoSV
                        join lopTinChi in db.LopTinChis on bangDiem.LopTCID equals lopTinChi.LopTCID
                        join lopDanhNghia in db.LopDanhNghias on sinhVien.LopDNID equals lopDanhNghia.LopDNID
                        join monHoc in db.MonHocs on lopTinChi.MaMon equals monHoc.MaMon
                        where sinhVien.LopDNID == lopDNID &&
                          lopDanhNghia.KhoaID == khoaID
                        select new
                        {
                            sinhVien.MaSoSV,
                            sinhVien.TenSV,
                            lopDanhNghia.MaLopDN,
                            monHoc.MaMon,
                            monHoc.TenMon,
                            bangDiem.DiemChuyenCan,
                            bangDiem.DiemGiuaKy,
                            bangDiem.DiemThiCuoiKy,
                            bangDiem.TiLeDiemQuaTrinh,
                            bangDiem.TiLeDiemThiCuoiKy,
                            bangDiem.DiemTB
                        };

            dgvBangDiem.DataSource = query.ToList();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnLocTinChi_Click(object sender, EventArgs e)
        {
            var selectedLopTCID = Convert.ToInt64(cbLopTinChi.SelectedValue);
            var query = from bd in db.BangDiems
                        join sv in db.SinhViens on bd.MaSoSV equals sv.MaSoSV
                        join ltc in db.LopTinChis on bd.LopTCID equals ltc.LopTCID
                        join mh in db.MonHocs on ltc.MaMon equals mh.MaMon
                        where bd.LopTCID == selectedLopTCID
                        select new
                        {
                            sv.MaSoSV,
                            sv.TenSV,
                            ltc.MaLopTC,
                            Mon = mh.TenMon,
                            bd.DiemChuyenCan,
                            bd.DiemGiuaKy,
                            bd.DiemThiCuoiKy,
                            bd.TiLeDiemQuaTrinh,
                            bd.TiLeDiemThiCuoiKy,
                            bd.DiemTB
                        };

            dataGridView2.DataSource = query.ToList();
        }

        private void btnLocSinhVien_Click(object sender, EventArgs e)
        {
            string tenSV = txtTenSV.Text;
            var query = from bangDiem in db.BangDiems
                        join sinhVien in db.SinhViens on bangDiem.MaSoSV equals sinhVien.MaSoSV
                        join lopTinChi in db.LopTinChis on bangDiem.LopTCID equals lopTinChi.LopTCID
                        join lopDanhNghia in db.LopDanhNghias on sinhVien.LopDNID equals lopDanhNghia.LopDNID
                        join monHoc in db.MonHocs on lopTinChi.MaMon equals monHoc.MaMon
                        where sinhVien.TenSV.Contains(tenSV)
                        select new
                        {
                            sinhVien.MaSoSV,
                            sinhVien.TenSV,
                            lopDanhNghia.MaLopDN,
                            monHoc.MaMon,
                            monHoc.TenMon,
                            bangDiem.DiemChuyenCan,
                            bangDiem.DiemGiuaKy,
                            bangDiem.DiemThiCuoiKy,
                            bangDiem.TiLeDiemQuaTrinh,
                            bangDiem.TiLeDiemThiCuoiKy,
                            bangDiem.DiemTB
                        };

            dataGridView3.DataSource = query.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long khoaID = Convert.ToInt64(cbKhoa.SelectedValue);
            long lopDNID = Convert.ToInt64(cbLopDanhNghia.SelectedValue);

            fReportBangDiem reportForm = new fReportBangDiem(khoaID, lopDNID);
            reportForm.Show();
        }

        private void btnBaoCao1_Click(object sender, EventArgs e)
        {
            var selectedLopTCID = Convert.ToInt64(cbLopTinChi.SelectedValue);

            fReportBangDiem1 reportForm = new fReportBangDiem1(selectedLopTCID);
            reportForm.Show();
        }

        private void btnBaoCao2_Click(object sender, EventArgs e)
        {
            string tenSV = txtTenSV.Text;
            fReportBangDiem2 reportForm = new fReportBangDiem2(tenSV);
            reportForm.Show();
        }
    }
}
