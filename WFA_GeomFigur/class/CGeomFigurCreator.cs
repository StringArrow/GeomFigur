using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WFA_GeomFigur
{
    internal class CGeomFigurCreator
    {
        public enum EnumFigur
        {
            Kreis,
            Kugel,
            Quadrat,
            Rechteck,
            Wuerfel
        }

        public static int getCountOfNeededValues(EnumFigur typ)
        {
            int count = 0;

            switch (typ)
            {
                case EnumFigur.Kreis:
                    count = 1;
                    break;
                case EnumFigur.Kugel:
                    count = 1;
                    break;
                case EnumFigur.Quadrat:
                    count = 1;
                    break;
                case EnumFigur.Rechteck:
                    count = 2;
                    break;
                case EnumFigur.Wuerfel:
                    count = 1;
                    break;
                default:
                    throw new ArgumentException("Die Figur hat einen ungültigen Typ", "typ");
            }

            return count;
        }
        public static int getCountOfNeededValues(string typ)
        {
            return getCountOfNeededValues(convertStringToEnum(typ));
        }

        public static CGeomFigur Factory(EnumFigur typ, string bezeichnung, Color color, double value1, double value2)
        {
            CGeomFigur createdFigur;

            if (value1 <= 0)
            {
                throw new ArgumentOutOfRangeException(getParameterName(typ, 1), "Der erste angegebene Wert muss größer als 0 sein.");
            }

            switch (typ)
            {
                case EnumFigur.Quadrat:
                    createdFigur = new CQuadrat(bezeichnung, value1, color);
                    break;
                case EnumFigur.Rechteck:
                    if (value2 <= 0)
                    {
                        throw new ArgumentOutOfRangeException(getParameterName(typ, 2), "Der zweite angegebene Wert muss größer als 0 sein.");
                    }
                    createdFigur = new CRechteck(bezeichnung, value1, value2, color);
                    break;
                case EnumFigur.Kreis:
                    createdFigur = new CKreis(bezeichnung, value1, color);
                    break;
                case EnumFigur.Wuerfel:
                    createdFigur = new CWuerfel(bezeichnung, value1, color);
                    break;
                case EnumFigur.Kugel:
                    createdFigur = new CKugel(bezeichnung, value1, color);
                    break;
                default:
                    throw new ArgumentException("Die Figur hat einen ungültigen Typ", "typ");
            }

            return createdFigur;
        }
        public static CGeomFigur Factory(string typ, string bezeichnung, Color color, double value1, double value2)
        {
            //Methode aufrufen, mit konvertierten Typen
            return Factory(convertStringToEnum(typ), bezeichnung, color, value1, value2);
        }
        
        public static EnumFigur convertStringToEnum(string typ)
        {
            //Figur Typ von String in Enumerator konvertieren
            switch (typ)
            {
                case "Quadrat":
                    return EnumFigur.Quadrat;
                case "Rechteck":
                    return EnumFigur.Rechteck;
                case "Kreis":
                    return EnumFigur.Kreis;
                case "Wuerfel":
                case "Würfel":
                    return EnumFigur.Wuerfel;
                case "Kugel":
                    return EnumFigur.Kugel;
                default:
                    throw new ArgumentException("Die angegebene Figur steht nicht zur Auswahl", "typ");
            }
        }
        
        public static string getParameterName(EnumFigur typ, int parameterNumber)
        {
            //Parameternamen für Label auflösen

            if (parameterNumber == 1)
            {
                switch (typ)
                {
                    case EnumFigur.Kreis:
                        return "Radius:";
                    case EnumFigur.Kugel:
                        return "Radius:";
                    case EnumFigur.Quadrat:
                        return "Seitenlänge:";
                    case EnumFigur.Rechteck:
                        return "Seitenlänge 1:";
                    case EnumFigur.Wuerfel:
                        return "Seitenlänge";
                    default:
                        throw new ArgumentException("Die Figur hat einen ungültigen Typ", "typ");
                }
            }
            else if (parameterNumber == 2)
            {
                switch (typ)
                {
                    case EnumFigur.Rechteck:
                        return "Seitenlänge 2:";
                    default:
                        throw new ArgumentException("Die Figur hat einen ungültigen Typ", "typ");
                }
            }
            else throw new ArgumentOutOfRangeException("parameterNumber", "Parameternummer existiert nicht");
        }
        public static string getParameterName(string typ, int parameterNumber)
        {
            return getParameterName(convertStringToEnum(typ), parameterNumber);
        }
    }
}
