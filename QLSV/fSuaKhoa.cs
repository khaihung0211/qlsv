using QLSV.Models;
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
    public partial class fSuaKhoa : Form
    {
        private EFDbContext db;
        Khoa Khoas;
        string MaKhoa;
        string TenKhoa;
        long KhoaID;
        private string value;

        public fSuaKhoa(long KhoaID)
        {
            InitializeComponent();
            this.KhoaID = KhoaID;
            db = new EFDbContext();
        }

        //public fSuaKhoa(string value)
        //{
         //   this.value = value;
        //}

        private void fSuaKhoa_Load(object sender, EventArgs e)
        {
            Khoas = db.Khoas.Find(KhoaID);


            if (Khoas != null)
            {
                Text += " - Mã Khoa " + Khoas.KhoaID.ToString();
                txtMaKhoa.Text = Khoas.MaKhoa;
                txtTenKhoa.Text = Khoas.TenKhoa;
            }
        }

        private void btSaveKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                Khoas.MaKhoa = txtMaKhoa.Text;
                Khoas.TenKhoa = txtTenKhoa.Text;
                db.SaveChanges();
                toolTip1.Show("Lưu thành công.", btSaveKhoa, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSaveKhoa, 0, 0, 1000);
            }
            txtMaKhoa.Focus();
        }

        private void btCancelKhoa_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
