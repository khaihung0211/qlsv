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
    public partial class fThemSinhVien : Form
    {
        SinhVien sinhVien;
        private EFDbContext db = new EFDbContext();

        public fThemSinhVien(Form parentForm)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeGenderComboBox();
            this.FormBorderStyle = FormBorderStyle.None; 
            this.Paint += new PaintEventHandler(fThemSinhVien_Paint);
            this.MouseClick += new MouseEventHandler(fThemSinhVien_MouseClick);
        }

        private void fThemSinhVien_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void fThemSinhVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.ClientRectangle.Contains(e.Location))
            {
                this.Close(); 
            }
        }


        private void InitializeGenderComboBox()
        {
            comboBoxGender.Items.Add(new { Text = "Nam", Value = true });
            comboBoxGender.Items.Add(new { Text = "Nữ", Value = false });
            comboBoxGender.DisplayMember = "Text";
            comboBoxGender.ValueMember = "Value";
            comboBoxGender.SelectedIndex = 0;
        }


        private void btSaveSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                sinhVien = new SinhVien();
                //monHoc.MaMon = Convert.ToInt64(txtMaMon.Text);
                sinhVien.TenSV = txtTenSV.Text;
                sinhVien.Email = txtEmail.Text;
                sinhVien.DiaChi = txtDiaChi.Text;
                sinhVien.LopDNID = Convert.ToInt64(cbMaLopDN.SelectedValue);
                sinhVien.SoDienThoai = txtSoDienThoai.Text;
                sinhVien.Email = txtEmail.Text;
                sinhVien.TrangThai = true;

                var selectedGender = (dynamic)comboBoxGender.SelectedItem;
                sinhVien.GioiTinh = selectedGender.Value;


                using (var db = new EFDbContext())
                {
                    db.SinhViens.Add(sinhVien);
                    db.SaveChanges();
                }

                toolTip1.Show("Thêm thành công.", btSaveSinhVien, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveSinhVien, 0, 0, 1000);
            }
        }

        private void fThemSinhVien_Load(object sender, EventArgs e)
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
        }

        private void btCancelSinhVien_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
