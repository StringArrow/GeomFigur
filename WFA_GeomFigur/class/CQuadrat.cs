using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    internal class CQuadrat : CFlaeche
    {
        //Attribut
        private double seitenlaenge;

        //Konstruktor
        public CQuadrat(double seitenlaenge, Color farbe)
        {
            setSeitenlaenge(seitenlaenge);
            setFarbe(farbe);
        }

        //Methoden
        public double getSeitenlaenge()
        {
            return seitenlaenge;
        }
        public void setSeitenlaenge(double newSeitenlaenge)
        {
            seitenlaenge = newSeitenlaenge;
        }
        
        public override double getFlaecheninhalt()
        {
            setFlaecheninhalt(seitenlaenge * 2);
            return getFlaecheninhalt();
        }
        public override double getUmfang()
        {
            setUmfang(seitenlaenge * 4);
            return getUmfang();
        }


        public override void zeichneFigur(Graphics graphics, SolidBrush solidBrush, Rectangle coordinates)
        {         
            graphics.FillRectangle(solidBrush, coordinates);
        }
    }
}
