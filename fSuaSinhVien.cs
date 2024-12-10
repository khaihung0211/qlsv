using QLSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace QLSV
{
    public partial class fSuaSinhVien : Form
    {
        SinhVien sinhVien;
        private EFDbContext db = new EFDbContext();
        private long MaSoSV;

        public fSuaSinhVien(long MaSoSV)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaSoSV = MaSoSV;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += new PaintEventHandler(fSuaSinhVien_Paint);
            this.MouseClick += new MouseEventHandler(fSuaSinhVien_MouseClick);
            this.Deactivate += new EventHandler(fSuaSinhVien_Deactivate);
        }
        private void fSuaSinhVien_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
        private void fSuaSinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.ClientRectangle.Contains(e.Location))
            {
                this.Close();
            }
        }

        private void fSuaSinhVien_Deactivate(object sender, EventArgs e)
        {
            this.Close(); 
        }


        private void btSaveSinhVien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sinh viên.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSV.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || !long.TryParse(txtSoDienThoai.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoDienThoai.Focus();
                return;
            }

            try
            {
                sinhVien.TenSV = txtTenSV.Text;
                sinhVien.Email = txtEmail.Text;
                sinhVien.DiaChi = txtDiaChi.Text;
                sinhVien.LopDNID = Convert.ToInt64(cbMaLopDN.SelectedValue);
                sinhVien.SoDienThoai = txtSoDienThoai.Text;
                sinhVien.Email = txtEmail.Text;
                sinhVien.TrangThai = ckTrangThai.CheckState == CheckState.Checked;
                sinhVien.GioiTinh = ckGioiTinh.CheckState == CheckState.Checked;
                sinhVien.NgaySinh = dtpNgaySinh.Value.Date;
                db.SaveChanges();

         
                MessageBox.Show(
                    "Sửa thành công.",                   
                    "Thông báo",                         
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information            
                );

                ClearForm();

                this.Close();
            }
            catch (Exception ex)
            { 
            
                MessageBox.Show(
                    "Lưu thất bại? Error: " + ex.Message, 
                    "Lỗi",                               
                    MessageBoxButtons.OK,              
                    MessageBoxIcon.Error               
                );
            }
        }

        private void ClearForm()
        {
            txtTenSV.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSoDienThoai.Text = string.Empty;
            cbMaLopDN.SelectedIndex = -1;
        }

        public class GenderItem
        {
            public string Text { get; set; }
            public bool Value { get; set; }
        }


        private void fSuaSinhVien_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual; 
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            cbMaLopDN.DisplayMember = "MaLopDN";
            cbMaLopDN.ValueMember = "LopDNID";
            cbMaLopDN.DataSource = db.LopDanhNghias.Select(p => new
            {
                p.LopDNID,
                p.MaLopDN
            }).ToList();
            cbMaLopDN.Text = null;

            comboGender.Items.Add(new GenderItem { Text = "Nam", Value = true });
            comboGender.Items.Add(new GenderItem { Text = "Nữ", Value = false });

            comboGender.DisplayMember = "Text";
            comboGender.ValueMember = "Value";

            sinhVien = db.SinhViens.Find(MaSoSV);
            Text += " - SỬA THÔNG TIN SINH VIÊN " + sinhVien.MaSoSV.ToString();
            txtTenSV.Text = sinhVien.TenSV ?? string.Empty; 
            txtSoDienThoai.Text = sinhVien.SoDienThoai ?? string.Empty; 
            txtDiaChi.Text = sinhVien.DiaChi ?? string.Empty; 
            txtEmail.Text = sinhVien.Email ?? string.Empty;

            if (sinhVien.NgaySinh == default(DateTime))
            {
                dtpNgaySinh.Value = DateTime.Now; 
            }
            else
            {
                dtpNgaySinh.Value = sinhVien.NgaySinh; 
            }

            comboGender.SelectedItem = comboGender.Items
                .OfType<GenderItem>()
                .FirstOrDefault(g => g.Value == sinhVien.GioiTinh);

            ckTrangThai.CheckState = sinhVien.TrangThai == true ? CheckState.Checked : CheckState.Unchecked;
            ckGioiTinh.CheckState = sinhVien.GioiTinh == true ? CheckState.Checked : CheckState.Unchecked;

            cbMaLopDN.DisplayMember = "MaLopDN";
            cbMaLopDN.ValueMember = "LopDNID";
            cbMaLopDN.DataSource = db.LopDanhNghias.ToList();
        }

        private void btCancelSinhVien_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
