using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class frmClienteLista : Form
    {
        private readonly ClienteService _clienteService; // Servicio de Cliente
        List<clsCliente> lista; // Lista de clientes

        // Constructor
        public frmClienteLista()
        {
            InitializeComponent();
            _clienteService = new ClienteService(); // Inicialización directa
        }

        // Evento Load del formulario
        private void frmClienteLista_Load(object sender, EventArgs e)
        {
            cargarListaClientes();
        }

        // Cargar lista de clientes
        private void cargarListaClientes()
        {
            lista = _clienteService.consultarTodos();
            lstvListaCliente.Items.Clear();

            foreach (clsCliente cliente in lista)
            {
                ListViewItem item = new ListViewItem(cliente.id.ToString());
                item.SubItems.Add(cliente.nombre);
                item.SubItems.Add(cliente.apellido1);
                item.SubItems.Add(cliente.apellido2);
                item.SubItems.Add(cliente.genero.ToString());
                item.SubItems.Add(cliente.fechaNac.ToShortDateString());
                item.SubItems.Add(cliente.email);
                item.SubItems.Add(cliente.estado ? "Activo" : "Inactivo");
                lstvListaCliente.Items.Add(item);
            }
        }

        // Evento Crear cliente
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.ShowDialog();
            cargarListaClientes();
        }

        // Evento doble click sobre ListView para modificar cliente
        private void lstvListaCliente_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            if (lstvListaCliente.SelectedItems.Count > 0)
            {
                int id = int.Parse(lstvListaCliente.SelectedItems[0].SubItems[0].Text);
                clsCliente cliente = lista.Where(c => c.id == id).SingleOrDefault();

                if (cliente != null)
                {
                    frmCliente frm = new frmCliente
                    {
                        clienteSelected = cliente
                    };
                    frm.ShowDialog();
                    cargarListaClientes();
                }
            }
        }

        // Eventos vacíos para diseño
        private void lblTitulo_TextChanged(object sender, EventArgs e) { }
        private void lstvListaCliente_SelectedIndexChanged(object sender, EventArgs e) { }
        private void gbxListaCliente_Enter(object sender, EventArgs e) { }
        private void btnNuevoCliente_TextChanged(object sender, EventArgs e) { }
    }
}
