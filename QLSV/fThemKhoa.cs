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
    public partial class fThemKhoa : Form
    {
        Khoa khoa;
        private EFDbContext _context;
        public fThemKhoa()
        {
            InitializeComponent();
            _context = new EFDbContext();
        }
        private void btCancelKhoa_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btSaveKhoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa?", txtMaKhoa, 0, 0, 1000);
                txtMaKhoa.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                toolTip1.Show("Hãy nhập tên khoa?", txtTenKhoa, 0, 0, 1000);
                txtTenKhoa.Focus();
                return;
            }

            try
            {
                // Tạo Khoa mới
                var khoa = new Khoa
                {
                    MaKhoa = txtMaKhoa.Text,
                    TenKhoa = txtTenKhoa.Text
                };

                using (var db = new EFDbContext())
                {
                    db.Khoas.Add(khoa); // Thêm khoa vào bối cảnh mô hình
                    db.SaveChanges(); // Lưu các thay đổi vào csdl
                }

                // Xóa trống và thiết lập lại các điều khiển
                txtMaKhoa.Text = null;
                txtTenKhoa.Text = null;
                toolTip1.Show("Lưu thành công!", btSaveKhoa, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveKhoa, 0, 0, 1000);
            }
            txtMaKhoa.Focus();
        }

        private void txtMaKhoa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKhoa.Text))
            {
                toolTip1.Show("Hãy nhập mã khoa?", txtMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtMaKhoa.Text.Length > 10)
            {
                toolTip1.Show("Mã khoa <= 10 ký tự?", txtMaKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtTenKhoa_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhoa.Text))
            {
                toolTip1.Show("Hãy nhập tên khoa?", txtTenKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtTenKhoa.Text.Length > 100)
            {
                toolTip1.Show("Tên khoa <= 100 ký tự?", txtTenKhoa, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void fThemKhoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
