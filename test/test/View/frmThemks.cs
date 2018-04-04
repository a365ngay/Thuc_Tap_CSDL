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
    public partial class frmThemks : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode code = new QLCode();
        public static int x;
        public frmThemks()
        {
            InitializeComponent();

            if (frmMain.idlogin == "3")
            {
                lbMaks.Visible = true;
                txtMaks.Visible = true;
            }
            else
            {
                lbMaks.Visible = false;
                txtMaks.Visible = false;
            }

            var query1 = (from n in dl.NhanViens where n.ChucVu == "Quản lý" select n.MaNV);
            foreach (string item in query1)
            {
                cbMaql.Items.Add(item);
            }
            String maauto = "KS";
            Random rd = new Random();
            int x = rd.Next(0, 1000);

            var manv = from nv in dl.KhachSans select nv.MaKhachSan;
            foreach (var item in manv)
            {
                if (item != maauto + Convert.ToString(x))
                {
                    break;
                }
                x = rd.Next(0, 1000);
            }
            maauto = maauto + Convert.ToString(x);
            txtMaks.Text = maauto;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbMaql.Text == "")
            {
                XtraMessageBox.Show("Bạn chưa nhập mã quản lý?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                x = code.add_ks(txtMaks.Text, txtTenks.Text, txtDiachi.Text, cbMaql.Text);
            }
        }
    }
}