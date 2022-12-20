using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    internal class CRechteck : CFlaeche
    {
        //Attribute
        private double breite;
        private double hoehe;

        //Konstruktor
        public CRechteck(string bezeichnung, double breite, double hoehe, Color farbe)
        {
            setFigurTyp("Rechteck");
            setBezeichnung(bezeichnung);
            setBreite(breite);
            setHoehe(hoehe);
            setFarbe(farbe);
        }

        //Methoden
        public double getBreite()
        {
            return breite;
        }
        public void setBreite(double newBreite)
        {
            breite = newBreite;
        }
        public double getHoehe()
        {
            return hoehe;
        }
        public void setHoehe(double newHoehe)
        {
            hoehe = newHoehe;
        }
        public override double getFlaecheninhalt()
        {
            return breite * hoehe;
        }
        public override double getUmfang()
        {
            return breite * 2 + hoehe * 2;
        }
        public override Rectangle berechneMaxFigurGroesse(Panel panel)
        {
            Rectangle rectangle = base.berechneMaxFigurGroesse(panel);

            //Etwas von der Höhe abziehen um aus dem Quadrat ein Rechteck zu machen
            rectangle.Height /= 2;

            //Startpunkt anpassen, um Symmetrie sicherzustellen
            rectangle.Y = rectangle.Height / 2;
            return rectangle;
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

            item = new ListViewItem("Höhe");
            item.SubItems.Add(getHoehe().ToString());
            listView.Items.Add(item);

            item = new ListViewItem("Breite");
            item.SubItems.Add(getBreite().ToString());
            listView.Items.Add(item);
        }
    }
}
