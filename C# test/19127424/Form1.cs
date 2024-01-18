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

namespace _19127424
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=QUY;Initial Catalog=QLSV;Integrated Security=True"); // making connection
           
            string tk = textBox1.Text.Trim();
            string mk = txtPass.Text.Trim();
            string qr = "SELECT TENDN,MATKHAU FROM SINHVIEN WHERE TENDN='" + tk + "' AND CONVERT(VARCHAR(MAX),MATKHAU,2)=CONVERT(VARCHAR(MAX),HASHBYTES('MD5','" + mk + "'),2)";
           
            SqlDataAdapter sda = new SqlDataAdapter(qr, con);
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Successfully login");
            }
            else
            {
                qr = "SELECT TENDN,MATKHAU FROM NHANVIEN WHERE TENDN='" + tk + "' AND CONVERT(VARCHAR(MAX),MATKHAU,2)=CONVERT(VARCHAR(MAX),HASHBYTES('SHA1','" + mk + "'),2)";
                sda.SelectCommand.CommandText = qr;
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Succesfully");
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e)
        {
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Hide password
            txtPass.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;     
            }
            else txtPass.UseSystemPasswordChar = true;
        }
    }
}
