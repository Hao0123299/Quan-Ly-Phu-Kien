namespace CuoiKy.GUI
{
    partial class frmLogin
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
            this.lblDangNhap = new System.Windows.Forms.Label();
            this.labTaiKhoan = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.Label();
            this.txtTàiKhoan = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblDangNhap.Location = new System.Drawing.Point(136, 9);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(99, 22);
            this.lblDangNhap.TabIndex = 0;
            this.lblDangNhap.Text = "Đăng nhập";
            this.lblDangNhap.UseWaitCursor = true;
            // 
            // labTaiKhoan
            // 
            this.labTaiKhoan.AutoSize = true;
            this.labTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTaiKhoan.Location = new System.Drawing.Point(13, 49);
            this.labTaiKhoan.Name = "labTaiKhoan";
            this.labTaiKhoan.Size = new System.Drawing.Size(94, 22);
            this.labTaiKhoan.TabIndex = 0;
            this.labTaiKhoan.Text = "Tài khoản";
            this.labTaiKhoan.UseWaitCursor = true;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoSize = true;
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(13, 97);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(99, 22);
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.Text = "Đăng nhập";
            // 
            // txtTàiKhoan
            // 
            this.txtTàiKhoan.Location = new System.Drawing.Point(153, 50);
            this.txtTàiKhoan.Name = "txtTàiKhoan";
            this.txtTàiKhoan.Size = new System.Drawing.Size(197, 21);
            this.txtTàiKhoan.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(197, 21);
            this.textBox2.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangNhap.Location = new System.Drawing.Point(17, 143);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(333, 37);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(367, 245);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTàiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.labTaiKhoan);
            this.Controls.Add(this.lblDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangNhap;
        private System.Windows.Forms.Label labTaiKhoan;
        private System.Windows.Forms.Label txtMatKhau;
        private System.Windows.Forms.TextBox txtTàiKhoan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDangNhap;
    }
}