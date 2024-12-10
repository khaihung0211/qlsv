using QLSV.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLSV
{
    public partial class fThemTaiKhoan : Form
    {
        public fThemTaiKhoan(Form parentForm)
        {
            InitializeComponent();
            InitializeGenderComboBox();
            this.FormBorderStyle = FormBorderStyle.None;
            CenterToParent(parentForm);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Paint += new PaintEventHandler(fThemTaiKhoan_Paint);
            this.MouseClick += new MouseEventHandler(fThemTaiKhoan_MouseClick);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
           

        }


        

        private void InitializeGenderComboBox()
        {
            comboBoxRole.Items.Add(new ComboBoxItem("Admin", 1));
            comboBoxRole.Items.Add(new ComboBoxItem("Giáo viên", 2));
            comboBoxRole.DisplayMember = "Text";
            comboBoxRole.ValueMember = "Value";
            comboBoxRole.SelectedIndex = 0;
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


        private void fThemTaiKhoan_Paint(object sender, PaintEventArgs e)
        {
            using (Pen borderPen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void fThemTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            if (!this.ClientRectangle.Contains(e.Location))
            {
                this.Close();
            }
        }


        private void CenterToParent(Form parentForm)
        {
            int centerX = parentForm.Left + (parentForm.Width - this.Width) / 2;
            int centerY = parentForm.Top + (parentForm.Height - this.Height) / 2;
            this.Location = new Point(centerX, centerY);
        }

        private void btSaveTaiKhoan_Click(object sender, EventArgs e)
        {
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

            if (comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn vai trò", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxRole.Focus();
                return;
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
                var selectedRole = (ComboBoxItem)comboBoxRole.SelectedItem;
                var taiKhoan = new TaiKhoan
                {
                    Email = txtEmail.Text,
                    MatKhau = txtMatKhau.Text,
                    RoleID  = selectedRole.Value,
                    TinhTrang = ckTinhTrang.CheckState == CheckState.Checked ? true : false,
                };

                using (var db = new EFDbContext())
                {
                    db.TaiKhoans.Add(taiKhoan); 
                    db.SaveChanges(); 
                }

                txtEmail.Text = string.Empty;
                txtMatKhau.Text = string.Empty;
                comboBoxRole.SelectedIndex = -1; 
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveTaiKhoan, 0, 0, 1000);
            }
            txtEmail.Focus();
        }

       

        private void btCancelTaiKhoan_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn hủy không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void fThemTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        //private void txtMatKhau_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
        //    {
        //        toolTip1.Show("Hãy nhập Mật khẩu", txtMatKhau, 0, 0, 1000);
        //        e.Cancel = true;
        //    }
        //    else if ((txtMatKhau.Text.Length > 100))
        //    {
        //        toolTip1.Show("Mật khẩu <= 100 ký tự", txtMatKhau, 0, 0, 1000);
        //        e.Cancel = true;
        //    }
        //}

        //private void txtVaiTro_Validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtVaiTro.Text))
        //    {
        //        toolTip1.Show("Hãy nhập Vai trò 1 (Người quản trị) hoặc 2 (Giảng viên)", txtVaiTro, 0, 0, 1000);
        //        e.Cancel = true;
        //    }
        //    else if ((txtVaiTro.Text.Length > 100))
        //    {
        //        toolTip1.Show("Vai trò <= 100 ký tự", txtVaiTro, 0, 0, 1000);
        //        e.Cancel = true;
        //    }
        //    else if (txtVaiTro.Text != "1" && txtVaiTro.Text != "2")
        //    {
        //        toolTip1.Show("Vai trò phải là 1 (Người quản trị) hoặc 2 (Giảng viên)", txtVaiTro, 0, 0, 1000);
        //        e.Cancel = true;
        //    }
        //}
    }
}
