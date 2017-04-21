namespace QLNHDN
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
            this.txtTenDangNhap_DN = new System.Windows.Forms.TextBox();
            this.txtMatKhau_DN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangNhap_DN = new System.Windows.Forms.Button();
            this.btnThoat_DN = new System.Windows.Forms.Button();
            this.lbBaoLoi_DN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTenDangNhap_DN
            // 
            this.txtTenDangNhap_DN.Location = new System.Drawing.Point(100, 69);
            this.txtTenDangNhap_DN.Name = "txtTenDangNhap_DN";
            this.txtTenDangNhap_DN.Size = new System.Drawing.Size(191, 20);
            this.txtTenDangNhap_DN.TabIndex = 0;
            this.txtTenDangNhap_DN.Leave += new System.EventHandler(this.txtTenDangNhap_DN_Leave);
            // 
            // txtMatKhau_DN
            // 
            this.txtMatKhau_DN.Location = new System.Drawing.Point(100, 110);
            this.txtMatKhau_DN.Name = "txtMatKhau_DN";
            this.txtMatKhau_DN.Size = new System.Drawing.Size(191, 20);
            this.txtMatKhau_DN.TabIndex = 1;
            this.txtMatKhau_DN.UseSystemPasswordChar = true;
            this.txtMatKhau_DN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_DN_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu:";
            // 
            // btnDangNhap_DN
            // 
            this.btnDangNhap_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap_DN.Location = new System.Drawing.Point(100, 160);
            this.btnDangNhap_DN.Name = "btnDangNhap_DN";
            this.btnDangNhap_DN.Size = new System.Drawing.Size(106, 32);
            this.btnDangNhap_DN.TabIndex = 4;
            this.btnDangNhap_DN.Text = "Đăng nhập";
            this.btnDangNhap_DN.UseVisualStyleBackColor = true;
            this.btnDangNhap_DN.Click += new System.EventHandler(this.btnDangNhap_DN_Click);
            // 
            // btnThoat_DN
            // 
            this.btnThoat_DN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_DN.Location = new System.Drawing.Point(217, 160);
            this.btnThoat_DN.Name = "btnThoat_DN";
            this.btnThoat_DN.Size = new System.Drawing.Size(74, 32);
            this.btnThoat_DN.TabIndex = 5;
            this.btnThoat_DN.Text = "Thoát";
            this.btnThoat_DN.UseVisualStyleBackColor = true;
            this.btnThoat_DN.Click += new System.EventHandler(this.btnThoat_DN_Click);
            // 
            // lbBaoLoi_DN
            // 
            this.lbBaoLoi_DN.AutoSize = true;
            this.lbBaoLoi_DN.ForeColor = System.Drawing.Color.Red;
            this.lbBaoLoi_DN.Location = new System.Drawing.Point(12, 144);
            this.lbBaoLoi_DN.Name = "lbBaoLoi_DN";
            this.lbBaoLoi_DN.Size = new System.Drawing.Size(0, 13);
            this.lbBaoLoi_DN.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(79, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 31);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Đăng nhập";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 203);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbBaoLoi_DN);
            this.Controls.Add(this.btnThoat_DN);
            this.Controls.Add(this.btnDangNhap_DN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhau_DN);
            this.Controls.Add(this.txtTenDangNhap_DN);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenDangNhap_DN;
        private System.Windows.Forms.TextBox txtMatKhau_DN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangNhap_DN;
        private System.Windows.Forms.Button btnThoat_DN;
        private System.Windows.Forms.Label lbBaoLoi_DN;
        private System.Windows.Forms.Label lblTitle;
    }
}