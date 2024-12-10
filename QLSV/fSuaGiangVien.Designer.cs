namespace QLSV
{
    partial class fSuaGiangVien
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSuaGiangVien));
            lblTenGV = new Label();
            lblNgaySinh = new Label();
            lblMaKhoa = new Label();
            txtTenGV = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cbMaKhoa = new ComboBox();
            lblEmail = new Label();
            lblHocVi = new Label();
            txtEmail = new TextBox();
            txtHocVi = new TextBox();
            btSaveGiangVien = new Button();
            btCancelGiangVien = new Button();
            toolTip1 = new ToolTip(components);
            ckGioiTinh = new CheckBox();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenGV
            // 
            lblTenGV.AutoSize = true;
            lblTenGV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTenGV.Location = new Point(23, 28);
            lblTenGV.Name = "lblTenGV";
            lblTenGV.Size = new Size(150, 28);
            lblTenGV.TabIndex = 1;
            lblTenGV.Text = "Tên Giảng Viên";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNgaySinh.Location = new Point(48, 94);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(105, 28);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaKhoa.Location = new Point(465, 93);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(58, 28);
            lblMaKhoa.TabIndex = 3;
            lblMaKhoa.Text = "Khoa";
            // 
            // txtTenGV
            // 
            txtTenGV.Location = new Point(179, 28);
            txtTenGV.Name = "txtTenGV";
            txtTenGV.Size = new Size(412, 31);
            txtTenGV.TabIndex = 5;
            txtTenGV.Validating += txtTenGV_Validating;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(179, 91);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(150, 31);
            dtpNgaySinh.TabIndex = 6;
            // 
            // cbMaKhoa
            // 
            cbMaKhoa.FormattingEnabled = true;
            cbMaKhoa.Location = new Point(543, 89);
            cbMaKhoa.Name = "cbMaKhoa";
            cbMaKhoa.Size = new Size(246, 33);
            cbMaKhoa.TabIndex = 7;
            cbMaKhoa.Validating += cbMaKhoa_Validating;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(59, 158);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 28);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // lblHocVi
            // 
            lblHocVi.AutoSize = true;
            lblHocVi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblHocVi.Location = new Point(575, 158);
            lblHocVi.Name = "lblHocVi";
            lblHocVi.Size = new Size(72, 28);
            lblHocVi.TabIndex = 10;
            lblHocVi.Text = "Học Vị";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(177, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(346, 31);
            txtEmail.TabIndex = 11;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtHocVi
            // 
            txtHocVi.Location = new Point(653, 155);
            txtHocVi.Name = "txtHocVi";
            txtHocVi.Size = new Size(136, 31);
            txtHocVi.TabIndex = 12;
            txtHocVi.Validating += txtHocVi_Validating;
            // 
            // btSaveGiangVien
            // 
            btSaveGiangVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveGiangVien.Image = (Image)resources.GetObject("btSaveGiangVien.Image");
            btSaveGiangVien.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveGiangVien.Location = new Point(322, 373);
            btSaveGiangVien.Name = "btSaveGiangVien";
            btSaveGiangVien.Padding = new Padding(30, 0, 0, 0);
            btSaveGiangVien.Size = new Size(150, 55);
            btSaveGiangVien.TabIndex = 16;
            btSaveGiangVien.Text = "Lưu";
            btSaveGiangVien.UseCompatibleTextRendering = true;
            btSaveGiangVien.UseVisualStyleBackColor = true;
            btSaveGiangVien.Click += btSaveGiangVien_Click;
            // 
            // btCancelGiangVien
            // 
            btCancelGiangVien.CausesValidation = false;
            btCancelGiangVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelGiangVien.Image = (Image)resources.GetObject("btCancelGiangVien.Image");
            btCancelGiangVien.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelGiangVien.Location = new Point(488, 373);
            btCancelGiangVien.Name = "btCancelGiangVien";
            btCancelGiangVien.Padding = new Padding(30, 0, 0, 0);
            btCancelGiangVien.Size = new Size(150, 55);
            btCancelGiangVien.TabIndex = 17;
            btCancelGiangVien.Text = "Hủy";
            btCancelGiangVien.UseCompatibleTextRendering = true;
            btCancelGiangVien.UseVisualStyleBackColor = true;
            btCancelGiangVien.Click += btCancelGiangVien_Click;
            // 
            // ckGioiTinh
            // 
            ckGioiTinh.AutoSize = true;
            ckGioiTinh.CheckAlign = ContentAlignment.MiddleRight;
            ckGioiTinh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ckGioiTinh.Location = new Point(637, 28);
            ckGioiTinh.Name = "ckGioiTinh";
            ckGioiTinh.Size = new Size(116, 32);
            ckGioiTinh.TabIndex = 18;
            ckGioiTinh.Text = "Giới tính";
            ckGioiTinh.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTenGV);
            panel1.Controls.Add(ckGioiTinh);
            panel1.Controls.Add(lblNgaySinh);
            panel1.Controls.Add(txtHocVi);
            panel1.Controls.Add(txtTenGV);
            panel1.Controls.Add(lblHocVi);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblMaKhoa);
            panel1.Controls.Add(cbMaKhoa);
            panel1.Controls.Add(dtpNgaySinh);
            panel1.Controls.Add(lblEmail);
            panel1.Location = new Point(65, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 234);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(245, 38);
            label1.Name = "label1";
            label1.Size = new Size(484, 45);
            label1.TabIndex = 20;
            label1.Text = "SỬA THÔNG TIN GIẢNG VIÊN";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(211, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(545, 32);
            panel2.TabIndex = 21;
            // 
            // fSuaGiangVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(938, 450);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btCancelGiangVien);
            Controls.Add(btSaveGiangVien);
            Name = "fSuaGiangVien";
            Text = "fSuaGiangVien";
            FormClosing += fSuaGiangVien_FormClosing;
            Load += fSuaGiangVien_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTenGV;
        private Label lblNgaySinh;
        private Label lblMaKhoa;
        private TextBox txtTenGV;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cbMaKhoa;
        private Label lblEmail;
        private Label lblHocVi;
        private TextBox txtEmail;
        private TextBox txtHocVi;
        private Button btSaveGiangVien;
        private Button btCancelGiangVien;
        private ToolTip toolTip1;
        private CheckBox ckGioiTinh;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
    }
}