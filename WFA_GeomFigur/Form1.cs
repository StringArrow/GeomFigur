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

            //dieses Objekt kümmert sich um alle Ausgabeelemente, die mit den Fiuren zu tun haben
            figurenHandler = new CFigurenHandler(LV_figuren, PL_formen, LV_details);
        }

        //Liste mit den hinzugefügten Figuren
        private CFigurenHandler figurenHandler;

        private void BTN_figurHinzufuegen_Click(object sender, EventArgs e)
        {
            //Dialogfenster öffnen, damit der User die Parameter eingeben kann
            FormFigur formNeueFigur = new FormFigur();
            DialogResult resultNeueFigur = formNeueFigur.ShowDialog();
            if (resultNeueFigur == DialogResult.OK )
            {
                figurenHandler.addFigure(formNeueFigur.NeueFigur);
            }
        }

        private void BTN_figurEntfernen_Click(object sender, EventArgs e)
        {
            figurenHandler.removeSelectedFigure();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            figurenHandler.displaySelectedFigure();
        }

        private void LV_figuren_SelectedIndexChanged(object sender, EventArgs e)
        {
            figurenHandler.displaySelectedFigure();
        }
    }
}
