using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANSİYON_OTEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnkulgiriş_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            {
                FrmAnaEkran fr = new FrmAnaEkran();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KULLANICI ADI VEYA ŞİFRE HATALI");
            }
        }

        private void txtsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkuladı_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}