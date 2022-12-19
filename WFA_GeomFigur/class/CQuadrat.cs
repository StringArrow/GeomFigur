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
            return Math.Pow(seitenlaenge, 2);
        }
        public override double getUmfang()
        {
            return Math.Pow(seitenlaenge, 2);
        }

        public override void zeichneFigur(Graphics graphics, SolidBrush solidBrush, Rectangle coordinates)
        {         
            graphics.FillRectangle(solidBrush, coordinates);
        }

        public override void showDetailsInListView(ListView listView)
        {
            base.showDetailsInListView(listView);

            //Parameter dem AusgabeListView anfügen
            ListViewItem item;

            item = new ListViewItem("Seitenlänge");
            item.SubItems.Add(getSeitenlaenge().ToString());
            listView.Items.Add(item);
        }
    }
}
