using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using test.View;
using BUS;

namespace test
{
    public partial class frmMain : Form
    {
        public static string user;
        public static string pass;
        public static string idlogin;
        public frmMain()
        {
            InitializeComponent();
            anButton(idlogin);
            if (idlogin != "2" || idlogin != "3")
            {
                var form = new frmHome();
                if (ExistForm(form))
                {
                    return;
                }
                form.MdiParent = this;
                form.Show();
            }
        }

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2010 Blue"; //tên giao diện mặc định khi khởi động
        }

        public void anButton(string _idlogin)
        {
            if (_idlogin == "1")
            {
                btnLogin.Enabled = false;
                btnChangePass.Enabled = true;
                btnLogout.Enabled = true;
                btnPhanquyen.Enabled = false;
                btnBackup.Enabled = false;
                btnRestore.Enabled = false;
                btnNhanvien.Enabled = false;
                btnKhachsan.Enabled = false;
                btnPhong.Enabled = false;
                btnThongkephong.Enabled = false;
                btnKhachhang.Enabled = false;
                btnDichvu.Enabled = false;
                btnTinhtrangphong.Enabled = false;
                btnBaocaodoanhthu.Enabled = false;
                btnDatphong.Enabled = false;
                btnSddv.Enabled = false;
                btnThanhtoan.Enabled = false;
                btnBaocaothuephong.Enabled = false;
            }
            else if (_idlogin == "2")
            {
                btnLogin.Enabled = false;
                btnChangePass.Enabled = true;
                btnLogout.Enabled = true;
                btnPhanquyen.Enabled = false;
                btnBackup.Enabled = true;
                btnRestore.Enabled = true;
                btnNhanvien.Enabled = true;
                btnKhachsan.Enabled = true;
                btnPhong.Enabled = true;
                btnThongkephong.Enabled = true;
                btnKhachhang.Enabled = true;
                btnDichvu.Enabled = true;
                btnTinhtrangphong.Enabled = true;
                btnBaocaodoanhthu.Enabled = true;
                btnDatphong.Enabled = true;
                btnSddv.Enabled = true;
                btnThanhtoan.Enabled = true;
                btnBaocaothuephong.Enabled = true;
            }
            else if (_idlogin == "3")
            {
                btnLogin.Enabled = false;
                btnChangePass.Enabled = true;
                btnLogout.Enabled = true;
                btnPhanquyen.Enabled = true;
                btnBackup.Enabled = true;
                btnRestore.Enabled = true;
                btnNhanvien.Enabled = true;
                btnKhachsan.Enabled = true;
                btnPhong.Enabled = true;
                btnThongkephong.Enabled = true;
                btnKhachhang.Enabled = true;
                btnDichvu.Enabled = true;
                btnTinhtrangphong.Enabled = true;
                btnBaocaodoanhthu.Enabled = true;
                btnDatphong.Enabled = true;
                btnSddv.Enabled = true;
                btnThanhtoan.Enabled = true;
                btnBaocaothuephong.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = true;
                btnChangePass.Enabled = false;
                btnLogout.Enabled = false;
                btnPhanquyen.Enabled = false;
                btnBackup.Enabled = false;
                btnRestore.Enabled = false;
                btnNhanvien.Enabled = false;
                btnKhachsan.Enabled = false;
                btnPhong.Enabled = false;
                btnThongkephong.Enabled = false;
                btnKhachhang.Enabled = false;
                btnDichvu.Enabled = false;
                btnTinhtrangphong.Enabled = false;
                btnBaocaodoanhthu.Enabled = false;
                btnDatphong.Enabled = false;
                btnSddv.Enabled = false;
                btnThanhtoan.Enabled = false;
                btnBaocaothuephong.Enabled = false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        QLCode code = new QLCode();

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin login = null;
            Check_Login:
            if (login == null || login.IsDisposed)
            {
                login = new frmLogin();
            }
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.txtUser.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập username!");
                    goto Check_Login;
                }
                if (login.txtPassword.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập password!");
                    goto Check_Login;
                }
                if (code.check_login(login.txtUser.Text, login.txtPassword.Text) == "0")
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                    goto Check_Login;
                }
                else
                {
                    user = login.txtUser.Text;
                    pass = login.txtPassword.Text;
                    idlogin = code.check_login(login.txtUser.Text, login.txtPassword.Text);
                    anButton(idlogin);
                    this.Hide();
                    frmMain main = new frmMain();
                    main.Show();
                }
            }
            else
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                idlogin = "0";
                anButton(idlogin);
                btnLogin_ItemClick(sender, e);
            }
        }

        private void btnChangePass_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRepass repass = new frmRepass();
            Check_Repass:
            if (repass == null || repass.IsDisposed)
            {
                repass = new frmRepass();
            }
            if (repass.ShowDialog() == DialogResult.OK)
            {
                if (repass.txtPasscu.Text == "" || repass.txtPassmoi.Text == "" || repass.txtRepass.Text == "")
                {
                    XtraMessageBox.Show("Hãy nhập password!");
                    goto Check_Repass;
                }
                if (repass.txtPassmoi.Text != repass.txtRepass.Text)
                {
                    XtraMessageBox.Show("Password không khớp!");
                    goto Check_Repass;
                }
                if (repass.txtPasscu.Text != pass)
                {
                    MessageBox.Show("Mật khẩu không đúng!");
                    goto Check_Repass;
                }
                else
                {
                    pass = repass.txtPassmoi.Text;
                    Properties.Settings.Default.Password = pass;
                    code.edit_tk_pass(user, repass.txtPassmoi.Text);
                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
            }
        }

        private void btnPhanquyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new frmQLsd();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private bool ExistForm(XtraForm form)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == form.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private void btnHome_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmHome();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnNhanvien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmQlnv();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnKhachsan_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmQLkhachsan();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnThongkephong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmPhongtrong();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmQLphong();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmQLkhachhang();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmQLdichvu();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnTinhtrangphong_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmTinhtrangphong();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnSddv_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmSddichvu();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }

        private void btnBackup_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var form = new frmBaocaothuephong();
            if (ExistForm(form))
            {
                return;
            }
            form.MdiParent = this;
            form.Show();
        }
    }
}
