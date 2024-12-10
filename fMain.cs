using Microsoft.IdentityModel.Tokens;
using QLSV;

namespace QLSV
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }


        private void quanLySinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fQlySinhVien"))
                return;
            fQlySinhVien f = new fQlySinhVien
            {
                MdiParent = this 
            };
            f.Show();
        }

       

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fQlyTaiKhoan"))
                return;
            fQlyTaiKhoan f = new fQlyTaiKhoan
            {
                MdiParent = this
            };
            f.Show();
        }

       

       

        private void themSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemSinhVien"))
                return;
            fThemSinhVien f = new fThemSinhVien(this);
            f.MdiParent = this;
            f.Show();
        }

       

        private void themTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemTaiKhoan"))
                return;
            fThemTaiKhoan f = new fThemTaiKhoan(this);
            f.MdiParent = this;
            f.Show();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            this.Hide();
            fLogin f = new fLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                int roleID = Utility.taiKhoan.RoleID;

                khoaToolStripMenuItem.Visible = false;
                quanLyKhoaToolStripMenuItem.Visible = false;
                themKhoaToolStripMenuItem1.Visible = false;
                giảngToolStripMenuItem.Visible = false;
                quảnLýGiảngViênToolStripMenuItem.Visible = false;
                themGiangVienToolStripMenuItem.Visible = false;
                mônToolStripMenuItem.Visible = false;
                quảnLýMônHọcToolStripMenuItem.Visible = false;
                themMonHocToolStripMenuItem.Visible = false;
                lopDanhNghiaToolStripMenuItem.Visible = false;
                quanLyLopDanhNghiaToolStripMenuItem.Visible = false;
                themLopDanhNghiaToolStripMenuItem.Visible = false;
                sinhVienToolStripMenuItem.Visible = false;
                quanLySinhVienToolStripMenuItem.Visible = false;
                themSinhVienToolStripMenuItem.Visible = false;
                lopTinChiToolStripMenuItem.Visible = false;
                quanLyLopTinChiToolStripMenuItem.Visible = false;
                themLopTinChiToolStripMenuItem.Visible = false;
                quanLyDiemToolStripMenuItem.Visible = false;
                nhapDiemToolStripMenuItem.Visible = false;
                quanLyDiemSVToolStripMenuItem.Visible = false;
                taiKhoanToolStripMenuItem.Visible = false;
                quanLyTaiKhoanToolStripMenuItem.Visible = false;
                themTaiKhoanToolStripMenuItem.Visible = false;

                if (Utility.taiKhoan.RoleID == 1)
                {
                    khoaToolStripMenuItem.Visible = true;
                    quanLyKhoaToolStripMenuItem.Visible = true;
                    themKhoaToolStripMenuItem1.Visible = true;
                    giảngToolStripMenuItem.Visible = true;
                    quảnLýGiảngViênToolStripMenuItem.Visible = true;
                    themGiangVienToolStripMenuItem.Visible = true;
                    mônToolStripMenuItem.Visible = true;
                    quảnLýMônHọcToolStripMenuItem.Visible = true;
                    themMonHocToolStripMenuItem.Visible = true;
                    lopDanhNghiaToolStripMenuItem.Visible = true;
                    quanLyLopDanhNghiaToolStripMenuItem.Visible = true;
                    themLopDanhNghiaToolStripMenuItem.Visible = true;
                    sinhVienToolStripMenuItem.Visible = true;
                    quanLySinhVienToolStripMenuItem.Visible = true;
                    themSinhVienToolStripMenuItem.Visible = true;
                    lopTinChiToolStripMenuItem.Visible = true;
                    quanLyLopTinChiToolStripMenuItem.Visible = true;
                    themLopTinChiToolStripMenuItem.Visible = true;
                    quanLyDiemToolStripMenuItem.Visible = true;
                    nhapDiemToolStripMenuItem.Visible = true;
                    quanLyDiemSVToolStripMenuItem.Visible = true;
                    taiKhoanToolStripMenuItem.Visible = true;
                    quanLyTaiKhoanToolStripMenuItem.Visible = true;
                    themTaiKhoanToolStripMenuItem.Visible = true;
                }
                else if (Utility.taiKhoan.RoleID == 2)
                {
                    mônToolStripMenuItem.Visible = true;
                    quảnLýMônHọcToolStripMenuItem.Visible = true;
                    themMonHocToolStripMenuItem.Visible = true;
                    lopTinChiToolStripMenuItem.Visible = true;
                    quanLyLopTinChiToolStripMenuItem.Visible = true;
                    themLopTinChiToolStripMenuItem.Visible = true;
                    quanLyDiemToolStripMenuItem.Visible = true;
                    nhapDiemToolStripMenuItem.Visible = true;
                    quanLyDiemSVToolStripMenuItem.Visible = true; 
                    sinhVienToolStripMenuItem.Visible = true;
                    quanLySinhVienToolStripMenuItem.Visible = true;
                    themSinhVienToolStripMenuItem.Visible = true;
                }

            }
        }

        private void logoutMenuItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin loginForm = new fLogin();
            this.Hide();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                int roleID = Utility.taiKhoan?.RoleID ?? 0;
                HideAllMenuItems();
                ShowMenuItemsByRole(roleID);
                fMain_Load(sender, e);
            }
            else
            {

                Utility.taiKhoan = null;
                this.Close();
            }
        }

        private void HideAllMenuItems()
        {
            khoaToolStripMenuItem.Visible = false;
            quanLyKhoaToolStripMenuItem.Visible = false;
            themKhoaToolStripMenuItem1.Visible = false;
            giảngToolStripMenuItem.Visible = false;
            quảnLýGiảngViênToolStripMenuItem.Visible = false;
            themGiangVienToolStripMenuItem.Visible = false;
            mônToolStripMenuItem.Visible = false;
            quảnLýMônHọcToolStripMenuItem.Visible = false;
            themMonHocToolStripMenuItem.Visible = false;
            lopDanhNghiaToolStripMenuItem.Visible = false;
            quanLyLopDanhNghiaToolStripMenuItem.Visible = false;
            themLopDanhNghiaToolStripMenuItem.Visible = false;
            sinhVienToolStripMenuItem.Visible = false;
            quanLySinhVienToolStripMenuItem.Visible = false;
            themSinhVienToolStripMenuItem.Visible = false;
            lopTinChiToolStripMenuItem.Visible = false;
            quanLyLopTinChiToolStripMenuItem.Visible = false;
            themLopTinChiToolStripMenuItem.Visible = false;
            quanLyDiemToolStripMenuItem.Visible = false;
            nhapDiemToolStripMenuItem.Visible = false;
            quanLyDiemSVToolStripMenuItem.Visible = false;
            taiKhoanToolStripMenuItem.Visible = false;
            quanLyTaiKhoanToolStripMenuItem.Visible = false;
            themTaiKhoanToolStripMenuItem.Visible = false;
        }

        private void ShowMenuItemsByRole(int roleID)
        {
            switch (roleID)
            {
                case 1:
                    khoaToolStripMenuItem.Visible = true;
                    quanLyKhoaToolStripMenuItem.Visible = true;
                    themKhoaToolStripMenuItem1.Visible = true;
                    giảngToolStripMenuItem.Visible = true;
                    quảnLýGiảngViênToolStripMenuItem.Visible = true;
                    themGiangVienToolStripMenuItem.Visible = true;
                    mônToolStripMenuItem.Visible = true;
                    quảnLýMônHọcToolStripMenuItem.Visible = true;
                    themMonHocToolStripMenuItem.Visible = true;
                    lopDanhNghiaToolStripMenuItem.Visible = true;
                    quanLyLopDanhNghiaToolStripMenuItem.Visible = true;
                    themLopDanhNghiaToolStripMenuItem.Visible = true;
                    sinhVienToolStripMenuItem.Visible = true;
                    quanLySinhVienToolStripMenuItem.Visible = true;
                    themSinhVienToolStripMenuItem.Visible = true;
                    lopTinChiToolStripMenuItem.Visible = true;
                    quanLyLopTinChiToolStripMenuItem.Visible = true;
                    themLopTinChiToolStripMenuItem.Visible = true;
                    quanLyDiemToolStripMenuItem.Visible = true;
                    nhapDiemToolStripMenuItem.Visible = true;
                    quanLyDiemSVToolStripMenuItem.Visible = true;
                    taiKhoanToolStripMenuItem.Visible = true;
                    quanLyTaiKhoanToolStripMenuItem.Visible = true;
                    themTaiKhoanToolStripMenuItem.Visible = true;
                    break;

                case 2:
                    mônToolStripMenuItem.Visible = true;
                    quảnLýMônHọcToolStripMenuItem.Visible = true;
                    themMonHocToolStripMenuItem.Visible = true;
                    lopTinChiToolStripMenuItem.Visible = true;
                    quanLyLopTinChiToolStripMenuItem.Visible = true;
                    themLopTinChiToolStripMenuItem.Visible = true;
                    quanLyDiemToolStripMenuItem.Visible = true;
                    nhapDiemToolStripMenuItem.Visible = true;
                    quanLyDiemSVToolStripMenuItem.Visible = true;
                    break;

                default:
                    break;
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
