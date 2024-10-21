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
   
    public partial class Ventas : Form
    {
        private Gerente_Dueño _mainForm;

        private List<string> listaVentas = new List<string>();
        Persona datoscliente = new Persona();
        Cliente direccioncliente = new Cliente();
        Pedidos datospedido = new Pedidos();

        public Ventas(Gerente_Dueño mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            RefreshDataGridView();
        }

        //método que genera las cadenas de los detalles de cada pedido realizado
        private void CadenasVentas()
        {
            string cadenaDatosCliente = "Nombre: " + datoscliente.Nombre + " Apellidos: " + datoscliente.Apellido + Environment.NewLine
                        + "Teléfono: " + datoscliente.Telefono + Environment.NewLine + "Correo electrónico: " + datoscliente.Correo + Environment.NewLine + "Dirección: " + direccioncliente.Direccion;

            string cadenaDetallesPedido = "Código del Pedido: " + datospedido.GenerarCodPedido() + Environment.NewLine + "Resumen del pedido: " + datospedido.CadenaPedido() + Environment.NewLine
                + "Fecha de pedido: " + datospedido.CadenaFechaPedido();

            double cadenaTotalPedido = datospedido.Total();

        }

        public void VentasRealizadas (string cadenaDatosCliente, string cadenaDetallesPedido, string cadenaTotalPedido)
        {
            CadenasVentas();
            listaVentas.Add($"Cliente: {cadenaDatosCliente}, Total: ${cadenaTotalPedido}, Detalles: {cadenaDetallesPedido}");
        }

        private void RefreshDataGridView()
        {
            
        }

        //para hacer la sumatoria?
        private void TotalVentas()
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _mainForm.FocusOnMain3();
            this.Close();
        }

    }
}
