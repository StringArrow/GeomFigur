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
        public CQuadrat(string bezeichnung, double seitenlaenge, Color farbe)
        {
            setBezeichnung(bezeichnung);
            setSeitenlaenge(seitenlaenge);
            setFarbe(farbe);
            setFigurTyp("Quadrat");
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
            return seitenlaenge * 4;
        }

        public override void zeichneFigur(Graphics graphics, SolidBrush solidBrush, Rectangle coordinates)
        {         
            graphics.FillRectangle(solidBrush, coordinates);
        }

        public override void appendDetailsInListViewItems(ListView listView)
        {
            base.appendDetailsInListViewItems(listView);

            //Parameter dem AusgabeListView anfügen
            ListViewItem item;

            item = new ListViewItem("Seitenlänge");
            item.SubItems.Add(getSeitenlaenge().ToString());
            listView.Items.Add(item);
        }
    }
}
