using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    //reglas de negocio
    public class ClienteService
    {
        //capa de servicio viaja o accede a capa de datos    
        private readonly ClienteDao _clienteDao = new ClienteDao();

        public ClienteService()
        {

        }

        public void crear(clsCliente cliente)
        {
            //regals de negocio
            // regla de negocio valida queno exista un cliente con el mismo id
            if (_clienteDao.consultarPorID(cliente.id) != null)
            {
                throw new Exception("El cliente ya existe");
            }
            // regla de negocio valida que el nombre    
            if (_clienteDao.consultarPorNombre(cliente.nombre) != null)
            {
                throw new Exception("Ya existe un cliente con ese nombre");
            }

            _clienteDao.crear(cliente);

        }

        public void modificar(clsCliente cliente)
        {
            //reglasd de negocio
            _clienteDao.modificar(cliente);
        }

        public void eliminar(int id)
        {
            //reglas de negocio
            //validar que el cliente exista
            if (_clienteDao.consultarPorID(id) == null)
            {
                throw new Exception("El cliente no existe");
            }
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
