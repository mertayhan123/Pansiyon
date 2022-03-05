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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection ("Data Source=LAPTOP-8AQVKO8P\\MERT;Initial Catalog=KizilayPansiyon;Integrated Security=True");
        public void müsterigöster()
        {
            listView1.Items.Clear();
            baglanti.Open ();
            SqlCommand komut =new SqlCommand ("select * from Müsterikayit",baglanti);
            SqlDataReader oku = komut.ExecuteReader ();
            while(oku.Read())
            {
                ListViewItem ekle=new ListViewItem();
                ekle.Text=oku["müsteriid"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ücret"].ToString());
                ekle.SubItems.Add(oku["giris"].ToString());
                ekle.SubItems.Add(oku["çıkıs"].ToString());


                listView1.Items.Add(ekle);
            }
            baglanti.Close ();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            müsterigöster();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {

        }
        int id=0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            msktxtno.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtmaıl.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txttc.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtodano.Text=listView1.SelectedItems[0].SubItems[6].Text;
            dtpgiristarh.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtpcikistarh.Text = listView1.SelectedItems[0].SubItems[9].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[7].Text;

        }

        private void btnsil_Click(object sender, EventArgs e) 
        {
            if (txtodano.Text =="101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "110")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda110", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "111")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda111", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            if (txtodano.Text == "112")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Oda112", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                müsterigöster();
            }
            
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtsoyad.Clear();
            msktxtno.Clear();
            txtmaıl.Clear();
            txttc.Clear();
            txtodano.Clear();
            dtpgiristarh.Text = "";
            dtpcikistarh.Text = "";
            txtucret.Clear();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();   
            SqlCommand komut=new SqlCommand("update Müsterikayit set ad='"+txtAdi.Text+"',soyad='"+txtsoyad.Text+"',telefon='"+msktxtno.Text+"',mail='"+txtmaıl.Text+"',tc='"+txttc.Text+"',odano='"+txtodano.Text+"',ücret='"+txtucret.Text+"',giris='"+dtpgiristarh.Value.ToString("yyyy-MM-dd")+"',çıkıs='"+dtpcikistarh.Value.ToString("yyyy-MM-dd")+"'where müsteriid="+id+"",baglanti);    
            komut.ExecuteNonQuery();
            baglanti.Close();
            müsterigöster();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Müsterikayit where ad like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["müsteriid"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ücret"].ToString());
                ekle.SubItems.Add(oku["giris"].ToString());
                ekle.SubItems.Add(oku["çıkıs"].ToString());


                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

