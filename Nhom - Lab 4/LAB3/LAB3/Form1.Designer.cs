
namespace LAB3
{
    partial class LoginScr
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TenDN = new System.Windows.Forms.Label();
            this.MatKhau = new System.Windows.Forms.Label();
            this.DienTenDN = new System.Windows.Forms.TextBox();
            this.DienMK = new System.Windows.Forms.TextBox();
            this.DangNhap = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TenDN
            // 
            this.TenDN.AutoSize = true;
            this.TenDN.Location = new System.Drawing.Point(65, 135);
            this.TenDN.Name = "TenDN";
            this.TenDN.Size = new System.Drawing.Size(107, 20);
            this.TenDN.TabIndex = 0;
            this.TenDN.Text = "Tên đăng nhập";
            this.TenDN.Click += new System.EventHandler(this.label1_Click);
            // 
            // MatKhau
            // 
            this.MatKhau.AutoSize = true;
            this.MatKhau.Location = new System.Drawing.Point(65, 210);
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Size = new System.Drawing.Size(70, 20);
            this.MatKhau.TabIndex = 1;
            this.MatKhau.Text = "Mật khẩu";
            this.MatKhau.Click += new System.EventHandler(this.label2_Click);
            // 
            // DienTenDN
            // 
            this.DienTenDN.Location = new System.Drawing.Point(178, 135);
            this.DienTenDN.Name = "DienTenDN";
            this.DienTenDN.Size = new System.Drawing.Size(261, 27);
            this.DienTenDN.TabIndex = 2;
            this.DienTenDN.TextChanged += new System.EventHandler(this.DienTenDN_TextChanged);
            // 
            // DienMK
            // 
            this.DienMK.Location = new System.Drawing.Point(178, 210);
            this.DienMK.Name = "DienMK";
            this.DienMK.Size = new System.Drawing.Size(261, 27);
            this.DienMK.TabIndex = 3;
            this.DienMK.UseSystemPasswordChar = true;
            // 
            // DangNhap
            // 
            this.DangNhap.Location = new System.Drawing.Point(178, 278);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(94, 29);
            this.DangNhap.TabIndex = 4;
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.UseVisualStyleBackColor = true;
            this.DangNhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(279, 277);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(94, 29);
            this.Thoat.TabIndex = 5;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // LoginScr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 382);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.DienMK);
            this.Controls.Add(this.DienTenDN);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.TenDN);
            this.Name = "LoginScr";
            this.Text = "Màn hình đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TenDN;
        private System.Windows.Forms.Label MatKhau;
        private System.Windows.Forms.TextBox DienTenDN;
        private System.Windows.Forms.TextBox DienMK;
        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.Button Thoat;
    }
}

