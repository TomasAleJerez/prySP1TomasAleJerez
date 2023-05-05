using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySP1TomasAleJerez
{
    public partial class frmFinanzas : Form
    {
        public frmFinanzas()
        {
            InitializeComponent();
        }
        private void mrcIngreso_Enter(object sender, EventArgs e) 
        { 
        
        }
        private void FrmFinanzas_Load(object sender, EventArgs e) 
        {
            var deposito = 0;
            var alquiler = 0;
            var impuesto = 0;
            var comida = 0;
            var monto = 0;
        }
        private void cmdGrabar_Click(object sender, EventArgs e) 
        {
            var deposito= Convert.ToDecimal(txtDeposito.Text);
            var alquiler= Convert.ToDecimal(txtAlquiler.Text);
            var impuesto = Convert.ToDecimal(txtImpuestos.Text);
            var comida= Convert.ToDecimal(txtComida.Text);
            var calculo = deposito− alquiler− impuesto− comida;
            txtMonto.Text = calculo.ToString();


        }
    }

}
