using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewCards.Entidades.Enums;

namespace NewCards.Windows
{
    public partial class FrmSeleccionarTipoCarta : Form
    {
        public FrmSeleccionarTipoCarta()
        {
            InitializeComponent();
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private TipoCarta tipoCarta;
        private void CrearMazoButton_Click(object sender, EventArgs e)
        {
            if (Espaniolas40RadioButton.Checked)
            {
                tipoCarta = TipoCarta.Espaniola40;
            }else if (Espaniolas50RadioButton.Checked)
            {
                tipoCarta = TipoCarta.Espaniola50;
            }else if (FrancesasConComodinRadioButton.Checked)
            {
                tipoCarta = TipoCarta.FrancesaConComodin;
            }else if (FrancesasSinComodinRadioButton.Checked)
            {
                tipoCarta = TipoCarta.FrancesaSinComodin;
            }

            FrmVerCartas frm = new FrmVerCartas();
            frm.SetTipoCarta(tipoCarta);
            frm.ShowDialog(this);
        }
    }
}
