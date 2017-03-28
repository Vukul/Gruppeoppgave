using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GruppeoppgavexD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            ranNumber = newRan.Next(0, 40);
            LoadSpm(ranNumber);
            RanSpm();
            radiobtns();
        }

        Random newRan = new Random();
        int ranNumber = 0;
        int clicks = 0;
        int totPoeng = 0;
        string RanSpm1 = "";
        string RanSpm2 = "";
        string riktigSvar = "";
        string[] svar = { "Island", "Norge", "Sverige", "Finland", "Russland", "Irland", "Storritannia"
                , "Danmark", "Litauen", "latvia", "Estland", "Belgia", "Nederland", "Luxemburg", "Tyskland"
                , "Tjekkia", "Slovakia", "Polen", "Ukraina", "Hviterussland", "Frankrike", "Sveits", "Østerrike"
                , "Ungaren", "Slovenia", "Kroatia", "Bosnia-Hercegovina", "Serbia", "Romania", "Moldova"
                , "Bulgaria", "Macedonia", "Montenegro", "Albania", "Hellas", "Tyrkia", "Kypros", "Spania"
                , "Portugal", "Italia"};


        private void LoadSpm(int spm)
        {
            Bildested.ImageLocation = Directory.GetCurrentDirectory() + @"\\Land\" + ranNumber + ".png";
            riktigSvar = svar[ranNumber];

        }


        // Eivind
        private void RanSpm()
        {
            RanSpm1 = svar[newRan.Next(0, 40)];
            RanSpm2 = svar[newRan.Next(0, 40)];
            if (RanSpm1 == riktigSvar || RanSpm2 == riktigSvar)
                RanSpm();
        }


        // Pablo 
        private void Count() {
            clicks += 1;
            if (clicks == 10)
            {
                if (MessageBox.Show("Gratulerer du er ferdig :)! Du fikk " + totPoeng.ToString() + " poeng!") == DialogResult.OK)
                    Application.Exit();
            }

        }


        // Eivind
        private void Check()
        {
            foreach (Control parent in groupBox1.Controls)
            {
                Panel panel = parent as Panel;
                if (panel!= null)
                {
                    foreach (Control child in panel.Controls)
                    {
                        RadioButton radio = child as RadioButton;
                        if (radio != null)
                        {
                            if (radio.Text == riktigSvar & radio.Checked == true)
                            {
                                MessageBox.Show("Riktig svar");
                                totPoeng += 1;
                            }
                        }
                    }
                }
            }
        }

        //Vu
        private void radiobtns()
        {
            switch (newRan.Next(0, 3))
            {
                case 0:
                    {
                        Alt1.Text = riktigSvar;
                        Alt2.Text = RanSpm1;
                        Alt3.Text = RanSpm2;
                        break;
                    }
                case 1:
                    {
                        Alt1.Text = RanSpm1;
                        Alt2.Text = riktigSvar;
                        Alt3.Text = RanSpm2;
                        break;
                    }
                case 2:
                    {
                        Alt1.Text = RanSpm1;
                        Alt2.Text = RanSpm2;
                        Alt3.Text = riktigSvar;
                        break;
                    }
            }
        }

        private void Neste_Click(object sender, EventArgs e)
        {
            Count();
            ranNumber = newRan.Next(0, 40);
            LoadSpm(ranNumber);
            RanSpm();
            radiobtns();
        }

        private void Sjekk_Click(object sender, EventArgs e)
        {
            Check();
        }
    }
}