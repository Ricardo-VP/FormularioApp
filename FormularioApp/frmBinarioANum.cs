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
    public partial class frmBinarioANum : Form
    {
        public frmBinarioANum()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double res = 0;
            double sum = 0;
            if (chk1.Checked == true)
            {
                res = Math.Pow(2, 0);
                sum += res;
            }
            if (chk2.Checked == true)
            {
                res = Math.Pow(2, 1);
                sum += res;
            }
            if (chk3.Checked == true)
            {
                res = Math.Pow(2, 2);
                sum += res;
            }
            if (chk4.Checked == true)
            {
                res = Math.Pow(2, 3);
                sum += res;
            }
            if (chk5.Checked == true)
            {
                res = Math.Pow(2, 4);
                sum += res;
            }
            if (chk6.Checked == true)
            {
                res = Math.Pow(2, 5);
                sum += res;
            }
            if (chk7.Checked == true)
            {
                res = Math.Pow(2, 6);
                sum += res;
            }
            if (chk8.Checked == true)
            {
                res = Math.Pow(2, 7);
                sum += res;
            }
            txtResultado.Text = sum.ToString(); 
        }
    }
}
