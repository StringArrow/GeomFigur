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
        public double getVolumen() 
        { 
            return volumen; 
        }
        public void setVolumen(double newVolumen)
        { 
            volumen = newVolumen; 
        }
        public double getOberflaeche() 
        { 
            return oberflaeche; 
        }
        public void setOberflaeche(double newOberflaeche) 
        { 
            oberflaeche = newOberflaeche; 
        }
    }
}
