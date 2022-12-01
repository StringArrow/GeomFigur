using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GeomFigur
{
    internal class CGeomFigur
    {
        //Attribute
        private string farbe;
        private string bezeichnung;

        //Methoden
        public string getFarbe()
        {
            return farbe;
        }
        public void setFarbe(string newFarbe)
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
    }
}
