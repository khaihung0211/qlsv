namespace QLSV
{
    partial class fSuaLopTinChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSuaLopTinChi));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btSaveLopTC = new Button();
            btCancelLopTC = new Button();
            txtMaLopTC = new TextBox();
            txtNamHoc = new TextBox();
            txtHocKy = new TextBox();
            cbMaMon = new ComboBox();
            cbMaSoGV = new ComboBox();
            cbMaKhoa = new ComboBox();
            toolTip1 = new ToolTip(components);
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(127, 140);
            label1.Name = "label1";
            label1.Size = new Size(126, 23);
            label1.TabIndex = 0;
            label1.Text = "Mã Lớp Tín Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(127, 221);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 1;
            label2.Text = "Mã Môn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(124, 298);
            label3.Name = "label3";
            label3.Size = new Size(125, 23);
            label3.TabIndex = 2;
            label3.Text = "Tên Giảng Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(506, 140);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 3;
            label4.Text = "Học Kỳ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(506, 221);
            label5.Name = "label5";
            label5.Size = new Size(83, 23);
            label5.TabIndex = 4;
            label5.Text = "Năm Học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(506, 298);
            label6.Name = "label6";
            label6.Size = new Size(79, 23);
            label6.TabIndex = 5;
            label6.Text = "Mã Khoa";
            // 
            // btSaveLopTC
            // 
            btSaveLopTC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveLopTC.Image = (Image)resources.GetObject("btSaveLopTC.Image");
            btSaveLopTC.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveLopTC.Location = new Point(337, 406);
            btSaveLopTC.Name = "btSaveLopTC";
            btSaveLopTC.Padding = new Padding(24, 0, 0, 0);
            btSaveLopTC.Size = new Size(120, 44);
            btSaveLopTC.TabIndex = 6;
            btSaveLopTC.Text = "Lưu";
            btSaveLopTC.UseVisualStyleBackColor = true;
            btSaveLopTC.Click += btSaveLopTC_Click;
            // 
            // btCancelLopTC
            // 
            btCancelLopTC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelLopTC.Image = (Image)resources.GetObject("btCancelLopTC.Image");
            btCancelLopTC.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelLopTC.Location = new Point(490, 406);
            btCancelLopTC.Name = "btCancelLopTC";
            btCancelLopTC.Padding = new Padding(24, 0, 0, 0);
            btCancelLopTC.Size = new Size(120, 44);
            btCancelLopTC.TabIndex = 7;
            btCancelLopTC.Text = "Hủy";
            btCancelLopTC.UseVisualStyleBackColor = true;
            btCancelLopTC.Click += btCancelLopTC_Click;
            // 
            // txtMaLopTC
            // 
            txtMaLopTC.Location = new Point(280, 139);
            txtMaLopTC.Name = "txtMaLopTC";
            txtMaLopTC.Size = new Size(148, 27);
            txtMaLopTC.TabIndex = 8;
            txtMaLopTC.Validating += txtMaLopTC_Validating;
            // 
            // txtNamHoc
            // 
            txtNamHoc.Location = new Point(604, 216);
            txtNamHoc.Name = "txtNamHoc";
            txtNamHoc.Size = new Size(142, 27);
            txtNamHoc.TabIndex = 9;
            txtNamHoc.Validating += txtNamHoc_Validating;
            // 
            // txtHocKy
            // 
            txtHocKy.Location = new Point(604, 139);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(142, 27);
            txtHocKy.TabIndex = 10;
            txtHocKy.Validating += txtHocKy_Validating;
            // 
            // cbMaMon
            // 
            cbMaMon.FormattingEnabled = true;
            cbMaMon.Location = new Point(280, 216);
            cbMaMon.Name = "cbMaMon";
            cbMaMon.Size = new Size(151, 28);
            cbMaMon.TabIndex = 11;
            cbMaMon.Validating += cbMaMon_Validating;
            // 
            // cbMaSoGV
            // 
            cbMaSoGV.FormattingEnabled = true;
            cbMaSoGV.Location = new Point(280, 297);
            cbMaSoGV.Name = "cbMaSoGV";
            cbMaSoGV.Size = new Size(151, 28);
            cbMaSoGV.TabIndex = 12;
            cbMaSoGV.Validating += cbMaSoGV_Validating;
            // 
            // cbMaKhoa
            // 
            cbMaKhoa.FormattingEnabled = true;
            cbMaKhoa.Location = new Point(604, 297);
            cbMaKhoa.Name = "cbMaKhoa";
            cbMaKhoa.Size = new Size(151, 28);
            cbMaKhoa.TabIndex = 13;
            cbMaKhoa.Validating += cbMaKhoa_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(18, 52, 86);
            label7.Location = new Point(250, 23);
            label7.Name = "label7";
            label7.Size = new Size(414, 37);
            label7.TabIndex = 14;
            label7.Text = "SỬA THÔNG TIN LỚP TÍN CHỈ";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(98, 111);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 272);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(238, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 36);
            panel2.TabIndex = 16;
            // 
            // fSuaLopTinChi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(966, 551);
            Controls.Add(label7);
            Controls.Add(cbMaKhoa);
            Controls.Add(cbMaSoGV);
            Controls.Add(cbMaMon);
            Controls.Add(txtHocKy);
            Controls.Add(txtNamHoc);
            Controls.Add(txtMaLopTC);
            Controls.Add(btCancelLopTC);
            Controls.Add(btSaveLopTC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "fSuaLopTinChi";
            Text = "Sửa Lớp tín chỉ";
            FormClosing += fSuaLopTinChi_FormClosing;
            Load += fSuaLopTinChi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btSaveLopTC;
        private Button btCancelLopTC;
        private TextBox txtMaLopTC;
        private TextBox txtNamHoc;
        private TextBox txtHocKy;
        private ComboBox cbMaMon;
        private ComboBox cbMaSoGV;
        private ComboBox cbMaKhoa;
        private ToolTip toolTip1;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
    }
}