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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Diagnostics;
using System.IO;
using BUS;
using DAL;

namespace test.View
{
    public partial class frmQLkhachhang : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public static string makhbd;
        public frmQLkhachhang()
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
            dataGridView1.DataSource = db.get_kh();
        }

        public void export2Execl(DataGridView dg)
        {
            string tentep = "";
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < dg.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = dg.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                for (int j = 0; j < dg.Columns.Count; j++)
                {
                    if (dg.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = dg.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            SaveFileDialog fsave = new SaveFileDialog();
            fsave.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            fsave.ShowDialog();
            if (fsave.FileName != null)
            {
                tentep = fsave.FileName;
                obj.ActiveWorkbook.SaveAs(tentep);
                obj.ActiveWorkbook.Saved = true;
                //Process.Start(tentep, Path.GetFileName(fsave.FileName));
                ProcessStartInfo info = new ProcessStartInfo(fsave.FileName + ".xlsx");
                Process.Start(info);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMakh.Text = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            makhbd = dataGridView1.CurrentRow.Cells["MaKH"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenKH"].Value == null)
            {
                txtTenkh.Text = "";
            }
            else
            {
                txtTenkh.Text = dataGridView1.CurrentRow.Cells["TenKH"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["NgaySinh"].Value == null)
            {
                dtpNs.Text = "";
            }
            else
            {
                dtpNs.Text = dataGridView1.CurrentRow.Cells["NgaySinh"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["DiaChi"].Value == null)
            {
                txtDiachi.Text = "";
            }
            else
            {
                txtDiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["GioiTinh"].Value == null)
            {
                cbGt.Text = "";
            }
            else
            {
                cbGt.Text = dataGridView1.CurrentRow.Cells["GioiTinh"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["SoCMT"].Value == null)
            {
                txtCmt.Text = "";
            }
            else
            {
                txtCmt.Text = dataGridView1.CurrentRow.Cells["SoCMT"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["SoDT"].Value == null)
            {
                txtSdt.Text = "";
            }
            else
            {
                txtSdt.Text = dataGridView1.CurrentRow.Cells["SoDT"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemkh themkh = null;
            Check_Them:
            if (themkh == null || themkh.IsDisposed)
            {
                themkh = new frmThemkh();
            }
            if (themkh.ShowDialog() == DialogResult.OK)
            {
                if (frmThemkh.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_kh();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            export2Execl(dataGridView1);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.delete_kh(txtMakh.Text);
                dataGridView1.DataSource = db.get_kh();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa khách hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.edit_kh(makhbd, txtMakh.Text, txtTenkh.Text, dtpNs.Text, cbGt.Text, txtCmt.Text, txtSdt.Text, txtDiachi.Text);
            }
            dataGridView1.DataSource = db.get_kh();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_kh(txtGiatri.Text);
        }
    }
}