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
    public partial class frmTabla : Form
    {
        public frmTabla()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(txtNum.Text);
            tabla(num);
        }

        void tabla(double num)
        {
            for(int i = 1; i <= 12; i++)
            {
                listBox1.Items.Add(num + " x " + i + " = " + num * i);
            }
        }
    }
}
