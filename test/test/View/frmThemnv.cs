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
    public partial class frmThemnv : DevExpress.XtraEditors.XtraForm
    {
        QLCode code = new QLCode();
        QLDuLieuDataContext db = new QLDuLieuDataContext();
        public static int x;
        public frmThemnv()
        {
            InitializeComponent();

            if (frmMain.idlogin == "3")
            {
                lbmanv.Visible = true;
                lbmaql.Visible = true;
                txtManv.Visible = true;
                cbMaks.Visible = true;


                var query = (from n in db.KhachSans select n.MaKhachSan).Distinct();
                foreach (string item in query)
                {
                    cbMaks.Items.Add(item);
                }
            }
            else
            {
                lbmanv.Visible = false;
                lbmaql.Visible = false;
                txtManv.Visible = false;
                cbMaks.Visible = false;
            }
            String maauto = "NV";
            Random rd = new Random();
            int x = rd.Next(0, 1000);

            var manv = from nv in db.NhanViens select nv.MaNV;
            foreach (var item in manv)
            {
                if (item != maauto + Convert.ToString(x))
                {
                    break;
                }
                x = rd.Next(0, 1000);
            }
            maauto = maauto + Convert.ToString(x);
            txtManv.Text = maauto;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtCmt.Text == "" || txtSdt.Text == "" || txtCvu.Text == "" || txtQuequan.Text == "" || txtLuong.Text == "")
            {
                if (XtraMessageBox.Show("Bạn chưa nhập đủ dữ liệu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                }
            }
            else
            {
                x = code.add_nv(txtManv.Text, txtTen.Text, dtpNs.Text, cbGt.Text, txtCmt.Text, txtSdt.Text, txtQuequan.Text, txtCvu.Text, txtLuong.Text, cbMaks.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}