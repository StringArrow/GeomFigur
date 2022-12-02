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
        public virtual double getFlaecheninhalt()
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public virtual void setFlaecheninhalt(double newFlaecheninhalt)
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public virtual double getUmfang()
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public virtual void setUmfang(double newUmfang)
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
    }
}
