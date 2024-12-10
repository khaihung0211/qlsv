using QLSV.Models;
using QLSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    public partial class fLogin : Form
    {

        public fLogin()
        {
            InitializeComponent();
            Utility.taiKhoan = null;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            lblMessage.ForeColor = Color.Red;
            if (txtEmail.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập tên người dùng?";
                txtEmail.Select();
            }
            if (txtMatKhau.Text == "")
            {
                lblMessage.Text = "Bạn phải nhập mật khẩu?";
                txtMatKhau.Select();
            }
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();

            Task.Run(() =>
            {
                try
                {
                    using (var db = new EFDbContext())
                    {
                        Utility.taiKhoan = db.TaiKhoans.SingleOrDefault(e => e.Email == txtEmail.Text && e.MatKhau == txtMatKhau.Text);

                        this.Invoke((MethodInvoker)delegate
                        {
                            if (Utility.taiKhoan != null)
                            {
                                if (!Utility.taiKhoan.TinhTrang)
                                {
                                    lblMessage.Text = "Tài khoản chưa được kích hoạt. Vui lòng liên hệ admin.";
                                }
                                else
                                {
                                    loadingForm.Close();
                                    ResetForm();
                                    DialogResult = DialogResult.OK;
                                    this.Close();
                                }
                            }
                            else
                            {
                                lblMessage.Text = "Sai tên người dùng hoặc mật khẩu.";
                            }
                        });
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        lblMessage.Text = "Lỗi: " + ex.Message;
                    });
                }
            });
        }
        private void ResetForm()
        {
            txtEmail.Clear();       
            txtMatKhau.Clear();   
            lblMessage.Text = string.Empty; 
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btLogin;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
