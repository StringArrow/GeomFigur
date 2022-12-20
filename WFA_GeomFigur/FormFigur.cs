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
    public partial class FormFigur : Form
    {
        public CGeomFigur NeueFigur { get; set; }

        public FormFigur()
        {
            InitializeComponent();

            //NumericUpDowns initialisieren
            NUD_value1.Maximum = Decimal.MaxValue;
            NUD_value2.Maximum = Decimal.MaxValue;

            //Initial das erste Element anzeigen
            this.CB_figureType.SelectedIndex = 0;
        }

        private void BTN_create_Click(object sender, EventArgs e)
        {
            //Rückgabeobjekt erstellen
            try
            {
                //Erstelle neue Figur
                this.NeueFigur = CGeomFigurCreator.Factory(CB_figureType.SelectedItem.ToString(),
                                                           TB_bezeichnung.Text,
                                                           colorDialog.Color,
                                                           (double)NUD_value1.Value,
                                                           (double)NUD_value2.Value);

                //Fenster schließen
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

            //Falsche Werte eingegeben
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void CB_figureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dispayAdequateElements(CB_figureType.SelectedItem.ToString());
        }
        private void dispayAdequateElements(string figureType)
        {
            //Anzahl der benötigten Eingabefelder ermitteln
            int valuesCount = CGeomFigurCreator.getCountOfNeededValues(figureType);

            //Benötigte Eingabefelder anzeigen oder verstecken
            this.LBL_value1.Visible = false;
            this.NUD_value1.Visible = false;
            this.LBL_value2.Visible = false;
            this.NUD_value2.Visible = false;

            if (valuesCount >= 1)
            {
                this.LBL_value1.Text = CGeomFigurCreator.getParameterName(figureType, 1);
                this.LBL_value1.Visible = true;
                this.NUD_value1.Visible = true;
            }
            if (valuesCount >= 2)
            {
                this.LBL_value2.Text = CGeomFigurCreator.getParameterName(figureType, 2);
                this.LBL_value2.Visible = true;
                this.NUD_value2.Visible = true;
            }
        }

        private void BTN_color_Click(object sender, EventArgs e)
        {
            DialogResult resultColorDialog = this.colorDialog.ShowDialog();
            if (resultColorDialog == DialogResult.OK)
            {
                BTN_colorDummy.BackColor = colorDialog.Color;
            }
        }
    }
}
