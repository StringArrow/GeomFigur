﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GeomFigur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Liste mit den hinzugefügten Figuren
        private List<CGeomFigur> figuren = new List<CGeomFigur>();
        private void BTN_figurHinzufuegen_Click(object sender, EventArgs e)
        {
            CGeomFigur figur = new CKugel(10, Color.Green);

            figuren.Add(figur);

            figur.zeichneFigurImPanel(PL_formen);
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            foreach (var figur in figuren)
            {
                figur.zeichneFigurImPanel(PL_formen);
            }
        }
    }
}
