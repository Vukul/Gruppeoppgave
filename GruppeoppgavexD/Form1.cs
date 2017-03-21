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
            ranNumber = newRan.Next(0, 39);
            LoadSpm(ranNumber);
            RanSpm(ranNumber);
        }

        Random newRan = new Random();
        int ranNumber = 0;
        string riktigSvar = "";
        string[] svar = { "Island", "Norge", "Sverige", "Finland", "Russland", "Irland", "Storritannia"
                , "Danmark", "Litauen", "latvia", "Estland", "Belgia", "Nederland", "Luxemburg", "Tyskland"
                , "Tjekkia", "Slovakia", "Polen", "Ukraina", "Hviterussland", "Frankrike", "Sveits", "Østerrike"
                , "Ungaren", "Slovenia", "Kroatia", "Bosnia-Hercegovina", "Serbia", "Romania", "Moldova"
                , "Bulgaria", "Macedonia", "Montenegro", "Albania", "Hellas", "Tyrkia", "Kypros", "Spania"
                , "Portugal", "Italia"};
        private void LoadSpm(int spm) {
            Bildested.ImageLocation = Directory.GetCurrentDirectory() + @"\\Land\" + ranNumber + ".png";
            riktigSvar = svar[ranNumber];
    }
        string RanSpm1 = "";
        string RanSpm2 = "";
        // Eivind
    private void RanSpm()
        {
            RanSpm1 = svar[newRan.Next(0, 39)];
            RanSpm2 = svar[newRan.Next(0, 39)];
            if (RanSpm1 == riktigSvar || RanSpm2 == riktigSvar)
                RanSpm();
        }


        // Pablo 
    private void Count() { }


        // Eivind
    private void Check() { }

        //Vu
    private void radiobtns() { }

        //Pablo
        private void Neste_Click(object sender, EventArgs e)
        {

        }

        //Pablo
        private void Sjekk_Click(object sender, EventArgs e)
        {

        }
    }
}
