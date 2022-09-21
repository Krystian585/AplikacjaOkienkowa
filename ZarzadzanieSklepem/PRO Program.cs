using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ZarzadzanieSklepem
{
    public partial class PROprogramform : Form
    {
        SqlConnection polaczenie = new SqlConnection(@"Data Source=tester1.wwsi.edu.pl,50223;Initial Catalog=Z408_K_Sz;Persist Security Info=True;User ID=wptasznik;Password=***********");
        public PROprogramform()
        {
            InitializeComponent();
        }

        private void zalogujButton_Click(object sender, EventArgs e)
        { 
            string haslo = hasloTextBox.Text;
            string uzytkownik = wyborUzytkownikComboBox.Text;
            bool logowanie = false;
            var tabela = passyTableAdapter.GetData();
            foreach (var passy in tabela)
            {
                string s = passy.haslo;
                if (s == haslo && uzytkownik == "World's Best Boss")
                {
                    Gra gra = new Gra();
                    gra.ShowDialog(); ;//"pracownik " i "szef      "
                    logowanie = true;
                }
                if (s == haslo && uzytkownik == "Pracownik")
                {
                    Produkty produkty = new Produkty();
                    produkty.ShowDialog();
                    logowanie = true;
                }
            }
            if (logowanie == false)
            {
                MessageBox.Show("Złe Hasło");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void PROprogramform_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'hasloDataSet.passy' . Możesz go przenieść lub usunąć.
            this.passyTableAdapter.Fill(this.hasloDataSet.passy);

        }
    }
}
