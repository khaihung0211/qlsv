namespace QLSV
{
    partial class fQlyMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlyMonHoc));
            label1 = new Label();
            txtSearchMonHoc = new TextBox();
            btFindMonHoc = new Button();
            btNewMonHoc = new Button();
            dataGridView1 = new DataGridView();
            MaMon = new DataGridViewTextBoxColumn();
            TenMon = new DataGridViewTextBoxColumn();
            SoTinChi = new DataGridViewTextBoxColumn();
            SoTietLT = new DataGridViewTextBoxColumn();
            SoTietTH = new DataGridViewTextBoxColumn();
            KhoaID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(659, 71);
            label1.Name = "label1";
            label1.Size = new Size(165, 25);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên môn học:";
            // 
            // txtSearchMonHoc
            // 
            txtSearchMonHoc.Location = new Point(830, 65);
            txtSearchMonHoc.Name = "txtSearchMonHoc";
            txtSearchMonHoc.Size = new Size(298, 31);
            txtSearchMonHoc.TabIndex = 1;
            // 
            // btFindMonHoc
            // 
            btFindMonHoc.Location = new Point(1134, 65);
            btFindMonHoc.Name = "btFindMonHoc";
            btFindMonHoc.Size = new Size(112, 34);
            btFindMonHoc.TabIndex = 2;
            btFindMonHoc.Text = "Tìm";
            btFindMonHoc.UseVisualStyleBackColor = true;
            btFindMonHoc.Click += btFindMonHoc_Click;
            // 
            // btNewMonHoc
            // 
            btNewMonHoc.BackColor = Color.Azure;
            btNewMonHoc.BackgroundImageLayout = ImageLayout.None;
            btNewMonHoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNewMonHoc.Image = (Image)resources.GetObject("btNewMonHoc.Image");
            btNewMonHoc.ImageAlign = ContentAlignment.MiddleLeft;
            btNewMonHoc.Location = new Point(12, 56);
            btNewMonHoc.Name = "btNewMonHoc";
            btNewMonHoc.Padding = new Padding(10, 0, 0, 0);
            btNewMonHoc.Size = new Size(165, 50);
            btNewMonHoc.TabIndex = 3;
            btNewMonHoc.Text = "Nhập mới";
            btNewMonHoc.UseCompatibleTextRendering = true;
            btNewMonHoc.UseVisualStyleBackColor = false;
            btNewMonHoc.Click += btNewMonHoc_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaMon, TenMon, SoTinChi, SoTietLT, SoTietTH, KhoaID, Edit, Delete });
            dataGridView1.Location = new Point(12, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 89;
            dataGridView1.Size = new Size(1354, 365);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaMon
            // 
            MaMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaMon.DataPropertyName = "MaMon";
            MaMon.HeaderText = "Mã Môn học";
            MaMon.MinimumWidth = 8;
            MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            TenMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenMon.DataPropertyName = "TenMon";
            TenMon.HeaderText = "Tên Môn học";
            TenMon.MinimumWidth = 8;
            TenMon.Name = "TenMon";
            // 
            // SoTinChi
            // 
            SoTinChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoTinChi.DataPropertyName = "SoTinChi";
            SoTinChi.HeaderText = "Số Tín chỉ";
            SoTinChi.MinimumWidth = 8;
            SoTinChi.Name = "SoTinChi";
            // 
            // SoTietLT
            // 
            SoTietLT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoTietLT.DataPropertyName = "SoTietLT";
            SoTietLT.HeaderText = "Số Tiết lý thuyết";
            SoTietLT.MinimumWidth = 8;
            SoTietLT.Name = "SoTietLT";
            // 
            // SoTietTH
            // 
            SoTietTH.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoTietTH.DataPropertyName = "SoTietTH";
            SoTietTH.HeaderText = "Số Tiết thực hành";
            SoTietTH.MinimumWidth = 8;
            SoTietTH.Name = "SoTietTH";
            // 
            // KhoaID
            // 
            KhoaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            KhoaID.DataPropertyName = "KhoaID";
            KhoaID.HeaderText = "Khoa";
            KhoaID.MinimumWidth = 8;
            KhoaID.Name = "KhoaID";
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.DataPropertyName = "Edit";
            Edit.HeaderText = "Sửa";
            Edit.MinimumWidth = 8;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.SortMode = DataGridViewColumnSortMode.Automatic;
            Edit.Text = "Sửa";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 78;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.DataPropertyName = "Delete";
            Delete.HeaderText = "Xóa";
            Delete.MinimumWidth = 8;
            Delete.Name = "Delete";
            Delete.Resizable = DataGridViewTriState.True;
            Delete.SortMode = DataGridViewColumnSortMode.Automatic;
            Delete.Text = "Xoá";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(18, 52, 86);
            label2.Location = new Point(235, 32);
            label2.Name = "label2";
            label2.Size = new Size(376, 48);
            label2.TabIndex = 5;
            label2.Text = "QUẢN LÝ MÔN HỌC";
            // 
            // fQlyMonHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Ivory;
            ClientSize = new Size(1378, 521);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btNewMonHoc);
            Controls.Add(btFindMonHoc);
            Controls.Add(txtSearchMonHoc);
            Controls.Add(label1);
            Name = "fQlyMonHoc";
            Text = "Quản lý Môn Học";
            Activated += fQlyMonHoc_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearchMonHoc;
        private Button btFindMonHoc;
        private Button btNewMonHoc;
        private DataGridView dataGridView1;
        private Label label2;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn SoTinChi;
        private DataGridViewTextBoxColumn SoTietLT;
        private DataGridViewTextBoxColumn SoTietTH;
        private DataGridViewTextBoxColumn KhoaID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}