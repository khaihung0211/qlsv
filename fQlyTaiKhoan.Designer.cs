namespace QLSV
{
    partial class fQlyTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQlyTaiKhoan));
            dataGridView1 = new DataGridView();
            TaiKhoanID = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            //MatKhau = new DataGridViewTextBoxColumn();
            RoleID = new DataGridViewTextBoxColumn();
            TinhTrang = new DataGridViewCheckBoxColumn();
            btEditTaiKhoan = new DataGridViewButtonColumn();
            btDeleteTaiKhoan = new DataGridViewButtonColumn();
            btNewTaiKhoan = new Button();
            btFindTaiKhoan = new Button();
            txtEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { TaiKhoanID, Email,  RoleID, TinhTrang, btEditTaiKhoan, btDeleteTaiKhoan });
            dataGridView1.Location = new Point(45, 140);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(780, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TaiKhoanID
            // 
            TaiKhoanID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TaiKhoanID.DataPropertyName = "TaiKhoanID";
            TaiKhoanID.HeaderText = "ID";
            TaiKhoanID.MinimumWidth = 6;
            TaiKhoanID.Name = "TaiKhoanID";
            TaiKhoanID.Width = 43;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            // 
            // MatKhau
            // 
            //MatKhau.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //MatKhau.DataPropertyName = "MatKhau";
            //MatKhau.HeaderText = "Mật khẩu";
            //MatKhau.MinimumWidth = 6;
            //MatKhau.Name = "MatKhau";
            // 
            // RoleID
            // 
            RoleID.DataPropertyName = "RoleID";
            RoleID.HeaderText = "Vai trò";
            RoleID.MinimumWidth = 6;
            RoleID.Name = "RoleID";
            RoleID.Width = 125;
            // 
            // TinhTrang
            // 
            TinhTrang.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            TinhTrang.DataPropertyName = "TinhTrang";
            TinhTrang.HeaderText = "Tình trạng";
            TinhTrang.MinimumWidth = 6;
            TinhTrang.Name = "TinhTrang";
            TinhTrang.Width = 67;
            // 
            // btEditTaiKhoan
            // 
            btEditTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btEditTaiKhoan.HeaderText = "Sửa";
            btEditTaiKhoan.MinimumWidth = 6;
            btEditTaiKhoan.Name = "btEditTaiKhoan";
            btEditTaiKhoan.Text = "Sửa";
            btEditTaiKhoan.UseColumnTextForButtonValue = true;
            btEditTaiKhoan.Width = 32;
            // 
            // btDeleteTaiKhoan
            // 
            btDeleteTaiKhoan.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            btDeleteTaiKhoan.HeaderText = "Xóa";
            btDeleteTaiKhoan.MinimumWidth = 6;
            btDeleteTaiKhoan.Name = "btDeleteTaiKhoan";
            btDeleteTaiKhoan.Text = "Xoá";
            btDeleteTaiKhoan.UseColumnTextForButtonValue = true;
            btDeleteTaiKhoan.Width = 33;
            // 
            // btNewTaiKhoan
            // 
            btNewTaiKhoan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btNewTaiKhoan.Image = (Image)resources.GetObject("btNewTaiKhoan.Image");
            btNewTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btNewTaiKhoan.Location = new Point(45, 83);
            btNewTaiKhoan.Margin = new Padding(1, 1, 1, 1);
            btNewTaiKhoan.Name = "btNewTaiKhoan";
            btNewTaiKhoan.Size = new Size(116, 30);
            btNewTaiKhoan.TabIndex = 1;
            btNewTaiKhoan.Text = "Nhập mới";
            btNewTaiKhoan.UseVisualStyleBackColor = true;
            btNewTaiKhoan.Click += btNewTaiKhoan_Click;
            // 
            // btFindTaiKhoan
            // 
            btFindTaiKhoan.Location = new Point(696, 89);
            btFindTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            btFindTaiKhoan.Name = "btFindTaiKhoan";
            btFindTaiKhoan.Size = new Size(83, 24);
            btFindTaiKhoan.TabIndex = 2;
            btFindTaiKhoan.Text = "Tìm";
            btFindTaiKhoan.UseVisualStyleBackColor = true;
            btFindTaiKhoan.Click += btFindTaiKhoan_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(473, 89);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(210, 23);
            txtEmail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 90);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 4;
            label1.Text = "Nhập Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(18, 52, 86);
            label2.Location = new Point(256, 17);
            label2.Name = "label2";
            label2.Size = new Size(269, 32);
            label2.TabIndex = 5;
            label2.Text = "QUẢN LÝ TÀI KHOẢN";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(248, 29);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 27);
            panel1.TabIndex = 6;
            // 
            // fQlyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(888, 337);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(btFindTaiKhoan);
            Controls.Add(btNewTaiKhoan);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fQlyTaiKhoan";
            Text = "Tài Khoản";
            Activated += fQlyTaiKhoan_Activated;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btNewTaiKhoan;
        private Button btFindTaiKhoan;
        private TextBox txtEmail;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private DataGridViewTextBoxColumn TaiKhoanID;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn MatKhau;
        private DataGridViewTextBoxColumn RoleID;
        private DataGridViewCheckBoxColumn TinhTrang;
        private DataGridViewButtonColumn btEditTaiKhoan;
        private DataGridViewButtonColumn btDeleteTaiKhoan;
    }
}