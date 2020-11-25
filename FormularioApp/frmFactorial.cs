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
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);
            txtFac.Text = Convert.ToString(factorial(num));

            
        }
        int factorial(int n)
        {
            if (n > 1)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return n;
            }
        }   

    }  

    


}
