using Microsoft.Reporting.WinForms;
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
    public partial class fReportBangDiem : Form
    {
        EFDbContext db = new EFDbContext();
        private long _khoaID;
        private long _lopDNID;
        public fReportBangDiem(long khoaID, long lopDNID)
        {
            InitializeComponent();
            _khoaID = khoaID;
            _lopDNID = lopDNID;
        }

        private void fReportBangDiem_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };
            var query = from bangDiem in db.BangDiems
                        join sinhVien in db.SinhViens on bangDiem.MaSoSV equals sinhVien.MaSoSV
                        join lopTinChi in db.LopTinChis on bangDiem.LopTCID equals lopTinChi.LopTCID
                        join lopDanhNghia in db.LopDanhNghias on sinhVien.LopDNID equals lopDanhNghia.LopDNID
                        join monHoc in db.MonHocs on lopTinChi.MaMon equals monHoc.MaMon
                        where sinhVien.LopDNID == _lopDNID && lopDanhNghia.KhoaID == _khoaID
                        orderby sinhVien.TenSV
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

            var reportDataSource = new ReportDataSource("ds_View_BangDiem", query.ToList());
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "rDiemSinhVienTheoLopDanhNghia.rdlc");

            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();

        }
    }
}
