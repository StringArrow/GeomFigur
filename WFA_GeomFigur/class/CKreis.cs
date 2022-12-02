using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    internal class CKreis : CFlaeche
    {
        //Attibute
        private double radius;

        //Konstruktor
        public CKreis(double radius, Color farbe)
        {
            setRadius(radius);
            setFarbe(farbe);
        }

        //Methoden
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

        public override double getFlaecheninhalt()
        {
            return 2 * radius * Math.PI;
        }
        public override double getUmfang()
        {
            return 2 * Math.PI * radius;
        }

        public override void zeichneFigur(Graphics graphics, SolidBrush solidBrush, Rectangle coordinates)
        {
            graphics.FillEllipse(solidBrush, coordinates);
        }
    }
}
