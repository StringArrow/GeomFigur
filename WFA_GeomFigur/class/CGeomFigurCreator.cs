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
        public enum Figur
        {
            Kreis,
            Kugel,
            Quadrat,
            Rechteck,
            Wuerfel
        }

        public static int getCountOfNeededValues(Figur typ)
        {
            int count = 0;

            switch (typ)
            {
                case Figur.Kreis:
                    count = 1;
                    break;
                case Figur.Kugel:
                    count = 1;
                    break;
                case Figur.Quadrat:
                    count = 1;
                    break;
                case Figur.Rechteck:
                    count = 2;
                    break;
                case Figur.Wuerfel:
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

        public static CGeomFigur Factory(Figur typ, string bezeichnung, Color color, double value1, double value2)
        {
            CGeomFigur createdFigur;

            if (value1 <= 0)
            {
                throw new ArgumentOutOfRangeException(getParameterName(typ, 1), "Der erste angegebene Wert muss größer als 0 sein.");
            }

            switch (typ)
            {
                case Figur.Quadrat:
                    createdFigur = new CQuadrat(bezeichnung, value1, color);
                    break;
                case Figur.Rechteck:
                    if (value2 <= 0)
                    {
                        throw new ArgumentOutOfRangeException(getParameterName(typ, 2), "Der zweite angegebene Wert muss größer als 0 sein.");
                    }
                    createdFigur = new CRechteck(bezeichnung, value1, value2, color);
                    break;
                case Figur.Kreis:
                    createdFigur = new CKreis(bezeichnung, value1, color);
                    break;
                case Figur.Wuerfel:
                    createdFigur = new CWuerfel(bezeichnung, value1, color);
                    break;
                case Figur.Kugel:
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
        public static Figur convertStringToEnum(string typ)
        {
            //Figur Typ von String in Enumerator konvertieren
            switch (typ)
            {
                case "Quadrat":
                    return Figur.Quadrat;
                case "Rechteck":
                    return Figur.Rechteck;
                case "Kreis":
                    return Figur.Kreis;
                case "Wuerfel":
                case "Würfel":
                    return Figur.Wuerfel;
                case "Kugel":
                    return Figur.Kugel;
                default:
                    throw new ArgumentException("Die angegebene Figur steht nicht zur Auswahl", "typ");
            }
        }

        public static string getParameterName(Figur typ, int parameterNumber)
        {
            //Parameternamen für Label auflösen

            if (parameterNumber == 1)
            {
                switch (typ)
                {
                    case Figur.Kreis:
                        return "Radius:";
                    case Figur.Kugel:
                        return "Radius:";
                    case Figur.Quadrat:
                        return "Seitenlänge:";
                    case Figur.Rechteck:
                        return "Seitenlänge 1:";
                    case Figur.Wuerfel:
                        return "Seitenlänge";
                    default:
                        throw new ArgumentException("Die Figur hat einen ungültigen Typ", "typ");
                }
            }
            else if (parameterNumber == 2)
            {
                switch (typ)
                {
                    case Figur.Rechteck:
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
