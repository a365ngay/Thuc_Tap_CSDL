namespace test.View
{
    partial class frmTinhtrangphong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTinhtrangphong));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtGiatri = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnTimkiem = new DevComponents.DotNetBar.ButtonX();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtTenphong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cbTinhtrangphong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.btnTinhtrangphong = new DevComponents.DotNetBar.ButtonX();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrangPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnTinhtrangphong);
            this.splitContainer1.Panel1.Controls.Add(this.labelX3);
            this.splitContainer1.Panel1.Controls.Add(this.cbTinhtrangphong);
            this.splitContainer1.Panel1.Controls.Add(this.txtTenphong);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1201, 492);
            this.splitContainer1.SplitterDistance = 214;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnTimkiem);
            this.splitContainer2.Panel1.Controls.Add(this.txtGiatri);
            this.splitContainer2.Panel1.Controls.Add(this.labelX1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Size = new System.Drawing.Size(983, 492);
            this.splitContainer2.SplitterDistance = 90;
            this.splitContainer2.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(254, 38);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(110, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tìm kiếm thông tin";
            // 
            // txtGiatri
            // 
            this.txtGiatri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtGiatri.Border.Class = "TextBoxBorder";
            this.txtGiatri.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiatri.Location = new System.Drawing.Point(370, 40);
            this.txtGiatri.Name = "txtGiatri";
            this.txtGiatri.PreventEnterBeep = true;
            this.txtGiatri.Size = new System.Drawing.Size(308, 21);
            this.txtGiatri.TabIndex = 1;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimkiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTimkiem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTimkiem.Location = new System.Drawing.Point(702, 38);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTimkiem.TabIndex = 2;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhong,
            this.TinhTrangPhong});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtTenphong
            // 
            this.txtTenphong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTenphong.Border.Class = "TextBoxBorder";
            this.txtTenphong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenphong.Enabled = false;
            this.txtTenphong.Location = new System.Drawing.Point(12, 108);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.PreventEnterBeep = true;
            this.txtTenphong.Size = new System.Drawing.Size(179, 21);
            this.txtTenphong.TabIndex = 4;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(12, 66);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(179, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "Tên phòng";
            // 
            // cbTinhtrangphong
            // 
            this.cbTinhtrangphong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTinhtrangphong.DisplayMember = "Text";
            this.cbTinhtrangphong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTinhtrangphong.FormattingEnabled = true;
            this.cbTinhtrangphong.ItemHeight = 15;
            this.cbTinhtrangphong.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2,
            this.comboItem3});
            this.cbTinhtrangphong.Location = new System.Drawing.Point(12, 215);
            this.cbTinhtrangphong.Name = "cbTinhtrangphong";
            this.cbTinhtrangphong.Size = new System.Drawing.Size(179, 21);
            this.cbTinhtrangphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTinhtrangphong.TabIndex = 5;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(12, 166);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(179, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Tình trạng phòng";
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "Đang dùng";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "Đang sửa";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Đang trống";
            // 
            // btnTinhtrangphong
            // 
            this.btnTinhtrangphong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTinhtrangphong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTinhtrangphong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTinhtrangphong.Image = ((System.Drawing.Image)(resources.GetObject("btnTinhtrangphong.Image")));
            this.btnTinhtrangphong.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnTinhtrangphong.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTinhtrangphong.Location = new System.Drawing.Point(17, 314);
            this.btnTinhtrangphong.Name = "btnTinhtrangphong";
            this.btnTinhtrangphong.Size = new System.Drawing.Size(174, 83);
            this.btnTinhtrangphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTinhtrangphong.TabIndex = 7;
            this.btnTinhtrangphong.Text = "Thay đổi tình trạng phòng";
            this.btnTinhtrangphong.Click += new System.EventHandler(this.btnTinhtrangphong_Click);
            // 
            // TenPhong
            // 
            this.TenPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // TinhTrangPhong
            // 
            this.TinhTrangPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrangPhong.DataPropertyName = "TinhTrangPhong";
            this.TinhTrangPhong.HeaderText = "Tình trạng phòng";
            this.TinhTrangPhong.Name = "TinhTrangPhong";
            // 
            // frmTinhtrangphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 492);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTinhtrangphong";
            this.Text = "Tình trạng phòng";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.ButtonX btnTinhtrangphong;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbTinhtrangphong;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenphong;
        private DevComponents.DotNetBar.LabelX labelX2;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.ButtonX btnTimkiem;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiatri;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrangPhong;
    }
}