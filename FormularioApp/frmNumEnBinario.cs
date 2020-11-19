using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioApp
{
    public partial class frmNumEnBinario : Form
    {
        public frmNumEnBinario()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //todo: validar que sean numericos


            //validar que esté en el rango de 0 a 255
            int num = int.Parse(this.txtNumero.Text);

            if(!(num>=0 && num >= 255))
            {
                MessageBox.Show("Tu número debe estar en el rango 0...255", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNumero.Focus();
                return;
            }
        }
    }
}
