using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmClienteLista : Form
    {
        public frmClienteLista()
        {
            InitializeComponent();
        }

        private void frmClienteLista_Load(object sender, EventArgs e)
        {
            cargarListaClientes();
        }

        private void cargarListaClientes()
        {
            //throw new NotImplementedException();
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente();
            frmCliente.ShowDialog();
        }

        
    }
}
