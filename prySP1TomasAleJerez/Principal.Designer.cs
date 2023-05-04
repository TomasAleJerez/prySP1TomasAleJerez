namespace prySP1TomasAleJerez
{
    partial class Principal
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
            this.btnFinanzas = new System.Windows.Forms.Button();
            this.btnAlacena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFinanzas
            // 
            this.btnFinanzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinanzas.Location = new System.Drawing.Point(50, 39);
            this.btnFinanzas.Name = "btnFinanzas";
            this.btnFinanzas.Size = new System.Drawing.Size(703, 140);
            this.btnFinanzas.TabIndex = 0;
            this.btnFinanzas.Text = "Finanzas";
            this.btnFinanzas.UseVisualStyleBackColor = true;
            this.btnFinanzas.Click += new System.EventHandler(this.btnFinanzas_Click);
            // 
            // btnAlacena
            // 
            this.btnAlacena.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlacena.Location = new System.Drawing.Point(50, 234);
            this.btnAlacena.Name = "btnAlacena";
            this.btnAlacena.Size = new System.Drawing.Size(703, 140);
            this.btnAlacena.TabIndex = 1;
            this.btnAlacena.Text = "Alacena";
            this.btnAlacena.UseVisualStyleBackColor = true;
            this.btnAlacena.Click += new System.EventHandler(this.btnAlacena_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlacena);
            this.Controls.Add(this.btnFinanzas);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFinanzas;
        private System.Windows.Forms.Button btnAlacena;
    }
}