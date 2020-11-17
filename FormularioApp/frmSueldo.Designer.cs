namespace FormularioApp
{
    partial class frmSueldo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotalIn = new System.Windows.Forms.TextBox();
            this.txtBono = new System.Windows.Forms.TextBox();
            this.txtValorHora = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalEgr = new System.Windows.Forms.TextBox();
            this.txtCtaPagar = new System.Windows.Forms.TextBox();
            this.txtBar = new System.Windows.Forms.TextBox();
            this.txtAso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(66, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sueldo del trabajador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del trabajador:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotalIn);
            this.groupBox1.Controls.Add(this.txtBono);
            this.groupBox1.Controls.Add(this.txtValorHora);
            this.groupBox1.Controls.Add(this.txtHoras);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresos";
            // 
            // txtTotalIn
            // 
            this.txtTotalIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIn.Location = new System.Drawing.Point(67, 230);
            this.txtTotalIn.Name = "txtTotalIn";
            this.txtTotalIn.ReadOnly = true;
            this.txtTotalIn.Size = new System.Drawing.Size(100, 24);
            this.txtTotalIn.TabIndex = 12;
            // 
            // txtBono
            // 
            this.txtBono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBono.Location = new System.Drawing.Point(67, 174);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(100, 24);
            this.txtBono.TabIndex = 11;
            this.txtBono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBono_KeyPress);
            // 
            // txtValorHora
            // 
            this.txtValorHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorHora.Location = new System.Drawing.Point(67, 121);
            this.txtValorHora.Name = "txtValorHora";
            this.txtValorHora.Size = new System.Drawing.Size(100, 24);
            this.txtValorHora.TabIndex = 10;
            this.txtValorHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorHora_KeyPress);
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(67, 63);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 24);
            this.txtHoras.TabIndex = 9;
            this.txtHoras.TextChanged += new System.EventHandler(this.txtHoras_TextChanged);
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoras_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total de ingresos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Bono de responsabilidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor por hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Horas trabajadas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalEgr);
            this.groupBox2.Controls.Add(this.txtCtaPagar);
            this.groupBox2.Controls.Add(this.txtBar);
            this.groupBox2.Controls.Add(this.txtAso);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(446, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 271);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Egresos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtTotalEgr
            // 
            this.txtTotalEgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalEgr.Location = new System.Drawing.Point(61, 230);
            this.txtTotalEgr.Name = "txtTotalEgr";
            this.txtTotalEgr.ReadOnly = true;
            this.txtTotalEgr.Size = new System.Drawing.Size(100, 24);
            this.txtTotalEgr.TabIndex = 7;
            // 
            // txtCtaPagar
            // 
            this.txtCtaPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCtaPagar.Location = new System.Drawing.Point(61, 174);
            this.txtCtaPagar.Name = "txtCtaPagar";
            this.txtCtaPagar.Size = new System.Drawing.Size(100, 24);
            this.txtCtaPagar.TabIndex = 6;
            this.txtCtaPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCtaPagar_KeyPress);
            // 
            // txtBar
            // 
            this.txtBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBar.Location = new System.Drawing.Point(61, 121);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(100, 24);
            this.txtBar.TabIndex = 5;
            this.txtBar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBar_KeyPress);
            // 
            // txtAso
            // 
            this.txtAso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAso.Location = new System.Drawing.Point(61, 63);
            this.txtAso.Name = "txtAso";
            this.txtAso.Size = new System.Drawing.Size(100, 24);
            this.txtAso.TabIndex = 4;
            this.txtAso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAso_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Total de egresos:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cuenta por pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Aso. de Trabajadores:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(267, 92);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 26);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(54, 421);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(161, 24);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Líquido a recibir";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(303, 217);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(137, 34);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(303, 280);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(137, 31);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmSueldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 466);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSueldo";
            this.Text = "Cálculo del sueldo de un trabajador";
            this.Load += new System.EventHandler(this.frmSueldo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTotalIn;
        private System.Windows.Forms.TextBox txtBono;
        private System.Windows.Forms.TextBox txtValorHora;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalEgr;
        private System.Windows.Forms.TextBox txtCtaPagar;
        private System.Windows.Forms.TextBox txtBar;
        private System.Windows.Forms.TextBox txtAso;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
    }
}