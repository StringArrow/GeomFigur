using System;
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
        private List<IDynamicFigure> figures = new List<IDynamicFigure>();

        private void BTN_figurHinzufuegen_Click(object sender, EventArgs e)
        {
            CFlaeche flaeche = new CFlaeche();
            flaeche.setFarbe("Braun");
            flaeche.setFlaecheninhalt(12.3);
            flaeche.setBezeichnung("Ich bin eine Fläche");

            //figures.Add(flaeche);
        }
    }
}
