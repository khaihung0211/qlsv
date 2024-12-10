namespace QLSV
{
    partial class fQlySinhVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlySinhVien));
            dataGridView1 = new DataGridView();
            MaSoSV = new DataGridViewTextBoxColumn();
            TenSV = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewCheckBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            TrangThai = new DataGridViewCheckBoxColumn();
            MaLopDN = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            btFindSinhVien = new Button();
            txtTenSV = new TextBox();
            label2 = new Label();
            btNewSinhVien = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSoSV, TenSV, NgaySinh, GioiTinh, DiaChi, SoDienThoai, Email, TrangThai, MaLopDN, Edit, Delete });
            dataGridView1.Location = new Point(18, 95);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 10;
            dataGridView1.Size = new Size(1128, 209);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaSoSV
            // 
            MaSoSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaSoSV.DataPropertyName = "MaSoSV";
            MaSoSV.HeaderText = "Mã số sinh viên";
            MaSoSV.Name = "MaSoSV";
            MaSoSV.Width = 114;
            // 
            // TenSV
            // 
            TenSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSV.DataPropertyName = "TenSV";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TenSV.DefaultCellStyle = dataGridViewCellStyle1;
            TenSV.HeaderText = "Tên sinh viên";
            TenSV.MinimumWidth = 6;
            TenSV.Name = "TenSV";
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgaySinh.DataPropertyName = "NgaySinh";
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Resizable = DataGridViewTriState.True;
            GioiTinh.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // DiaChi
            // 
            DiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DiaChi.DataPropertyName = "DiaChi";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DiaChi.DefaultCellStyle = dataGridViewCellStyle2;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Email.DefaultCellStyle = dataGridViewCellStyle3;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            // 
            // TrangThai
            // 
            TrangThai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TrangThai.DataPropertyName = "TrangThai";
            TrangThai.HeaderText = "Trạng thái";
            TrangThai.MinimumWidth = 6;
            TrangThai.Name = "TrangThai";
            // 
            // MaLopDN
            // 
            MaLopDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLopDN.DataPropertyName = "MaLopDN";
            MaLopDN.HeaderText = "Lớp danh nghĩa";
            MaLopDN.MinimumWidth = 6;
            MaLopDN.Name = "MaLopDN";
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 51;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xóa";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 52;
            // 
            // btFindSinhVien
            // 
            btFindSinhVien.Location = new Point(1063, 56);
            btFindSinhVien.Margin = new Padding(3, 2, 3, 2);
            btFindSinhVien.Name = "btFindSinhVien";
            btFindSinhVien.Size = new Size(83, 25);
            btFindSinhVien.TabIndex = 2;
            btFindSinhVien.Text = "Tìm";
            btFindSinhVien.UseVisualStyleBackColor = true;
            btFindSinhVien.Click += btFindSinhVien_Click;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(868, 58);
            txtTenSV.Margin = new Padding(3, 2, 3, 2);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(190, 23);
            txtTenSV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(18, 52, 86);
            label2.Location = new Point(224, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(254, 32);
            label2.TabIndex = 6;
            label2.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // btNewSinhVien
            // 
            btNewSinhVien.BackColor = Color.Azure;
            btNewSinhVien.BackgroundImageLayout = ImageLayout.None;
            btNewSinhVien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNewSinhVien.Image = (Image)resources.GetObject("btNewSinhVien.Image");
            btNewSinhVien.ImageAlign = ContentAlignment.MiddleLeft;
            btNewSinhVien.Location = new Point(18, 56);
            btNewSinhVien.Margin = new Padding(2);
            btNewSinhVien.Name = "btNewSinhVien";
            btNewSinhVien.Padding = new Padding(7, 0, 0, 0);
            btNewSinhVien.Size = new Size(116, 30);
            btNewSinhVien.TabIndex = 7;
            btNewSinhVien.Text = "Nhập mới";
            btNewSinhVien.UseCompatibleTextRendering = true;
            btNewSinhVien.UseVisualStyleBackColor = false;
            btNewSinhVien.Click += btNewSinhVien_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(752, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 8;
            label1.Text = "Nhập tên sinh viên";
            // 
            // fQlySinhVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Ivory;
            ClientSize = new Size(1159, 313);
            Controls.Add(label1);
            Controls.Add(btNewSinhVien);
            Controls.Add(label2);
            Controls.Add(txtTenSV);
            Controls.Add(btFindSinhVien);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fQlySinhVien";
            Text = "Quản lý sinh viên";
            Activated += fQlySinhVien_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btFindSinhVien;
        private TextBox txtTenSV;
        private Label label2;
        private Button btNewSinhVien;
        private Label label1;
        private DataGridViewTextBoxColumn MaSoSV;
        private DataGridViewTextBoxColumn TenSV;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewCheckBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewCheckBoxColumn TrangThai;
        private DataGridViewTextBoxColumn MaLopDN;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}