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
    public partial class Wysyłki_Zrobione : Form
    {
        public Wysyłki_Zrobione()
        {
            InitializeComponent();
        }
        public void DodajKolejnaWysyłke(int stara, int nowa)
        {
            wysylkiZrobioneListBox.Items.Add($"{DateTime.Now.ToLongDateString()} kolejnosc wysyłka stara zakonczona: {stara}, aktualnie pracujemy nad: {nowa}");

        }

        private void zapiszButton_Click(object sender, EventArgs e)
        {
            string plik = zapiszTextBox.Text;
            string pracaPracownika = Convert.ToString(wysylkiZrobioneListBox); // uzupelnic
            string dokumenty = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            File.WriteAllText(plik, pracaPracownika);
            Komunikat($"przerobione Zamowienia(twoja praca) zapisane w pliku: {plik} w MyDocuments");
        }
        public void Komunikat(string tekstKomunikatu)
        {
            komunikatLabel.Text = tekstKomunikatu;
            komunikatLabel.Show();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            komunikatLabel.Hide();
            timer1.Stop();
        }

        private void zapiszTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            Komunikat("Podaj nazwe pliku w jakim chcesz zapisac");
            komunikatLabel.Show();
            timer1.Start();
        }
    }
    
}
