using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;






namespace PANSİYON_OTEL
{
    public partial class FrmYenimusteri : Form
    {
        public FrmYenimusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection("Data Source=LAPTOP-8AQVKO8P\\MERT;Initial Catalog=KizilayPansiyon;Integrated Security=True");
        
        
        private void button2_Click(object sender, EventArgs e)
        {
            txtodano.Text = "101";
            baglanti.Open();
            SqlCommand komut=new SqlCommand("insert into Oda101(Adi,Soyadi) values ('"+ txtAdi.Text+"','"+txtsoyad.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            txtodano.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda102(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            txtodano.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda103(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            txtodano.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda106(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            txtodano.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda105(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            txtodano.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda104(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            txtodano.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda107(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            txtodano.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda108(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            txtodano.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda109(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda112_Click(object sender, EventArgs e)
        {
            txtodano.Text = "112";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda112(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda111_Click(object sender, EventArgs e)
        {
            txtodano.Text = "111";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda111(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btnoda110_Click(object sender, EventArgs e)
        {
            txtodano.Text = "110";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Oda110(Adi,Soyadi) values ('" + txtAdi.Text + "','" + txtsoyad.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BOŞ ODALAR YEŞİL RENK İLE GÖSTERİLMEKTEDİR");
        }

        private void btndolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DOLU ODALAR KIRMIZI RENK İLE GÖSTERİLMEKTEDİR");

        }

        private void dtpcikistarh_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih=Convert.ToDateTime(dtpgiristarh.Text);
            DateTime buyuktarih=Convert.ToDateTime(dtpcikistarh.Text);
            TimeSpan sonuc;
            sonuc = buyuktarih - kucuktarih;
            label2.Text=sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(label2.Text) * 50;
            txtucret.Text=ucret.ToString();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Müsterikayit (ad,soyad,telefon,mail,tc,odano,ücret,giris,çıkıs) values('" + txtAdi.Text + "','" + txtsoyad.Text + "','" + msktxtno.Text + "','" + txtmaıl.Text + "','" + txttc.Text + "','" + txtodano.Text + "','" + txtucret.Text + "','" + dtpgiristarh.Value.ToString("yyyy-MM-dd") + "','" + dtpcikistarh.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            //SqlCommand komut = new SqlCommand("insert into Müsterikayit (ad,soyad,telefon,mail,tc,odano,ücret,giris,çıkıs) values('" + txtAdi.Text + "','" + txtsoyad.Text + "','" + msktxtno.Text + "','" + txtmaıl.Text + "','" + txttc.Text + "','" + txtodano.Text + "','" + txtucret.Text + "','" + dtpgiristarh.Value.ToString("yyyy-MM-dd") + "','" + dtpcikistarh.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            MessageBox.Show("Kayıt Başarı İle Yapıldı");
        }

        private void msktxtno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtucret_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmYenimusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnoda101.Text = oku1["Adi"].ToString() + " " + oku1["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
                btnoda101.Enabled = false;
            }
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnoda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda102.Text != "102")
            {
                btnoda102.BackColor = Color.Red;
                btnoda102.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnoda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda103.Text != "103")
            {
                btnoda103.Enabled = false;
                btnoda103.BackColor = Color.Red;
            }
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnoda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda104.Text != "104")
            {
                btnoda104.BackColor = Color.Red;
                btnoda104.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from Oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnoda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda105.Text != "105")
            {
                btnoda105.BackColor = Color.Red;
                btnoda105.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from Oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnoda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda106.Text != "106")
            {
                btnoda106.BackColor = Color.Red;
                btnoda106.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from Oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnoda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda107.Text != "107")
            {
                btnoda107.BackColor = Color.Red;
                btnoda107.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from Oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnoda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda108.Text != "108")
            {
                btnoda108.BackColor = Color.Red;
                btnoda108.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from Oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();
            while (oku9.Read())
            {
                btnoda109.Text = oku9["Adi"].ToString() + " " + oku9["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda109.Text != "109")
            {
                btnoda109.BackColor = Color.Red;
                btnoda109.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut10 = new SqlCommand("select * from Oda110", baglanti);
            SqlDataReader oku10 = komut10.ExecuteReader();
            while (oku10.Read())
            {
                btnoda110.Text = oku10["Adi"].ToString() + " " + oku10["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda110.Text != "110")
            {
                btnoda110.BackColor = Color.Red;
                btnoda110.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut11 = new SqlCommand("select * from Oda111", baglanti);
            SqlDataReader oku11 = komut11.ExecuteReader();
            while (oku11.Read())
            {
                btnoda101.Text = oku11["Adi"].ToString() + " " + oku11["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda111.Text != "111")
            {
                btnoda111.BackColor = Color.Red;
                btnoda111.Enabled = false;

            }
            baglanti.Open();
            SqlCommand komut12 = new SqlCommand("select * from Oda112", baglanti);
            SqlDataReader oku12 = komut12.ExecuteReader();
            while (oku12.Read())
            {
                btnoda101.Text = oku12["Adi"].ToString() + " " + oku12["Soyadi"].ToString();

            }
            baglanti.Close();

            if (btnoda112.Text != "112")
            {
                btnoda112.BackColor = Color.Red;
                btnoda112.Enabled = false;

            }
        }
    }
}
//Data Source=LAPTOP-8AQVKO8P\MERT;Initial Catalog=KizilayPansiyon;Integrated Security=True
//Data Source=LAPTOP-8AQVKO8P\MERT;Initial Catalog=KizilayPansiyon;Integrated Security=True
