using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA256_SHA384__SHA512
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "SHA256":
                    label1.Text = sha256(textBox1.Text);
                    break;

                case "SHA384":
                    label1.Text = sha384(textBox1.Text);
                    break;

                case "SHA512":
                    label1.Text = sha512(textBox1.Text);
                    break;
                default:
                    MessageBox.Show("Select any options in the combobox", "Program", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;


            }
        }
        private string sha256(string text)
            
        {
            SHA256 sha256Encrypnting = new SHA256CryptoServiceProvider();
            byte[] bytes=sha256Encrypnting.ComputeHash(Encoding.UTF8.GetBytes(text.ToCharArray()));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }
        private string sha384(string text)

        {
            SHA384 sha384Encrypnting = new SHA384CryptoServiceProvider();
            byte[] bytes = sha384Encrypnting.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }
        private string sha512(string text)

        {
            SHA512 sha512Encrypnting = new SHA512CryptoServiceProvider();
            byte[] bytes = sha512Encrypnting.ComputeHash(Encoding.UTF8.GetBytes(text.ToCharArray()));
            StringBuilder builder = new StringBuilder();
            foreach (var item in bytes)
            {
                builder.Append(item.ToString("x2"));
            }
            return builder.ToString();
        }

    }
}
