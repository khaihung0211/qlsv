namespace QLSV
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtMatKhau = new TextBox();
            btLogin = new Button();
            btClose = new Button();
            liForget = new LinkLabel();
            lblMessage = new Label();
            label2 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(398, 183);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(302, 230);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(86, 19);
            label3.TabIndex = 2;
            label3.Text = "Người dùng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label4.Location = new Point(320, 264);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 3;
            label4.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(398, 230);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(244, 23);
            txtEmail.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(398, 264);
            txtMatKhau.Margin = new Padding(2);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(244, 23);
            txtMatKhau.TabIndex = 5;
            // 
            // btLogin
            // 
            btLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.Image = (Image)resources.GetObject("btLogin.Image");
            btLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btLogin.Location = new Point(521, 291);
            btLogin.Margin = new Padding(2);
            btLogin.Name = "btLogin";
            btLogin.Padding = new Padding(7, 0, 0, 0);
            btLogin.Size = new Size(121, 35);
            btLogin.TabIndex = 6;
            btLogin.Text = "Đăng nhập";
            btLogin.TextAlign = ContentAlignment.MiddleRight;
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btClose
            // 
            btClose.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btClose.Image = (Image)resources.GetObject("btClose.Image");
            btClose.ImageAlign = ContentAlignment.MiddleLeft;
            btClose.Location = new Point(398, 291);
            btClose.Margin = new Padding(2);
            btClose.Name = "btClose";
            btClose.Padding = new Padding(21, 0, 0, 0);
            btClose.Size = new Size(119, 35);
            btClose.TabIndex = 7;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // liForget
            // 
            liForget.AutoSize = true;
            liForget.Location = new Point(299, 301);
            liForget.Margin = new Padding(2, 0, 2, 0);
            liForget.Name = "liForget";
            liForget.Size = new Size(89, 15);
            liForget.TabIndex = 8;
            liForget.TabStop = true;
            liForget.Text = "Quên mật khẩu";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(398, 211);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 15);
            lblMessage.TabIndex = 9;
            lblMessage.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 35F, FontStyle.Bold);
            label2.Location = new Point(73, 53);
            label2.Name = "label2";
            label2.Size = new Size(755, 62);
            label2.TabIndex = 10;
            label2.Text = "PHẦN MỀM QUẢN LÝ SINH VIÊN";
            label2.Click += label2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(398, 350);
            label5.Name = "label5";
            label5.Size = new Size(216, 15);
            label5.TabIndex = 11;
            label5.Text = "Test account: admin@gmail.com / 1111";
            // 
            // fLogin
            // 
            AcceptButton = btLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(894, 594);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(lblMessage);
            Controls.Add(liForget);
            Controls.Add(btClose);
            Controls.Add(btLogin);
            Controls.Add(txtMatKhau);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtMatKhau;
        private Button btLogin;
        private Button btClose;
        private LinkLabel liForget;
        private Label lblMessage;
        private Label label2;
        private Label label5;
    }
}