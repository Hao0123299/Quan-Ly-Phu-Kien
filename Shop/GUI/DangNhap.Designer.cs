namespace GUI
{
    partial class frmDangNhap
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
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.hLCDangKy = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.chEMatKhau = new DevExpress.XtraEditors.CheckEdit();
            this.txtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.txtDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.lblHoi = new DevExpress.XtraEditors.LabelControl();
            this.lblMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.lblTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.lblDangNhap = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chEMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDangNhap.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(446, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(303, 275);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
            this.btnDangNhap.TabIndex = 34;
            this.btnDangNhap.Text = "Đăng nhập";
            // 
            // hLCDangKy
            // 
            this.hLCDangKy.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.hLCDangKy.Appearance.Options.UseFont = true;
            this.hLCDangKy.Location = new System.Drawing.Point(376, 230);
            this.hLCDangKy.Name = "hLCDangKy";
            this.hLCDangKy.Size = new System.Drawing.Size(49, 16);
            this.hLCDangKy.TabIndex = 32;
            this.hLCDangKy.Text = "Đăng ký";
            // 
            // chEMatKhau
            // 
            this.chEMatKhau.Location = new System.Drawing.Point(500, 226);
            this.chEMatKhau.Name = "chEMatKhau";
            this.chEMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chEMatKhau.Properties.Appearance.Options.UseFont = true;
            this.chEMatKhau.Properties.Caption = "Nhớ mật khẩu";
            this.chEMatKhau.Size = new System.Drawing.Size(103, 21);
            this.chEMatKhau.TabIndex = 33;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(340, 159);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Properties.UseSystemPasswordChar = true;
            this.txtMatKhau.Size = new System.Drawing.Size(243, 20);
            this.txtMatKhau.TabIndex = 31;
            this.txtMatKhau.UseWaitCursor = true;
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.Location = new System.Drawing.Point(340, 120);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(243, 20);
            this.txtDangNhap.TabIndex = 30;
            // 
            // lblHoi
            // 
            this.lblHoi.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoi.Appearance.Options.UseFont = true;
            this.lblHoi.Location = new System.Drawing.Point(200, 231);
            this.lblHoi.Name = "lblHoi";
            this.lblHoi.Size = new System.Drawing.Size(130, 17);
            this.lblHoi.TabIndex = 26;
            this.lblHoi.Text = "Bạn dã có tài khản ?";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Appearance.Options.UseFont = true;
            this.lblMatKhau.Location = new System.Drawing.Point(200, 164);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(58, 17);
            this.lblMatKhau.TabIndex = 27;
            this.lblMatKhau.Text = "Mật khẩu";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDangNhap.Appearance.Options.UseFont = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(200, 125);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(97, 17);
            this.lblTenDangNhap.TabIndex = 28;
            this.lblTenDangNhap.Text = "Tên đăng nhập";
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.Appearance.Options.UseFont = true;
            this.lblDangNhap.Location = new System.Drawing.Point(376, 67);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(132, 31);
            this.lblDangNhap.TabIndex = 29;
            this.lblDangNhap.Text = "Đăng nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 365);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.hLCDangKy);
            this.Controls.Add(this.chEMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtDangNhap);
            this.Controls.Add(this.lblHoi);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblDangNhap);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.chEMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDangNhap.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.HyperlinkLabelControl hLCDangKy;
        private DevExpress.XtraEditors.CheckEdit chEMatKhau;
        private DevExpress.XtraEditors.TextEdit txtMatKhau;
        private DevExpress.XtraEditors.TextEdit txtDangNhap;
        private DevExpress.XtraEditors.LabelControl lblHoi;
        private DevExpress.XtraEditors.LabelControl lblMatKhau;
        private DevExpress.XtraEditors.LabelControl lblTenDangNhap;
        private DevExpress.XtraEditors.LabelControl lblDangNhap;
    }
}