﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    string[] svar = { "Island", "Norge", "Sverige", "Finland", "Russland", "Irland", "Storritannia"
                , "Danmark", "Litauen", "latvia", "Estland", "Belgia", "Nederland", "Luxemburg", "Tyskland"
                , "Tjekkia", "Slovakia", "Polen", "Ukraina", "Hviterussland", "Frankrike", "Sveits", "Østerrike"
                , "Ungaren", "Slovenia", "Kroatia", "Bosnia-Hercegovina", "Serbia", "Romania", "Moldova"
                , "Bulgaria", "Macedonia", "Montenegro", "Albania", "Hellas", "Tyrkia", "Kypros", "Spania"
                , "Portugal", "Italia"};

        //Vu
    private void LoadSpm(int spm) {


    }
        // Eivind
    private void RanSpm(int spm) { }


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
