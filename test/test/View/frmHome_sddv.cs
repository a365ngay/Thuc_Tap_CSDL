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
using BUS;

namespace test.View
{
    public partial class frmHome_sddv : DevExpress.XtraEditors.XtraForm
    {
        QLCode db = new QLCode();
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        public frmHome_sddv()
        {
            InitializeComponent();

            if(frmMain.idlogin != "1" && frmMain.idlogin != "2" && frmMain.idlogin != "3")
            {
                if (XtraMessageBox.Show("Bạn chưa phải là khách hàng? Bạn có muốn đăng ký?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmThemkh them = new frmThemkh();
                    them.Show();
                    if (them.IsDisposed == false)
                    {
                        if (XtraMessageBox.Show("Tên đăng nhập và mật khẩu của bạn : " + frmThemkh.makh, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            frmLogin login = new frmLogin();
                            login.Show();
                        }
                    }
                }
            }

            var query2 = (from n in dl.DichVus select n.TenDV);
            foreach (string item in query2)
            {
                cbTendv.Items.Add(item);
            }
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            DichVu dv = dl.DichVus.Single(a => a.TenDV == cbTendv.Text);
            string money = dv.GiaDV.ToString();
            txtTien.Text = Convert.ToString(Convert.ToInt32(money) * Convert.ToInt32(txtSl.Text));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            KhachHang dv = dl.KhachHangs.Single(a => a.MaKH == frmThemkh.makh);
            string tenkh = dv.TenKH;
        }
    }
}