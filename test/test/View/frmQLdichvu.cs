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
    public partial class frmQLdichvu : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public static string madvbd;
        public frmQLdichvu()
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
            var query1 = (from n in dl.DichVus select n.LoaiDV).Distinct();
            foreach (string item in query1)
            {
                cbLoaidv.Items.Add(item);
            }
            dataGridView1.DataSource = db.get_dv();
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
            txtMadv.Text = dataGridView1.CurrentRow.Cells["MaDV"].Value.ToString();
            madvbd = dataGridView1.CurrentRow.Cells["MaDV"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["TenDV"].Value == null)
            {
                txtTendv.Text = "";
            }
            else
            {
                txtTendv.Text = dataGridView1.CurrentRow.Cells["TenDV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["GiaDV"].Value == null)
            {
                txtGiadv.Text = "";
            }
            else
            {
                txtGiadv.Text = dataGridView1.CurrentRow.Cells["GiaDV"].Value.ToString();
            }
            if (dataGridView1.CurrentRow.Cells["LoaiDV"].Value == null)
            {
                cbLoaidv.Text = "";
            }
            else
            {
                cbLoaidv.Text = dataGridView1.CurrentRow.Cells["LoaiDV"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemdv themdv = null;
            Check_Them:
            if (themdv == null || themdv.IsDisposed)
            {
                themdv = new frmThemdv();
            }
            if (themdv.ShowDialog() == DialogResult.OK)
            {
                if (frmThemdv.x == 0)
                {
                    goto Check_Them;
                }
            }
            dataGridView1.DataSource = db.get_dv();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.search_dv(txtGiatri.Text);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            export2Execl(dataGridView1);
        }

        private void comboBoxEx1_TextChanged(object sender, EventArgs e)
        {
            if(cbKhoanggia.Text == "0-999.999")
            {
                dataGridView1.DataSource = db.search_dv("0", "999999");
            }
            if (cbKhoanggia.Text == "1.000.000-9.999.999")
            {
                dataGridView1.DataSource = db.search_dv("1000000", "9999999");
            }
            if (cbKhoanggia.Text == "Lớn hơn 10.000.000")
            {
                dataGridView1.DataSource = db.search_dv("10000000", "999999999");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn sửa dịch vụ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.edit_dv(madvbd, txtMadv.Text, txtTendv.Text, txtGiadv.Text, cbLoaidv.Text);
            }
            dataGridView1.DataSource = db.get_dv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xóa dịch vụ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.delete_dv(txtMadv.Text);
                dataGridView1.DataSource = db.get_dv();
            }
        }

        private void cbLoaidv_TextChanged(object sender, EventArgs e)
        {
            var query4 = (from n in dl.DichVus where n.LoaiDV == cbLoaidv.Text select n.GiaDV).Distinct();
            foreach (int item1 in query4)
            {
                txtGiadv.Text = item1.ToString();
            }
        }
    }
}