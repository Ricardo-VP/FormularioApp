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
    public partial class frmNumPrimo : Form
    {
        public frmNumPrimo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNum.Text);
            primo(numero);
        }

        void primo(int num)
        {
            int contador=0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                lblRes.Text = Convert.ToString(num + " es primo");
            }
            else
            {
                lblRes.Text = Convert.ToString(num + " no es primo");
            }
        }
    }
}
