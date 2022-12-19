using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WFA_GeomFigur
{
    internal class CFigurenHandler
    {
        //Attribute
        private ListView listView;
        private Panel panel;
        private ListView listViewDetails;

        //Liste mit den hinzugefügten Figuren
        private List<CGeomFigur> figuren;

        //Handler benötigt Zugriff auf die GUI-Objekte
        public CFigurenHandler(ListView listView, Panel panel, ListView listViewDetails)
        {
            //Referenz erstellen
            this.listView = listView;
            this.panel = panel;
            this.listViewDetails = listViewDetails;

            //Figurenliste initialisieren
            this.figuren = new List<CGeomFigur>();
        }

        public void addFigure(CGeomFigur newFigure)
        {
            //Figur der Figurenliste anfügen
            figuren.Add(newFigure);

            refreshDisplay();

            newFigure.zeichneFigurImPanel(panel);
        }

        public void removeSelectedFigure()
        {
            //Selektierte Figur ermitteln
            CGeomFigur figur = getFigure(listView.SelectedItems[0].Index);

            figuren.Remove(figur);
            refreshDisplay();
            refreshDetailsDisplay();
        }

        public void refreshDisplay()
        {
            //Aktualisieren des ListViews mit der neuen Figur
            listView.BeginUpdate();

            listView.Items.Clear();
            foreach (var figure in figuren)
            {

                ListViewItem item = new ListViewItem();
                item.Text = figure.getBezeichnung();

                listView.Items.Add(item);
            }

            listView.EndUpdate();
        }

        public void refreshDetailsDisplay()
        {
            listViewDetails.BeginUpdate();

            foreach (var figure in figuren)
            {

            }

            listViewDetails.EndUpdate();
        }

        public void displaySelectedFigure()
        {
            if (listView.SelectedItems.Count == 0)
            {
                //throw new Exception("Bitte eine Figur auswählen");
            }
            else
            {
                //Selektierte Figur ermitteln
                CGeomFigur figur = getFigure(listView.SelectedItems[0].Index);

                figur.zeichneFigurImPanel(panel);


            }
        }

        public CGeomFigur getFigure(int index)
        {
            return figuren[index];
        }

        public int getFigureCount()
        {
            return figuren.Count;
        }
    }
}
