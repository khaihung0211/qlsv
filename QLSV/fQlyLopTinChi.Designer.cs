namespace QLSV
{
    partial class fQlyLopTinChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlyLopTinChi));
            dgvLopTC = new DataGridView();
            txtSearchLopTC = new TextBox();
            btFindLopTC = new Button();
            btNewLopTC = new Button();
            label1 = new Label();
            label2 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            LopTCID = new DataGridViewTextBoxColumn();
            MaLopTC = new DataGridViewTextBoxColumn();
            MaMon = new DataGridViewTextBoxColumn();
            MaSoGV = new DataGridViewTextBoxColumn();
            HocKy = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            KhoaID = new DataGridViewTextBoxColumn();
            EditLopTC = new DataGridViewButtonColumn();
            DeleteLopTC = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvLopTC).BeginInit();
            SuspendLayout();
            // 
            // dgvLopTC
            // 
            dgvLopTC.AllowUserToAddRows = false;
            dgvLopTC.AllowUserToDeleteRows = false;
            dgvLopTC.AllowUserToOrderColumns = true;
            dgvLopTC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLopTC.Columns.AddRange(new DataGridViewColumn[] { LopTCID, MaLopTC, MaMon, MaSoGV, HocKy, NamHoc, KhoaID, EditLopTC, DeleteLopTC });
            dgvLopTC.Location = new Point(44, 117);
            dgvLopTC.Name = "dgvLopTC";
            dgvLopTC.RowHeadersWidth = 51;
            dgvLopTC.Size = new Size(938, 264);
            dgvLopTC.TabIndex = 0;
            dgvLopTC.CellContentClick += dgvLopTC_CellContentClick;
            // 
            // txtSearchLopTC
            // 
            txtSearchLopTC.Location = new Point(658, 71);
            txtSearchLopTC.Name = "txtSearchLopTC";
            txtSearchLopTC.Size = new Size(175, 27);
            txtSearchLopTC.TabIndex = 1;
            // 
            // btFindLopTC
            // 
            btFindLopTC.Location = new Point(853, 71);
            btFindLopTC.Name = "btFindLopTC";
            btFindLopTC.Size = new Size(94, 29);
            btFindLopTC.TabIndex = 2;
            btFindLopTC.Text = "Tìm";
            btFindLopTC.UseVisualStyleBackColor = true;
            btFindLopTC.Click += btFindLopTC_Click;
            // 
            // btNewLopTC
            // 
            btNewLopTC.BackColor = Color.Azure;
            btNewLopTC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btNewLopTC.Image = (Image)resources.GetObject("btNewLopTC.Image");
            btNewLopTC.ImageAlign = ContentAlignment.MiddleLeft;
            btNewLopTC.Location = new Point(61, 63);
            btNewLopTC.Margin = new Padding(2);
            btNewLopTC.Name = "btNewLopTC";
            btNewLopTC.Size = new Size(132, 40);
            btNewLopTC.TabIndex = 3;
            btNewLopTC.Text = "Nhập mới";
            btNewLopTC.UseCompatibleTextRendering = true;
            btNewLopTC.UseVisualStyleBackColor = false;
            btNewLopTC.Click += btNewLopTC_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(212, 19);
            label1.Name = "label1";
            label1.Size = new Size(343, 41);
            label1.TabIndex = 4;
            label1.Text = "QUẢN LÝ LỚP TÍN CHỈ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 74);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 5;
            label2.Text = "Tìm kiếm theo mã lớp tín chỉ :";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // LopTCID
            // 
            LopTCID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LopTCID.DataPropertyName = "LopTCID";
            LopTCID.HeaderText = "LopTCID";
            LopTCID.MinimumWidth = 6;
            LopTCID.Name = "LopTCID";
            // 
            // MaLopTC
            // 
            MaLopTC.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaLopTC.DataPropertyName = "MaLopTC";
            MaLopTC.HeaderText = "MaLopTC";
            MaLopTC.MinimumWidth = 6;
            MaLopTC.Name = "MaLopTC";
            // 
            // MaMon
            // 
            MaMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaMon.DataPropertyName = "MaMon";
            MaMon.HeaderText = "MaMon";
            MaMon.MinimumWidth = 6;
            MaMon.Name = "MaMon";
            // 
            // MaSoGV
            // 
            MaSoGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSoGV.DataPropertyName = "MaSoGV";
            MaSoGV.HeaderText = "MaSoGV";
            MaSoGV.MinimumWidth = 6;
            MaSoGV.Name = "MaSoGV";
            // 
            // HocKy
            // 
            HocKy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HocKy.DataPropertyName = "HocKy";
            HocKy.HeaderText = "HocKy";
            HocKy.MinimumWidth = 6;
            HocKy.Name = "HocKy";
            // 
            // NamHoc
            // 
            NamHoc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NamHoc.DataPropertyName = "NamHoc";
            NamHoc.HeaderText = "NamHoc";
            NamHoc.MinimumWidth = 6;
            NamHoc.Name = "NamHoc";
            // 
            // KhoaID
            // 
            KhoaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KhoaID.DataPropertyName = "KhoaID";
            KhoaID.HeaderText = "KhoaID";
            KhoaID.MinimumWidth = 6;
            KhoaID.Name = "KhoaID";
            // 
            // EditLopTC
            // 
            EditLopTC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditLopTC.DataPropertyName = "EditLopTC";
            EditLopTC.HeaderText = "Sửa";
            EditLopTC.MinimumWidth = 6;
            EditLopTC.Name = "EditLopTC";
            EditLopTC.Text = "Sửa";
            EditLopTC.UseColumnTextForButtonValue = true;
            EditLopTC.Width = 40;
            // 
            // DeleteLopTC
            // 
            DeleteLopTC.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteLopTC.DataPropertyName = "DeleteLopTC";
            DeleteLopTC.HeaderText = "Xóa";
            DeleteLopTC.MinimumWidth = 6;
            DeleteLopTC.Name = "DeleteLopTC";
            DeleteLopTC.Text = "Xóa";
            DeleteLopTC.UseColumnTextForButtonValue = true;
            DeleteLopTC.Width = 41;
            // 
            // fQlyLopTinChi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1092, 515);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btNewLopTC);
            Controls.Add(btFindLopTC);
            Controls.Add(txtSearchLopTC);
            Controls.Add(dgvLopTC);
            Name = "fQlyLopTinChi";
            Text = "Quản lý Lớp tín chỉ";
            Activated += fQlyLopTinChi_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvLopTC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLopTC;
        private TextBox txtSearchLopTC;
        private Button btFindLopTC;
        private Button btNewLopTC;
        private Label label1;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn LopTCID;
        private DataGridViewTextBoxColumn MaLopTC;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn MaSoGV;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewTextBoxColumn KhoaID;
        private DataGridViewButtonColumn EditLopTC;
        private DataGridViewButtonColumn DeleteLopTC;
    }
}