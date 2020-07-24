namespace CuoiKy.GUI
{
    partial class frmNhanVien
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
            this.groupBoxThongTinChung = new System.Windows.Forms.GroupBox();
            this.groupBoxThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.groupBoxThongTinNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxThongTinChung
            // 
            this.groupBoxThongTinChung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTinChung.BackColor = System.Drawing.Color.Blue;
            this.groupBoxThongTinChung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTinChung.Location = new System.Drawing.Point(0, 445);
            this.groupBoxThongTinChung.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxThongTinChung.Name = "groupBoxThongTinChung";
            this.groupBoxThongTinChung.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxThongTinChung.Size = new System.Drawing.Size(1232, 442);
            this.groupBoxThongTinChung.TabIndex = 0;
            this.groupBoxThongTinChung.TabStop = false;
            this.groupBoxThongTinChung.Text = "Thông tin chung";
            this.groupBoxThongTinChung.Enter += new System.EventHandler(this.groupBoxThongTinChung_Enter);
            // 
            // groupBoxThongTinNhanVien
            // 
            this.groupBoxThongTinNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTinNhanVien.BackColor = System.Drawing.Color.Red;
            this.groupBoxThongTinNhanVien.Controls.Add(this.panel1);
            this.groupBoxThongTinNhanVien.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTinNhanVien.Location = new System.Drawing.Point(0, 81);
            this.groupBoxThongTinNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxThongTinNhanVien.Name = "groupBoxThongTinNhanVien";
            this.groupBoxThongTinNhanVien.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxThongTinNhanVien.Size = new System.Drawing.Size(1232, 359);
            this.groupBoxThongTinNhanVien.TabIndex = 0;
            this.groupBoxThongTinNhanVien.TabStop = false;
            this.groupBoxThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 69);
            this.panel1.TabIndex = 0;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Location = new System.Drawing.Point(379, 1);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(538, 73);
            this.lblNhanVien.TabIndex = 1;
            this.lblNhanVien.Text = "Quản lý nhân viên";
            // 
            // frmNhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1232, 887);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.groupBoxThongTinChung);
            this.Controls.Add(this.groupBoxThongTinNhanVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.groupBoxThongTinNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxThongTinChung;
        private System.Windows.Forms.GroupBox groupBoxThongTinNhanVien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNhanVien;
    }
}