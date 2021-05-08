using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rezystor
{
    public partial class Form1 : Form
    {
        List<Color> opornikKolor = new List<Color>() {Color.Silver, Color.Gold, Color.Black, Color.Brown,  Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Violet, Color.Gray, Color.White};
        private int opornik1 = 2;
        private int opornik2 = 2;
        private int opornik3 = 2;
        private int opornikMnoznik = 0;
        private int opornikTolerancja = 0;
        private string wartoscOpornikow = "";
        private string wartoscMnoznika = "";

        void wyswietlanieWartosci()
        {
            wartoscOpornikow = "";
            if ((opornik1 - 2) != 0)
            {
                wartoscOpornikow += (opornik1 - 2).ToString();
            }
            if ((opornik2 - 2) != 0)
            {
                wartoscOpornikow += (opornik2 - 2).ToString();
            }
            if ((opornik3 - 2) != 0)
            {
                wartoscOpornikow += (opornik3 - 2).ToString();
            }
            textBox1.Text = wartoscOpornikow;
        }

        void wyswietlanieMnoznika()
        {
            wartoscMnoznika = "";
            wartoscMnoznika = (Math.Pow(10,(opornikMnoznik - 2))).ToString()+" ";
            switch(float.Parse(wartoscMnoznika))
            {
                case 1000:
                    wartoscMnoznika = "1 k";
                    break;
                case 10000:
                    wartoscMnoznika = "10 k";
                    break;
                case 100000:
                    wartoscMnoznika = "100 k";
                    break;
                case 1000000:
                    wartoscMnoznika = "1 M";
                    break;
                case 10000000:
                    wartoscMnoznika = "10 M";
                    break;
                case 100000000:
                    wartoscMnoznika = "100 M";
                    break;
                case 1000000000:
                    wartoscMnoznika = "1 G";
                    break;
            }
            textBox2.Text = wartoscMnoznika+ "Ω";
        }
        void wyswietlanieKoncowej()
        {
            double temp = double.Parse(wartoscOpornikow) * (Math.Pow(10, (opornikMnoznik - 2)));
            string text = "";
            if(temp>=1000 && temp<1000000)
            {
                text = ((temp/1000).ToString() + " kΩ").ToString();
            }
            else if (temp >= 1000000 && temp < 1000000000)
            {
                text = ((temp/1000000).ToString() + " MΩ").ToString();
            }
            else if(temp>=1000000000)
            {
                text = ((temp/1000000000).ToString() + " GΩ").ToString();
            }
            else
            {
                text = (temp.ToString() + " Ω").ToString();
            }
            textBox4.Text = text;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opornik1 += 1;
            if((opornik1-2)>9)
            {
                opornik1 = 2;
            }
            button1.BackColor = opornikKolor[opornik1];
            wyswietlanieWartosci();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            opornik2 += 1;
            if ((opornik2-2) > 9)
            {
                opornik2 = 2;
            }
            button2.BackColor = opornikKolor[opornik2];
            wyswietlanieWartosci();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.TabStop = false;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;

            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

            button3.TabStop = false;
            button3.FlatStyle = FlatStyle.Flat;
            button3.FlatAppearance.BorderSize = 0;

            button4.TabStop = false;
            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;

            button5.TabStop = false;
            button5.FlatStyle = FlatStyle.Flat;
            button5.FlatAppearance.BorderSize = 0;

            button1.BackColor = opornikKolor[2];
            button2.BackColor = opornikKolor[2];
            button3.BackColor = opornikKolor[2];
            button4.BackColor = opornikKolor[2];
            button5.BackColor = opornikKolor[3];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            opornik3 += 1;
            if ((opornik3-2) > 9)
            {
                opornik3 = 2;
            }
            button3.BackColor = opornikKolor[opornik3];
            wyswietlanieWartosci();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            wyswietlanieKoncowej();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opornikMnoznik += 1;
            if (opornikMnoznik > 11)
            {
                opornikMnoznik = 0;
            }
            button4.BackColor = opornikKolor[opornikMnoznik];
            wyswietlanieMnoznika();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opornikTolerancja += 1;
            if(opornikTolerancja>11)
            {
                opornikTolerancja = 3;
            }
            if(opornikTolerancja==10)
            {
                opornikTolerancja += 1;
            }
            if(opornikTolerancja==11)
            {
                opornikTolerancja += 1;
            }
            button5.BackColor = opornikKolor[opornikTolerancja];
            switch(opornikTolerancja)
            {
                case 0:
                    textBox3.Text = "10%";
                    break;
                case 1:
                    textBox3.Text = "5%";
                    break;
                case 3:
                    textBox3.Text = "1%";
                    break;
                case 4:
                    textBox3.Text = "2%";
                    break;
                case 5:
                    textBox3.Text = "3%";
                    break;
                case 6:
                    textBox3.Text = "4%";
                    break;
                case 7:
                    textBox3.Text = "0.5%";
                    break;
                case 8:
                    textBox3.Text = "0.25%";
                    break;
                case 9:
                    textBox3.Text = "0.1%";
                    break;
                case 10:
                    textBox3.Text = "0.05%";
                    break;

            }
        }
    }
}
