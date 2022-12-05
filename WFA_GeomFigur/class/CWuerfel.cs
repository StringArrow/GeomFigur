using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GeomFigur
{
    internal class CWuerfel : CKoerper
    {
        //Attribut
        private double kantenlaenge;

        //Konstruktor
        public CWuerfel(double kantenlaenge, Color farbe)
        {
            setKantenlaenge(kantenlaenge);
            setFarbe(farbe);
        }

        //Getter und Setter
        public double getKantenlaenge()
        {
            return kantenlaenge;
        }
        public void setKantenlaenge(double newKantenlaenge)
        {
            kantenlaenge = newKantenlaenge;
        }
        public override double getOberflaeche()
        {
            return Math.Pow(kantenlaenge, 2) * 6;
        }
        public override double getVolumen()
        {
            return Math.Pow(kantenlaenge, 3);
        }

        public override void zeichneFigur(Graphics graphics, SolidBrush solidBrush, Rectangle coordinates)
        {
            //Lord forgive me for what I am about to code ✝

            const double ABDUNKELNMULTIPLIKATOR = 0.5;

            //Vorderseite initialisieren
            Rectangle front = coordinates;
            front.Y = front.Height / 3;
            front.Width = coordinates.Width * 2 / 3;
            front.Height = coordinates.Height * 2 / 3;

            //3D-Budget-Zeichner :3
            //Hintergrund ist dunkler als Vordergrund
            Rectangle background = front; 
            Color darkerColor = Color.FromArgb(Convert.ToInt32(solidBrush.Color.R * ABDUNKELNMULTIPLIKATOR),
                                               Convert.ToInt32(solidBrush.Color.G * ABDUNKELNMULTIPLIKATOR),
                                               Convert.ToInt32(solidBrush.Color.B * ABDUNKELNMULTIPLIKATOR));
            SolidBrush darker = new SolidBrush(darkerColor);

            //Hintergrund aus vielen Rechtecken zeichnen
            while(background.X < coordinates.Width && background.Y > 0)
            {
                background.X += 1;
                background.Y -= 1;

                graphics.FillRectangle(darker, background);
            }

            //Vordere Seite zum Schluss zeichnen, da diese ganz Vorne ist.
            graphics.FillRectangle(solidBrush, front);
        }
    }
}
