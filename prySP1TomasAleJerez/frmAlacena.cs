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
    public partial class frmAlacena : Form
    {
        public frmAlacena()
        {
            InitializeComponent();
        }

        private void frmAlacena_Load(object sender, EventArgs e)
        {
            cboProducto.Items.Add("Azucar");
            cboProducto.Items.Add("Te");
            cboProducto.Items.Add("Arroz");
            cboProducto.Items.Add("Detergente");
            cboProducto.Items.Add("Trapo");
            cboProducto.Items.Add("Esponja");
            cboProducto.Items.Add("Cerveza");

            
        }
    }
}
