using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace POOYECTO_DE_CATEDRA
{
    public partial class Registro_Empleados : Form
    {
        private Gerente_Dueño _mainForm;

        //para conectar a la base de datos
        private SqlConnection conn1;
        private SqlCommand insert1;
        private string sCn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;

        public Registro_Empleados(Gerente_Dueño mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            RefreshDataGridView();

            Conexión cn1 = new Conexión();
            cn1.conexion();
            sCn1 = cn1.cadena;
            conn1 = new SqlConnection(sCn1);
            conn1.Open();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        //Agregar un nuevo empleado en la base de datos
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Persona empleado = new Persona();
                empleado.Nombre = txtNombre.Text;
                empleado.Apellido = txtApellido.Text;
                empleado.Correo = txtCorreo.Text;
                empleado.Telefono = txtTelefono.Text;

                string insertarEmpleado;

                insertarEmpleado = "insert into Empleado (Nombre, Apellido, Correo, Telefono)";
                insertarEmpleado += "values (@nombre, @apellido, @correo, @telefono)";
                insert1 = new SqlCommand(insertarEmpleado, conn1);
                insert1.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                insert1.Parameters["@nombre"].Value = txtNombre.Text;
                insert1.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                insert1.Parameters["@apellido"].Value = txtApellido.Text;
                insert1.Parameters.Add(new SqlParameter("@correo", SqlDbType.VarChar));
                insert1.Parameters["@correo"].Value = txtCorreo.Text;
                insert1.Parameters.Add(new SqlParameter("@telefono", SqlDbType.VarChar));
                insert1.Parameters["@telefono"].Value = txtTelefono.Text;
                insert1.ExecuteNonQuery();
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                txtTelefono.Text = "";
                MessageBox.Show("El empleado ha sido registrado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshDataGridView();
                conn1.Close();

            }
            catch (ArgumentNullException ex) 
            { 
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            string correo=txtCorreo.Text;
            if (Persona.ValidarCorreo(correo))
            {
                
            }
            else
            {
                MessageBox.Show("El correo no tiene un formato válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
            }

            string telefono= txtTelefono.Text;
            if(Persona.ValidarTelefono(telefono))
            {
                
            }
            else
            {
                MessageBox.Show("El numero de teléfono no tiene un formato válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }


        }

        private void RefreshDataGridView()
        {
            DataSet dn = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Empleado", conn1);
            da1.Fill(dn, "Empleado");
            dataGridView1.DataSource = dn.Tables[0].DefaultView;
        }

        //Eliminar empleado directamente de la base de datos 
        private void btnEliminarEmple_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _mainForm.FocusOnMain3();
            this.Close();
        }
    }
}
