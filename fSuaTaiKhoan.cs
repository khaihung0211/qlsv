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
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static QLSV.fSuaSinhVien;

namespace QLSV
{
    public partial class fSuaTaiKhoan : Form
    {
        EFDbContext db = new EFDbContext();
        TaiKhoan taiKhoan;
        int TaiKhoanID;
        public fSuaTaiKhoan(int TaiKhoanID)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TaiKhoanID = TaiKhoanID;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += new PaintEventHandler(fSuaTaiKhoan_Paint);
            this.MouseClick += new MouseEventHandler(fSuaTaiKhoan_MouseClick);
            this.Deactivate += new EventHandler(fTaiKhoan_Deactivate);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                     (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        }

        private void fSuaTaiKhoan_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
        private void fSuaTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.ClientRectangle.Contains(e.Location))
            {
                this.Close();
            }
        }

        private void fTaiKhoan_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public byte Value { get; set; }

            public ComboBoxItem(string text, byte value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private void fSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            taiKhoan = db.TaiKhoans.Find(TaiKhoanID);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                     (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            comboVaiTro.Items.Add(new ComboBoxItem("Admin", 1));
            comboVaiTro.Items.Add(new ComboBoxItem("Giáo viên", 2));

            comboVaiTro.DisplayMember = "Text";
            comboVaiTro.ValueMember = "Value";

            if (taiKhoan != null)
            {
                Text += " - Tài khoản " + taiKhoan.TaiKhoanID.ToString();
                txtEmail.Text = taiKhoan.Email ?? string.Empty; ;
                txtMatKhau.Text = taiKhoan.MatKhau ?? string.Empty; ;

                ckTinhTrang.CheckState = taiKhoan.TinhTrang == true ? CheckState.Checked : CheckState.Unchecked;
            }
            comboVaiTro.SelectedItem = comboVaiTro.Items
               .OfType<ComboBoxItem>()
               .FirstOrDefault(g => g.Value == taiKhoan.RoleID);
        }
        private string originalEmail;

        private void btSaveTaiKhoan_Click(object sender, EventArgs e)
        {
            originalEmail = taiKhoan.Email;
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Hãy nhập Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            if (txtEmail.Text != originalEmail)
            {
                using (var db = new EFDbContext())
                {
                    var existingAccount = db.TaiKhoans.FirstOrDefault(t => t.Email == txtEmail.Text);
                    if (existingAccount != null)
                    {
                        MessageBox.Show("Email đã tồn tại. Vui lòng chọn email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtEmail.Focus();
                        return;
                    }
                }
            }



            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Hãy nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            if (txtMatKhau.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }
            try
            {
                taiKhoan.Email = txtEmail.Text;
                taiKhoan.MatKhau = txtMatKhau.Text;
                var selectedRole = (ComboBoxItem)comboVaiTro.SelectedItem;
                taiKhoan.RoleID = selectedRole.Value;
                taiKhoan.TinhTrang = ckTinhTrang.CheckState == CheckState.Checked ? true : false;

                db.SaveChanges();

                MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();

                this.Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveTaiKhoan, 0, 0, 1000);
            }

        }


        private void ClearForm()
        {
            txtEmail.Text = string.Empty;
            txtMatKhau.Text = string.Empty;
            comboVaiTro.SelectedIndex = -1;
            ckTinhTrang.CheckState = CheckState.Unchecked;
        }
        private void fSuaTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btCancelTaiKhoan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }



        private void doiMatKhau_Click(object sender, EventArgs e)
        {
            txtMatKhau.Enabled = true;
            txtMatKhau.Focus();
        }
    }
}
