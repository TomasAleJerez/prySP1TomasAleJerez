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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnFinanzas_Click(object sender, EventArgs e)
        {
            frmFinanzas frmFinanzas = new frmFinanzas();
            frmFinanzas.ShowDialog();
        }

        private void btnAlacena_Click(object sender, EventArgs e)
        {
            frmAlacena frmAlacena = new frmAlacena();  
            frmAlacena.ShowDialog();
        }
    }
}
