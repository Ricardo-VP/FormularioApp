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
    public partial class frmVentanaPrincipal : Form
    {
        public frmVentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir el formulario de bin a num
            frmBinarioANum frm1 = new frmBinarioANum();
            frm1.ShowDialog(); //Mostrar el formulario
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            frmEdad frm2 = new frmEdad();
            frm2.ShowDialog();
        }

        private void btnFechaN_Click(object sender, EventArgs e)
        {
            frmFecha frm3 = new frmFecha();
            frm3.ShowDialog();
        }

        private void btnNumABin_Click(object sender, EventArgs e)
        {
            frmNumEnBinario frm4 = new frmNumEnBinario();
            frm4.ShowDialog();
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            frmNumPrimo frm5 = new frmNumPrimo();
            frm5.ShowDialog();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            frmSueldo frm6 = new frmSueldo();
            frm6.ShowDialog();
        }
    }
}
