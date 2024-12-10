namespace QLSV
{
    partial class fQlyGiangVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlyGiangVien));
            label1 = new Label();
            txtSearchGiangVien = new TextBox();
            btFindGiangVien = new Button();
            btNewGiangVien = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            MaSoGV = new DataGridViewTextBoxColumn();
            tenGV = new DataGridViewTextBoxColumn();
            ngaySinh = new DataGridViewTextBoxColumn();
            gioiTinh = new DataGridViewCheckBoxColumn();
            email = new DataGridViewTextBoxColumn();
            hocVi = new DataGridViewTextBoxColumn();
            maKhoa = new DataGridViewTextBoxColumn();
            EditGiangVien = new DataGridViewButtonColumn();
            DeleteGiangVien = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(760, 77);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên Giảng Viên:";
            // 
            // txtSearchGiangVien
            // 
            txtSearchGiangVien.Location = new Point(945, 74);
            txtSearchGiangVien.Name = "txtSearchGiangVien";
            txtSearchGiangVien.Size = new Size(289, 31);
            txtSearchGiangVien.TabIndex = 1;
            // 
            // btFindGiangVien
            // 
            btFindGiangVien.Location = new Point(1240, 71);
            btFindGiangVien.Name = "btFindGiangVien";
            btFindGiangVien.Size = new Size(112, 34);
            btFindGiangVien.TabIndex = 2;
            btFindGiangVien.Text = "Tìm";
            btFindGiangVien.UseVisualStyleBackColor = true;
            btFindGiangVien.Click += btFindGiangVien_Click;
            // 
            // btNewGiangVien
            // 
            btNewGiangVien.BackColor = Color.Azure;
            btNewGiangVien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btNewGiangVien.Image = (Image)resources.GetObject("btNewGiangVien.Image");
            btNewGiangVien.ImageAlign = ContentAlignment.MiddleLeft;
            btNewGiangVien.Location = new Point(12, 77);
            btNewGiangVien.Name = "btNewGiangVien";
            btNewGiangVien.Padding = new Padding(10, 0, 0, 0);
            btNewGiangVien.Size = new Size(165, 50);
            btNewGiangVien.TabIndex = 3;
            btNewGiangVien.Text = "Nhập mới";
            btNewGiangVien.UseCompatibleTextRendering = true;
            btNewGiangVien.UseVisualStyleBackColor = false;
            btNewGiangVien.Click += btNewGiangVien_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSoGV, tenGV, ngaySinh, gioiTinh, email, hocVi, maKhoa, EditGiangVien, DeleteGiangVien });
            dataGridView1.Location = new Point(12, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1354, 366);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(18, 52, 86);
            label2.Location = new Point(264, 54);
            label2.Name = "label2";
            label2.Size = new Size(411, 48);
            label2.TabIndex = 6;
            label2.Text = "QUẢN LÝ GIẢNG VIÊN";
            // 
            // MaSoGV
            // 
            MaSoGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSoGV.DataPropertyName = "MaSoGV";
            MaSoGV.HeaderText = "Mã GV";
            MaSoGV.MinimumWidth = 8;
            MaSoGV.Name = "MaSoGV";
            // 
            // tenGV
            // 
            tenGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenGV.DataPropertyName = "tenGV";
            tenGV.HeaderText = "Tên GV";
            tenGV.MinimumWidth = 8;
            tenGV.Name = "tenGV";
            // 
            // ngaySinh
            // 
            ngaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ngaySinh.DataPropertyName = "ngaySinh";
            ngaySinh.HeaderText = "Ngày Sinh";
            ngaySinh.MinimumWidth = 8;
            ngaySinh.Name = "ngaySinh";
            // 
            // gioiTinh
            // 
            gioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            gioiTinh.DataPropertyName = "gioiTinh";
            gioiTinh.FalseValue = "Nữ";
            gioiTinh.HeaderText = "Giới Tính";
            gioiTinh.MinimumWidth = 8;
            gioiTinh.Name = "gioiTinh";
            gioiTinh.ReadOnly = true;
            gioiTinh.Resizable = DataGridViewTriState.True;
            gioiTinh.SortMode = DataGridViewColumnSortMode.Automatic;
            gioiTinh.TrueValue = "Nam";
            gioiTinh.Width = 117;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 8;
            email.Name = "email";
            // 
            // hocVi
            // 
            hocVi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hocVi.DataPropertyName = "hocVi";
            hocVi.HeaderText = "Học Vị";
            hocVi.MinimumWidth = 8;
            hocVi.Name = "hocVi";
            // 
            // maKhoa
            // 
            maKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhoa.DataPropertyName = "maKhoa";
            maKhoa.HeaderText = "Khoa";
            maKhoa.MinimumWidth = 8;
            maKhoa.Name = "maKhoa";
            // 
            // EditGiangVien
            // 
            EditGiangVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditGiangVien.DataPropertyName = "EditGiangVien";
            EditGiangVien.HeaderText = "Sửa";
            EditGiangVien.MinimumWidth = 8;
            EditGiangVien.Name = "EditGiangVien";
            EditGiangVien.Resizable = DataGridViewTriState.True;
            EditGiangVien.Text = "Sửa";
            EditGiangVien.UseColumnTextForButtonValue = true;
            EditGiangVien.Width = 48;
            // 
            // DeleteGiangVien
            // 
            DeleteGiangVien.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteGiangVien.DataPropertyName = "DeleteGiangVien";
            DeleteGiangVien.HeaderText = "Xóa";
            DeleteGiangVien.MinimumWidth = 8;
            DeleteGiangVien.Name = "DeleteGiangVien";
            DeleteGiangVien.Resizable = DataGridViewTriState.True;
            DeleteGiangVien.Text = "Xoá";
            DeleteGiangVien.UseColumnTextForButtonValue = true;
            DeleteGiangVien.Width = 49;
            // 
            // fQlyGiangVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Ivory;
            ClientSize = new Size(1378, 521);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btNewGiangVien);
            Controls.Add(btFindGiangVien);
            Controls.Add(txtSearchGiangVien);
            Controls.Add(label1);
            Name = "fQlyGiangVien";
            Text = "Quản lý Giảng Viên";
            Activated += fQlyGiangVien_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchGiangVien;
        private Button btFindGiangVien;
        private Button btNewGiangVien;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn MaSoGV;
        private DataGridViewTextBoxColumn tenGV;
        private DataGridViewTextBoxColumn ngaySinh;
        private DataGridViewCheckBoxColumn gioiTinh;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn hocVi;
        private DataGridViewTextBoxColumn maKhoa;
        private DataGridViewButtonColumn EditGiangVien;
        private DataGridViewButtonColumn DeleteGiangVien;
    }
}