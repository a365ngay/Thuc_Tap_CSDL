using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DAL;

namespace test.View
{
    public partial class frmRegister : DevExpress.XtraEditors.XtraForm
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            QLDuLieuDataContext db = new QLDuLieuDataContext();

            TaiKhoan tk = new TaiKhoan();

            int taikhoan = (from x in db.TaiKhoans
                            where x.Name == txtUser.Text
                            select tk).Count();
            if (taikhoan != 0)
            {
                XtraMessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                this.Hide();
                frmRegister register = new frmRegister();
                register.Show();
            }
            else
            {
                if (txtPassword.Text == txtRePass.Text)
                {
                    tk.Name = txtUser.Text;
                    tk.Pass = txtPassword.Text;
                    tk.ID = "1";
                    db.TaiKhoans.InsertOnSubmit(tk);
                    db.SubmitChanges();
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("Mật khẩu không khớp!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    this.Hide();
                    frmRegister register = new frmRegister();
                    register.Show();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}