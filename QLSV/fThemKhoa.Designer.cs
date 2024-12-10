namespace QLSV
{
    partial class fThemKhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fThemKhoa));
            lblMaKhoa = new Label();
            lblTenKhoa = new Label();
            txtMaKhoa = new TextBox();
            txtTenKhoa = new TextBox();
            btSaveKhoa = new Button();
            btCancelKhoa = new Button();
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
            lblMaKhoa.Location = new Point(19, 25);
            lblMaKhoa.Name = "lblMaKhoa";
            lblMaKhoa.Size = new Size(92, 28);
            lblMaKhoa.TabIndex = 0;
            lblMaKhoa.Text = "Mã Khoa";
            // 
            // lblTenKhoa
            // 
            lblTenKhoa.AutoSize = true;
            lblTenKhoa.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTenKhoa.Location = new Point(19, 91);
            lblTenKhoa.Name = "lblTenKhoa";
            lblTenKhoa.Size = new Size(96, 28);
            lblTenKhoa.TabIndex = 1;
            lblTenKhoa.Text = "Tên Khoa";
            // 
            // txtMaKhoa
            // 
            txtMaKhoa.Location = new Point(134, 22);
            txtMaKhoa.Name = "txtMaKhoa";
            txtMaKhoa.Size = new Size(449, 31);
            txtMaKhoa.TabIndex = 2;
            txtMaKhoa.Validating += txtMaKhoa_Validating;
            // 
            // txtTenKhoa
            // 
            txtTenKhoa.Location = new Point(134, 91);
            txtTenKhoa.Name = "txtTenKhoa";
            txtTenKhoa.Size = new Size(449, 31);
            txtTenKhoa.TabIndex = 3;
            txtTenKhoa.Validating += txtTenKhoa_Validating;
            // 
            // btSaveKhoa
            // 
            btSaveKhoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btSaveKhoa.Image = (Image)resources.GetObject("btSaveKhoa.Image");
            btSaveKhoa.ImageAlign = ContentAlignment.MiddleLeft;
            btSaveKhoa.Location = new Point(201, 336);
            btSaveKhoa.Name = "btSaveKhoa";
            btSaveKhoa.Padding = new Padding(30, 0, 0, 0);
            btSaveKhoa.Size = new Size(151, 56);
            btSaveKhoa.TabIndex = 4;
            btSaveKhoa.Text = "Lưu";
            btSaveKhoa.UseCompatibleTextRendering = true;
            btSaveKhoa.UseVisualStyleBackColor = true;
            btSaveKhoa.Click += btSaveKhoa_Click;
            // 
            // btCancelKhoa
            // 
            btCancelKhoa.CausesValidation = false;
            btCancelKhoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btCancelKhoa.Image = (Image)resources.GetObject("btCancelKhoa.Image");
            btCancelKhoa.ImageAlign = ContentAlignment.MiddleLeft;
            btCancelKhoa.Location = new Point(403, 336);
            btCancelKhoa.Name = "btCancelKhoa";
            btCancelKhoa.Padding = new Padding(30, 0, 0, 0);
            btCancelKhoa.Size = new Size(151, 56);
            btCancelKhoa.TabIndex = 5;
            btCancelKhoa.Text = "Hủy";
            btCancelKhoa.UseCompatibleTextRendering = true;
            btCancelKhoa.UseVisualStyleBackColor = true;
            btCancelKhoa.Click += btCancelKhoa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(18, 52, 86);
            label1.Location = new Point(256, 40);
            label1.Name = "label1";
            label1.Size = new Size(298, 45);
            label1.TabIndex = 16;
            label1.Text = "THÊM MỚI KHOA";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(222, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 32);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtTenKhoa);
            panel2.Controls.Add(lblMaKhoa);
            panel2.Controls.Add(lblTenKhoa);
            panel2.Controls.Add(txtMaKhoa);
            panel2.Location = new Point(83, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(607, 150);
            panel2.TabIndex = 18;
            // 
            // fThemKhoa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btCancelKhoa);
            Controls.Add(btSaveKhoa);
            Name = "fThemKhoa";
            Text = "Thêm Khoa";
            FormClosing += fThemKhoa_FormClosing;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaKhoa;
        private Label lblTenKhoa;
        private TextBox txtMaKhoa;
        private TextBox txtTenKhoa;
        private Button btSaveKhoa;
        private Button btCancelKhoa;
        private ToolTip toolTip1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}