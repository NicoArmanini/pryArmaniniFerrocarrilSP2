using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArmaniniFerrocarrilSP2
{
    public partial class frmFerroc : Form
    {

        public frmFerroc()
        {
            InitializeComponent();
        }

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            int vDias = 1;
            int vDistancia = 1;
            int vSumaTotal = 0;

            vDias = int.Parse(nudDias.Text);
            vDistancia = int.Parse(txtDistancia.Text);

            vSumaTotal = vDistancia * 5;


            //if (vDias <= 7 && vDistancia >= 100)
            //{
            //    vSumaTotal = (vSumaTotal * 50) / 100;

            //    lblPrecioF.Text = "CONTROLE LA CANTIDAD" +
            //       "DE CADA PRODUCTO, la suma debe dar 100" +
            //       "Tu calculo resulta en : " + vSumaTotal;
            //    //cambiar el color de la fuente por rojo
            //    lblPrecioF.ForeColor = Color.Red;
            //}

        }

        private void txtDistancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
