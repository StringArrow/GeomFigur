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

            refreshFigureListView();
        }

        public void removeSelectedFigure()
        {
            try
            {
                //Selektierte Figur ermitteln
                CGeomFigur figur = getFigure(listView.SelectedItems[0].Index);

                figuren.Remove(figur);

                //GUI refresh
                refreshFigureListView();

                //Panel leeren
                panel.Invalidate();

                //Details entfernen
                listViewDetails.Items.Clear();
                listViewDetails.Columns.Clear();
                
            }
            catch
            {
                MessageBox.Show("Bitte die zu entfernende Figur auswählen");
            }

        }

        public void refreshFigureListView()
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

        public void refreshDetailsDisplay(CGeomFigur figur)
        {
            listViewDetails.BeginUpdate();

            listViewDetails.Items.Clear();

            //Spaltenüberschriften
            listViewDetails.Columns.Clear();

            listViewDetails.Columns.Add("Attribut");
            listViewDetails.Columns.Add("Wert");
            figur.showDetailsInListView(listViewDetails);
            listViewDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewDetails.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

                refreshDetailsDisplay(figur);

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
