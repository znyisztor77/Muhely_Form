using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Muhely_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fajlbeolvas();
        }

        private void fajlbeolvas()
        {
            StreamReader sr = new StreamReader("Muhely_2023.csv", Encoding.UTF8);
            string[] sorok;
            string dateFormat = ("yyyy.MM.dd.");
            DateTime meretvetel;
            DateTime atadas;
            DateTime szulev;
            while(!sr.EndOfStream)
            {
                // Muhely adatok = new Muhely(int id, string nev, DateTime meretvetel, DateTime atadas, string eszkoz, string orvos, string cim, string taj, DateTime szulev, string telefon);
                sorok = sr.ReadLine().Split(',');
                DateTime.TryParseExact(sorok[2],dateFormat,null, DateTimeStyles.None, out meretvetel);
                DateTime.TryParseExact(sorok[3], dateFormat,null, DateTimeStyles.None,out atadas);
                DateTime.TryParseExact(sorok[8], dateFormat, null, DateTimeStyles.None, out szulev);
                Muhely adatok = new Muhely(int.Parse(sorok[0]), sorok[1], meretvetel, atadas, sorok[4], sorok[5], sorok[6], sorok[7], szulev, sorok[9]);

               /* adatok.id = int.Parse(sorok[0]);
                adatok.nev = sorok[1];
                adatok.meretvetel = meretvetel;
                adatok.atadas = atadas;
                adatok.eszkoz = sorok[4];
                adatok.orvos = sorok[5];
                adatok.cim = sorok[6];
                adatok.taj = sorok[7];
                adatok.szulev = szulev;
                adatok.telefon = sorok[9];*/


                listBox1_alapadatok.Items.Add(adatok);
                
               

            }
        }

        private void listBox1_alapadatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1_alapadatok.SelectedIndex < 0)
            {
                return;
            }

            Muhely kivalasztottNev = (Muhely)listBox1_alapadatok.SelectedItem;
            textBox1_nev.Text = kivalasztottNev.nev.ToString();
            textBox2_meretvetel.Text = kivalasztottNev.meretvetel.ToString();
            textBox3_atadas.Text = kivalasztottNev.atadas.ToString();
            textBox4_eszkoz.Text = kivalasztottNev.eszkoz.ToString();
            textBox5_orvos.Text = kivalasztottNev.orvos.ToString();
            textBox6_cim.Text = kivalasztottNev.cim.ToString();
            textBox7_taj.Text = kivalasztottNev.taj.ToString();
            textBox8_szulev.Text = kivalasztottNev.szulev.ToString();
            textBox9_tel.Text = kivalasztottNev.telefon.ToString();

        }
    }
}
