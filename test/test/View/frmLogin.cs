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
using BUS;

namespace test.View
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void SaveSettings()
        {
            if (checkGhinho.Checked)
            {
                Properties.Settings.Default.UserName = this.txtUser.Text;
                Properties.Settings.Default.Password = this.txtPassword.Text;
                Properties.Settings.Default.RememberMe = "true";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = this.txtUser.Text;
                Properties.Settings.Default.Password = this.txtPassword.Text;
                Properties.Settings.Default.RememberMe = "false";
                Properties.Settings.Default.Save();
            }
        }

        private void ReadSettings()
        {
            if (Properties.Settings.Default.RememberMe == "true")
            {
                txtUser.Text = Properties.Settings.Default.UserName;
                txtPassword.Text = Properties.Settings.Default.Password;
                checkGhinho.Checked = true;
            }
            else
            {
                txtUser.Text = "";
                txtPassword.Text = "";
                checkGhinho.Checked = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ReadSettings();
            txtPassword.Properties.PasswordChar = '*';
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            frmRegister dk = new frmRegister();
            dk.Show();
        }
    }
}