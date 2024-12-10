namespace QLSV
{
    partial class fSuaTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSuaTaiKhoan));
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            txtVaiTro = new TextBox();
            btSaveTaiKhoan = new Button();
            btCancelTaiKhoan = new Button();
            ckTinhTrang = new CheckBox();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            panel1 = new Panel();
            doiMatKhau = new Button();
            comboVaiTro = new ComboBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(105, 121);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(105, 170);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(362, 121);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 3;
            label4.Text = "Vai Trò";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(185, 120);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(133, 23);
            txtEmail.TabIndex = 7;
            //txtEmail.Validating += txtEmail_Validating;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Enabled = false;
            txtMatKhau.Location = new Point(185, 166);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(133, 23);
            txtMatKhau.TabIndex = 8;
            //txtMatKhau.Validating += txtMatKhau_Validating;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(423, 118);
            txtVaiTro.Margin = new Padding(3, 2, 3, 2);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(38, 23);
            txtVaiTro.TabIndex = 9;
            //txtVaiTro.Validating += txtVaiTro_Validating;
            // 
            // btSaveTaiKhoan
            // 
            btSaveTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveTaiKhoan.Image = (Image)resources.GetObject("btSaveTaiKhoan.Image");
            btSaveTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveTaiKhoan.Location = new Point(198, 254);
            btSaveTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            btSaveTaiKhoan.Name = "btSaveTaiKhoan";
            btSaveTaiKhoan.Padding = new Padding(21, 0, 0, 0);
            btSaveTaiKhoan.Size = new Size(105, 33);
            btSaveTaiKhoan.TabIndex = 10;
            btSaveTaiKhoan.Text = "Lưu";
            btSaveTaiKhoan.UseVisualStyleBackColor = true;
            btSaveTaiKhoan.Click += btSaveTaiKhoan_Click;
            // 
            // btCancelTaiKhoan
            // 
            btCancelTaiKhoan.CausesValidation = false;
            btCancelTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelTaiKhoan.Image = (Image)resources.GetObject("btCancelTaiKhoan.Image");
            btCancelTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelTaiKhoan.Location = new Point(312, 254);
            btCancelTaiKhoan.Margin = new Padding(3, 2, 3, 2);
            btCancelTaiKhoan.Name = "btCancelTaiKhoan";
            btCancelTaiKhoan.Padding = new Padding(21, 0, 0, 0);
            btCancelTaiKhoan.Size = new Size(105, 33);
            btCancelTaiKhoan.TabIndex = 11;
            btCancelTaiKhoan.Text = "Hủy";
            btCancelTaiKhoan.UseVisualStyleBackColor = true;
            btCancelTaiKhoan.Click += btCancelTaiKhoan_Click;
            // 
            // ckTinhTrang
            // 
            ckTinhTrang.AutoSize = true;
            ckTinhTrang.Checked = true;
            ckTinhTrang.CheckState = CheckState.Checked;
            ckTinhTrang.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ckTinhTrang.Location = new Point(362, 169);
            ckTinhTrang.Margin = new Padding(2);
            ckTinhTrang.Name = "ckTinhTrang";
            ckTinhTrang.RightToLeft = RightToLeft.Yes;
            ckTinhTrang.Size = new Size(93, 23);
            ckTinhTrang.TabIndex = 12;
            ckTinhTrang.Text = "Tình trạng";
            ckTinhTrang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(18, 52, 86);
            label3.Location = new Point(206, 18);
            label3.Name = "label3";
            label3.Size = new Size(197, 30);
            label3.TabIndex = 13;
            label3.Text = "SỬA TÀI KHOẢN";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(doiMatKhau);
            panel1.Controls.Add(comboVaiTro);
            panel1.Location = new Point(69, 83);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 147);
            panel1.TabIndex = 14;
            // 
            // doiMatKhau
            // 
            doiMatKhau.Location = new Point(115, 110);
            doiMatKhau.Name = "doiMatKhau";
            doiMatKhau.Size = new Size(133, 23);
            doiMatKhau.TabIndex = 16;
            doiMatKhau.Text = "Đổi mật khẩu";
            doiMatKhau.UseVisualStyleBackColor = true;
            doiMatKhau.Click += doiMatKhau_Click;
            // 
            // comboVaiTro
            // 
            comboVaiTro.FormattingEnabled = true;
            comboVaiTro.Location = new Point(350, 36);
            comboVaiTro.Name = "comboVaiTro";
            comboVaiTro.Size = new Size(89, 23);
            comboVaiTro.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(198, 32);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 24);
            panel2.TabIndex = 15;
            // 
            // fSuaTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(638, 338);
            Controls.Add(label3);
            Controls.Add(ckTinhTrang);
            Controls.Add(btCancelTaiKhoan);
            Controls.Add(btSaveTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(txtVaiTro);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fSuaTaiKhoan";
            Text = "Sửa tài khoản";
            FormClosing += fSuaTaiKhoan_FormClosing;
            Load += fSuaTaiKhoan_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private TextBox txtVaiTro;
        private Button btSaveTaiKhoan;
        private Button btCancelTaiKhoan;
        private CheckBox ckTinhTrang;
        private ToolTip toolTip1;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboVaiTro;
        private Button doiMatKhau;
    }
}