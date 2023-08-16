using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerProyecto
{
    public partial class PrimerForm : Form
    {
        int sumando1 = 10;
        int sumando2 = 10;
        int Resultado = 0;

        public PrimerForm()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            lblHolaMundo.Text = "Hola " + txtNombre.Text;
        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            Resultado = sumando1 + sumando2;

            lblHolaMundo.Text = Resultado.ToString();
            //lblHolaMundo.Text = Convert.ToString( Resultado);

        }

        private void btSuma2_Click(object sender, EventArgs e)
        {
            lblHolaMundo.Text = Resultado.ToString();
        }
    }
}
