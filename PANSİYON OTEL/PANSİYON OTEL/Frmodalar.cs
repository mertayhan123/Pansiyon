﻿using System;
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
    public partial class Frmodalar : Form
    {
        public Frmodalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-8AQVKO8P\\MERT;Initial Catalog=KizilayPansiyon;Integrated Security=True");

        private void btnoda111_Click(object sender, EventArgs e)
        {

        }

        private void Frmodalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1=komut1.ExecuteReader();
            while (oku1.Read())
            {
                btnoda101.Text=oku1["Adi"].ToString()+" "+oku1["Soyadi"].ToString();
                
            }
            baglanti.Close();

            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
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
            }

        }
    }
}
