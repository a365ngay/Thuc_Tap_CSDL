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
using DAL;

namespace test.View
{
    public partial class frmThemkh : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public static int x;
        public static string makh;
        public frmThemkh()
        {
            InitializeComponent();

            if (frmMain.idlogin == "3")
            {
                lbMakh.Visible = true;
                txtMakh.Visible = true;
            }
            else
            {
                lbMakh.Visible = false;
                txtMakh.Visible = false;
            }
            String maauto = "KH";
            Random rd = new Random();
            int x = rd.Next(0, 1000);

            var makh = from nv in dl.KhachHangs select nv.MaKH;
            foreach (var item in makh)
            {
                if (item != maauto + Convert.ToString(x))
                {
                    break;
                }
                x = rd.Next(0, 1000);
            }
            maauto = maauto + Convert.ToString(x);
            txtMakh.Text = maauto;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCmt.Text == "" || txtSdt.Text == "" || txtDiachi.Text == "")
            {
                if (XtraMessageBox.Show("Bạn chưa nhập đủ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
            }
            else
            {
                makh = txtMakh.Text;
                x = db.add_kh(txtMakh.Text, txtTenkh.Text, dtpNs.Text, cbGt.Text, txtCmt.Text, txtSdt.Text, txtDiachi.Text);
            }
        }
    }
}