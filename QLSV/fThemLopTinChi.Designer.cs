namespace QLSV
{
    partial class fThemLopTinChi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemLopTinChi));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMaLopTC = new TextBox();
            txtHocKy = new TextBox();
            txtNamHoc = new TextBox();
            cbMaMon = new ComboBox();
            cbMaSoGV = new ComboBox();
            cbMaKhoa = new ComboBox();
            btSaveLopTC = new Button();
            btCancelLopTC = new Button();
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
            label1.Location = new Point(184, 226);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 28);
            label1.TabIndex = 0;
            label1.Text = "Mã Lớp Tín Chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(184, 322);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã Môn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(184, 425);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(175, 28);
            label3.TabIndex = 2;
            label3.Text = "Mã Số Giảng Viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(630, 226);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 28);
            label4.TabIndex = 3;
            label4.Text = "Học Kỳ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label5.Location = new Point(625, 322);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(97, 28);
            label5.TabIndex = 4;
            label5.Text = "Năm Học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label6.Location = new Point(630, 425);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 5;
            label6.Text = "Mã Khoa";
            // 
            // txtMaLopTC
            // 
            txtMaLopTC.Location = new Point(371, 222);
            txtMaLopTC.Margin = new Padding(4, 4, 4, 4);
            txtMaLopTC.Name = "txtMaLopTC";
            txtMaLopTC.Size = new Size(188, 31);
            txtMaLopTC.TabIndex = 6;
            txtMaLopTC.Validating += txtMaLopTC_Validating;
            // 
            // txtHocKy
            // 
            txtHocKy.Location = new Point(744, 222);
            txtHocKy.Margin = new Padding(4, 4, 4, 4);
            txtHocKy.Name = "txtHocKy";
            txtHocKy.Size = new Size(188, 31);
            txtHocKy.TabIndex = 7;
            txtHocKy.Validating += txtHocKy_Validating;
            // 
            // txtNamHoc
            // 
            txtNamHoc.Location = new Point(744, 321);
            txtNamHoc.Margin = new Padding(4, 4, 4, 4);
            txtNamHoc.Name = "txtNamHoc";
            txtNamHoc.Size = new Size(188, 31);
            txtNamHoc.TabIndex = 8;
            txtNamHoc.Validating += txtNamHoc_Validating;
            // 
            // cbMaMon
            // 
            cbMaMon.FormattingEnabled = true;
            cbMaMon.Location = new Point(371, 321);
            cbMaMon.Margin = new Padding(4, 4, 4, 4);
            cbMaMon.Name = "cbMaMon";
            cbMaMon.Size = new Size(188, 33);
            cbMaMon.TabIndex = 9;
            cbMaMon.Validating += cbMaMon_Validating;
            // 
            // cbMaSoGV
            // 
            cbMaSoGV.FormattingEnabled = true;
            cbMaSoGV.Location = new Point(371, 421);
            cbMaSoGV.Margin = new Padding(4, 4, 4, 4);
            cbMaSoGV.Name = "cbMaSoGV";
            cbMaSoGV.Size = new Size(188, 33);
            cbMaSoGV.TabIndex = 10;
            cbMaSoGV.Validating += cbMaSoGV_Validating;
            // 
            // cbMaKhoa
            // 
            cbMaKhoa.FormattingEnabled = true;
            cbMaKhoa.Location = new Point(744, 421);
            cbMaKhoa.Margin = new Padding(4, 4, 4, 4);
            cbMaKhoa.Name = "cbMaKhoa";
            cbMaKhoa.Size = new Size(188, 33);
            cbMaKhoa.TabIndex = 11;
            cbMaKhoa.Validating += cbMaKhoa_Validating;
            // 
            // btSaveLopTC
            // 
            btSaveLopTC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveLopTC.Image = (Image)resources.GetObject("btSaveLopTC.Image");
            btSaveLopTC.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveLopTC.Location = new Point(428, 551);
            btSaveLopTC.Margin = new Padding(2);
            btSaveLopTC.Name = "btSaveLopTC";
            btSaveLopTC.Padding = new Padding(30, 0, 0, 0);
            btSaveLopTC.Size = new Size(150, 55);
            btSaveLopTC.TabIndex = 12;
            btSaveLopTC.Text = "Lưu";
            btSaveLopTC.UseVisualStyleBackColor = true;
            btSaveLopTC.Click += btSaveLopTC_Click;
            // 
            // btCancelLopTC
            // 
            btCancelLopTC.CausesValidation = false;
            btCancelLopTC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelLopTC.Image = (Image)resources.GetObject("btCancelLopTC.Image");
            btCancelLopTC.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelLopTC.Location = new Point(612, 551);
            btCancelLopTC.Margin = new Padding(2);
            btCancelLopTC.Name = "btCancelLopTC";
            btCancelLopTC.Padding = new Padding(30, 0, 0, 0);
            btCancelLopTC.Size = new Size(150, 55);
            btCancelLopTC.TabIndex = 13;
            btCancelLopTC.Text = "Hủy";
            btCancelLopTC.UseVisualStyleBackColor = true;
            btCancelLopTC.Click += btCancelLopTC_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(18, 52, 86);
            label7.Location = new Point(405, 40);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(320, 45);
            label7.TabIndex = 14;
            label7.Text = "THÊM LỚP TÍN CHỈ";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(158, 165);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 347);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(371, 60);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 48);
            panel2.TabIndex = 16;
            // 
            // fThemLopTinChi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1301, 715);
            Controls.Add(label7);
            Controls.Add(btCancelLopTC);
            Controls.Add(btSaveLopTC);
            Controls.Add(cbMaKhoa);
            Controls.Add(cbMaSoGV);
            Controls.Add(cbMaMon);
            Controls.Add(txtNamHoc);
            Controls.Add(txtHocKy);
            Controls.Add(txtMaLopTC);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "fThemLopTinChi";
            Text = "Thêm Lớp tín chỉ";
            FormClosing += fThemLopTinChi_FormClosing;
            Load += fThemLopTinChi_Load;
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
        private TextBox txtMaLopTC;
        private TextBox txtHocKy;
        private TextBox txtNamHoc;
        private ComboBox cbMaMon;
        private ComboBox cbMaSoGV;
        private ComboBox cbMaKhoa;
        private Button btSaveLopTC;
        private Button btCancelLopTC;
        private ToolTip toolTip1;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
    }
}