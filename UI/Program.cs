using Services;
using System;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ProductoService _productoServ = new ProductoService();
            ClienteService clienteService = new ClienteService();

            ApplicationConfiguration.Initialize();

            // Ejecutar el formulario principal de clientes
            Application.Run(new frmClienteLista(clienteService));

            // Alternativa para ejecutar el formulario de productos:
            // Application.Run(new frmProductoLista(_productoServ));

            // Para un sistema con login:
            // var loginForm = new frmLogin();
            // if (loginForm.ShowDialog() == DialogResult.OK)
            // {
            //     Application.Run(new frmClienteLista(clienteService));
            // }
        }
    }
}
