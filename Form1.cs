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
    public partial class Form1 : Form
    {
        Realizar_Pedido realizarPedido;
        Ventana_Empleados Empleados;
        Gerente_Dueño Dueño;
        Login loginE_D;
        Acerca_de acerca;

        //para conectar a la base de datos
        private SqlConnection conn1;
        private SqlDataAdapter da1;
        private SqlDataReader dr1;
        private string sCn1;
        OleDbConnection cnn = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            mdiProp();

            cnn.ConnectionString = @"PROVIDER= SQLOLEDB; Server= localhost; Database = PupuseriaBD; Integrated Security = yes";
            Conexión cn1 = new Conexión();
            cn1.conexion();
            sCn1 = cn1.cadena;
            conn1 = new SqlConnection(sCn1);
            conn1.Open();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        bool expandirMenu = false;
        
        private void transicion_menú2_Tick(object sender, EventArgs e)
        {
            if (expandirMenu == false)
            {
                menuConteiner2.Height += 25;
                if (menuConteiner2.Height >= 110)
                {
                    transicion_menú2.Stop();
                    expandirMenu = true;
                }
            }
            else
            {
                menuConteiner2.Height -= 25;
                if (menuConteiner2.Height <= 49)
                {
                    transicion_menú2.Stop();
                    expandirMenu = false;
                }
            }
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            transicion_menú2.Start();
        }

        bool expandirBarra = false;

        private void timerbarra_Tick(object sender, EventArgs e)
        {
            if (expandirBarra)
            {
                barraMenu.Width -= 25;
                if(barraMenu.Width <=55)
                {
                    timerbarra.Stop();
                    expandirBarra = false;
                }
            }
            else
            {
                barraMenu.Width += 25;
                if(barraMenu.Width >=220)
                {
                    timerbarra.Stop();
                    expandirBarra = true;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerbarra.Start();
        }

        // Método para recibir el foco desde formularios secundarios
        public void FocusOnMain1()
        {
            this.Activate();
        }

        //Boton de iniciar sesion, atraves de un login se determinara si abrir un a ventana u otra 
        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginE_D = new Login(this);
            loginE_D.MdiParent = this;
            loginE_D.Show();
        }

        //Boton para form de realizar pedido
        private void btnRePedido_Click(object sender, EventArgs e)
        {
            realizarPedido = new Realizar_Pedido(this);
            realizarPedido.MdiParent = this;
            realizarPedido.Show();
        }

        private void btnAcerca_Click(object sender, EventArgs e)
        {
            acerca = new Acerca_de(this);
            acerca.MdiParent = this;
            acerca.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
   
}

