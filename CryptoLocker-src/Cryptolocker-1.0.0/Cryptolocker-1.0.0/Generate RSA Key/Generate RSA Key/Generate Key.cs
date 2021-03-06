using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Generate_RSA_Key
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int key = Convert.ToInt32(comboBox1.SelectedItem);

            RSA rsa = new RSACryptoServiceProvider(key);

            string publicPrivateKeyXML = rsa.ToXmlString(true);
            string publicOnlyKeyXML = rsa.ToXmlString(false);

            richTextBox1.Text = publicOnlyKeyXML;
            richTextBox2.Text = publicPrivateKeyXML;


        }
    }
}
