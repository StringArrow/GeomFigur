using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    internal abstract class CGeomFigur
    {
        //Attribute
        private Color farbe;
        private string bezeichnung;

        //Methoden
        public Color getFarbe()
        {
            return farbe;
        }
        public void setFarbe(Color newFarbe)
        {
            farbe = newFarbe;
        }
        public string getBezeichnung()
        {
            return bezeichnung;
        }
        public void setBezeichnung(string newBezeichnung)
        {
            bezeichnung = newBezeichnung;
        }
        public void zeichneFigurImPanel(Panel panel)
        {
            //Panel leeren
            panel.Controls.Clear();
            //Überzeichnen mit leerem Dreieck
            SolidBrush clearBrush = new SolidBrush(Color.Transparent);
            Graphics graphic = panel.CreateGraphics();
            graphic.FillRectangle(clearBrush, new Rectangle(0, 0, panel.Width, panel.Height));

            //Figur Zeichnen
            SolidBrush sb = new SolidBrush(farbe);

            //Größe und Position ermitteln
            Rectangle coordinates = berechneMaxFigurGroesse(panel);

            //Figur zeichnen
            zeichneFigur(graphic, sb, coordinates);
        }

        public virtual Rectangle berechneMaxFigurGroesse(Panel panel)
        {
            Size panelSize = panel.Size;

            //Maximalgröße der Figur im Panel errechnen
            int x = 0;
            int y = 0;
            int width;
            int height;

            //gleiche Seitenlänge
            if (panelSize.Width >= panelSize.Height)
            {
                width = panelSize.Height;
                height = width;
            }
            else
            {
                height = panelSize.Width;
                width = height;
            }

            return new Rectangle(x, y, width, height);
        }

        public virtual void zeichneFigur(Graphics graphics, SolidBrush solidBrush, Rectangle coordinates)
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
    }
}
