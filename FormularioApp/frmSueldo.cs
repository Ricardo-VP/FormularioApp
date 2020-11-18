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
    public partial class frmSueldo : Form
    {
        public frmSueldo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmSueldo_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //validaciones
            if (this.txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor debes ingresar el nombre..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtNombre.Focus(); //Ubica el cursor en un control
                return;
            }
            //Tarea:
            //1. Validar el ingreso de todos los cuadros de texto
            //2. Validar que el dato ingresado sea numérico 
            // No usar try catch
            // Presentar hasta el miercoles 20:00

            //Tarea:
            //1. Validar el ingreso de todos los cuadros de texto:

            //Ingresos
            if (this.txtHoras.Text.Length == 0) //Validación horas trabajadas
            {
                MessageBox.Show("Por favor debes ingresar las horas trabajadas..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtHoras.Focus();
                return;
            }
            else if (this.txtValorHora.Text.Length == 0) //Validación valor hora
            {
                MessageBox.Show("Por favor debes ingresar el valor por hora..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtValorHora.Focus();
                return;
            }
            else if (this.txtBono.Text.Length == 0) //Validación bono
            {
                MessageBox.Show("Por favor debes ingresar el valor del bono..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtBono.Focus();
                return;
            }

            //Egresos
            else if (this.txtAso.Text.Length == 0) //Validación asociación
            {
                MessageBox.Show("Por favor debes ingresar el egreso por asociación..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtAso.Focus();
                return;
            }
            else if (this.txtBar.Text.Length == 0) //Validación asociación
            {
                MessageBox.Show("Por favor debes ingresar el egreso por bar..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtBar.Focus();
                return;
            }
            else if (this.txtCtaPagar.Text.Length == 0) //Validación asociación
            {
                MessageBox.Show("Por favor debes ingresar el egreso por cuentas por pagar..", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.txtCtaPagar.Focus();
                return;
            }
            
            //sumar los ingresos
            double horasTrabajadas = double.Parse(this.txtHoras.Text);
            double valorHora = double.Parse(this.txtValorHora.Text);
            double bono = double.Parse(this.txtBono.Text);
            double totIng = horasTrabajadas * valorHora + bono;

            //mostrar el total de ingresos en el cuadro de texto 
            this.txtTotalIn.Text = totIng.ToString();

            //sumar los egresos
            double asoTrabajadores = double.Parse(this.txtAso.Text);
            double bar = double.Parse(this.txtBar.Text);
            double ctaPagar = double.Parse(this.txtCtaPagar.Text);
            double totEgr = asoTrabajadores + bar + ctaPagar;

            //mostrar el total de egresos en el cuadro de texto
            this.txtTotalEgr.Text = totEgr.ToString();

            //mostrar mensaje del líquido a recibir
            double LiquidoRecibir = totIng - totEgr;
            lblResultado.Text = "Estimado " + this.txtNombre.Text + ", tu sueldo es: " + LiquidoRecibir;

            }
            
            // Tarea 2: Validar datos

            public static void SoloLetras(KeyPressEventArgs v) //Función para validar letras
            {
            if (!(char.IsLetter(v.KeyChar)) && (v.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                v.Handled = true;
                return;
            }
        }


            public static void NumerosDecimales(KeyPressEventArgs v) //Función para validar números/decimales
            {
                if (Char.IsDigit(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsSeparator(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (Char.IsControl(v.KeyChar))
                {
                    v.Handled = false;
                }
                else if (v.KeyChar.ToString().Equals("."))
                {
                    v.Handled = false;
                }
                else
                {
                    v.Handled = true;
                    MessageBox.Show("Solo números con o sin decimales", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            private void btnSalir_Click(object sender, EventArgs e)
            {
                this.Close(); //Cerrar el formulario actual
            }

            private void txtHoras_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
            {
                NumerosDecimales(e);
            }

            private void txtValorHora_KeyPress(object sender, KeyPressEventArgs e)
            {
                NumerosDecimales(e);
            }

            private void txtBono_KeyPress(object sender, KeyPressEventArgs e)
            {
                NumerosDecimales(e);
            }

            private void txtAso_KeyPress(object sender, KeyPressEventArgs e)
            {
                NumerosDecimales(e);
            }

            private void txtBar_KeyPress(object sender, KeyPressEventArgs e)
            {
                NumerosDecimales(e);
            }

            private void txtCtaPagar_KeyPress(object sender, KeyPressEventArgs e)
            {
                NumerosDecimales(e);
            }

            private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
            {
                SoloLetras(e);
            }
        }
}
