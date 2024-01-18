using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace LAB3
{
    public partial class QuanLySV : Form
    {
        public QuanLySV()
        {
            InitializeComponent();
            MaNV_box.ReadOnly = true;
            Matkhau.ReadOnly = true;
            Luong.ReadOnly = true;
            Hoten.ReadOnly = true;
            TenDN_box.ReadOnly = true;
            Email_box.ReadOnly = true;
            textBox1.ReadOnly = true;
        }


        public class AESOperation
        {
            public static string key = "19127424000000000000000000000000";

            public static string EncryptString(string plainText)
            {
                byte[] iv = new byte[16];
                byte[] array;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = iv;

                    ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                            {
                                streamWriter.Write(plainText);
                            }

                            array = memoryStream.ToArray();
                        }
                    }
                }

                return Convert.ToBase64String(array);
            }
            public static string DecryptString(string cipherText)
            {
                byte[] iv = new byte[16];
                byte[] buffer = Convert.FromBase64String(cipherText);

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key);
                    aes.IV = iv;
                    ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                    using (MemoryStream memoryStream = new MemoryStream(buffer))
                    {
                        using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                        {
                            using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                            {
                                return streamReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
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
        /*
        static string EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return Convert.ToBase64String(encrypted);
        }
        static string DecryptStringFromBytes_Aes(string cipher, byte[] Key, byte[] IV)
        {

            byte[] cipherText = Convert.FromBase64String(cipher);
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }
        */


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=QUY\MSSQLSERVER01;Initial Catalog=QLSV;Integrated Security=True");
            //string qr = "SELECT MANV,HOTEN,EMAIL FROM NHANVIEN";
            string qr = "EXEC SP_SEL_ENCRYPT_NHANVIEN";
            SqlDataAdapter sda = new SqlDataAdapter(qr, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Aes myAes = Aes.Create();
            for(int i = 0; i < dt.Rows.Count;i++)
            {
                dt.Rows[i]["LUONG"] = AESOperation.DecryptString(dt.Rows[i]["LUONG"].ToString());
            }

            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=QUY\MSSQLSERVER01;Initial Catalog=QLSVNhom;Integrated Security=True");
            //string qr = "UPDATE SINHVIEN SET HOTEN = '" + dataGridView1.CurrentRow.Cells[dataGridView1.Columns["HOTEN"].Index].Value + "', NGAYSINH = '" + dataGridView1.CurrentRow.Cells[dataGridView1.Columns["NGAYSINH"].Index].Value + "', DIACHI = '" + dataGridView1.CurrentRow.Cells[dataGridView1.Columns["DIACHI"].Index].Value + "'WHERE = '" + dataGridView1.CurrentRow.Cells[dataGridView1.Columns["MASV"].Index].Value + "'";
           
            //SqlCommand cmd = new SqlCommand(qr, con);

            //foreach (DataGridViewColumn dc in dataGridView1.Columns) 
            //{
            //    if (dc.Index.Equals(0))
            //    {
            //        dc.ReadOnly = true;
            //    }
            //    else
            //    {
            //        dc.ReadOnly = false;
            //    }
            //}

            //cmd.ExecuteNonQuery();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aes myAes = Aes.Create();
         
            SqlConnection con = new SqlConnection(@"Data Source=QUY\MSSQLSERVER01;Initial Catalog=QLSV;Integrated Security=True");

           string qr = "EXEC SP_INS_ENCRYPT_NHANVIEN '" + nhapmanv.Text + "','" + nhaphoten.Text + "','" + nhapemail.Text + "','" + AESOperation.EncryptString(nhapluong.Text) + "','" + nhaptendangnhap.Text + "','" + Hash_sha1(nhapmatkhau.Text) + "'";
            //Gui du lieu cho sql server
            SqlDataAdapter sda = new SqlDataAdapter(qr, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MessageBox.Show("Thêm nhân viên thành công");
            nhapemail.Text = "";
            nhaphoten.Text = "";
            nhapluong.Text = "";
            nhapmanv.Text = "";
            nhapmatkhau.Text = "";
            nhaptendangnhap.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mục này chưa làm");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mục này chưa làm");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MaNV_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Email_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TenDN_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Luong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Matkhau_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginScr login = new LoginScr();
            login.ShowDialog();
        }
        private void nhapmanv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mục này chưa làm");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mục này chưa làm");
        }
    }
}
