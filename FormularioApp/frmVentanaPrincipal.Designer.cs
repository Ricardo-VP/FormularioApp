namespace FormularioApp
{
    partial class frmVentanaPrincipal
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
            this.btnBinANum = new System.Windows.Forms.Button();
            this.btnEdad = new System.Windows.Forms.Button();
            this.btnFechaN = new System.Windows.Forms.Button();
            this.btnNumABin = new System.Windows.Forms.Button();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.btnSueldo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBinANum
            // 
            this.btnBinANum.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBinANum.Location = new System.Drawing.Point(303, 97);
            this.btnBinANum.Name = "btnBinANum";
            this.btnBinANum.Size = new System.Drawing.Size(184, 38);
            this.btnBinANum.TabIndex = 0;
            this.btnBinANum.Text = "Bin a Num";
            this.btnBinANum.UseVisualStyleBackColor = true;
            this.btnBinANum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEdad
            // 
            this.btnEdad.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdad.Location = new System.Drawing.Point(303, 141);
            this.btnEdad.Name = "btnEdad";
            this.btnEdad.Size = new System.Drawing.Size(184, 38);
            this.btnEdad.TabIndex = 1;
            this.btnEdad.Text = "Edad";
            this.btnEdad.UseVisualStyleBackColor = true;
            // 
            // btnFechaN
            // 
            this.btnFechaN.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechaN.Location = new System.Drawing.Point(303, 185);
            this.btnFechaN.Name = "btnFechaN";
            this.btnFechaN.Size = new System.Drawing.Size(184, 38);
            this.btnFechaN.TabIndex = 2;
            this.btnFechaN.Text = "Fecha de nac.";
            this.btnFechaN.UseVisualStyleBackColor = true;
            // 
            // btnNumABin
            // 
            this.btnNumABin.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumABin.Location = new System.Drawing.Point(303, 229);
            this.btnNumABin.Name = "btnNumABin";
            this.btnNumABin.Size = new System.Drawing.Size(184, 38);
            this.btnNumABin.TabIndex = 3;
            this.btnNumABin.Text = "Num a Bin";
            this.btnNumABin.UseVisualStyleBackColor = true;
            // 
            // btnPrimo
            // 
            this.btnPrimo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimo.Location = new System.Drawing.Point(303, 273);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(184, 43);
            this.btnPrimo.TabIndex = 4;
            this.btnPrimo.Text = "Num Primo";
            this.btnPrimo.UseVisualStyleBackColor = true;
            // 
            // btnSueldo
            // 
            this.btnSueldo.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSueldo.Location = new System.Drawing.Point(303, 322);
            this.btnSueldo.Name = "btnSueldo";
            this.btnSueldo.Size = new System.Drawing.Size(184, 43);
            this.btnSueldo.TabIndex = 5;
            this.btnSueldo.Text = "Sueldo";
            this.btnSueldo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "MENÚ PRINCIPAL\r\n";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(303, 395);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(184, 43);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmVentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSueldo);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.btnNumABin);
            this.Controls.Add(this.btnFechaN);
            this.Controls.Add(this.btnEdad);
            this.Controls.Add(this.btnBinANum);
            this.Name = "frmVentanaPrincipal";
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBinANum;
        private System.Windows.Forms.Button btnEdad;
        private System.Windows.Forms.Button btnFechaN;
        private System.Windows.Forms.Button btnNumABin;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Button btnSueldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}