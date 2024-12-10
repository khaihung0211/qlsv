namespace QLSV
{
    partial class fThemTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemTaiKhoan));
            label2 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtMatKhau = new TextBox();
            txtVaiTro = new TextBox();
            btSaveTaiKhoan = new Button();
            btCancelTaiKhoan = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            ckTinhTrang = new CheckBox();
            toolTip1 = new ToolTip(components);
            label3 = new Label();
            panel1 = new Panel();
            comboBoxRole = new ComboBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(102, 165);
            label2.Name = "label2";
            label2.Size = new Size(70, 19);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(369, 116);
            label4.Name = "label4";
            label4.Size = new Size(52, 19);
            label4.TabIndex = 3;
            label4.Text = "Vai Trò";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(369, 214);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(176, 160);
            txtMatKhau.Margin = new Padding(3, 2, 3, 2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(141, 23);
            txtMatKhau.TabIndex = 7;
            // 
            // txtVaiTro
            // 
            txtVaiTro.Location = new Point(422, 113);
            txtVaiTro.Margin = new Padding(3, 2, 3, 2);
            txtVaiTro.Name = "txtVaiTro";
            txtVaiTro.Size = new Size(39, 23);
            txtVaiTro.TabIndex = 9;
            txtVaiTro.Visible = false;
            // 
            // btSaveTaiKhoan
            // 
            btSaveTaiKhoan.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveTaiKhoan.Image = (Image)resources.GetObject("btSaveTaiKhoan.Image");
            btSaveTaiKhoan.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveTaiKhoan.Location = new Point(184, 226);
            btSaveTaiKhoan.Margin = new Padding(2);
            btSaveTaiKhoan.Name = "btSaveTaiKhoan";
            btSaveTaiKhoan.Padding = new Padding(21, 0, 0, 0);
            btSaveTaiKhoan.Size = new Size(105, 33);
            btSaveTaiKhoan.TabIndex = 12;
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
            btCancelTaiKhoan.Location = new Point(300, 226);
            btCancelTaiKhoan.Margin = new Padding(2);
            btCancelTaiKhoan.Name = "btCancelTaiKhoan";
            btCancelTaiKhoan.Padding = new Padding(21, 0, 0, 0);
            btCancelTaiKhoan.Size = new Size(105, 33);
            btCancelTaiKhoan.TabIndex = 13;
            btCancelTaiKhoan.Text = "Xóa";
            btCancelTaiKhoan.UseVisualStyleBackColor = true;
            btCancelTaiKhoan.Click += btCancelTaiKhoan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label1.Location = new Point(102, 116);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(176, 113);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(141, 23);
            txtEmail.TabIndex = 6;
            // 
            // ckTinhTrang
            // 
            ckTinhTrang.AutoSize = true;
            ckTinhTrang.Checked = true;
            ckTinhTrang.CheckState = CheckState.Checked;
            ckTinhTrang.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            ckTinhTrang.Location = new Point(374, 162);
            ckTinhTrang.Margin = new Padding(2);
            ckTinhTrang.Name = "ckTinhTrang";
            ckTinhTrang.Size = new Size(93, 23);
            ckTinhTrang.TabIndex = 14;
            ckTinhTrang.Text = "Tình trạng";
            ckTinhTrang.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(18, 52, 86);
            label3.Location = new Point(209, 18);
            label3.Name = "label3";
            label3.Size = new Size(215, 30);
            label3.TabIndex = 15;
            label3.Text = "THÊM TÀI KHOẢN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(comboBoxRole);
            panel1.Location = new Point(70, 89);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(462, 123);
            panel1.TabIndex = 16;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(351, 23);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(86, 23);
            comboBoxRole.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Location = new Point(198, 28);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 28);
            panel2.TabIndex = 17;
            // 
            // fThemTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(633, 338);
            Controls.Add(label3);
            Controls.Add(ckTinhTrang);
            Controls.Add(btCancelTaiKhoan);
            Controls.Add(btSaveTaiKhoan);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(txtVaiTro);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fThemTaiKhoan";
            Text = "Thêm tài khoản";
            FormClosing += fThemTaiKhoan_FormClosing;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label4;
        private Label label6;
        private TextBox txtMatKhau;
        private TextBox txtVaiTro;
        private Button btSaveTaiKhoan;
        private Button btCancelTaiKhoan;
        private Label label1;
        private TextBox txtEmail;
        private CheckBox ckTinhTrang;
        private ToolTip toolTip1;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private ComboBox comboBoxRole;
    }
}