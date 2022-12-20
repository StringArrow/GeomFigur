using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    internal class CKugel : CKoerper
    {
        //Attribut
        private double radius;

        //Konstruktor
        public CKugel(string bezeichnung, double radius, Color farbe)
        {
            setBezeichnung(bezeichnung);
            setRadius(radius);
            setFarbe(farbe);
            setFigurTyp("Kugel");
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
        public double getDurchmesser()
        {
            return radius * 2;
        }
        public void setDurchmesser(double newDiameter)
        {
            radius = newDiameter / 2;
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
            const int ANZAHLGRADIENTEN = 80;

            //Koordinaten des Gradianten-Teils
            Rectangle circleRectangle = coordinates;

            //Ausgangsfarbe vordunkeln, um nach der Schleife die Originalfarbe zu erhalten
            //Speichern im double, wegen erhöhter Farbpräzision
            double r = solidBrush.Color.R / ANZAHLGRADIENTEN;
            double g = solidBrush.Color.G / ANZAHLGRADIENTEN;
            double b = solidBrush.Color.B / ANZAHLGRADIENTEN;

            double rIncrement = r;
            double gIncrement = g;
            double bIncrement = b;

            //Koordinaten
            double x = circleRectangle.X;
            double y = circleRectangle.Y;

            //Lichteinfall vortäuschen durch Helligkeit-Gradienten
            for (int i = 0; i < ANZAHLGRADIENTEN; i++)
            {
                //Koordinaten des nächsten Kreises
                x = x + circleRectangle.Width / 90;
                y = y + circleRectangle.Height / 90;
                circleRectangle.X = Convert.ToInt32(x);
                circleRectangle.Y = Convert.ToInt32(y);
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
        public override void appendDetailsInListViewItems(ListView listView)
        {
            base.appendDetailsInListViewItems(listView);

            //Parameter dem AusgabeListView anfügen
            ListViewItem item;

            item = new ListViewItem("Radius");
            item.SubItems.Add(getRadius().ToString());
            listView.Items.Add(item);

            item = new ListViewItem("Durchmesser");
            item.SubItems.Add(getDurchmesser().ToString());
            listView.Items.Add(item);
        }
    }
}
