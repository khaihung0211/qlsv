namespace QLSV
{
    partial class fSuaLopDanhNghia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSuaLopDanhNghia));
            lblMaLopDN = new Label();
            lblMaSoGV = new Label();
            lblMaKhoa = new Label();
            lblSoLuongSV = new Label();
            lblNamNhapHocCuaSV = new Label();
            btSaveLopDN = new Button();
            btCancelLopDN = new Button();
            txtMaLopDN = new TextBox();
            txtSoLuongSV = new TextBox();
            txtNamNhapHocCuaSV = new TextBox();
            cbMaSoGV = new ComboBox();
            cbMaKhoa = new ComboBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // lblMaLopDN
            // 
            lblMaLopDN.AutoSize = true;
            lblMaLopDN.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaLopDN.Location = new Point(65, 127);
            lblMaLopDN.Name = "lblMaLopDN";
            lblMaLopDN.Size = new Size(165, 23);
            lblMaLopDN.TabIndex = 0;
            lblMaLopDN.Text = "Mã Lớp Danh Nghĩa";
            // 
            // lblMaSoGV
            // 
            lblMaSoGV.AutoSize = true;
            lblMaSoGV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaSoGV.Location = new Point(65, 203);
            lblMaSoGV.Name = "lblMaSoGV";
            lblMaSoGV.Size = new Size(148, 23);
            lblMaSoGV.TabIndex = 1;
            lblMaSoGV.Text = "Mã Số Giảng Viên";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaKhoa.Location = new Point(65, 278);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(79, 23);
            lblMaKhoa.TabIndex = 2;
            lblMaKhoa.Text = "Mã Khoa";
            // 
            // lblSoLuongSV
            // 
            lblSoLuongSV.AutoSize = true;
            lblSoLuongSV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSoLuongSV.Location = new Point(442, 127);
            lblSoLuongSV.Name = "lblSoLuongSV";
            lblSoLuongSV.Size = new Size(160, 23);
            lblSoLuongSV.TabIndex = 3;
            lblSoLuongSV.Text = "Số Lượng Sinh Viên";
            // 
            // lblNamNhapHocCuaSV
            // 
            lblNamNhapHocCuaSV.AutoSize = true;
            lblNamNhapHocCuaSV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNamNhapHocCuaSV.Location = new Point(442, 203);
            lblNamNhapHocCuaSV.Name = "lblNamNhapHocCuaSV";
            lblNamNhapHocCuaSV.Size = new Size(130, 23);
            lblNamNhapHocCuaSV.TabIndex = 4;
            lblNamNhapHocCuaSV.Text = "Năm Nhập Học";
            // 
            // btSaveLopDN
            // 
            btSaveLopDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveLopDN.Image = (Image)resources.GetObject("btSaveLopDN.Image");
            btSaveLopDN.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveLopDN.Location = new Point(281, 373);
            btSaveLopDN.Margin = new Padding(2);
            btSaveLopDN.Name = "btSaveLopDN";
            btSaveLopDN.Padding = new Padding(24, 0, 0, 0);
            btSaveLopDN.Size = new Size(120, 44);
            btSaveLopDN.TabIndex = 5;
            btSaveLopDN.Text = "Lưu";
            btSaveLopDN.UseVisualStyleBackColor = true;
            btSaveLopDN.Click += btSaveLopDN_Click;
            // 
            // btCancelLopDN
            // 
            btCancelLopDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelLopDN.Image = (Image)resources.GetObject("btCancelLopDN.Image");
            btCancelLopDN.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelLopDN.Location = new Point(415, 373);
            btCancelLopDN.Margin = new Padding(2);
            btCancelLopDN.Name = "btCancelLopDN";
            btCancelLopDN.Padding = new Padding(24, 0, 0, 0);
            btCancelLopDN.Size = new Size(120, 44);
            btCancelLopDN.TabIndex = 6;
            btCancelLopDN.Text = "Hủy";
            btCancelLopDN.UseVisualStyleBackColor = true;
            btCancelLopDN.Click += btCancelLopDN_Click;
            // 
            // txtMaLopDN
            // 
            txtMaLopDN.Location = new Point(236, 123);
            txtMaLopDN.Name = "txtMaLopDN";
            txtMaLopDN.Size = new Size(151, 27);
            txtMaLopDN.TabIndex = 7;
            txtMaLopDN.Validating += txtMaLopDN_Validating;
            // 
            // txtSoLuongSV
            // 
            txtSoLuongSV.Location = new Point(608, 123);
            txtSoLuongSV.Name = "txtSoLuongSV";
            txtSoLuongSV.Size = new Size(125, 27);
            txtSoLuongSV.TabIndex = 8;
            txtSoLuongSV.Validating += txtSoLuongSV_Validating;
            // 
            // txtNamNhapHocCuaSV
            // 
            txtNamNhapHocCuaSV.Location = new Point(608, 202);
            txtNamNhapHocCuaSV.Name = "txtNamNhapHocCuaSV";
            txtNamNhapHocCuaSV.Size = new Size(125, 27);
            txtNamNhapHocCuaSV.TabIndex = 9;
            txtNamNhapHocCuaSV.Validating += txtNamNhapHocCuaSV_Validating;
            // 
            // cbMaSoGV
            // 
            cbMaSoGV.FormattingEnabled = true;
            cbMaSoGV.Location = new Point(236, 198);
            cbMaSoGV.Name = "cbMaSoGV";
            cbMaSoGV.Size = new Size(151, 28);
            cbMaSoGV.TabIndex = 10;
            cbMaSoGV.Validating += cbMaSoGV_Validating;
            // 
            // cbMaKhoa
            // 
            cbMaKhoa.FormattingEnabled = true;
            cbMaKhoa.Location = new Point(236, 277);
            cbMaKhoa.Name = "cbMaKhoa";
            cbMaKhoa.Size = new Size(151, 28);
            cbMaKhoa.TabIndex = 11;
            cbMaKhoa.Validating += cbMaKhoa_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(144, 29);
            label1.Name = "label1";
            label1.Size = new Size(496, 37);
            label1.TabIndex = 12;
            label1.Text = "SỬA THÔNG TIN LỚP DANH NGHĨA";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(128, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 33);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(42, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(710, 255);
            panel2.TabIndex = 14;
            // 
            // fSuaLopDanhNghia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cbMaKhoa);
            Controls.Add(cbMaSoGV);
            Controls.Add(txtNamNhapHocCuaSV);
            Controls.Add(txtSoLuongSV);
            Controls.Add(txtMaLopDN);
            Controls.Add(btCancelLopDN);
            Controls.Add(btSaveLopDN);
            Controls.Add(lblNamNhapHocCuaSV);
            Controls.Add(lblSoLuongSV);
            Controls.Add(lblMaKhoa);
            Controls.Add(lblMaSoGV);
            Controls.Add(lblMaLopDN);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fSuaLopDanhNghia";
            Text = "Sửa Lớp Danh Nghĩa";
            FormClosing += fSuaGiangVien_FormClosing;
            Load += fSuaLopDanhNghia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaLopDN;
        private Label lblMaSoGV;
        private Label lblMaKhoa;
        private Label lblSoLuongSV;
        private Label lblNamNhapHocCuaSV;
        private Button btSaveLopDN;
        private Button btCancelLopDN;
        private TextBox txtMaLopDN;
        private TextBox txtSoLuongSV;
        private TextBox txtNamNhapHocCuaSV;
        private ComboBox cbMaSoGV;
        private ComboBox cbMaKhoa;
        private ToolTip toolTip1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}