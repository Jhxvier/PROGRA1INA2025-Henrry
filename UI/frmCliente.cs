using Entities;
using Services;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmCliente : Form
    {
        private readonly ClienteService _clienteService; // Servicio de cliente
        public clsCliente clienteSelected { get; set; }  // Cliente seleccionado (para modificar)

        // Constructor
        public frmCliente()
        {
            InitializeComponent();
            _clienteService = new ClienteService(); // Inicialización directa
        }

        // Evento Load del formulario
        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (clienteSelected != null) // modificar
            {
                txtIdCliente.Text = clienteSelected.id.ToString();
                txtNombreCliente.Text = clienteSelected.nombre;
                txtApellido1.Text = clienteSelected.apellido1;
                txtApellido2.Text = clienteSelected.apellido2;
                txtGenero.Text = clienteSelected.genero.ToString();
                dateCliente.Value = clienteSelected.fechaNac;
                txtCorreoCliente.Text = clienteSelected.email;
                chkActivo.Checked = clienteSelected.estado;
            }
        }

        // Validación de datos obligatorios
        private bool validarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtNombreCliente.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtApellido1.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtCorreoCliente.Text)) return false;
            return true;
        }

        // Evento Guardar/Modificar
        private void btnGuardarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    clsCliente cliente = new clsCliente
                    {
                        id = Convert.ToInt32(txtIdCliente.Text),
                        nombre = txtNombreCliente.Text,
                        apellido1 = txtApellido1.Text,
                        apellido2 = txtApellido2.Text,
                        genero = Convert.ToInt16(txtGenero.Text),
                        fechaNac = dateCliente.Value,
                        email = txtCorreoCliente.Text,
                        estado = chkActivo.Checked
                    };

                    if (clienteSelected == null) // Crear
                        _clienteService.crear(cliente);
                    else // Modificar
                        _clienteService.modificar(cliente);

                    MessageBox.Show("Cliente guardado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Faltan datos obligatorios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Evento Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (clienteSelected != null)
            {
                try
                {
                    DialogResult resp = MessageBox.Show("¿Desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        _clienteService.eliminar(clienteSelected.id);
                        MessageBox.Show("Cliente eliminado correctamente");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        // Evento Cancelar
        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Eventos de cambio de texto vacíos para diseño
        private void txtNombreCliente_TextChanged(object sender, EventArgs e) { }
        private void txtIdCliente_TextChanged(object sender, EventArgs e) { }
        private void txtGenero_TextChanged(object sender, EventArgs e) { }
        private void txtCorreoCliente_TextChanged(object sender, EventArgs e) { }
        private void txtApellido1_TextChanged(object sender, EventArgs e) { }
        private void txtApellido2_TextChanged(object sender, EventArgs e) { }
        private void lblTitulo_TextChanged(object sender, EventArgs e) { }
        private void lblTitulo_DoubleClick(object sender, EventArgs e) { }
        private void lblTitulo_Click(object sender, EventArgs e) { }
        private void gbxDatosProducto_Enter(object sender, EventArgs e) { }
        private void dateCliente_ValueChanged(object sender, EventArgs e) { }
        private void chkActivo_TextChanged(object sender, EventArgs e) { }
        private void chkActivo_CheckedChanged(object sender, EventArgs e) { }
    }
}
