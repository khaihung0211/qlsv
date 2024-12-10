namespace QLSV
{
    partial class fThemLopDanhNghia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemLopDanhNghia));
            lblMaLopDN = new Label();
            lblMaSoGV = new Label();
            lblMaKhoa = new Label();
            lblSoLuongSV = new Label();
            lblNamNhapHocCuaSV = new Label();
            txtSoLuongSV = new TextBox();
            txtNamNhapHocCuaSV = new TextBox();
            txtMaLopDN = new TextBox();
            cbMaSoGV = new ComboBox();
            cbMaKhoa = new ComboBox();
            btSaveLopDN = new Button();
            btCancelLopDN = new Button();
            toolTip1 = new ToolTip(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblMaLopDN
            // 
            lblMaLopDN.AutoSize = true;
            lblMaLopDN.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaLopDN.Location = new Point(50, 124);
            lblMaLopDN.Name = "lblMaLopDN";
            lblMaLopDN.Size = new Size(165, 23);
            lblMaLopDN.TabIndex = 0;
            lblMaLopDN.Text = "Mã Lớp Danh Nghĩa";
            // 
            // lblMaSoGV
            // 
            lblMaSoGV.AutoSize = true;
            lblMaSoGV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaSoGV.Location = new Point(50, 193);
            lblMaSoGV.Name = "lblMaSoGV";
            lblMaSoGV.Size = new Size(148, 23);
            lblMaSoGV.TabIndex = 1;
            lblMaSoGV.Text = "Mã Số Giảng Viên";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaKhoa.Location = new Point(50, 260);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(79, 23);
            lblMaKhoa.TabIndex = 2;
            lblMaKhoa.Text = "Mã Khoa";
            // 
            // lblSoLuongSV
            // 
            lblSoLuongSV.AutoSize = true;
            lblSoLuongSV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSoLuongSV.Location = new Point(413, 121);
            lblSoLuongSV.Name = "lblSoLuongSV";
            lblSoLuongSV.Size = new Size(160, 23);
            lblSoLuongSV.TabIndex = 3;
            lblSoLuongSV.Text = "Số Lượng Sinh Viên";
            // 
            // lblNamNhapHocCuaSV
            // 
            lblNamNhapHocCuaSV.AutoSize = true;
            lblNamNhapHocCuaSV.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblNamNhapHocCuaSV.Location = new Point(413, 193);
            lblNamNhapHocCuaSV.Name = "lblNamNhapHocCuaSV";
            lblNamNhapHocCuaSV.Size = new Size(130, 23);
            lblNamNhapHocCuaSV.TabIndex = 4;
            lblNamNhapHocCuaSV.Text = "Năm Nhập Học";
            // 
            // txtSoLuongSV
            // 
            txtSoLuongSV.Location = new Point(581, 121);
            txtSoLuongSV.Name = "txtSoLuongSV";
            txtSoLuongSV.Size = new Size(125, 27);
            txtSoLuongSV.TabIndex = 4;
            txtSoLuongSV.Validating += txtSoLuongSV_Validating;
            // 
            // txtNamNhapHocCuaSV
            // 
            txtNamNhapHocCuaSV.Location = new Point(585, 190);
            txtNamNhapHocCuaSV.Name = "txtNamNhapHocCuaSV";
            txtNamNhapHocCuaSV.Size = new Size(125, 27);
            txtNamNhapHocCuaSV.TabIndex = 5;
            txtNamNhapHocCuaSV.Validating += txtNamNhapHocCuaSV_Validating;
            // 
            // txtMaLopDN
            // 
            txtMaLopDN.Location = new Point(221, 120);
            txtMaLopDN.Name = "txtMaLopDN";
            txtMaLopDN.Size = new Size(151, 27);
            txtMaLopDN.TabIndex = 1;
            txtMaLopDN.Validating += txtMaLopDN_Validating;
            // 
            // cbMaSoGV
            // 
            cbMaSoGV.FormattingEnabled = true;
            cbMaSoGV.Location = new Point(221, 188);
            cbMaSoGV.Name = "cbMaSoGV";
            cbMaSoGV.Size = new Size(151, 28);
            cbMaSoGV.TabIndex = 2;
            cbMaSoGV.Validating += cbMaSoGV_Validating;
            // 
            // cbMaKhoa
            // 
            cbMaKhoa.FormattingEnabled = true;
            cbMaKhoa.Location = new Point(221, 259);
            cbMaKhoa.Name = "cbMaKhoa";
            cbMaKhoa.Size = new Size(151, 28);
            cbMaKhoa.TabIndex = 3;
            cbMaKhoa.Validating += cbMaKhoa_Validating;
            // 
            // btSaveLopDN
            // 
            btSaveLopDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveLopDN.Image = (Image)resources.GetObject("btSaveLopDN.Image");
            btSaveLopDN.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveLopDN.Location = new Point(262, 351);
            btSaveLopDN.Margin = new Padding(2);
            btSaveLopDN.Name = "btSaveLopDN";
            btSaveLopDN.Padding = new Padding(24, 0, 0, 0);
            btSaveLopDN.Size = new Size(120, 44);
            btSaveLopDN.TabIndex = 6;
            btSaveLopDN.Text = "Lưu";
            btSaveLopDN.UseVisualStyleBackColor = true;
            btSaveLopDN.Click += btSaveLopDN_Click;
            // 
            // btCancelLopDN
            // 
            btCancelLopDN.CausesValidation = false;
            btCancelLopDN.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelLopDN.Image = (Image)resources.GetObject("btCancelLopDN.Image");
            btCancelLopDN.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelLopDN.Location = new Point(395, 351);
            btCancelLopDN.Margin = new Padding(2);
            btCancelLopDN.Name = "btCancelLopDN";
            btCancelLopDN.Padding = new Padding(24, 0, 0, 0);
            btCancelLopDN.Size = new Size(120, 44);
            btCancelLopDN.TabIndex = 7;
            btCancelLopDN.Text = "Hủy";
            btCancelLopDN.UseVisualStyleBackColor = true;
            btCancelLopDN.Click += btCancelLopDN_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Location = new Point(38, 109);
            flowLayoutPanel1.Margin = new Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(691, 215);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(172, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(419, 37);
            label1.TabIndex = 9;
            label1.Text = "THÊM MỚI LỚP DANH NGHĨA";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(160, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(433, 30);
            panel1.TabIndex = 10;
            // 
            // fThemLopDanhNghia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(cbMaKhoa);
            Controls.Add(label1);
            Controls.Add(lblSoLuongSV);
            Controls.Add(lblMaKhoa);
            Controls.Add(btCancelLopDN);
            Controls.Add(btSaveLopDN);
            Controls.Add(cbMaSoGV);
            Controls.Add(txtMaLopDN);
            Controls.Add(txtNamNhapHocCuaSV);
            Controls.Add(txtSoLuongSV);
            Controls.Add(lblNamNhapHocCuaSV);
            Controls.Add(lblMaSoGV);
            Controls.Add(lblMaLopDN);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "fThemLopDanhNghia";
            Text = "Thêm lớp danh nghĩa";
            FormClosing += fThemLopDanhNghia_FormClosing;
            Load += fThemLopDanhNghia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaLopDN;
        private Label lblMaSoGV;
        private Label lblMaKhoa;
        private Label lblSoLuongSV;
        private Label lblNamNhapHocCuaSV;
        private TextBox txtSoLuongSV;
        private TextBox txtNamNhapHocCuaSV;
        private TextBox txtMaLopDN;
        private ComboBox cbMaSoGV;
        private ComboBox cbMaKhoa;
        private Button btSaveLopDN;
        private Button btCancelLopDN;
        private ToolTip toolTip1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private Panel panel1;
    }
}