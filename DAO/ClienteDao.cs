using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class ClienteDao
    {
        public List<clsCliente> listaCliente { get; set; }

        public ClienteDao()
        {
            listaCliente = new List<clsCliente>();
        }

        public void crear(clsCliente cliente)
        {
            listaCliente.Add(cliente);
        }

        public void modificar(clsCliente cliente)
        {
            clsCliente clienteModificar = listaCliente.SingleOrDefault(p => p.id == cliente.id);
            int indice = listaCliente.IndexOf(clienteModificar);
            listaCliente[indice] = cliente;
        }

        public void eliminar(int id)
        {
            clsCliente clienteEliminar = listaCliente.SingleOrDefault(p => p.id == id);
            listaCliente.Remove(clienteEliminar);
        }

        public clsCliente consultarPorID(int id)
        {
            return listaCliente.SingleOrDefault(p => p.id == id);
        }

        public List<clsCliente> consultarTodos()
        {
            return listaCliente;
        }
    }
}
