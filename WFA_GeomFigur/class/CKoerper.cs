using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
