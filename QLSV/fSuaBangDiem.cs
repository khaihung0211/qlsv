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
    public partial class fSuaBangDiem : Form
    {
        private EFDbContext db = new EFDbContext();
        BangDiem bangDiem;
        long MaSoSV;
        long LopTCID;
        public fSuaBangDiem(long MaSoSV, long LopTCID)
        {
            InitializeComponent();
            this.MaSoSV = MaSoSV;
            this.LopTCID = LopTCID;
        }

        private void btCancelBangDiem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fSuaBangDiem_Load(object sender, EventArgs e)
        {
            bangDiem = db.BangDiems
                 .Where(bd => bd.MaSoSV == MaSoSV && bd.LopTCID == LopTCID)
                 .SingleOrDefault();

            if (bangDiem != null)
            {
                Text += " - Sinh Viên " + bangDiem.MaSoSV.ToString();
                cbMaLopTC.DisplayMember = "MaLopTC";
                cbMaLopTC.ValueMember = "LopTCID";
                cbMaLopTC.DataSource = db.LopTinChis.ToList();
                cbMaLopTC.SelectedValue = bangDiem.LopTCID;

                cbMaSoSV.DisplayMember = "TenSV";
                cbMaSoSV.ValueMember = "MaSoSV";
                cbMaSoSV.DataSource = db.SinhViens.ToList();
                cbMaSoSV.SelectedValue = bangDiem.MaSoSV;

                txtDiemChuyenCan.Text = bangDiem.DiemChuyenCan.ToString();
                txtDiemGiuaKy.Text = bangDiem.DiemGiuaKy.ToString();
                txtDiemThiCuoiKy.Text = bangDiem.DiemThiCuoiKy.ToString();

                txtTiLeDiemQuaTrinh.Text = bangDiem.TiLeDiemQuaTrinh.ToString();
                txtTiLeDiemThiCuoiKy.Text = bangDiem.TiLeDiemThiCuoiKy.ToString();
            }
        }

        private void btSaveBangDiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (bangDiem != null)
                {
                    long selectedLopTCID = Convert.ToInt64(cbMaLopTC.SelectedValue);
                    long selectedMaSoSV = Convert.ToInt64(cbMaSoSV.SelectedValue);

                    if (selectedLopTCID != LopTCID || selectedMaSoSV != MaSoSV)
                    {
                        // Check for existing BangDiem
                        var existingBangDiem = db.BangDiems
                            .SingleOrDefault(bd => bd.LopTCID == selectedLopTCID && bd.MaSoSV == selectedMaSoSV);

                        if (existingBangDiem != null)
                        {
                            MessageBox.Show("Sinh viên này đã có điểm cho lớp tín chỉ này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        db.BangDiems.Remove(bangDiem);
                        db.SaveChanges();

                        // Create a new record with updated keys
                        bangDiem = new BangDiem
                        {
                            LopTCID = selectedLopTCID,
                            MaSoSV = selectedMaSoSV,
                            DiemChuyenCan = Convert.ToDecimal(txtDiemChuyenCan.Text),
                            DiemGiuaKy = Convert.ToDecimal(txtDiemGiuaKy.Text),
                            DiemThiCuoiKy = Convert.ToDecimal(txtDiemThiCuoiKy.Text),
                            TiLeDiemQuaTrinh = Convert.ToInt16(txtTiLeDiemQuaTrinh.Text),
                            TiLeDiemThiCuoiKy = Convert.ToInt16(txtTiLeDiemThiCuoiKy.Text)
                        };
                        bangDiem.DiemTB = ((bangDiem.DiemGiuaKy * 0.7m) + (bangDiem.DiemChuyenCan * 0.3m)) * (bangDiem.TiLeDiemQuaTrinh / 100m) + bangDiem.DiemThiCuoiKy * (bangDiem.TiLeDiemThiCuoiKy / 100m);

                        db.BangDiems.Add(bangDiem);
                    }
                    else
                    {
                        bangDiem.DiemChuyenCan = Convert.ToDecimal(txtDiemChuyenCan.Text);
                        bangDiem.DiemGiuaKy = Convert.ToDecimal(txtDiemGiuaKy.Text);
                        bangDiem.DiemThiCuoiKy = Convert.ToDecimal(txtDiemThiCuoiKy.Text);
                        bangDiem.TiLeDiemQuaTrinh = Convert.ToInt16(txtTiLeDiemQuaTrinh.Text);
                        bangDiem.TiLeDiemThiCuoiKy = Convert.ToInt16(txtTiLeDiemThiCuoiKy.Text);
                        bangDiem.DiemTB = ((bangDiem.DiemGiuaKy * 0.7m) + (bangDiem.DiemChuyenCan * 0.3m)) * (bangDiem.TiLeDiemQuaTrinh / 100m) + bangDiem.DiemThiCuoiKy * (bangDiem.TiLeDiemThiCuoiKy / 100m);
                    }

                    db.SaveChanges();
                    toolTip1.Show("Lưu thành công.", btSaveBangDiem, 0, 0, 1000);
                }
                else
                {
                    toolTip1.Show("Không tìm thấy bản ghi để lưu.", btSaveBangDiem, 0, 0, 1000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lưu thất bại? Error: " + ex.Message);
            }
            cbMaLopTC.Focus();
        }

        private void cbMaLopTC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLopTC.SelectedValue != null && cbMaSoSV.SelectedValue != null)
            {
                long selectedLopTCID = Convert.ToInt64(cbMaLopTC.SelectedValue);
                long selectedMaSoSV = Convert.ToInt64(cbMaSoSV.SelectedValue);

                // Check if there is already a record with the selected LopTCID and MaSoSV
                var existingBangDiem = db.BangDiems.SingleOrDefault(bd => bd.LopTCID == selectedLopTCID && bd.MaSoSV == selectedMaSoSV);

                if (existingBangDiem != null)
                {
                    // Show a message to the user
                    toolTip1.Show("Sinh viên này đã có điểm cho lớp tín chỉ này.", cbMaLopTC, 0, 0, 1000);
                    cbMaLopTC.SelectedValue = bangDiem.LopTCID;
                }
            }
        }
    }
}
