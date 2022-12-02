using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WFA_GeomFigur
{
    internal class CKugel : CKoerper
    {
        //Attribut
        private double radius;

        //Konstruktor
        public CKugel(double radius, Color farbe)
        {
            setRadius(radius);
            setFarbe(farbe);
        }

        //Getter und Setter
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double newRadius)
        {
            radius = newRadius;
        }
        public override double getOberflaeche()
        {
            //Oberfläche einer Kugel
            return 4 * Math.PI * Math.Pow(radius, 2);
        }
        public override double getVolumen()
        {
            //Volumen einer Kugel
            return 4 / 3 * Math.PI * Math.Pow(radius, 2);
        }

        public override void zeichneFigur(Graphics graphics, SolidBrush solidBrush, Rectangle coordinates)
        {
            //Lord forgive me for what I am about to code ✝
            const double ABDUNKELNMULTIPLIKATOR = 0.98;
            double LIGHTOFFSET = 1f / 3f * coordinates.Width;
            const int ANZAHLGRADIENTEN = 100;

            //Koordinaten des Gradianten-Teils
            Rectangle circleRectangle = coordinates;

            //Ausgangsfarbe vordunkeln, um nach der Schleife die Originalfarbe zu erhalten
            double r = solidBrush.Color.R / ANZAHLGRADIENTEN;
            double g = solidBrush.Color.G / ANZAHLGRADIENTEN;
            double b = solidBrush.Color.B / ANZAHLGRADIENTEN;

            double rIncrement = r;
            double gIncrement = g;
            double bIncrement = b;

            //Lichteinfall vortäuschen durch Helligkeit-Gradienten
            for (int i = 0; i < ANZAHLGRADIENTEN; i++)
            {
                //Koordinaten des nächsten Kreises
                circleRectangle.X = Convert.ToInt32(circleRectangle.X + LIGHTOFFSET);
                circleRectangle.Y = Convert.ToInt32(circleRectangle.Y + LIGHTOFFSET);
                circleRectangle.Width = Convert.ToInt32(circleRectangle.Width * ABDUNKELNMULTIPLIKATOR);
                circleRectangle.Height = Convert.ToInt32(circleRectangle.Height * ABDUNKELNMULTIPLIKATOR);

                //Farben des nächsten Kreises etwas aufhellen
                r += rIncrement;
                g += gIncrement;
                b += bIncrement;

                Color farbeKreis = Color.FromArgb(Convert.ToInt32(r),
                                                  Convert.ToInt32(g),
                                                  Convert.ToInt32(b));

                //Pinsel mit einem Stück weit hellere Farbe
                SolidBrush gradient = new SolidBrush(farbeKreis);

                //Zeichnen des einzelnen Gradienten-Kreises
                graphics.FillEllipse(gradient, circleRectangle);
            }
        }
    }
}
