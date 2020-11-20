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
    public partial class frmEdad : Form
    {
        public frmEdad()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            //Validaciones
            if(txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Ingresa tu nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                return;
            }
            if(txtEdadIn.Text.Length == 0)
            {
                MessageBox.Show("Ingresa tu edad", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEdadIn.Focus();
                return;
            }

            // Condiciones 
            int edad = int.Parse(txtEdadIn.Text);
            if(!(edad>=15 && edad <= 80)) 
            {
                MessageBox.Show("Ingresa una edad entre 15 y 80 años", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEdadIn.Focus();
                return;
            }
            else if(edad>=15 && edad <= 17)
            {
                txtEdad.Text = "Eres menor de edad";
            }else if(edad >=18 && edad<=25)
            {
                txtEdad.Text = "Puedes votar en las elecciones 2021";
            }else if(edad >=26 && edad <= 30)
            {
                txtEdad.Text = "Ya debes casarte";
            }else if(edad >=31 && edad <= 50)
            {
                txtEdad.Text = "Trabaja, duerme y disfruta";
            }else if(edad > 50)
            {
                txtEdad.Text = "Ya casi llegas a la tercera edad";
            }
        }

        //Funcion para validar soloLetras
        public static void SoloLetras(KeyPressEventArgs v) //Función para validar letras
        {
            if (!(char.IsLetter(v.KeyChar)) && (v.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                v.Handled = true;
                return;
            }
        }

        //Funcion para validar soloNumeros
        public static void soloNumeros(KeyPressEventArgs v) //Función para validar números/decimales
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Solo números enteros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Aplicando validacion en campo nombre
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        //Aplicando validacion en campo edad
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
