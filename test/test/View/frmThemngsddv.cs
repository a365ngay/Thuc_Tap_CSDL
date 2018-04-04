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
    public partial class frmThemngsddv : DevExpress.XtraEditors.XtraForm
    {
        public static int x;
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public frmThemngsddv()
        {
            InitializeComponent();
            String maauto = "HD";
            Random rd = new Random();
            int x = rd.Next(0, 1000);

            var manv = from nv in dl.HDDichVus select nv.MaHD;
            foreach (var item in manv)
            {
                if (item != maauto + Convert.ToString(x))
                {
                    break;
                }
                x = rd.Next(0, 1000);
            }
            maauto = maauto + Convert.ToString(x);
            txtMahd.Text = maauto;

            var query3 = (from n in dl.KhachHangs select n.TenKH);
            foreach (string item in query3)
            {
                cbTenkh.Items.Add(item);
            }

            var query2 = (from n in dl.DichVus select n.TenDV);
            foreach (string item in query2)
            {
                cbTendv.Items.Add(item);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTendv_TextChanged_1(object sender, EventArgs e)
        {
            if (cbTennv.Items != null)
            {
                cbTennv.Items.Clear();
            }
            var query4 = (from n in dl.DichVus where n.TenDV == cbTendv.Text select n.LoaiDV).Distinct();
            string x = "";
            foreach (string item1 in query4)
            {
                x = item1;
            }
            var query3 = (from n in dl.NhanViens where n.ChucVu == x select n.TenNV).Distinct();
            foreach (string item2 in query3)
            {
                cbTennv.Items.Add(item2);
            }
        }

        private void cbTenkh_TextChanged_1(object sender, EventArgs e)
        {
            var query4 = (from n in dl.KhachHangs where n.TenKH == cbTenkh.Text select n.MaKH).Distinct();
            foreach (string item1 in query4)
            {
                txtMakh.Text = item1;
            }
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            if (txtSl.Text != "")
            {
                DichVu dv = dl.DichVus.Single(a => a.TenDV == cbTendv.Text);
                string money = dv.GiaDV.ToString();
                txtTien.Text = Convert.ToString(Convert.ToInt32(money) * Convert.ToInt32(txtSl.Text));
            }
            else
            {
                txtTien.Text = "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            x = db.add_sddv(txtMahd.Text, txtMakh.Text, cbTendv.Text, txtSl.Text, txtTien.Text, cbTennv.Text, dtpN.Text);
        }
    }
}