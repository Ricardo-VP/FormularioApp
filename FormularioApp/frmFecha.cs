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
    public partial class frmFecha : Form
    {
        public frmFecha()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edadAn = DateTime.Today.Year - dtpFecha.Value.Year;
            txtEdadAn.Text = Convert.ToString(edadAn + " años de edad");
            double edadDias = (DateTime.Today.Year - dtpFecha.Value.Year)*365.25;
            edadDias += (DateTime.Today.Month - dtpFecha.Value.Month) * 30.75;
            edadDias += DateTime.Today.Day - dtpFecha.Value.Day;
            txtEdadDias.Text = Convert.ToString(edadDias + " días de edad");
        }
    }
}
