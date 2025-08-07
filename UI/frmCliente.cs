using Entities;
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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void gbxDatosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    clsCliente cliente = new clsCliente();

                    cliente.id = Convert.ToInt32(txtIdCliente.Text);
                    cliente.nombre = txtNombreCliente.Text;
                    cliente.apellido1 = txtApellido1.Text;
                    cliente.apellido2 = txtApellido2.Text;
                    cliente.genero = Convert.ToInt16(txtGenero.Text);
                    cliente.fechaNac = dateCliente.Value;
                    cliente.email = txtCorreoCliente.Text;
                    cliente.estado = chkActivo.Checked;

                    
                    MessageBox.Show("Cliente validado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private bool validarDatos()
        {
            if (txtIdCliente.Text.Length == 0 || !int.TryParse(txtIdCliente.Text, out _))
            {
                MessageBox.Show("El ID es obligatorio y debe ser un número entero.");
                txtIdCliente.Focus();
                return false;
            }

            if (txtNombreCliente.Text.Length < 2)
            {
                MessageBox.Show("El nombre es obligatorio y debe tener al menos 2 caracteres.");
                txtNombreCliente.Focus();
                return false;
            }

            if (txtApellido1.Text.Length < 2)
            {
                MessageBox.Show("El primer apellido es obligatorio y debe tener al menos 2 caracteres.");
                txtApellido1.Focus();
                return false;
            }

            if (txtApellido2.Text.Length < 2)
            {
                MessageBox.Show("El segundo apellido es obligatorio y debe tener al menos 2 caracteres.");
                txtApellido2.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGenero.Text) || !short.TryParse(txtGenero.Text, out short gen) || (gen != 0 && gen != 1))
            {
                MessageBox.Show("El género debe ser 0 (femenino) o 1 (masculino).");
                txtGenero.Focus();
                return false;
            }

            if (dateCliente.Value >= DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento debe ser anterior a hoy.");
                dateCliente.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoCliente.Text) || !txtCorreoCliente.Text.Contains("@"))
            {
                MessageBox.Show("El correo es obligatorio y debe ser válido.");
                txtCorreoCliente.Focus();
                return false;
            }

            return true;
        }


        private void gbxDatosProducto_Enter(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateCliente_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreoCliente_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
