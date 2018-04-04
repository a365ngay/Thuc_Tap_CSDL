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
    public partial class frmPhongtrong : DevExpress.XtraEditors.XtraForm
    {
        QLDuLieuDataContext dl = new QLDuLieuDataContext();
        QLCode db = new QLCode();
        public frmPhongtrong()
        {
            InitializeComponent();
        }

        public void showTreeview ()
        {
            int i = 0;
            var nodecha = from a in dl.Phongs select a.TenPhong;
            foreach (var item in nodecha)
            {
                twDsks.Nodes.Add(item);
                twDsks.Nodes[i].Tag = '1';
                i++;
            }
        }
    }
}