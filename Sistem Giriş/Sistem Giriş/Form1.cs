using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Giriş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici;
            kullanici = textBox1.Text;
            if (kullanici == "Muhammed Kerem Doğmuş")
            {
                MessageBox.Show("Sisteme kayıtlısınız");
            }
            else 
            {
                MessageBox.Show("Sisteme kayıtlı Değilsiniz");
            }
        }
    }
}
