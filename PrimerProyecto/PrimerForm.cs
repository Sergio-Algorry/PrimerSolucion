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
        public PrimerForm()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            lblHolaMundo.Text = "Hola " + txtNombre.Text;
        }
    }
}
