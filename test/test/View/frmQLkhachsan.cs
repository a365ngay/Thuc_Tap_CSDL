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
using DAL;
using BUS;

namespace test.View
{
    public partial class frmQLkhachsan : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public static string ma1;
        public frmQLkhachsan()
        {
            InitializeComponent();

            if(frmMain.idlogin == "3")
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

            dataGridView1.DataSource = db.get_ks();
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            export2Execl(dataGridView1);
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_ks(txtGiatri.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaks.Text = dataGridView1.CurrentRow.Cells["MaKhachSan"].Value.ToString();
            ma1 = dataGridView1.CurrentRow.Cells["MaKhachSan"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenKhachSan"].Value == null)
            {
                txtTenks.Text = "";
            }
            else
            {
                txtTenks.Text = dataGridView1.CurrentRow.Cells["TenKhachSan"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["DiaChi"].Value == null)
            {
                txtDiachi.Text = "";
            }
            else
            {
                txtDiachi.Text = dataGridView1.CurrentRow.Cells["DiaChi"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["MaNQL"].Value == null)
            {
                cbMaql.Text = "";
            }
            else
            {
                cbMaql.Text = dataGridView1.CurrentRow.Cells["MaNQL"].Value.ToString();
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            frmThemks themks = null;
            Check_Them:
            if (themks == null || themks.IsDisposed)
            {
                themks = new frmThemks();
            }
            if (themks.ShowDialog() == DialogResult.OK)
            {
                if (frmThemks.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_ks();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa nhân viên?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.edit_ks(ma1, txtMaks.Text, txtTenks.Text, txtDiachi.Text, cbMaql.Text);
                dataGridView1.DataSource = db.get_ks();
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa khách sạn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.delete_ks(txtMaks.Text);
                dataGridView1.DataSource = db.get_ks();
            }
        }
    }
}