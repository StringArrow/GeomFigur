using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
