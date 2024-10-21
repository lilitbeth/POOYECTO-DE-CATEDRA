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
    public partial class Gerente_Dueño : Form
    {
        Revisar_Inventario ReviInventario;
        Registro_Empleados Registro;
        Ventas ventas;

        public Gerente_Dueño()
        {
            InitializeComponent();
            mdiProp();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.White;
        }

        bool expandirMenu = false;
        private void transicion_menú_Tick(object sender, EventArgs e)
        {
            if (expandirMenu == false)
            {
                menuConteiner1.Height += 25;
                if (menuConteiner1.Height >= 162)
                {
                    transicion_menú.Stop();
                    expandirMenu = true;
                }
            }
            else
            {
                menuConteiner1.Height -= 25;
                if (menuConteiner1.Height <= 49)
                {
                    transicion_menú.Stop();
                    expandirMenu = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            transicion_menú.Start();
        }
        bool expandirMenu2 = false;
        private void transicion_menú2_Tick(object sender, EventArgs e)
        {
            if (expandirMenu2 == false)
            {
                menuConteiner2.Height += 25;
                if (menuConteiner2.Height >= 110)
                {
                    transicion_menú2.Stop();
                    expandirMenu2 = true;
                }
            }
            else
            {
                menuConteiner2.Height -= 25;
                if (menuConteiner2.Height <= 49)
                {
                    transicion_menú2.Stop();
                    expandirMenu2 = false;
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
                if (barraMenu.Width <= 55)
                {
                    timerbarra.Stop();
                    expandirBarra = false;
                }
            }
            else
            {
                barraMenu.Width += 25;
                if (barraMenu.Width >= 220)
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
        public void FocusOnMain3()
        {
            this.Activate();
        }

        //Acceder al form de revison de inventario 
        private void btnInventario_Click(object sender, EventArgs e)
        {
            ReviInventario = new Revisar_Inventario(this);
            ReviInventario.MdiParent = this;
            ReviInventario.Show();
        }
        //Acceder al form de Registro de empleados 
        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Registro = new Registro_Empleados(this);
            Registro.MdiParent = this;
            Registro.Show();
        }

        //Acceder al form de registro de ventas 
        private void btnVentas_Click(object sender, EventArgs e)
        {
            ventas = new Ventas(this);
            ventas.MdiParent = this;
            ventas.Show();
        }

        private void Gerente_Dueño_Load(object sender, EventArgs e)
        {

        }
    }
}
