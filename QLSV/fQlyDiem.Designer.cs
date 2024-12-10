namespace QLSV
{
    partial class fQlyDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlyDiem));
            dgvBangDiem = new DataGridView();
            LopTCID = new DataGridViewTextBoxColumn();
            MaLopTC = new DataGridViewTextBoxColumn();
            MaSoSV = new DataGridViewTextBoxColumn();
            TenSV = new DataGridViewTextBoxColumn();
            MaLopDN = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            DiemChuyenCan = new DataGridViewTextBoxColumn();
            DiemGiuaKy = new DataGridViewTextBoxColumn();
            DiemThiCuoiKy = new DataGridViewTextBoxColumn();
            TiLeDiemQuaTrinh = new DataGridViewTextBoxColumn();
            TiLeDiemThiCuoiKy = new DataGridViewTextBoxColumn();
            DiemTB = new DataGridViewTextBoxColumn();
            btEditBangDiem = new DataGridViewButtonColumn();
            btDeleteBangDiem = new DataGridViewButtonColumn();
            btNewBangDiem = new Button();
            btFindBangDiem = new Button();
            txtSearchBangDiem = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBangDiem).BeginInit();
            SuspendLayout();
            // 
            // dgvBangDiem
            // 
            dgvBangDiem.AllowUserToAddRows = false;
            dgvBangDiem.AllowUserToDeleteRows = false;
            dgvBangDiem.AllowUserToOrderColumns = true;
            dgvBangDiem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBangDiem.Columns.AddRange(new DataGridViewColumn[] { LopTCID, MaLopTC, MaSoSV, TenSV, MaLopDN, TenMon, DiemChuyenCan, DiemGiuaKy, DiemThiCuoiKy, TiLeDiemQuaTrinh, TiLeDiemThiCuoiKy, DiemTB, btEditBangDiem, btDeleteBangDiem });
            dgvBangDiem.Location = new Point(15, 234);
            dgvBangDiem.Margin = new Padding(4, 4, 4, 4);
            dgvBangDiem.Name = "dgvBangDiem";
            dgvBangDiem.RowHeadersWidth = 51;
            dgvBangDiem.Size = new Size(1852, 604);
            dgvBangDiem.TabIndex = 0;
            dgvBangDiem.CellContentClick += dgvBangDiem_CellContentClick;
            // 
            // LopTCID
            // 
            LopTCID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LopTCID.DataPropertyName = "LopTCID";
            LopTCID.HeaderText = "Lớp TC ID";
            LopTCID.MinimumWidth = 8;
            LopTCID.Name = "LopTCID";
            LopTCID.Visible = false;
            LopTCID.Width = 150;
            // 
            // MaLopTC
            // 
            MaLopTC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLopTC.DataPropertyName = "MaLopTC";
            MaLopTC.HeaderText = "Lớp tín chỉ";
            MaLopTC.MinimumWidth = 6;
            MaLopTC.Name = "MaLopTC";
            // 
            // MaSoSV
            // 
            MaSoSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            MaSoSV.DataPropertyName = "MaSoSV";
            MaSoSV.HeaderText = "Mã số sinh viên";
            MaSoSV.MinimumWidth = 6;
            MaSoSV.Name = "MaSoSV";
            MaSoSV.Width = 128;
            // 
            // TenSV
            // 
            TenSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenSV.DataPropertyName = "TenSV";
            TenSV.HeaderText = "Tên sinh viên";
            TenSV.MinimumWidth = 8;
            TenSV.Name = "TenSV";
            // 
            // MaLopDN
            // 
            MaLopDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLopDN.DataPropertyName = "MaLopDN";
            MaLopDN.HeaderText = "Lớp danh nghĩa";
            MaLopDN.MinimumWidth = 8;
            MaLopDN.Name = "MaLopDN";
            // 
            // TenMon
            // 
            TenMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên môn";
            TenMon.MinimumWidth = 8;
            TenMon.Name = "TenMon";
            // 
            // DiemChuyenCan
            // 
            DiemChuyenCan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemChuyenCan.DataPropertyName = "DiemChuyenCan";
            DiemChuyenCan.HeaderText = "Điểm chuyên cần";
            DiemChuyenCan.MinimumWidth = 6;
            DiemChuyenCan.Name = "DiemChuyenCan";
            DiemChuyenCan.Width = 126;
            // 
            // DiemGiuaKy
            // 
            DiemGiuaKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemGiuaKy.DataPropertyName = "DiemGiuaKy";
            DiemGiuaKy.HeaderText = "Điểm giữa kỳ";
            DiemGiuaKy.MinimumWidth = 6;
            DiemGiuaKy.Name = "DiemGiuaKy";
            DiemGiuaKy.Width = 99;
            // 
            // DiemThiCuoiKy
            // 
            DiemThiCuoiKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemThiCuoiKy.DataPropertyName = "DiemThiCuoiKy";
            DiemThiCuoiKy.HeaderText = "Điểm cuối kỳ";
            DiemThiCuoiKy.MinimumWidth = 6;
            DiemThiCuoiKy.Name = "DiemThiCuoiKy";
            DiemThiCuoiKy.Width = 97;
            // 
            // TiLeDiemQuaTrinh
            // 
            TiLeDiemQuaTrinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TiLeDiemQuaTrinh.DataPropertyName = "TiLeDiemQuaTrinh";
            TiLeDiemQuaTrinh.HeaderText = "Tỉ lệ điểm quá trình";
            TiLeDiemQuaTrinh.MinimumWidth = 6;
            TiLeDiemQuaTrinh.Name = "TiLeDiemQuaTrinh";
            TiLeDiemQuaTrinh.Width = 119;
            // 
            // TiLeDiemThiCuoiKy
            // 
            TiLeDiemThiCuoiKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TiLeDiemThiCuoiKy.DataPropertyName = "TiLeDiemThiCuoiKy";
            TiLeDiemThiCuoiKy.HeaderText = "Tỉ lệ điểm thi cuối kỳ";
            TiLeDiemThiCuoiKy.MinimumWidth = 6;
            TiLeDiemThiCuoiKy.Name = "TiLeDiemThiCuoiKy";
            TiLeDiemThiCuoiKy.Width = 119;
            // 
            // DiemTB
            // 
            DiemTB.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DiemTB.DataPropertyName = "DiemTB";
            DiemTB.HeaderText = "Điểm trung bình";
            DiemTB.MinimumWidth = 6;
            DiemTB.Name = "DiemTB";
            DiemTB.Width = 121;
            // 
            // btEditBangDiem
            // 
            btEditBangDiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btEditBangDiem.DataPropertyName = "btEditBangDiem";
            btEditBangDiem.HeaderText = "Sửa";
            btEditBangDiem.MinimumWidth = 6;
            btEditBangDiem.Name = "btEditBangDiem";
            btEditBangDiem.Text = "Sửa";
            btEditBangDiem.UseColumnTextForButtonValue = true;
            btEditBangDiem.Width = 48;
            // 
            // btDeleteBangDiem
            // 
            btDeleteBangDiem.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btDeleteBangDiem.DataPropertyName = "btDeleteBangDiem";
            btDeleteBangDiem.HeaderText = "Xóa";
            btDeleteBangDiem.MinimumWidth = 6;
            btDeleteBangDiem.Name = "btDeleteBangDiem";
            btDeleteBangDiem.Text = "Xóa";
            btDeleteBangDiem.UseColumnTextForButtonValue = true;
            btDeleteBangDiem.Width = 49;
            // 
            // btNewBangDiem
            // 
            btNewBangDiem.Image = (Image)resources.GetObject("btNewBangDiem.Image");
            btNewBangDiem.ImageAlign = ContentAlignment.MiddleLeft;
            btNewBangDiem.Location = new Point(69, 131);
            btNewBangDiem.Margin = new Padding(4, 4, 4, 4);
            btNewBangDiem.Name = "btNewBangDiem";
            btNewBangDiem.Padding = new Padding(10, 0, 0, 0);
            btNewBangDiem.Size = new Size(165, 50);
            btNewBangDiem.TabIndex = 1;
            btNewBangDiem.Text = "Nhập mới";
            btNewBangDiem.UseVisualStyleBackColor = true;
            btNewBangDiem.Click += btNewBangDiem_Click;
            // 
            // btFindBangDiem
            // 
            btFindBangDiem.Location = new Point(1244, 150);
            btFindBangDiem.Margin = new Padding(4, 4, 4, 4);
            btFindBangDiem.Name = "btFindBangDiem";
            btFindBangDiem.Size = new Size(118, 36);
            btFindBangDiem.TabIndex = 2;
            btFindBangDiem.Text = "Tìm";
            btFindBangDiem.UseVisualStyleBackColor = true;
            // 
            // txtSearchBangDiem
            // 
            txtSearchBangDiem.Location = new Point(952, 150);
            txtSearchBangDiem.Margin = new Padding(4, 4, 4, 4);
            txtSearchBangDiem.Name = "txtSearchBangDiem";
            txtSearchBangDiem.Size = new Size(252, 31);
            txtSearchBangDiem.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(400, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(299, 48);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ  ĐIỂM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(785, 153);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 25);
            label2.TabIndex = 5;
            label2.Text = "Nhập tên sinh viên";
            // 
            // fQlyDiem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1878, 1024);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearchBangDiem);
            Controls.Add(btFindBangDiem);
            Controls.Add(btNewBangDiem);
            Controls.Add(dgvBangDiem);
            Margin = new Padding(4, 4, 4, 4);
            Name = "fQlyDiem";
            Text = "Bảng điểm";
            WindowState = FormWindowState.Maximized;
            Activated += fQlyDiem_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvBangDiem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBangDiem;
        private Button btNewBangDiem;
        private Button btFindBangDiem;
        private TextBox txtSearchBangDiem;
        private DataGridViewTextBoxColumn LopTCID;
        private DataGridViewTextBoxColumn MaLopTC;
        private DataGridViewTextBoxColumn MaSoSV;
        private DataGridViewTextBoxColumn TenSV;
        private DataGridViewTextBoxColumn MaLopDN;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn DiemChuyenCan;
        private DataGridViewTextBoxColumn DiemGiuaKy;
        private DataGridViewTextBoxColumn DiemThiCuoiKy;
        private DataGridViewTextBoxColumn TiLeDiemQuaTrinh;
        private DataGridViewTextBoxColumn TiLeDiemThiCuoiKy;
        private DataGridViewTextBoxColumn DiemTB;
        private DataGridViewButtonColumn btEditBangDiem;
        private DataGridViewButtonColumn btDeleteBangDiem;
        private Label label1;
        private Label label2;
    }
}