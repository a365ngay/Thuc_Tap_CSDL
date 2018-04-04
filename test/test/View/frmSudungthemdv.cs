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
    public partial class frmSudungthemdv : DevExpress.XtraEditors.XtraForm
    {
        public static int x;
        public static int slbd;
        public static string slls;
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public frmSudungthemdv()
        {
            InitializeComponent();

            txtMakh.Text = frmSddichvu.makh;
            cbTenkh.Text = frmSddichvu.tenkh;
            txtMahd.Text = frmSddichvu.mahd;

            var query2 = (from n in dl.DichVus select n.TenDV);
            foreach (string item in query2)
            {
                cbTendv.Items.Add(item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            x = db.add_sddv(txtMahd.Text, txtMakh.Text, cbTendv.Text, slls, txtTien.Text, cbTennv.Text, dtpN.Text);
        }

        private void cbTendv_TextChanged(object sender, EventArgs e)
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

            DichVu dv = dl.DichVus.Single(a => a.TenDV == cbTendv.Text);
            string madv = dv.MaDV;
            var query5 = from tk in dl.ChiTietDVs
                         where tk.MaHD == txtMahd.Text && tk.MaDV == madv
                         select tk.SoLuongDV;
            slbd = 0;
            foreach (int item1 in query5)
            {
                slbd = item1;
            }
        }

        private void txtSl_TextChanged(object sender, EventArgs e)
        {
            DichVu dv = dl.DichVus.Single(a => a.TenDV == cbTendv.Text);
            string madv = dv.MaDV;
            int cout = (from tk in dl.ChiTietDVs
                        where tk.MaHD == txtMahd.Text && tk.MaDV == madv
                        select tk).Count();
            if (cout != 0)
            {
                slls = Convert.ToString(slbd + Convert.ToInt32(txtSl.Text));
            }
            else
            {
                slls = txtSl.Text;
            }
            if (txtSl.Text != "")
            {
                DichVu dv1 = dl.DichVus.Single(a => a.TenDV == cbTendv.Text);
                string money = dv1.GiaDV.ToString();
                txtTien.Text = Convert.ToString(Convert.ToInt32(money) * Convert.ToInt32(slls));
            }
            else
            {
                txtTien.Text = "";
            }
        }
    }
}