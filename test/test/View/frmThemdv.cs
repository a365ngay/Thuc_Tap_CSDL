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
    public partial class frmThemdv : DevExpress.XtraEditors.XtraForm
    {
        QLCode code = new QLCode();
        QLDuLieuDataContext db = new QLDuLieuDataContext();
        public static int x;
        public frmThemdv()
        {
            InitializeComponent();

            if (frmMain.idlogin == "3")
            {
                lbMadv.Visible = true;
                txtMadv.Visible = true;
            }
            else
            {
                lbMadv.Visible = false;
                txtMadv.Visible = false;
            }

            var query1 = (from n in db.DichVus select n.LoaiDV).Distinct();
            foreach (string item in query1)
            {
                cbLoaidv.Items.Add(item);
            }

            String maauto = "DV";
            Random rd = new Random();
            int x = rd.Next(0, 1000);

            var madv = from nv in db.DichVus select nv.MaDV;
            foreach (var item in madv)
            {
                if (item != maauto + Convert.ToString(x))
                {
                    break;
                }
                x = rd.Next(0, 1000);
            }
            maauto = maauto + Convert.ToString(x);
            txtMadv.Text = maauto;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTendv.Text == "" || txtGiadv.Text == "")
            {
                if (XtraMessageBox.Show("Bạn chưa nhập đủ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
            }
            else
            {
                x = code.add_dv(txtMadv.Text, txtTendv.Text, txtGiadv.Text, cbLoaidv.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}