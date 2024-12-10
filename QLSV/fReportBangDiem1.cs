using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Reporting.WinForms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fReportBangDiem1 : Form
    {
        EFDbContext db = new EFDbContext();
        private long LopTCID;
        public fReportBangDiem1(long LopTCID)
        {
            InitializeComponent();
            this.LopTCID = LopTCID;
        }

        private void fReportBangDiem1_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local
            };

            var query = from bd in db.BangDiems
                        join sv in db.SinhViens on bd.MaSoSV equals sv.MaSoSV
                        join ltc in db.LopTinChis on bd.LopTCID equals ltc.LopTCID
                        join mh in db.MonHocs on ltc.MaMon equals mh.MaMon
                        where bd.LopTCID == LopTCID
                        orderby sv.TenSV
                        select new
                        {
                            sv.MaSoSV,
                            sv.TenSV,
                            ltc.MaLopTC,
                            mh.TenMon,
                            bd.DiemChuyenCan,
                            bd.DiemGiuaKy,
                            bd.DiemThiCuoiKy,
                            bd.TiLeDiemQuaTrinh,
                            bd.TiLeDiemThiCuoiKy,
                            bd.DiemTB
                        };

            var reportDataSource = new ReportDataSource("ds_View_BangDiem", query.ToList());
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "rDiemSVTheoLopTC.rdlc");

            reportViewer.Dock = DockStyle.Fill;
            Controls.Add(reportViewer);
            reportViewer.RefreshReport();
        }
    }
}
