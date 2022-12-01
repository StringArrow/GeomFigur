using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GeomFigur
{
    internal class CFlaeche : CGeomFigur
    {
        //Attribute
        private double flaecheninhalt;
        private double umfang;

        //Methoden
        public double getFlaecheninhalt()
        {
            return flaecheninhalt;
        }
        public void setFlaecheninhalt(double newFlaecheninhalt)
        { 
            flaecheninhalt = newFlaecheninhalt; 
        }
        public double getUmfang()
        {
            return umfang;
        }
        public void setUmfang(double newUmfang)
        {
            umfang = newUmfang;
        }
    }
}
