using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarzadzanieSklepem
{
    public partial class Gra : Form
    {
        Obrazek sokol, meteor1, meteor2, meteor3,pocisk;
        Image sokolImage, pociskImage, meteorImage;
        
        public Gra()
        {
            pociskImage = Image.FromFile(@"Images\pocisk.png");
            pocisk = new Obrazek(pociskImage);
             pocisk.X = 3000; pocisk.Y = 8500; pocisk.Kierunek = -90;
            sokolImage = Image.FromFile(@"Images\sokol.png");
            sokol = new Obrazek(sokolImage);
            sokol.X = 3300; sokol.Y = 6000;
            meteorImage = Image.FromFile(@"Images\Meteor.png");
            meteor1 = new Obrazek(meteorImage);
            meteor2 = new Obrazek(meteorImage);
            meteor2.X = 3000;
            meteor3 = new Obrazek(meteorImage);
            meteor3.X = 6000;           
            InitializeComponent();
            restart();
              
        }
        public void Gra_Paint(object sender, PaintEventArgs e)
        {
            pocisk.Rysuj(e.Graphics);
            sokol.Rysuj(e.Graphics);
            meteor1.Rysuj(e.Graphics);
            meteor2.Rysuj(e.Graphics);
            meteor3.Rysuj(e.Graphics);
            
        }

        bool wlewo, wprawo, strzal, koniec;

        

        int punkty, sokolSpeed = 400, meteorSpeed = 500, pociskSpeed=900;
        Random rnd = new Random();
        private void Gra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                wlewo = true;
                
            }
            if (e.KeyCode == Keys.Right)
            {
                wprawo = true;
               

            }
        }

        private void Gra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                wlewo = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                wprawo = false;
            }
            if (e.KeyCode==Keys.Space && strzal == false)
            {
                strzal = true;
                pocisk.Y = sokol.Y+1000;
                pocisk.X = sokol.X-250;
                
            }
            if ((e.KeyCode == Keys.Space && koniec == true))
            {
                koniecGry();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            punktyLabel.Text = punkty.ToString();
            meteor1.Y += meteorSpeed;
            meteor2.Y += meteorSpeed;
            meteor3.Y += meteorSpeed;
            if (meteor1.Y > 6000 || meteor3.Y >6000|| meteor2.Y>6000)
            {
                koniecGry();
            }
            if (wlewo == true && sokol.X > 10)
            {
                
                sokol.X -= sokolSpeed;              
              
            }
            if (wprawo == true && sokol.X < 6300)
            {
                sokol.X += sokolSpeed;           
                
            }

            if (strzal==true)
            {
                 pocisk.Y -= pociskSpeed;
            }

            if (pocisk.Y<0)
            {
                strzal = false;
            }
            
            
            Refresh();
        }
        private void restart()
        {
            czasGry.Start();
            meteor1.X = rnd.Next(0, 4000);
            meteor2.X = rnd.Next(2000, 5000);
            meteor3.X = rnd.Next(4000, 6000);
            meteor3.Y += rnd.Next(-800, 400);
            meteor2.Y += rnd.Next(-800, 400);
            meteor1.Y += rnd.Next(-800,400);
            
        }
        private void koniecGry()
        {
            koniec = true;
            czasGry.Stop();
            punktyLabel.Text += " GAME OVER"+Environment.NewLine +"Wcisnij Klawisz";
            //l.Graphics.DrawLine(Pen., 0,0, ClientSize)

        }

        private void Gra_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
