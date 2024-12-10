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

    public partial class fThemBangDiem : Form
    {
        private EFDbContext db = new EFDbContext();
        BangDiem bangDiem;
        public fThemBangDiem()
        {
            InitializeComponent();
        }

        private void fThemBangDiem_Load(object sender, EventArgs e)
        {
            cbMaLopTC.DisplayMember = "MaLopTC";
            cbMaLopTC.ValueMember = "LopTCID";
            cbMaLopTC.DataSource = db.LopTinChis.Select(sv => new
            {
                sv.LopTCID,
                sv.MaLopTC
            }).ToList();
            cbMaLopTC.Text = null;

            cbMaSoSV.DisplayMember = "TenSV";
            cbMaSoSV.ValueMember = "MaSoSV";
            cbMaSoSV.DataSource = db.SinhViens.Select(sv => new
            {
                sv.MaSoSV,
                sv.TenSV
            }).ToList();
            cbMaSoSV.Text = null;
        }

        private void btSaveBangDiem_Click(object sender, EventArgs e)
        {
            try
            {
                bangDiem = new BangDiem();
                {
                    bangDiem.LopTCID = Convert.ToInt64(cbMaLopTC.SelectedValue);
                    bangDiem.MaSoSV = Convert.ToInt64(cbMaSoSV.SelectedValue);
                    bangDiem.DiemChuyenCan = Convert.ToDecimal(txtDiemChuyenCan.Text);
                    bangDiem.DiemGiuaKy = Convert.ToDecimal(txtDiemGiuaKy.Text);
                    bangDiem.DiemThiCuoiKy = Convert.ToDecimal(txtDiemThiCuoiKy.Text);
                    bangDiem.TiLeDiemQuaTrinh = Convert.ToInt16(txtTiLeDiemQuaTrinh.Text);
                    bangDiem.TiLeDiemThiCuoiKy = Convert.ToInt16(txtTiLeDiemThiCuoiKy.Text);
                };
                bangDiem.DiemTB = ((bangDiem.DiemGiuaKy * 0.7m) + (bangDiem.DiemChuyenCan * 0.3m)) * (bangDiem.TiLeDiemQuaTrinh / 100m) + bangDiem.DiemThiCuoiKy * (bangDiem.TiLeDiemThiCuoiKy / 100m);
                using (var db = new EFDbContext())
                {
                    db.BangDiems.Add(bangDiem); // Thêm giảng viên vào bối cảnh mô hình
                    db.SaveChanges(); // Lưu các thay đổi vào csdl
                }

                // Xóa trống và thiết lập lại các điều khiển
                //txtMaGV.Text = null;
                txtDiemChuyenCan.Text = null;
                txtDiemGiuaKy.Text = null;
                txtTiLeDiemQuaTrinh.Text = null;
                txtDiemThiCuoiKy.Text = null;
                cbMaLopTC.Text = null;
                cbMaSoSV.Text = null;

                toolTip1.Show("Lưu thành công!", btSaveBangDiem, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                // Log or handle the outer exception
                Console.WriteLine("Error saving changes: " + ex.Message);

                // Check the inner exception for more details
                if (ex.InnerException != null)
                {
                    MessageBox.Show("Inner exception message: " + ex.InnerException.Message);
                    // You can also access deeper inner exceptions if necessary
                    // ex.InnerException.InnerException, etc.
                }
            }
            cbMaLopTC.Focus();
        }

        private void cbMaSoSV_Validating(object sender, CancelEventArgs e)
        {
            long selectedLopTCID = Convert.ToInt64(cbMaLopTC.SelectedValue);
            long selectedMaSoSV = Convert.ToInt64(cbMaSoSV.SelectedValue);

            var existingBangDiem = db.BangDiems.SingleOrDefault(bd => bd.LopTCID == selectedLopTCID && bd.MaSoSV == selectedMaSoSV);

            if (existingBangDiem != null)
            {
                MessageBox.Show("Sinh viên này đã có điểm cho lớp tín chỉ này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCancelBangDiem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fThemBangDiem_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        
    }
}
