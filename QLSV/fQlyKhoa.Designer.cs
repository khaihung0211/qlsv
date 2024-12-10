namespace QLSV
{
    partial class fQlyKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlyKhoa));
            txtSearchKhoa = new TextBox();
            btFindKhoa = new Button();
            btNewKhoa = new Button();
            dgvKhoa = new DataGridView();
            label1 = new Label();
            KhoaID = new DataGridViewTextBoxColumn();
            maKhoa = new DataGridViewTextBoxColumn();
            tenKhoa = new DataGridViewTextBoxColumn();
            EditKhoa = new DataGridViewButtonColumn();
            DeleteKhoa = new DataGridViewButtonColumn();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).BeginInit();
            SuspendLayout();
            // 
            // txtSearchKhoa
            // 
            txtSearchKhoa.Location = new Point(925, 88);
            txtSearchKhoa.Name = "txtSearchKhoa";
            txtSearchKhoa.Size = new Size(323, 31);
            txtSearchKhoa.TabIndex = 0;
            txtSearchKhoa.TextChanged += txtSearchKhoa_TextChanged;
            // 
            // btFindKhoa
            // 
            btFindKhoa.Location = new Point(1254, 85);
            btFindKhoa.Name = "btFindKhoa";
            btFindKhoa.Size = new Size(112, 34);
            btFindKhoa.TabIndex = 1;
            btFindKhoa.Text = "Tìm";
            btFindKhoa.UseVisualStyleBackColor = true;
            btFindKhoa.Click += btFindKhoa_Click;
            // 
            // btNewKhoa
            // 
            btNewKhoa.BackColor = Color.Azure;
            btNewKhoa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btNewKhoa.Image = (Image)resources.GetObject("btNewKhoa.Image");
            btNewKhoa.ImageAlign = ContentAlignment.MiddleLeft;
            btNewKhoa.Location = new Point(12, 69);
            btNewKhoa.Name = "btNewKhoa";
            btNewKhoa.Padding = new Padding(10, 0, 0, 0);
            btNewKhoa.Size = new Size(165, 50);
            btNewKhoa.TabIndex = 2;
            btNewKhoa.Text = "Nhập mới";
            btNewKhoa.UseCompatibleTextRendering = true;
            btNewKhoa.UseVisualStyleBackColor = false;
            btNewKhoa.Click += btNewKhoa_Click;
            // 
            // dgvKhoa
            // 
            dgvKhoa.AllowUserToAddRows = false;
            dgvKhoa.AllowUserToDeleteRows = false;
            dgvKhoa.AllowUserToOrderColumns = true;
            dgvKhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoa.Columns.AddRange(new DataGridViewColumn[] { KhoaID, maKhoa, tenKhoa, EditKhoa, DeleteKhoa });
            dgvKhoa.Location = new Point(12, 138);
            dgvKhoa.Name = "dgvKhoa";
            dgvKhoa.RowHeadersWidth = 62;
            dgvKhoa.Size = new Size(1354, 371);
            dgvKhoa.TabIndex = 3;
            dgvKhoa.CellContentClick += dgvKhoa_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(786, 91);
            label1.Name = "label1";
            label1.Size = new Size(133, 25);
            label1.TabIndex = 4;
            label1.Text = "Nhập tên khoa:";
            // 
            // KhoaID
            // 
            KhoaID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            KhoaID.DataPropertyName = "KhoaID";
            KhoaID.HeaderText = "KhoaID";
            KhoaID.MinimumWidth = 8;
            KhoaID.Name = "KhoaID";
            KhoaID.Width = 106;
            // 
            // maKhoa
            // 
            maKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            maKhoa.DataPropertyName = "MaKhoa";
            maKhoa.HeaderText = "Mã Khoa";
            maKhoa.MinimumWidth = 8;
            maKhoa.Name = "maKhoa";
            // 
            // tenKhoa
            // 
            tenKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tenKhoa.DataPropertyName = "tenKhoa";
            tenKhoa.HeaderText = "Tên Khoa";
            tenKhoa.MinimumWidth = 8;
            tenKhoa.Name = "tenKhoa";
            // 
            // EditKhoa
            // 
            EditKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EditKhoa.DataPropertyName = "EditKhoa";
            EditKhoa.HeaderText = "Sửa";
            EditKhoa.MinimumWidth = 8;
            EditKhoa.Name = "EditKhoa";
            EditKhoa.Resizable = DataGridViewTriState.True;
            EditKhoa.SortMode = DataGridViewColumnSortMode.Automatic;
            EditKhoa.Text = "Sửa";
            EditKhoa.UseColumnTextForButtonValue = true;
            EditKhoa.Width = 78;
            // 
            // DeleteKhoa
            // 
            DeleteKhoa.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DeleteKhoa.DataPropertyName = "DeleteKhoa";
            DeleteKhoa.HeaderText = "Xóa";
            DeleteKhoa.MinimumWidth = 8;
            DeleteKhoa.Name = "DeleteKhoa";
            DeleteKhoa.Resizable = DataGridViewTriState.True;
            DeleteKhoa.SortMode = DataGridViewColumnSortMode.Automatic;
            DeleteKhoa.Text = "Xoá";
            DeleteKhoa.UseColumnTextForButtonValue = true;
            DeleteKhoa.Width = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(18, 52, 86);
            label2.Location = new Point(330, 46);
            label2.Name = "label2";
            label2.Size = new Size(302, 48);
            label2.TabIndex = 7;
            label2.Text = "QUẢN LÝ KHOA";
            // 
            // fQlyKhoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1378, 521);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvKhoa);
            Controls.Add(btNewKhoa);
            Controls.Add(btFindKhoa);
            Controls.Add(txtSearchKhoa);
            Name = "fQlyKhoa";
            Text = "Quản lý Khoa";
            Activated += fQlyKhoa_Activated;
            ((System.ComponentModel.ISupportInitialize)dgvKhoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchKhoa;
        private Button btFindKhoa;
        private Button btNewKhoa;
        private DataGridView dgvKhoa;
        private Label label1;
        private DataGridViewTextBoxColumn KhoaID;
        private DataGridViewTextBoxColumn maKhoa;
        private DataGridViewTextBoxColumn tenKhoa;
        private DataGridViewButtonColumn EditKhoa;
        private DataGridViewButtonColumn DeleteKhoa;
        private Label label2;
    }
}