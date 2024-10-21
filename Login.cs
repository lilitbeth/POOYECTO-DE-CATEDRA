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
    public partial class Login : Form
    {
        private Form1 _mainForm;

        private SqlConnection conn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();

        public Login(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;

            cnn.ConnectionString = @"PROVIDER= SQLOLEDB; Server= localhost; Database = PupuseriaBD; Integrated Security = sspi";
            Conexión cn1 = new Conexión();
            cn1.conexion();
            sCn1 = cn1.cadena;
            conn1 = new SqlConnection(sCn1);
            conn1.Open();
            comboBox2.Items.Add("Empleado");
            comboBox2.Items.Add("Gerente");
        }
        //Boton que permitira el accesso de empleados y dueño segun credenciales
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string seleccion;
            string Usuario = txtUsuario.Text.Trim();
            string Contraseña = txtContraseña.Text.Trim();

            if (comboBox2.SelectedItem.ToString() == "Empleado")
            {
                seleccion = "select * from UsuarioEmpleado where usuarioEmpleado= @NombreUsuario and contraEmpleado = @Contraseña";
                using (SqlConnection conn1 = new SqlConnection("Server = localhost; Database = PupuseriaBD; Integrated Security = sspi"))
                {
                    using (SqlCommand cmd= new SqlCommand(seleccion, conn1))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", Usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                        try
                        {
                            conn1.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            if(reader.HasRows)
                            {
                                MessageBox.Show("Acceso Concedido");
                            }
                            else
                            {
                                MessageBox.Show("Acceso denegado. Ingrese credenciales correctas");
                            }
                            reader.Close();
                        }catch (Exception ex)
                        {
                            MessageBox.Show("Error al conectar", ex.Message);
                        }
                    }
                }
            }
            else if (comboBox2.SelectedItem.ToString() == "Gerente")
            {
                seleccion = "select * from UsuarioGerente where usuarioGerente= @NombreUsuario and contraGerente = @Contraseña";
                using (SqlConnection conn1 = new SqlConnection("Server = localhost; Database = PupuseriaBD; Integrated Security = sspi"))
                {
                    using (SqlCommand cmd = new SqlCommand(seleccion, conn1))
                    {
                        cmd.Parameters.AddWithValue("@NombreUsuario", Usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                        try
                        {
                            conn1.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.HasRows)
                            {
                                MessageBox.Show("Acceso Concedido");
                            }
                            else
                            {
                                MessageBox.Show("Acceso denegado. Ingrese credenciales correctas");
                            }
                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al conectar", ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de usuario.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _mainForm.FocusOnMain1();
            this.Close();

        }

        //Combo box para seleccionar tipo de usuario
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
