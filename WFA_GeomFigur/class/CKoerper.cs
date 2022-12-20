using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    internal abstract class CKoerper : CGeomFigur
    {
        //Methoden
        public virtual double getVolumen() 
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public virtual double getOberflaeche() 
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public override void appendDetailsInListViewItems(ListView listView)
        {
            base.appendDetailsInListViewItems(listView);

            //Parameter dem AusgabeListView anfügen
            ListViewItem item;

            item = new ListViewItem("Volumen");
            item.SubItems.Add(getVolumen().ToString());
            listView.Items.Add(item);

            item = new ListViewItem("Oberflächeninhalt");
            item.SubItems.Add(getOberflaeche().ToString());
            listView.Items.Add(item);
        }
    }
}
