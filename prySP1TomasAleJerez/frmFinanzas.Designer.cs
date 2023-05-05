namespace prySP1TomasAleJerez
{
    partial class frmFinanzas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mrcFinanzas = new System.Windows.Forms.GroupBox();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.mrcGastosFijo = new System.Windows.Forms.GroupBox();
            this.txtComida = new System.Windows.Forms.TextBox();
            this.txtAlquiler = new System.Windows.Forms.TextBox();
            this.txtImpuestos = new System.Windows.Forms.TextBox();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblImpuestos = new System.Windows.Forms.Label();
            this.lblAlquiler = new System.Windows.Forms.Label();
            this.mrcGastosVarios = new System.Windows.Forms.GroupBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.mrcIngreso = new System.Windows.Forms.GroupBox();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.mrcFinanzas.SuspendLayout();
            this.mrcGastosFijo.SuspendLayout();
            this.mrcGastosVarios.SuspendLayout();
            this.mrcIngreso.SuspendLayout();
            this.SuspendLayout();
            // 
            // mrcFinanzas
            // 
            this.mrcFinanzas.Controls.Add(this.cmdGrabar);
            this.mrcFinanzas.Controls.Add(this.btnCancelar);
            this.mrcFinanzas.Controls.Add(this.mrcGastosFijo);
            this.mrcFinanzas.Controls.Add(this.mrcGastosVarios);
            this.mrcFinanzas.Controls.Add(this.mrcIngreso);
            this.mrcFinanzas.Location = new System.Drawing.Point(12, 12);
            this.mrcFinanzas.Name = "mrcFinanzas";
            this.mrcFinanzas.Size = new System.Drawing.Size(337, 577);
            this.mrcFinanzas.TabIndex = 0;
            this.mrcFinanzas.TabStop = false;
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Location = new System.Drawing.Point(192, 516);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(88, 31);
            this.cmdGrabar.TabIndex = 3;
            this.cmdGrabar.Text = "Grabar";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(30, 516);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 31);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // mrcGastosFijo
            // 
            this.mrcGastosFijo.Controls.Add(this.txtComida);
            this.mrcGastosFijo.Controls.Add(this.txtAlquiler);
            this.mrcGastosFijo.Controls.Add(this.txtImpuestos);
            this.mrcGastosFijo.Controls.Add(this.lblComida);
            this.mrcGastosFijo.Controls.Add(this.lblImpuestos);
            this.mrcGastosFijo.Controls.Add(this.lblAlquiler);
            this.mrcGastosFijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosFijo.Location = new System.Drawing.Point(6, 111);
            this.mrcGastosFijo.Name = "mrcGastosFijo";
            this.mrcGastosFijo.Size = new System.Drawing.Size(309, 268);
            this.mrcGastosFijo.TabIndex = 1;
            this.mrcGastosFijo.TabStop = false;
            this.mrcGastosFijo.Text = "Gasto Fijo";
            // 
            // txtComida
            // 
            this.txtComida.Location = new System.Drawing.Point(125, 186);
            this.txtComida.Name = "txtComida";
            this.txtComida.Size = new System.Drawing.Size(100, 22);
            this.txtComida.TabIndex = 6;
            // 
            // txtAlquiler
            // 
            this.txtAlquiler.Location = new System.Drawing.Point(125, 53);
            this.txtAlquiler.Name = "txtAlquiler";
            this.txtAlquiler.Size = new System.Drawing.Size(100, 22);
            this.txtAlquiler.TabIndex = 5;
            // 
            // txtImpuestos
            // 
            this.txtImpuestos.Location = new System.Drawing.Point(125, 118);
            this.txtImpuestos.Name = "txtImpuestos";
            this.txtImpuestos.Size = new System.Drawing.Size(100, 22);
            this.txtImpuestos.TabIndex = 4;
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(21, 189);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(60, 16);
            this.lblComida.TabIndex = 3;
            this.lblComida.Text = "Comida";
            // 
            // lblImpuestos
            // 
            this.lblImpuestos.AutoSize = true;
            this.lblImpuestos.Location = new System.Drawing.Point(21, 121);
            this.lblImpuestos.Name = "lblImpuestos";
            this.lblImpuestos.Size = new System.Drawing.Size(78, 16);
            this.lblImpuestos.TabIndex = 2;
            this.lblImpuestos.Text = "Impuestos";
            // 
            // lblAlquiler
            // 
            this.lblAlquiler.AutoSize = true;
            this.lblAlquiler.Location = new System.Drawing.Point(21, 56);
            this.lblAlquiler.Name = "lblAlquiler";
            this.lblAlquiler.Size = new System.Drawing.Size(60, 16);
            this.lblAlquiler.TabIndex = 1;
            this.lblAlquiler.Text = "Alquiler";
            // 
            // mrcGastosVarios
            // 
            this.mrcGastosVarios.Controls.Add(this.txtMonto);
            this.mrcGastosVarios.Controls.Add(this.lblMonto);
            this.mrcGastosVarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcGastosVarios.Location = new System.Drawing.Point(6, 385);
            this.mrcGastosVarios.Name = "mrcGastosVarios";
            this.mrcGastosVarios.Size = new System.Drawing.Size(309, 100);
            this.mrcGastosVarios.TabIndex = 1;
            this.mrcGastosVarios.TabStop = false;
            this.mrcGastosVarios.Text = "Gastos Varios";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(125, 41);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.TabIndex = 2;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(21, 44);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(49, 16);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto";
            // 
            // mrcIngreso
            // 
            this.mrcIngreso.Controls.Add(this.txtDeposito);
            this.mrcIngreso.Controls.Add(this.lblDeposito);
            this.mrcIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrcIngreso.Location = new System.Drawing.Point(6, 19);
            this.mrcIngreso.Name = "mrcIngreso";
            this.mrcIngreso.Size = new System.Drawing.Size(309, 86);
            this.mrcIngreso.TabIndex = 0;
            this.mrcIngreso.TabStop = false;
            this.mrcIngreso.Text = "Ingreso";
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(125, 35);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(100, 22);
            this.txtDeposito.TabIndex = 1;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(21, 38);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(70, 16);
            this.lblDeposito.TabIndex = 0;
            this.lblDeposito.Text = "Deposito";
            // 
            // Finanzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 601);
            this.Controls.Add(this.mrcFinanzas);
            this.Name = "Finanzas";
            this.Text = "Gestion de gastos mensuales";
            this.mrcFinanzas.ResumeLayout(false);
            this.mrcGastosFijo.ResumeLayout(false);
            this.mrcGastosFijo.PerformLayout();
            this.mrcGastosVarios.ResumeLayout(false);
            this.mrcGastosVarios.PerformLayout();
            this.mrcIngreso.ResumeLayout(false);
            this.mrcIngreso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcFinanzas;
        private System.Windows.Forms.GroupBox mrcGastosFijo;
        private System.Windows.Forms.GroupBox mrcGastosVarios;
        private System.Windows.Forms.GroupBox mrcIngreso;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblImpuestos;
        private System.Windows.Forms.Label lblAlquiler;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.TextBox txtComida;
        private System.Windows.Forms.TextBox txtAlquiler;
        private System.Windows.Forms.TextBox txtImpuestos;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDeposito;
    }
}

