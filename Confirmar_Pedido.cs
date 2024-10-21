using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POOYECTO_DE_CATEDRA
{
    public partial class Confirmar_Pedido : Form
    {           
        Pedidos confirmacionPedido = new Pedidos();
        Cliente confirmarCliente = new Cliente();
        Persona clientes = new Persona();

        public Confirmar_Pedido()
        {
            InitializeComponent();
            RefreshDataGridView();
        }

        //método de limpieza para el datagridview

        private void limpiar()
        {
            txtNombre.Clear();
            txtDirección.Clear();
            txtTelefono.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
        }

        //método de validación de datos del cliente 
        private void guardar()
        { 
            try
            {
                clientes.Nombre = txtNombre.Text; 
                clientes.Apellido = txtApellido.Text;

                MessageBox.Show("El cliente ha sido registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string correo = txtCorreo.Text;
            if (Persona.ValidarCorreo(correo))
            {

            }
            else
            {
                MessageBox.Show("El correo no tiene un formato válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
            }

            string telefono = txtTelefono.Text;
            if (Persona.ValidarTelefono(telefono))
            {

            }
            else
            {
                MessageBox.Show("El numero de teléfono no tiene un formato válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }

            confirmarCliente.direccion = txtDirección.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string codPed = confirmacionPedido.GenerarCodPedido();
                string resumenPed = confirmacionPedido.CadenaPedido();
                double totalPed = confirmacionPedido.Total();
                string fechaPed = confirmacionPedido.CadenaFechaPedido();

                guardar();

                DataTable table = new DataTable();
                table.Columns.Add("Nombre", typeof(string));
                table.Columns.Add("Apellido", typeof(string));
                table.Columns.Add("Correo", typeof(string));
                table.Columns.Add("Telefono", typeof(string));
                table.Columns.Add("Dirección", typeof(string));
                table.Columns.Add("Número de orden", typeof(string));
                table.Columns.Add("Resumen del pedido", typeof(string));
                table.Columns.Add("Fecha del pedido", typeof(string));

                table.Rows.Add(clientes.Nombre, clientes.Apellido, clientes.Correo, clientes.Telefono, confirmarCliente.Direccion, codPed, resumenPed, fechaPed);
                dataGridView1.DataSource = table;
                limpiar();

                MessageBox.Show("TICKET DE PAGO \n" + "Codigo del Pedido" + codPed + Environment.NewLine + "Nombre: " + clientes.Nombre + " Apellidos: " + clientes.Apellido + Environment.NewLine
                    + "Teléfono: " + clientes.Telefono + Environment.NewLine + "Correo electrónico: " + clientes.Correo + Environment.NewLine + "Dirección: " + confirmarCliente.Direccion + Environment.NewLine
                    + "Resumen del pedido: " + resumenPed + Environment.NewLine + "Total a pagar: $" + totalPed + Environment.NewLine + "Fecha del pedido: " + fechaPed + Environment.NewLine + "PRESENTE ESTE TICKET EN CAJA");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo guardar el pedido","Error" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void RefreshDataGridView()
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
