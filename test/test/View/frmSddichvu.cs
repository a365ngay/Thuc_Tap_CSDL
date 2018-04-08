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
    public partial class frmSddichvu : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public static string makh;
        public static string mahd;
        public static string tenkh;
        public static string tendvbd;

        public frmSddichvu()
        {
            InitializeComponent();

            if(frmMain.idlogin == "3")
            {
                lbMakh.Visible = true;
                txtMakh.Visible = true;
                lbMahd.Visible = true;
                txtMahd.Visible = true;
            }
            else
            {
                lbMakh.Visible = false;
                txtMakh.Visible = false;
                lbMahd.Visible = false;
                txtMahd.Visible = false;
            }

            var query2 = (from n in dl.KhachSans select n.TenKhachSan);
            foreach (string item in query2)
            {
                cbTenks.Items.Add(item);
            }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            frmThemngsddv themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmThemngsddv();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmThemngsddv.x == 0)
                {
                    goto Check_Them;
                }
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmSuasddv themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmSuasddv();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmSuasddv.x == 0)
                {
                    goto Check_Them;
                }
            }
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmSudungthemdv themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmSudungthemdv();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmSudungthemdv.x == 0)
                {
                    goto Check_Them;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn hủy sử dụng dịch vụ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DichVu dv = dl.DichVus.Single(a => a.TenDV == cbTendv.Text);
                string madv = dv.MaDV;
                db.huy_dv(txtMahd.Text, madv);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["MaHD1"].Value == null)
            {
                txtMahd.Text = "";
            }
            else
            {
                txtMahd.Text = dataGridView1.CurrentRow.Cells["MaHD1"].Value.ToString();
                mahd = txtMahd.Text;
            }
            if (dataGridView1.CurrentRow.Cells["MaKH1"].Value == null)
            {
                txtMakh.Text = "";
            }
            else
            {
                txtMakh.Text = dataGridView1.CurrentRow.Cells["MaKH1"].Value.ToString();
                makh = txtMakh.Text;
            }
            if (dataGridView1.CurrentRow.Cells["TenKhachHang"].Value == null)
            {
                cbTenkh.Text = "";
            }
            else
            {
                cbTenkh.Text = dataGridView1.CurrentRow.Cells["TenKhachHang"].Value.ToString();
                tenkh = cbTenkh.Text;
            }
            if (dataGridView1.CurrentRow.Cells["TenDV"].Value == null)
            {
                cbTendv.Text = "";
            }
            else
            {
                cbTendv.Text = dataGridView1.CurrentRow.Cells["TenDV"].Value.ToString();
                tendvbd = cbTendv.Text;
            }
            if (dataGridView1.CurrentRow.Cells["SoLuong"].Value == null)
            {
                txtSl.Text = "";
            }
            else
            {
                txtSl.Text = dataGridView1.CurrentRow.Cells["SoLuong"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["ThanhTien"].Value == null)
            {
                txtTien.Text = "";
            }
            else
            {
                txtTien.Text = dataGridView1.CurrentRow.Cells["ThanhTien"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["TenNV"].Value == null)
            {
                cbTennv.Text = "";
            }
            else
            {
                cbTennv.Text = dataGridView1.CurrentRow.Cells["TenNV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["NgayDangKy"].Value == null)
            {
                dtpN.Text = "";
            }
            else
            {
                dtpN.Text = dataGridView1.CurrentRow.Cells["NgayDangKy"].Value.ToString();
            }
        }

        private void cbTenks_TextChanged(object sender, EventArgs e)
        {
            if (cbTenphong.Items != null)
            {
                cbTenphong.Items.Clear();
            }
            cbTenphong.Text = "";
            if (cbTenks.Text != "")
            {
                KhachSan ks = dl.KhachSans.Single(a => a.TenKhachSan == cbTenks.Text);
                string maks = ks.MaKhachSan;
                var query = (from n in dl.Phongs where n.MaKS == maks select n.TenPhong);
                foreach (string item in query)
                {
                    cbTenphong.Items.Add(item);
                }
            }
        }

        private void cbTenphong_TextChanged(object sender, EventArgs e)
        {
            if (cbTenkh1.Items != null)
            {
                cbTenkh1.Items.Clear();
            }
            cbTenkh1.Text = "";
            if (cbTenphong.Text != "")
            {
                int taikhoan = (from tk in dl.ChiTietThuePhongs
                                where tk.TenPhong == cbTenphong.Text
                                select tk).Count();
                if( taikhoan != 0)
                {
                    ChiTietThuePhong ct = dl.ChiTietThuePhongs.Single(a => a.TenPhong == cbTenphong.Text);
                    string map = ct.MaPhong;
                    var query = (from n in dl.ThuePhongs where n.MaPhong == map select n.MaKH);
                    foreach (string item in query)
                    {
                        makh = item;
                        int taikhoan1 = (from tk in dl.HDDichVus
                                         where tk.MaKH == makh
                                         select tk).Count();
                        if (taikhoan1 != 0)
                        {
                            KhachHang kh = dl.KhachHangs.Single(b => b.MaKH == makh);
                            cbTenkh1.Items.Add(kh.TenKH);
                        }
                    }
                }
            }
        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLocnhanh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.get_sddv(cbTenkh1.Text);
        }

        private void txtTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.get_sddv(txtGiatri.Text);
        }
    }
}