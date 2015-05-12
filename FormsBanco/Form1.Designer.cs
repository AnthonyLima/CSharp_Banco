namespace FormsBanco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.btnCrearCuenta = new System.Windows.Forms.Button();
            this.btnHacerDeposito = new System.Windows.Forms.Button();
            this.btnHacerRetiro = new System.Windows.Forms.Button();
            this.btnConsultarCuenta = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.Location = new System.Drawing.Point(33, 41);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(113, 43);
            this.btnCrearCliente.TabIndex = 0;
            this.btnCrearCliente.Text = "Crear Cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = true;
            // 
            // btnCrearCuenta
            // 
            this.btnCrearCuenta.Location = new System.Drawing.Point(208, 41);
            this.btnCrearCuenta.Name = "btnCrearCuenta";
            this.btnCrearCuenta.Size = new System.Drawing.Size(108, 43);
            this.btnCrearCuenta.TabIndex = 1;
            this.btnCrearCuenta.Text = "CrearCuenta";
            this.btnCrearCuenta.UseVisualStyleBackColor = true;
            // 
            // btnHacerDeposito
            // 
            this.btnHacerDeposito.Location = new System.Drawing.Point(33, 122);
            this.btnHacerDeposito.Name = "btnHacerDeposito";
            this.btnHacerDeposito.Size = new System.Drawing.Size(113, 45);
            this.btnHacerDeposito.TabIndex = 2;
            this.btnHacerDeposito.Text = "Hacer Deposito";
            this.btnHacerDeposito.UseVisualStyleBackColor = true;
            // 
            // btnHacerRetiro
            // 
            this.btnHacerRetiro.Location = new System.Drawing.Point(208, 122);
            this.btnHacerRetiro.Name = "btnHacerRetiro";
            this.btnHacerRetiro.Size = new System.Drawing.Size(108, 45);
            this.btnHacerRetiro.TabIndex = 3;
            this.btnHacerRetiro.Text = "Hacer Retiro";
            this.btnHacerRetiro.UseVisualStyleBackColor = true;
            // 
            // btnConsultarCuenta
            // 
            this.btnConsultarCuenta.Location = new System.Drawing.Point(33, 201);
            this.btnConsultarCuenta.Name = "btnConsultarCuenta";
            this.btnConsultarCuenta.Size = new System.Drawing.Size(113, 46);
            this.btnConsultarCuenta.TabIndex = 4;
            this.btnConsultarCuenta.Text = "Consultar";
            this.btnConsultarCuenta.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(208, 201);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 46);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 309);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultarCuenta);
            this.Controls.Add(this.btnHacerRetiro);
            this.Controls.Add(this.btnHacerDeposito);
            this.Controls.Add(this.btnCrearCuenta);
            this.Controls.Add(this.btnCrearCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Button btnCrearCuenta;
        private System.Windows.Forms.Button btnHacerDeposito;
        private System.Windows.Forms.Button btnHacerRetiro;
        private System.Windows.Forms.Button btnConsultarCuenta;
        private System.Windows.Forms.Button btnSalir;
    }
}

