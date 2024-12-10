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

namespace QLSV
{
    public partial class fQlySinhVien : Form
    {
        public fQlySinhVien()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Load += new EventHandler(fQlySinhVien_Load);
            this.dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting); // Đăng ký sự kiện

        }
        private void fQlySinhVien_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            dataGridView1.Width = this.ClientSize.Width;
            dataGridView1.Height = this.ClientSize.Height;
            int topMargin = 120;
            dataGridView1.Location = new Point((this.ClientSize.Width - dataGridView1.Width) / 2, topMargin);
            dataGridView1.Dock = DockStyle.None;
        }

        private void fQlySinhVien_Activated(object sender, EventArgs e)
        {
            InitializeDataGridView();
            using (var db = new EFDbContext())
            {
                var query = from sinhVien in db.SinhViens
                            join lopdn in db.LopDanhNghias on sinhVien.LopDNID equals lopdn.LopDNID
                            select new
                            {
                                sinhVien.MaSoSV,
                                sinhVien.TenSV,
                                sinhVien.NgaySinh,
                                GioiTinh = sinhVien.GioiTinh,
                                GioiTinhString = sinhVien.GioiTinh ? "Nam" : "Nữ",
                                sinhVien.DiaChi,
                                sinhVien.SoDienThoai,
                                sinhVien.Email,
                                sinhVien.TrangThai,
                                TrangThaiString = sinhVien.TrangThai ? "Hoạt động" : "Không hoạt động",
                                MaLopDN = lopdn.MaLopDN,
                                TenLop = lopdn.MaLopDN
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void btNewSinhVien_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fThemSinhVien"))
                return;

            fThemSinhVien f = new fThemSinhVien(this);
            f.MdiParent = this.MdiParent;
            f.Show();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fSuaSinhVien"))
                    return;
                fSuaSinhVien f = new fSuaSinhVien(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MaSoSV"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long maSoSV = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["MaSoSV"].Value);
                    using (var db = new EFDbContext())
                    {
                        SinhVien sinhVien = db.SinhViens.Single(sv => sv.MaSoSV == maSoSV);
                        if (MessageBox.Show("Bạn muốn xóa sinh viên " + sinhVien.TenSV, "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.SinhViens.Remove(sinhVien);
                            db.SaveChanges();
                            fQlySinhVien_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }

        private void btFindSinhVien_Click(object sender, EventArgs e)
        {
           
            string tenSV = txtTenSV.Text;
            using (var db = new EFDbContext())
            {
                var query = from sinhVien in db.SinhViens
                            join lopdn in db.LopDanhNghias on sinhVien.LopDNID equals lopdn.LopDNID
                            where sinhVien.TenSV.Contains(tenSV)
                            select new
                            {
                                sinhVien.MaSoSV,
                                sinhVien.TenSV,
                                sinhVien.NgaySinh,
                                GioiTinh = sinhVien.GioiTinh,
                                GioiTinhString = sinhVien.GioiTinh ? "Nam" : "Nữ",
                                sinhVien.DiaChi,
                                sinhVien.SoDienThoai,
                                sinhVien.Email,
                                sinhVien.TrangThai,
                                TrangThaiString = sinhVien.TrangThai ? "Hoạt động" : "Không hoạt động",
                                MaLopDN = lopdn.MaLopDN,
                                TenLop = lopdn.MaLopDN
                            };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "TrangThaiString" && e.Value != null)
            {
                string status = e.Value.ToString();
                if (status == "Không hoạt động")
                {
                  e.CellStyle.ForeColor = Color.Red;
                }
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

            var maSoSVColumn = new DataGridViewTextBoxColumn
            {
                Name = "MaSoSV",
                HeaderText = "Mã Số SV",
                DataPropertyName = "MaSoSV",
                DefaultCellStyle = centerCellStyle,
                Width = 80, 
                MinimumWidth = 50 
            };
            maSoSVColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(maSoSVColumn);

            var tenSVColumn = new DataGridViewTextBoxColumn
            {
                Name = "TenSV",
                HeaderText = "Tên SV",
                DataPropertyName = "TenSV",
                DefaultCellStyle = centerCellStyle,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 100
            };
            tenSVColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(tenSVColumn);

            var ngaySinhColumn = new DataGridViewTextBoxColumn
            {
                Name = "NgaySinh",
                HeaderText = "Ngày Sinh",
                DataPropertyName = "NgaySinh",
                DefaultCellStyle = centerCellStyle,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 100
            };
            ngaySinhColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(ngaySinhColumn);

            var gioiTinhStringColumn = new DataGridViewTextBoxColumn
            {
                Name = "GioiTinhString",
                HeaderText = "Giới Tính",
                DataPropertyName = "GioiTinhString",
                DefaultCellStyle = centerCellStyle,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 100
            };
            gioiTinhStringColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(gioiTinhStringColumn);

            var diaChiColumn = new DataGridViewTextBoxColumn
            {
                Name = "DiaChi",
                HeaderText = "Địa Chỉ",
                DataPropertyName = "DiaChi",
                DefaultCellStyle = centerCellStyle,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 150
            };
            diaChiColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(diaChiColumn);

            var emailColumn = new DataGridViewTextBoxColumn
            {
                Name = "Email",
                HeaderText = "Email",
                DataPropertyName = "Email",
                DefaultCellStyle = centerCellStyle
            };
            emailColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(emailColumn);

            var soDienThoaiColumn = new DataGridViewTextBoxColumn
            {
                Name = "SoDienThoai",
                HeaderText = "Số điện thoại",
                DataPropertyName = "SoDienThoai",
                DefaultCellStyle = centerCellStyle
            };
            soDienThoaiColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(soDienThoaiColumn);

            var trangThaiColumn = new DataGridViewTextBoxColumn
            {
                Name = "TrangThaiString",
                HeaderText = "Trạng Thái",
                DataPropertyName = "TrangThaiString",
                DefaultCellStyle = centerCellStyle,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 100
            };
            trangThaiColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(trangThaiColumn);

            var tenLopColumn = new DataGridViewTextBoxColumn
            {
                Name = "TenLop",
                HeaderText = "Tên Lớp",
                DataPropertyName = "TenLop",
                DefaultCellStyle = centerCellStyle,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                MinimumWidth = 100
            };
            tenLopColumn.HeaderCell.Style = headerCellStyle;
            dataGridView1.Columns.Add(tenLopColumn);

            var editColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                HeaderText = "",
                Text = "Sửa",
                UseColumnTextForButtonValue = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            };
            dataGridView1.Columns.Add(editColumn);

           if(Utility.taiKhoan.RoleID == 1)
            {
                var deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Delete",
                    HeaderText = "",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };
                dataGridView1.Columns.Add(deleteColumn);
            }
        }




    }
}
