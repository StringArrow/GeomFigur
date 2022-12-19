using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    internal abstract class CFlaeche : CGeomFigur
    {
        //Methoden
        public virtual double getFlaecheninhalt()
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public virtual double getUmfang()
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public override void showDetailsInListView(ListView listView)
        {
            base.showDetailsInListView(listView);

            //Parameter dem AusgabeListView anfügen
            ListViewItem item;

            item = new ListViewItem("Flächeninhalt");
            item.SubItems.Add(getFlaecheninhalt().ToString());
            listView.Items.Add(item);

            item = new ListViewItem("Umfang");
            item.SubItems.Add(getUmfang().ToString());
            listView.Items.Add(item);
        }
    }
}
