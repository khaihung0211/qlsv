namespace QLSV
{
    partial class fQlyLopDanhNghia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlyLopDanhNghia));
            dgvLopDN = new DataGridView();
            btNewLopDN = new Button();
            btFindLopDN = new Button();
            txtMaLopDN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            LopDNID = new DataGridViewTextBoxColumn();
            MaLopDN = new DataGridViewTextBoxColumn();
            MaSoGV = new DataGridViewTextBoxColumn();
            SoLuongSV = new DataGridViewTextBoxColumn();
            NamNhapHocCuaSV = new DataGridViewTextBoxColumn();
            maKhoa = new DataGridViewTextBoxColumn();
            btEditLopDN = new DataGridViewButtonColumn();
            btDeleteLopDN = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLopDN).BeginInit();
            SuspendLayout();
            // 
            // dgvLopDN
            // 
            dgvLopDN.AllowUserToAddRows = false;
            dgvLopDN.AllowUserToDeleteRows = false;
            dgvLopDN.AllowUserToOrderColumns = true;
            dgvLopDN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopDN.Columns.AddRange(new DataGridViewColumn[] { LopDNID, MaLopDN, MaSoGV, SoLuongSV, NamNhapHocCuaSV, maKhoa, btEditLopDN, btDeleteLopDN });
            dgvLopDN.Location = new Point(12, 127);
            dgvLopDN.Name = "dgvLopDN";
            dgvLopDN.RowHeadersWidth = 51;
            dgvLopDN.Size = new Size(1026, 271);
            dgvLopDN.TabIndex = 0;
            dgvLopDN.CellContentClick += dgvLopDN_CellContentClick;
            // 
            // btNewLopDN
            // 
            btNewLopDN.BackColor = Color.Azure;
            btNewLopDN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btNewLopDN.Image = (Image)resources.GetObject("btNewLopDN.Image");
            btNewLopDN.ImageAlign = ContentAlignment.MiddleLeft;
            btNewLopDN.Location = new Point(10, 62);
            btNewLopDN.Margin = new Padding(2);
            btNewLopDN.Name = "btNewLopDN";
            btNewLopDN.Padding = new Padding(8, 0, 0, 0);
            btNewLopDN.Size = new Size(139, 42);
            btNewLopDN.TabIndex = 1;
            btNewLopDN.Text = "Nhập mới";
            btNewLopDN.UseCompatibleTextRendering = true;
            btNewLopDN.UseVisualStyleBackColor = false;
            btNewLopDN.Click += btNewLopDN_Click;
            // 
            // btFindLopDN
            // 
            btFindLopDN.Location = new Point(908, 77);
            btFindLopDN.Name = "btFindLopDN";
            btFindLopDN.Size = new Size(94, 29);
            btFindLopDN.TabIndex = 2;
            btFindLopDN.Text = "Tìm";
            btFindLopDN.UseVisualStyleBackColor = true;
            btFindLopDN.Click += btFindLopDN_Click;
            // 
            // txtMaLopDN
            // 
            txtMaLopDN.Location = new Point(687, 77);
            txtMaLopDN.Name = "txtMaLopDN";
            txtMaLopDN.Size = new Size(215, 27);
            txtMaLopDN.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Ivory;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(167, 26);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(435, 41);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ LỚP DANH NGHĨA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 80);
            label2.Name = "label2";
            label2.Size = new Size(181, 20);
            label2.TabIndex = 5;
            label2.Text = "Nhập mã lớp danh nghĩa :";
            // 
            // LopDNID
            // 
            LopDNID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LopDNID.DataPropertyName = "LopDNID";
            LopDNID.HeaderText = "LopDNID";
            LopDNID.MinimumWidth = 6;
            LopDNID.Name = "LopDNID";
            // 
            // MaLopDN
            // 
            MaLopDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLopDN.DataPropertyName = "MaLopDN";
            MaLopDN.HeaderText = "MaLopDN";
            MaLopDN.MinimumWidth = 6;
            MaLopDN.Name = "MaLopDN";
            // 
            // MaSoGV
            // 
            MaSoGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSoGV.DataPropertyName = "MaSoGV";
            MaSoGV.HeaderText = "MaSoGV";
            MaSoGV.MinimumWidth = 6;
            MaSoGV.Name = "MaSoGV";
            // 
            // SoLuongSV
            // 
            SoLuongSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SoLuongSV.DataPropertyName = "SoLuongSV";
            SoLuongSV.HeaderText = "SoLuongSV";
            SoLuongSV.MinimumWidth = 6;
            SoLuongSV.Name = "SoLuongSV";
            SoLuongSV.Width = 113;
            // 
            // NamNhapHocCuaSV
            // 
            NamNhapHocCuaSV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NamNhapHocCuaSV.DataPropertyName = "NamNhapHocCuaSV";
            NamNhapHocCuaSV.HeaderText = "NamNhapHocCuaSV";
            NamNhapHocCuaSV.MinimumWidth = 6;
            NamNhapHocCuaSV.Name = "NamNhapHocCuaSV";
            // 
            // maKhoa
            // 
            maKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhoa.DataPropertyName = "maKhoa";
            maKhoa.HeaderText = "Khoa";
            maKhoa.MinimumWidth = 6;
            maKhoa.Name = "maKhoa";
            // 
            // btEditLopDN
            // 
            btEditLopDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btEditLopDN.DataPropertyName = "btEditLopDN";
            btEditLopDN.HeaderText = "Sửa";
            btEditLopDN.MinimumWidth = 6;
            btEditLopDN.Name = "btEditLopDN";
            btEditLopDN.Text = "Sửa";
            btEditLopDN.UseColumnTextForButtonValue = true;
            btEditLopDN.Width = 40;
            // 
            // btDeleteLopDN
            // 
            btDeleteLopDN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btDeleteLopDN.DataPropertyName = "btDeleteLopDN";
            btDeleteLopDN.HeaderText = "Xóa";
            btDeleteLopDN.MinimumWidth = 6;
            btDeleteLopDN.Name = "btDeleteLopDN";
            btDeleteLopDN.Text = "Xóa";
            btDeleteLopDN.UseColumnTextForButtonValue = true;
            btDeleteLopDN.Width = 41;
            // 
            // fQlyLopDanhNghia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1088, 450);
            Controls.Add(label2);
            Controls.Add(dgvLopDN);
            Controls.Add(label1);
            Controls.Add(txtMaLopDN);
            Controls.Add(btFindLopDN);
            Controls.Add(btNewLopDN);
            Name = "fQlyLopDanhNghia";
            Text = "Lớp Danh Nghĩa";
            Activated += fQlyLopDanhNghia_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvLopDN).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLopDN;
        private Button btNewLopDN;
        private Button btFindLopDN;
        private TextBox txtMaLopDN;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn LopDNID;
        private DataGridViewTextBoxColumn MaLopDN;
        private DataGridViewTextBoxColumn MaSoGV;
        private DataGridViewTextBoxColumn SoLuongSV;
        private DataGridViewTextBoxColumn NamNhapHocCuaSV;
        private DataGridViewTextBoxColumn maKhoa;
        private DataGridViewButtonColumn btEditLopDN;
        private DataGridViewButtonColumn btDeleteLopDN;
    }
}