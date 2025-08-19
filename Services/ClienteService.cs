using DAO;
using Entities;
using System;
using System.Collections.Generic;

namespace Services
{
    public class ClienteService
    {
        private readonly ClienteDao _clienteDao = new ClienteDao();

        public void guardar(clsCliente cliente)
        {
            if (_clienteDao.consultarPorID(cliente.id) != null)
                throw new Exception("El cliente ya existe");

            _clienteDao.crear(cliente);
        }

        public void modificar(clsCliente cliente)
        {
            if (_clienteDao.consultarPorID(cliente.id) == null)
                throw new Exception("El cliente no existe");

            _clienteDao.modificar(cliente);
        }

        public void eliminar(int id)
        {
            if (_clienteDao.consultarPorID(id) == null)
                throw new Exception("El cliente no existe");

            _clienteDao.eliminar(id);
        }

        public clsCliente consultarPorID(int id)
        {
            return _clienteDao.consultarPorID(id);
        }

        public List<clsCliente> consultarTodos()
        {
            return _clienteDao.consultarTodos();
        }
    }
}
