namespace test.View
{
    partial class frmThemphong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLoaiphong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtGiaphong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTenphong = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnOk = new DevComponents.DotNetBar.ButtonX();
            this.lbMaks = new DevComponents.DotNetBar.LabelX();
            this.txtMaks = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaks);
            this.groupBox1.Controls.Add(this.cbLoaiphong);
            this.groupBox1.Controls.Add(this.lbMaks);
            this.groupBox1.Controls.Add(this.txtGiaphong);
            this.groupBox1.Controls.Add(this.labelX5);
            this.groupBox1.Controls.Add(this.txtTenphong);
            this.groupBox1.Controls.Add(this.labelX4);
            this.groupBox1.Controls.Add(this.labelX3);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 265);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng khách sạn";
            // 
            // cbLoaiphong
            // 
            this.cbLoaiphong.DisplayMember = "Text";
            this.cbLoaiphong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiphong.FormattingEnabled = true;
            this.cbLoaiphong.ItemHeight = 16;
            this.cbLoaiphong.Location = new System.Drawing.Point(96, 95);
            this.cbLoaiphong.Name = "cbLoaiphong";
            this.cbLoaiphong.Size = new System.Drawing.Size(135, 22);
            this.cbLoaiphong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbLoaiphong.TabIndex = 46;
            this.cbLoaiphong.TextChanged += new System.EventHandler(this.cbLoaiphong_TextChanged);
            // 
            // txtGiaphong
            // 
            // 
            // 
            // 
            this.txtGiaphong.Border.Class = "TextBoxBorder";
            this.txtGiaphong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtGiaphong.Enabled = false;
            this.txtGiaphong.Location = new System.Drawing.Point(96, 158);
            this.txtGiaphong.Name = "txtGiaphong";
            this.txtGiaphong.PreventEnterBeep = true;
            this.txtGiaphong.Size = new System.Drawing.Size(135, 21);
            this.txtGiaphong.TabIndex = 45;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(14, 156);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 43;
            this.labelX5.Text = "Giá phòng";
            // 
            // txtTenphong
            // 
            // 
            // 
            // 
            this.txtTenphong.Border.Class = "TextBoxBorder";
            this.txtTenphong.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTenphong.Location = new System.Drawing.Point(96, 32);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.PreventEnterBeep = true;
            this.txtTenphong.Size = new System.Drawing.Size(135, 21);
            this.txtTenphong.TabIndex = 42;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(14, 94);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 44;
            this.labelX4.Text = "Loại phòng";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(14, 30);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 41;
            this.labelX3.Text = "Tên phòng";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(180, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnOk.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(73, 294);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnOk.TabIndex = 28;
            this.btnOk.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbMaks
            // 
            // 
            // 
            // 
            this.lbMaks.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMaks.Location = new System.Drawing.Point(14, 209);
            this.lbMaks.Name = "lbMaks";
            this.lbMaks.Size = new System.Drawing.Size(75, 23);
            this.lbMaks.TabIndex = 44;
            this.lbMaks.Text = "Mã khách sạn";
            // 
            // txtMaks
            // 
            this.txtMaks.DisplayMember = "Text";
            this.txtMaks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMaks.FormattingEnabled = true;
            this.txtMaks.ItemHeight = 16;
            this.txtMaks.Location = new System.Drawing.Point(96, 210);
            this.txtMaks.Name = "txtMaks";
            this.txtMaks.Size = new System.Drawing.Size(135, 22);
            this.txtMaks.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txtMaks.TabIndex = 47;
            // 
            // frmThemphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 329);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "frmThemphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phòng khách sạn";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnOk;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbLoaiphong;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGiaphong;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenphong;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbMaks;
        private DevComponents.DotNetBar.Controls.ComboBoxEx txtMaks;
    }
}