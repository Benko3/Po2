﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prosjek_ocjena2
{
    public partial class Form1 : Form
    {
        List<Prosjek> ListaOcjena = new List<Prosjek>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Ucitaj_Click(object sender, EventArgs e)
        {

        }

        private void Unesi_Click(object sender, EventArgs e)
        {
            Prosjek prosjek = new Prosjek(Predmeti.Text, Convert.ToInt32(Ocjena.Text));

            ListaOcjena.Add(prosjek);
            Ocjena.Clear();
            Ocjena.Focus();
        }
    }
}
