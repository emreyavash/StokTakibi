using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****************************************************************************
** SAKARYA ÜNİVERSİTESİ
** BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
** BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
** NESNEYE DAYALI PROGRAMLAMA DERSİ
** 2019-2020 BAHAR DÖNEMİ
**
** ÖDEV NUMARASI..........:3
** ÖĞRENCİ ADI............:Emre Yavaş   
** ÖĞRENCİ NUMARASI.......:B181200035
** DERSİN ALINDIĞI GRUP...:Yok
****************************************************************************/

namespace stoktakini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public  string giriş(string a)
        {
           string urunadı = cmbalurun.Text;
            

            return urunadı;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           





        }
        int sonuc, alınanurun, stoktakiurun,kar,satfiyat;

        private void button3_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsatfiyat.Clear();
            txtsoyad.Clear();
            txtstok.Clear();
            txturunadet.Clear();
            txturunalfiyat.Clear();
            txturunkod.Clear();
            msktxttel.Clear();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int alısfiyat,netkar=0;
        private void button1_Click(object sender, EventArgs e)
        {




            string urun = cmburunad.Text;
            switch (urun)
            {
                case "Telefon":
                    txturunkod.Text = 13541387.ToString();
                    txturunalfiyat.Text = 2500.ToString();
                    txtsatfiyat.Text = 3500.ToString();
                    txtstok.Text = 1000.ToString();
                    break;
                case "Bilgisayar":
                    txturunkod.Text = 12046238.ToString();
                    txturunalfiyat.Text = 4000.ToString();
                    txtsatfiyat.Text = 5350.ToString();
                    txtstok.Text = 1200.ToString();
                    break;
                case "Televizyon":
                    txturunkod.Text = 65489122.ToString();
                    txturunalfiyat.Text = 6399.ToString();
                    txtsatfiyat.Text = 7999.ToString();
                    txtstok.Text = 500.ToString();
                    break;
                case "Laptop":
                    txturunkod.Text = 41621687.ToString();
                    txturunalfiyat.Text = 2750.ToString();
                    txtsatfiyat.Text = 4599.ToString();
                    txtstok.Text = 400.ToString();
                    break;
                case "Ps4":
                    txturunkod.Text = 75641256.ToString();
                    txturunalfiyat.Text = 1500.ToString();
                    txtsatfiyat.Text = 2799.ToString();
                    txtstok.Text = 750.ToString();
                    break;
            }
           stoktakiurun = Convert.ToInt32(txtstok.Text);
            alınanurun = Convert.ToInt32(txturunadet.Text);

            sonuc = stoktakiurun - alınanurun;

            satfiyat = Convert.ToInt32(txtsatfiyat.Text);
            alısfiyat = Convert.ToInt32(txturunalfiyat.Text);

            kar = satfiyat * alınanurun;
            netkar += kar;

    


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Müşteri Bilgileri");
            listBox1.Items.Add(txtad.Text + " " + txtsoyad.Text + " " + msktxttel.Text + " " + cmbalurun.Text);

            listBox1.Items.Add("Ürün Bilgileri");
            listBox1.Items.Add("Ürün Kodu:" + txturunkod.Text + " " + txtsatfiyat.Text + " " + txtstok.Text);
            listBox1.Items.Add("Ürün Adı:" + cmburunad.Text);
            listBox1.Items.Add("Ürün Alış Fiyatı" + txturunalfiyat.Text);
            listBox1.Items.Add("Ürün Satış Fiyatı" + txtsatfiyat.Text);
            listBox1.Items.Add("Stokta Kalan Ürün:" + sonuc);
            listBox1.Items.Add("Net Kar:" + netkar);
            listBox1.Items.Add("----------------------------------------------------------------------------------------------------------------");

        }
    }
}
