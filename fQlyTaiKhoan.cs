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
using System.Xml.Linq;

namespace QLSV
{
    public partial class fQlyTaiKhoan : Form
    {
        public fQlyTaiKhoan()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Load += new EventHandler(fQlyTaiKhoan_Load);
        }

        private void fQlyTaiKhoan_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
            int topMargin = 260;
            dataGridView1.Location = new Point((this.ClientSize.Width - dataGridView1.Width) / 2, topMargin);
            dataGridView1.Dock = DockStyle.None;
            InitializeDataGridView();
        }

        private void btNewTaiKhoan_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemTaiKhoan"))
                return;
            fThemTaiKhoan f = new fThemTaiKhoan(this);
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fQlyTaiKhoan_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                var accounts = db.TaiKhoans
                    .Select(c => new
                    {
                        c.TaiKhoanID,
                        c.Email,
                        RoleString = c.RoleID == 1 ? "Admin" : "Giáo viên",
                        TinhTrangString = c.TinhTrang ? "Hoạt động" : "Không hoạt động"
                    }).ToList();

                dataGridView1.DataSource = accounts;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btDeleteTaiKhoan")
            {
                try
                {
                    long TaiKhoanID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["TaiKhoanID"].Value);
                    using (var db = new EFDbContext())
                    {
                        TaiKhoan taiKhoan = db.TaiKhoans.Single(c => c.TaiKhoanID == TaiKhoanID);
                        if (MessageBox.Show("Bạn muốn xóa tài khoản " + taiKhoan.TaiKhoanID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            db.TaiKhoans.Remove(taiKhoan);
                            db.SaveChanges();
                            fQlyTaiKhoan_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btEditTaiKhoan")
            {
                if (Utility.IsOpeningForm("fSuaTaiKhoan"))
                    return;
                fSuaTaiKhoan f = new fSuaTaiKhoan(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["TaiKhoanID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }
        }

        private void btFindTaiKhoan_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.TaiKhoans.Select(c => new { c.TaiKhoanID, c.Email, c.MatKhau, c.RoleID, c.TinhTrang }).Where(c =>
               c.Email.Contains(txtEmail.Text)).ToList();
            }

        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            DataGridViewCellStyle centerCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            DataGridViewCellStyle headerCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            var taiKhoanIDColumn = new DataGridViewTextBoxColumn
            {
                Name = "TaiKhoanID",
                HeaderText = "ID Tài Khoản",
                DataPropertyName = "TaiKhoanID",
                DefaultCellStyle = centerCellStyle
            };
            taiKhoanIDColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(taiKhoanIDColumn);

            var emailColumn = new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
                DefaultCellStyle = centerCellStyle
            };
            emailColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(emailColumn);

            //var matKhauColumn = new DataGridViewTextBoxColumn
            //{
            //    Name = "MatKhau",
            //    HeaderText = "Mật Khẩu",
            //    DataPropertyName = "MatKhau",
            //    DefaultCellStyle = centerCellStyle
            //};
            //matKhauColumn.HeaderCell.Style = headerCellStyle;
            //dataGridView1.Columns.Add(matKhauColumn);

            var roleIDColumn = new DataGridViewTextBoxColumn
            {
                Name = "RoleString",
                HeaderText = "Vai trò",
                DataPropertyName = "RoleString",
                DefaultCellStyle = centerCellStyle
            };
            roleIDColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(roleIDColumn);

            var tinhTrangColumn = new DataGridViewTextBoxColumn
            {
                Name = "TinhTrangString",
                HeaderText = "Trạng Thái",
                DataPropertyName = "TinhTrangString",
                DefaultCellStyle = centerCellStyle
            };
            tinhTrangColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(tinhTrangColumn);

            var editColumn = new DataGridViewButtonColumn
            {
                Name = "btEditTaiKhoan",
                HeaderText = "Sửa",
                Text = "Sửa",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            dataGridView1.Columns.Add(editColumn);

            if(Utility.taiKhoan.RoleID == 1)
            {
                var deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "btDeleteTaiKhoan",
                    HeaderText = "Xóa",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dataGridView1.Columns.Add(deleteColumn);
            }
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "TinhTrangString" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Không hoạt động")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }
    }
}
