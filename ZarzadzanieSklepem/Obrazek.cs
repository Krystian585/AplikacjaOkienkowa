using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarzadzanieSklepem
{
    class Obrazek
    {
        Image image;
        float y, x, kierunek;
        public Obrazek(Image image)
        {
            this.image = image;
        }
        public float Y { get => y; set => y = value; }
        public float X { get => x; set => x = value; }
        public float Kierunek { get => kierunek; set => kierunek = value; }

        public void Rysuj(Graphics ctx)
        {
            var m = ctx.Transform;            
            ctx.ScaleTransform(0.1f, 0.1f);           
            ctx.TranslateTransform(X, Y);
            ctx.RotateTransform(Kierunek);
            ctx.TranslateTransform(-X, -Y);
            ctx.DrawImage(image, X, Y);           
            ctx.Transform = m;
        }
    }
}
