using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
            //int vDias = 1;
            //int vDistancia = 1;
            //int vSumaTotal = 0;

            //vDias = int.Parse(nudDias.Text);
            //vDistancia = int.Parse(txtDistancia.Text);


            //vSumaTotal = vDistancia * 5;

            string ComprueboDistancia = txtDistancia.Text.Trim();
            

            if (ComprueboDistancia.Length > 0)
            {
                int distancia = Convert.ToInt32(txtDistancia.Text); 

                if (distancia > 0)
                {
                    if (Convert.ToInt32(nudDias.Value) >= 7 && distancia >= 100)
                    {
                        lblPrecio1.Text = Convert.ToString(2.50 * distancia);
                        lblTotal1.Text = "$ 2.5";
                    }
                    else
                    {
                        lblPrecio1.Text = Convert.ToString(5 * distancia);
                        lblTotal1.Text = "$ 5";
                        
                    }
                }
                else
                {
                    MessageBox.Show("Ingresar distancia", "Atencion",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                
            }
            
            

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
