﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    internal class CRechteck : CFlaeche
    {
        //Attribute
        private double breite;
        private double hoehe;

        //Konstruktor
        public CRechteck(double breite, double hoehe, Color farbe)
        {
            setBreite(breite);
            setHoehe(hoehe);
            setFarbe(farbe);
        }

        //Methoden
        public double getBreite()
        {
            return breite;
        }
        public void setBreite(double newBreite)
        {
            breite = newBreite;
        }
        public double getHoehe()
        {
            return hoehe;
        }
        public void setHoehe(double newHoehe)
        {
            hoehe = newHoehe;
        }
        public override double getFlaecheninhalt()
        {
            setFlaecheninhalt(breite * hoehe);
            return getFlaecheninhalt();
        }
        public override double getUmfang()
        {
            setUmfang(breite * hoehe * 2);
            return getUmfang();
        }
        public override Rectangle berechneMaxFigurGroesse(Panel panel)
        {
            Rectangle rectangle = base.berechneMaxFigurGroesse(panel);

            //Etwas von der Höhe abziehen um aus dem Quadrat ein Rechteck zu machen
            rectangle.Height /= 2;

            //Startpunkt anpassen, um Symmetrie sicherzustellen
            rectangle.Y = rectangle.Height / 2;
            return rectangle;
        }

        public override void zeichneFigur(Graphics graphics, SolidBrush solidBrush, Rectangle coordinates)
        {
            graphics.FillRectangle(solidBrush, coordinates);
        }
    }
}