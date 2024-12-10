namespace QLSV
{
    partial class fSuaMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSuaMonHoc));
            lblTenMon = new Label();
            lblSoTinChi = new Label();
            lblSoTietLT = new Label();
            lblSoTietTH = new Label();
            lblMaKhoa = new Label();
            txtTenMon = new TextBox();
            txtSoTinChi = new TextBox();
            txtSoTietLT = new TextBox();
            txtSoTietTH = new TextBox();
            cbMaKhoa = new ComboBox();
            btSaveMonHoc = new Button();
            btCancelMonHoc = new Button();
            label1 = new Label();
            panel1 = new Panel();
            toolTip1 = new ToolTip(components);
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTenMon
            // 
            lblTenMon.AutoSize = true;
            lblTenMon.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTenMon.Location = new Point(32, 34);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Size = new Size(92, 28);
            lblTenMon.TabIndex = 1;
            lblTenMon.Text = "Tên Môn";
            // 
            // lblSoTinChi
            // 
            lblSoTinChi.AutoSize = true;
            lblSoTinChi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSoTinChi.Location = new Point(32, 91);
            lblSoTinChi.Name = "lblSoTinChi";
            lblSoTinChi.Size = new Size(97, 28);
            lblSoTinChi.TabIndex = 2;
            lblSoTinChi.Text = "Số tín chỉ";
            // 
            // lblSoTietLT
            // 
            lblSoTietLT.AutoSize = true;
            lblSoTietLT.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSoTietLT.Location = new Point(475, 31);
            lblSoTietLT.Name = "lblSoTietLT";
            lblSoTietLT.Size = new Size(157, 28);
            lblSoTietLT.TabIndex = 3;
            lblSoTietLT.Text = "Số tiết lý thuyết";
            // 
            // lblSoTietTH
            // 
            lblSoTietTH.AutoSize = true;
            lblSoTietTH.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblSoTietTH.Location = new Point(476, 91);
            lblSoTietTH.Name = "lblSoTietTH";
            lblSoTietTH.Size = new Size(169, 28);
            lblSoTietTH.TabIndex = 4;
            lblSoTietTH.Text = "Số tiết thực hành";
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaKhoa.Location = new Point(57, 148);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(58, 28);
            lblMaKhoa.TabIndex = 5;
            lblMaKhoa.Text = "Khoa";
            // 
            // txtTenMon
            // 
            txtTenMon.Location = new Point(135, 31);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(286, 31);
            txtTenMon.TabIndex = 7;
            txtTenMon.Validating += txtTenMon_Validating;
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(135, 88);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(100, 31);
            txtSoTinChi.TabIndex = 8;
            txtSoTinChi.Validating += txtSoTinChi_Validating;
            // 
            // txtSoTietLT
            // 
            txtSoTietLT.Location = new Point(651, 31);
            txtSoTietLT.Name = "txtSoTietLT";
            txtSoTietLT.Size = new Size(150, 31);
            txtSoTietLT.TabIndex = 9;
            txtSoTietLT.Validating += txtSoTietLT_Validating;
            // 
            // txtSoTietTH
            // 
            txtSoTietTH.Location = new Point(651, 91);
            txtSoTietTH.Name = "txtSoTietTH";
            txtSoTietTH.Size = new Size(150, 31);
            txtSoTietTH.TabIndex = 10;
            txtSoTietTH.Validating += txtSoTietTH_Validating;
            // 
            // cbMaKhoa
            // 
            cbMaKhoa.FormattingEnabled = true;
            cbMaKhoa.Location = new Point(135, 143);
            cbMaKhoa.Name = "cbMaKhoa";
            cbMaKhoa.Size = new Size(286, 33);
            cbMaKhoa.TabIndex = 11;
            cbMaKhoa.Validating += cbMaKhoa_Validating;
            // 
            // btSaveMonHoc
            // 
            btSaveMonHoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSaveMonHoc.Image = (Image)resources.GetObject("btSaveMonHoc.Image");
            btSaveMonHoc.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveMonHoc.Location = new Point(564, 367);
            btSaveMonHoc.Name = "btSaveMonHoc";
            btSaveMonHoc.Padding = new Padding(30, 0, 0, 0);
            btSaveMonHoc.Size = new Size(150, 55);
            btSaveMonHoc.TabIndex = 12;
            btSaveMonHoc.Text = "Lưu";
            btSaveMonHoc.UseCompatibleTextRendering = true;
            btSaveMonHoc.UseVisualStyleBackColor = true;
            btSaveMonHoc.UseWaitCursor = true;
            btSaveMonHoc.Click += btSaveMonHoc_Click;
            // 
            // btCancelMonHoc
            // 
            btCancelMonHoc.CausesValidation = false;
            btCancelMonHoc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelMonHoc.Image = (Image)resources.GetObject("btCancelMonHoc.Image");
            btCancelMonHoc.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelMonHoc.Location = new Point(731, 367);
            btCancelMonHoc.Name = "btCancelMonHoc";
            btCancelMonHoc.Padding = new Padding(30, 0, 0, 0);
            btCancelMonHoc.Size = new Size(150, 55);
            btCancelMonHoc.TabIndex = 13;
            btCancelMonHoc.Text = "Hủy";
            btCancelMonHoc.UseVisualStyleBackColor = true;
            btCancelMonHoc.Click += btCancelMonHoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(241, 24);
            label1.Name = "label1";
            label1.Size = new Size(452, 45);
            label1.TabIndex = 14;
            label1.Text = "SỬA THÔNG TIN MÔN HỌC";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(213, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(503, 32);
            panel1.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtTenMon);
            panel2.Controls.Add(lblTenMon);
            panel2.Controls.Add(txtSoTinChi);
            panel2.Controls.Add(lblSoTinChi);
            panel2.Controls.Add(cbMaKhoa);
            panel2.Controls.Add(txtSoTietTH);
            panel2.Controls.Add(lblMaKhoa);
            panel2.Controls.Add(txtSoTietLT);
            panel2.Controls.Add(lblSoTietLT);
            panel2.Controls.Add(lblSoTietTH);
            panel2.Location = new Point(38, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 231);
            panel2.TabIndex = 16;
            // 
            // fSuaMonHoc
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(928, 474);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btCancelMonHoc);
            Controls.Add(btSaveMonHoc);
            Name = "fSuaMonHoc";
            Text = "Sửa Môn học";
            FormClosing += fSuaMonHoc_FormClosing;
            Load += fSuaMonHoc_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTenMon;
        private Label lblSoTinChi;
        private Label lblSoTietLT;
        private Label lblSoTietTH;
        private Label lblMaKhoa;
        private TextBox txtTenMon;
        private TextBox txtSoTinChi;
        private TextBox txtSoTietLT;
        private TextBox txtSoTietTH;
        private ComboBox cbMaKhoa;
        private Button btSaveMonHoc;
        private Button btCancelMonHoc;
        private Label label1;
        private Panel panel1;
        private ToolTip toolTip1;
        private Panel panel2;
    }
}