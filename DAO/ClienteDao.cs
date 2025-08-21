using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClienteDao
    {
        //CRUD
        private dbContextINA _context;

        //public List<clsCliente> listaCliente { get; set; }

        public ClienteDao()
        {
            _context = new dbContextINA();
            // listaCliente = new List<clsCliente>();
        }

        public void crear(clsCliente cliente)
        {
            // listaCliente.Add(cliente);

            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void modificar(clsCliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();

            //expresion lambda
            //busco por id el cliente que quiero modificar en la lista 
            //clsCliente clienteModificar = listaCliente.Where(p => p.id
            //== cliente.id).SingleOrDefault();

            //int 
            // encuento el indice del cliente que quiero modificar, indice de la lista
            //int indice = listaCliente.IndexOf(clienteModificar);
            //le caigo encima al indice del cliente que quiero modificar
            //listaCliente[indice] = cliente;
        }

        public void eliminar(int id)
        {
            var cliente = consultarPorID(id);
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            // clsCliente clienteEliminar = listaCliente.Where(p => p.id
            // == id).SingleOrDefault();
            // listaCliente.Remove(clienteEliminar);
        }

        public clsCliente consultarPorID(int id)
        {
            return _context.Clientes.Where(p => p.id
                                               == id).SingleOrDefault();
        }

        public clsCliente consultarPorNombre(string nombre)
        {
            return _context.Clientes.Where(p => p.nombre.Trim().ToUpper()
                                               == nombre.Trim().ToUpper()).SingleOrDefault();
        }

        public List<clsCliente> consultarTodos()
        {
            return _context.Clientes.ToList();
        }
    }
}
