using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOYECTO_DE_CATEDRA
{
    public partial class Pedidos_Realizados : Form
    {
        private List<string> listaPedidos = new List<string>();
        Persona datoscliente = new Persona();
        Cliente direccioncliente = new Cliente();
        Pedidos datospedido = new Pedidos();

        private Ventana_Empleados _mainForm;

        public Pedidos_Realizados(Ventana_Empleados mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;   
        }

        private void CadenaPedidos()
        {
            string cadenaDatosCliente = "Nombre: " + datoscliente.Nombre + " Apellidos: " + datoscliente.Apellido + Environment.NewLine
                        + "Teléfono: " + datoscliente.Telefono + Environment.NewLine + "Correo electrónico: " + datoscliente.Correo + Environment.NewLine + "Dirección: " + direccioncliente.Direccion;

            string cadenaDetallesPedido = "Código del Pedido: " + datospedido.GenerarCodPedido() + Environment.NewLine + "Resumen del pedido: " + datospedido.CadenaPedido() + Environment.NewLine
                + "Fecha de pedido: " + datospedido.CadenaFechaPedido();

            double cadenaTotalPedido = datospedido.Total();

        }
        
        public void LlegadaDePedido(string cadenaDatosCliente, string cadenaDetallesPedido, string cadenaTotalPedido)//los pedidos que llegan 
        {
            CadenaPedidos();

            listaPedidos.Add($"Cliente: {cadenaDatosCliente}, Total: ${cadenaTotalPedido}, Detalles: {cadenaDetallesPedido}");

            MessageBox.Show($"Nuevo pedido de {cadenaDatosCliente}\nTotal: ${cadenaTotalPedido}\nDetalles: ${cadenaDetallesPedido}", "Pedido Recibido");
        }

        public void RevisarPedidos()
        {
            if (listaPedidos.Count == 0)
            {
                MessageBox.Show("No hay pedidos registrados.", "Revisión de Pedidos");
            }
            else
            {
                string todosLosPedidos = string.Join("\n", listaPedidos);
                MessageBox.Show($"Pedidos recibidos:\n{todosLosPedidos}", "Revisión de Pedidos");
            }
        }
        public void EliminarPedidos()
        {
            listaPedidos.Clear();
            MessageBox.Show("Todos los pedidos han sido eliminados.", "Pedidos Eliminados");
            
        }

        private void Pedidos_Realizados_Load(object sender, EventArgs e)
        {

        }
        // En este boton se eliminaria del datagrid el pedido que se selccione, pero no de la base de datos 
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _mainForm.FocusOnMain2();
            this.Close();
        }
    }
}
