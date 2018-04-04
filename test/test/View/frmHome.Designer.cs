namespace test.View
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnBaocao = new DevComponents.DotNetBar.ButtonX();
            this.btnDatphong = new DevComponents.DotNetBar.ButtonX();
            this.btnKhachsan = new DevComponents.DotNetBar.ButtonX();
            this.btnNhanvien = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
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
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 446);
            this.splitContainer1.SplitterDistance = 738;
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
            this.splitContainer2.Panel1.Controls.Add(this.labelX4);
            this.splitContainer2.Panel1.Controls.Add(this.labelX3);
            this.splitContainer2.Panel1.Controls.Add(this.labelX2);
            this.splitContainer2.Panel1.Controls.Add(this.labelX1);
            this.splitContainer2.Panel1.Controls.Add(this.btnBaocao);
            this.splitContainer2.Panel1.Controls.Add(this.btnDatphong);
            this.splitContainer2.Panel1.Controls.Add(this.btnKhachsan);
            this.splitContainer2.Panel1.Controls.Add(this.btnNhanvien);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.labelX5);
            this.splitContainer2.Size = new System.Drawing.Size(284, 446);
            this.splitContainer2.SplitterDistance = 363;
            this.splitContainer2.TabIndex = 0;
            // 
            // labelX4
            // 
            this.labelX4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Location = new System.Drawing.Point(147, 323);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(125, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Thanh toán";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Red;
            this.labelX3.Location = new System.Drawing.Point(13, 325);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(124, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Đặt phòng";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Red;
            this.labelX2.Location = new System.Drawing.Point(146, 159);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(126, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "Khách sạn";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Red;
            this.labelX1.Location = new System.Drawing.Point(13, 159);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(128, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Sử dụng dịch vụ";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnBaocao
            // 
            this.btnBaocao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBaocao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaocao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBaocao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaocao.Image")));
            this.btnBaocao.ImageFixedSize = new System.Drawing.Size(126, 119);
            this.btnBaocao.Location = new System.Drawing.Point(146, 198);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(126, 119);
            this.btnBaocao.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBaocao.TabIndex = 3;
            // 
            // btnDatphong
            // 
            this.btnDatphong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDatphong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDatphong.Image = ((System.Drawing.Image)(resources.GetObject("btnDatphong.Image")));
            this.btnDatphong.ImageFixedSize = new System.Drawing.Size(124, 119);
            this.btnDatphong.Location = new System.Drawing.Point(13, 198);
            this.btnDatphong.Name = "btnDatphong";
            this.btnDatphong.Size = new System.Drawing.Size(124, 119);
            this.btnDatphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDatphong.TabIndex = 2;
            this.btnDatphong.Click += new System.EventHandler(this.btnDatphong_Click);
            // 
            // btnKhachsan
            // 
            this.btnKhachsan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnKhachsan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKhachsan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnKhachsan.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachsan.Image")));
            this.btnKhachsan.ImageFixedSize = new System.Drawing.Size(125, 120);
            this.btnKhachsan.Location = new System.Drawing.Point(147, 33);
            this.btnKhachsan.Name = "btnKhachsan";
            this.btnKhachsan.Size = new System.Drawing.Size(125, 120);
            this.btnKhachsan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnKhachsan.TabIndex = 1;
            this.btnKhachsan.Click += new System.EventHandler(this.btnKhachsan_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNhanvien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.Image")));
            this.btnNhanvien.ImageFixedSize = new System.Drawing.Size(128, 120);
            this.btnNhanvien.Location = new System.Drawing.Point(13, 33);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(128, 120);
            this.btnNhanvien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNhanvien.TabIndex = 0;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // labelX5
            // 
            this.labelX5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Red;
            this.labelX5.Location = new System.Drawing.Point(13, 28);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(259, 23);
            this.labelX5.TabIndex = 7;
            this.labelX5.Text = "Quản lý chung hệ thống khách sạn";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 446);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmHome";
            this.Text = "Home";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnBaocao;
        private DevComponents.DotNetBar.ButtonX btnDatphong;
        private DevComponents.DotNetBar.ButtonX btnKhachsan;
        private DevComponents.DotNetBar.ButtonX btnNhanvien;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}