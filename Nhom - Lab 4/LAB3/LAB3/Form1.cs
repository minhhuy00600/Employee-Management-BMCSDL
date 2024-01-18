using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
//using System.Data;

namespace LAB3
{
    public partial class LoginScr : Form
    {
        public LoginScr()
        {
            InitializeComponent();
        }
        static string Hash_sha1(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=QUY\MSSQLSERVER01;Initial Catalog=QLSV;Integrated Security=True");
            string tk = DienTenDN.Text.Trim();
            string mk = DienMK.Text.Trim();
            string qr = "SELECT TENDN,MATKHAU FROM NHANVIEN WHERE TENDN='" + tk + "' AND CONVERT(VARCHAR(MAX),MATKHAU)=CONVERT(VARCHAR(MAX),'" + Hash_sha1(mk) + "')";
            SqlDataAdapter sda = new SqlDataAdapter(qr, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count==1)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
                QuanLySV qlsv = new QuanLySV();
                qlsv.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DienTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
