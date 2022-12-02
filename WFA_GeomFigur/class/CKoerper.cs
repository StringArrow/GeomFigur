using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_GeomFigur
{
    internal class CKoerper : CGeomFigur
    {
        //Attribute
        private double volumen;
        private double oberflaeche;

        //Methoden
        public virtual double getVolumen() 
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public virtual void setVolumen(double newVolumen)
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public virtual double getOberflaeche() 
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
        public virtual void setOberflaeche(double newOberflaeche) 
        {
            //Methode soll von Spezialisierungen implementiert werden
            throw new NotImplementedException();
        }
    }
}
