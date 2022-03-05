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
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            Form1 fr=new Form1();
            fr.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYenimusteri fr =new FrmYenimusteri();
            fr.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmodalar fr    =new Frmodalar();
            fr.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Musteriler fr=new Musteriler();
            fr.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KIZILAY PANSİYON / 2022 ANKARA");
        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Müzik fr=new Müzik();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr=new Form2();
            fr.Show();
        }
    }
}
