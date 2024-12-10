namespace QLSV
{
    partial class fSuaKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSuaKhoa));
            lblMaKhoa = new Label();
            lblTenKhoa = new Label();
            btSaveKhoa = new Button();
            btCancelKhoa = new Button();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblMaKhoa
            // 
            lblMaKhoa.AutoSize = true;
            lblMaKhoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblMaKhoa.Location = new Point(26, 26);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(92, 28);
            lblMaKhoa.TabIndex = 0;
            lblMaKhoa.Text = "Mã Khoa";
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTenKhoa.Location = new Point(26, 86);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(96, 28);
            lblTenKhoa.TabIndex = 1;
            lblTenKhoa.Text = "Tên Khoa";
            // 
            // btSaveKhoa
            // 
            btSaveKhoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveKhoa.Image = (Image)resources.GetObject("btSaveKhoa.Image");
            btSaveKhoa.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveKhoa.Location = new Point(237, 302);
            btSaveKhoa.Name = "btSaveKhoa";
            btSaveKhoa.Padding = new Padding(30, 0, 0, 0);
            btSaveKhoa.Size = new Size(150, 55);
            btSaveKhoa.TabIndex = 2;
            btSaveKhoa.Text = "Lưu";
            btSaveKhoa.UseVisualStyleBackColor = true;
            btSaveKhoa.Click += btSaveKhoa_Click;
            // 
            // btCancelKhoa
            // 
            btCancelKhoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelKhoa.Image = (Image)resources.GetObject("btCancelKhoa.Image");
            btCancelKhoa.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelKhoa.Location = new Point(405, 302);
            btCancelKhoa.Name = "btCancelKhoa";
            btCancelKhoa.Padding = new Padding(30, 0, 0, 0);
            btCancelKhoa.Size = new Size(150, 55);
            btCancelKhoa.TabIndex = 3;
            btCancelKhoa.Text = "Hủy";
            btCancelKhoa.UseVisualStyleBackColor = true;
            btCancelKhoa.Click += btCancelKhoa_Click;
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(141, 26);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(415, 31);
            txtMaKhoa.TabIndex = 4;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(141, 86);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(415, 31);
            txtTenKhoa.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(218, 21);
            label1.Name = "label1";
            label1.Size = new Size(387, 45);
            label1.TabIndex = 18;
            label1.Text = "SỬA THÔNG TIN KHOA";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(184, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 32);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblTenKhoa);
            panel2.Controls.Add(lblMaKhoa);
            panel2.Controls.Add(txtTenKhoa);
            panel2.Controls.Add(txtMaKhoa);
            panel2.Location = new Point(104, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 146);
            panel2.TabIndex = 20;
            // 
            // fSuaKhoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 404);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btCancelKhoa);
            Controls.Add(btSaveKhoa);
            Name = "fSuaKhoa";
            Text = "fSuaKhoa";
            Load += fSuaKhoa_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaKhoa;
        private Label lblTenKhoa;
        private Button btSaveKhoa;
        private Button btCancelKhoa;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private ToolTip toolTip1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}