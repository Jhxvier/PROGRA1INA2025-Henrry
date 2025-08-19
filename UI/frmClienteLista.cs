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
        private readonly ClienteService _clienteService;
        List<clsCliente> lista;

        public frmClienteLista(ClienteService clienteService)
        {
            InitializeComponent();
            _clienteService = clienteService;
        }

        private void frmClienteLista_Load(object sender, EventArgs e)
        {
            cargarListaClientes();
        }

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

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente(_clienteService);
            frm.ShowDialog();
            cargarListaClientes();
        }

        private void lstvListaCliente_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            // Verificar que haya un elemento seleccionado
            if (lstvListaCliente.SelectedItems.Count > 0)
            {
                // Tomamos el id del cliente desde la primera subitem (colId)
                int id = int.Parse(lstvListaCliente.SelectedItems[0].SubItems[0].Text);

                // Buscamos el cliente en la lista cargada
                clsCliente cliente = lista.Where(c => c.id == id).SingleOrDefault();

                if (cliente != null)
                {
                    // Abrimos el formulario de cliente pasando el servicio
                    frmCliente frm = new frmCliente(_clienteService)
                    {
                        clienteSelected = cliente // Pasamos el cliente seleccionado
                    };

                    frm.ShowDialog();

                    // Después de cerrar, recargamos la lista
                    cargarListaClientes();
                }
            }
        }


        private void lblTitulo_TextChanged(object sender, EventArgs e) { }
        private void lstvListaCliente_SelectedIndexChanged(object sender, EventArgs e) { }
        private void gbxListaCliente_Enter(object sender, EventArgs e) { }
        private void btnNuevoCliente_TextChanged(object sender, EventArgs e) { }


    }
}
