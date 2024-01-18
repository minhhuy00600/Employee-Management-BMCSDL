
namespace LAB3
{
    partial class QuanLySV
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MaNV_box = new System.Windows.Forms.TextBox();
            this.Email_box = new System.Windows.Forms.TextBox();
            this.TenDN_box = new System.Windows.Forms.TextBox();
            this.Hoten = new System.Windows.Forms.TextBox();
            this.Luong = new System.Windows.Forms.TextBox();
            this.Matkhau = new System.Windows.Forms.TextBox();
            this.nhapmanv = new System.Windows.Forms.TextBox();
            this.nhaphoten = new System.Windows.Forms.TextBox();
            this.nhapluong = new System.Windows.Forms.TextBox();
            this.nhapmatkhau = new System.Windows.Forms.TextBox();
            this.nhaptendangnhap = new System.Windows.Forms.TextBox();
            this.nhapemail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(789, 156);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Hiện tên";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 410);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "Ghi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(591, 410);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "Không";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(124, 410);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(94, 29);
            this.button7.TabIndex = 7;
            this.button7.Text = "Xóa";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(704, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 8;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(256, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 52);
            this.textBox1.TabIndex = 9;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Danh mục nhân viên";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MaNV_box
            // 
            this.MaNV_box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaNV_box.Location = new System.Drawing.Point(22, 77);
            this.MaNV_box.Name = "MaNV_box";
            this.MaNV_box.Size = new System.Drawing.Size(125, 27);
            this.MaNV_box.TabIndex = 10;
            this.MaNV_box.Text = "Mã NV";
            this.MaNV_box.TextChanged += new System.EventHandler(this.MaNV_box_TextChanged);
            // 
            // Email_box
            // 
            this.Email_box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email_box.Location = new System.Drawing.Point(22, 110);
            this.Email_box.Name = "Email_box";
            this.Email_box.Size = new System.Drawing.Size(125, 27);
            this.Email_box.TabIndex = 11;
            this.Email_box.Text = "Email";
            this.Email_box.TextChanged += new System.EventHandler(this.Email_box_TextChanged);
            // 
            // TenDN_box
            // 
            this.TenDN_box.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TenDN_box.Location = new System.Drawing.Point(22, 144);
            this.TenDN_box.Name = "TenDN_box";
            this.TenDN_box.Size = new System.Drawing.Size(125, 27);
            this.TenDN_box.TabIndex = 12;
            this.TenDN_box.Text = "Tên đăng nhập";
            this.TenDN_box.TextChanged += new System.EventHandler(this.TenDN_box_TextChanged);
            // 
            // Hoten
            // 
            this.Hoten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Hoten.Location = new System.Drawing.Point(376, 77);
            this.Hoten.Name = "Hoten";
            this.Hoten.Size = new System.Drawing.Size(125, 27);
            this.Hoten.TabIndex = 13;
            this.Hoten.Text = "Họ tên";
            this.Hoten.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Luong
            // 
            this.Luong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Luong.Location = new System.Drawing.Point(376, 111);
            this.Luong.Name = "Luong";
            this.Luong.Size = new System.Drawing.Size(125, 27);
            this.Luong.TabIndex = 14;
            this.Luong.Text = "Lương";
            this.Luong.TextChanged += new System.EventHandler(this.Luong_TextChanged);
            // 
            // Matkhau
            // 
            this.Matkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Matkhau.Location = new System.Drawing.Point(376, 144);
            this.Matkhau.Name = "Matkhau";
            this.Matkhau.Size = new System.Drawing.Size(125, 27);
            this.Matkhau.TabIndex = 15;
            this.Matkhau.Text = "Mật khẩu";
            this.Matkhau.TextChanged += new System.EventHandler(this.Matkhau_TextChanged);
            // 
            // nhapmanv
            // 
            this.nhapmanv.Location = new System.Drawing.Point(162, 77);
            this.nhapmanv.Name = "nhapmanv";
            this.nhapmanv.Size = new System.Drawing.Size(187, 27);
            this.nhapmanv.TabIndex = 16;
            this.nhapmanv.TextChanged += new System.EventHandler(this.nhapmanv_TextChanged);
            // 
            // nhaphoten
            // 
            this.nhaphoten.Location = new System.Drawing.Point(523, 77);
            this.nhaphoten.Name = "nhaphoten";
            this.nhaphoten.Size = new System.Drawing.Size(275, 27);
            this.nhaphoten.TabIndex = 17;
            // 
            // nhapluong
            // 
            this.nhapluong.Location = new System.Drawing.Point(523, 110);
            this.nhapluong.Name = "nhapluong";
            this.nhapluong.Size = new System.Drawing.Size(275, 27);
            this.nhapluong.TabIndex = 18;
            // 
            // nhapmatkhau
            // 
            this.nhapmatkhau.Location = new System.Drawing.Point(523, 143);
            this.nhapmatkhau.Name = "nhapmatkhau";
            this.nhapmatkhau.Size = new System.Drawing.Size(275, 27);
            this.nhapmatkhau.TabIndex = 19;
            // 
            // nhaptendangnhap
            // 
            this.nhaptendangnhap.Location = new System.Drawing.Point(162, 143);
            this.nhaptendangnhap.Name = "nhaptendangnhap";
            this.nhaptendangnhap.Size = new System.Drawing.Size(187, 27);
            this.nhaptendangnhap.TabIndex = 20;
            // 
            // nhapemail
            // 
            this.nhapemail.Location = new System.Drawing.Point(162, 110);
            this.nhapemail.Name = "nhapemail";
            this.nhapemail.Size = new System.Drawing.Size(187, 27);
            this.nhapemail.TabIndex = 21;
            // 
            // QuanLySV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 450);
            this.Controls.Add(this.nhapemail);
            this.Controls.Add(this.nhaptendangnhap);
            this.Controls.Add(this.nhapmatkhau);
            this.Controls.Add(this.nhapluong);
            this.Controls.Add(this.nhaphoten);
            this.Controls.Add(this.nhapmanv);
            this.Controls.Add(this.Matkhau);
            this.Controls.Add(this.Luong);
            this.Controls.Add(this.Hoten);
            this.Controls.Add(this.TenDN_box);
            this.Controls.Add(this.Email_box);
            this.Controls.Add(this.MaNV_box);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLySV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox MaNV_box;
        private System.Windows.Forms.TextBox Email_box;
        private System.Windows.Forms.TextBox TenDN_box;
        private System.Windows.Forms.TextBox Hoten;
        private System.Windows.Forms.TextBox Luong;
        private System.Windows.Forms.TextBox Matkhau;
        private System.Windows.Forms.TextBox nhaphoten;
        private System.Windows.Forms.TextBox nhapluong;
        private System.Windows.Forms.TextBox nhapmatkhau;
        private System.Windows.Forms.TextBox nhaptendangnhap;
        private System.Windows.Forms.TextBox nhapemail;
        public System.Windows.Forms.TextBox nhapmanv;
    }
}