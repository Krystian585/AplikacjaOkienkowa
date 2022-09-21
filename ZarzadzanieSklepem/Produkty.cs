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

namespace ZarzadzanieSklepem
{
    public partial class Produkty : Form
    {
    
        NrZamowienia nrzamowienia = new NrZamowienia();
        public Produkty()
        {
            InitializeComponent();
            nrzamowienia.ZmianaNr += Nrzamowienia_ZmianaNr;
            nrzamowienia.Numer = 0;
        }

        private void Nrzamowienia_ZmianaNr(int nowyNr, int staryNr)
        {
            aktualneZamowienieLabel.Text = nowyNr.ToString(); ;
        }

        private void zapiszDoPlikuButton_Click(object sender, EventArgs e)
        {
            string plik = nazwaPlikuTextBox.Text;
            string zamowienie = ""; // uzupelnic
           string dokumenty = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText(plik, zamowienie);
            Komunikat($"Zamowienie zapisane w pliku: {plik} w MyDocuments");

        }
        public void Komunikat(string tekstKomunikatu)
        {
            komunikatLabel.Text = tekstKomunikatu;
            komunikatLabel.Show();
            timer1.Start();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    komunikatLabel.Hide();
        //    timer1.Stop();
        //}

        private void zapiszNrZamowieniaButton_Click(object sender, EventArgs e)
        {

            nrzamowienia.Numer = Convert.ToInt32(nrZamowieniaTextBox.Text);
        }

        private void wyrobioneZamowieniaButton_Click(object sender, EventArgs e)
        {
            Wysyłki_Zrobione zrobione = new Wysyłki_Zrobione();
            nrzamowienia.ZmianaNr += zrobione.DodajKolejnaWysyłke;
            zrobione.Show();
        }
    }
}
