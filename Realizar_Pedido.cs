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
    public partial class Realizar_Pedido : Form
    {
        private Form1 _mainForm;

        public Realizar_Pedido(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        //método que manda las cantidades recibidas al constructor de Pedidos
        public void MandarCantidades()
        {
            //Ayote
            int amaiz = Convert.ToInt32(numericUpDown1.Value);
            int aarroz = Convert.ToInt32(numericUpDown2.Value);
            //Chicharron
            int chmaiz = Convert.ToInt32(numericUpDown3.Value);
            int charroz = Convert.ToInt32(numericUpDown4.Value);
            //Queso
            int qmaiz = Convert.ToInt32(numericUpDown5.Value);
            int qarroz = Convert.ToInt32(numericUpDown6.Value);
            //Revueltas
            int rmaiz = Convert.ToInt32(numericUpDown7.Value);
            int rarroz = Convert.ToInt32(numericUpDown8.Value);
            //Pollo
            int pmaiz = Convert.ToInt32(numericUpDown9.Value);
            int parroz = Convert.ToInt32(numericUpDown10.Value);
            //Frijol con queso 
            int fmaiz = Convert.ToInt32(numericUpDown11.Value);
            int farroz = Convert.ToInt32(numericUpDown12.Value);

            //fecha y hora
            DateTime fechayhora = DateTime.Now;

            //objeto Pedidos que manda los datos de tipos de pupusas al constructor correspondiente
            Pedidos pedidos1 = new Pedidos(fmaiz, farroz, qmaiz, qarroz,
                                           rmaiz, rarroz, amaiz, aarroz,
                                           pmaiz, parroz, chmaiz, charroz);

            //objeto Pedidos que manda el dato de fecha al constructor correspondiente
            Pedidos fechaa = new Pedidos(fechayhora);
        }
        

        //objeto Pedidos que llama a los métodos de la clase Pedidos
        Pedidos llamado = new Pedidos();


        private void Realizar_Pedido_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }


		private void btnVolver_Click(object sender, EventArgs e)
        {
            _mainForm.FocusOnMain1();
            this.Close();
        }

        //Boton donde se confirmara el pedido y se generar el MessageBox con numero de orden y el total de ella
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Confirmar_Pedido Form3 = new Confirmar_Pedido();
            Form3.MdiParent = _mainForm;
            Form3.Show();
        }

        private void numericUpDown12_ValueChanged(object sender, EventArgs e)
        {

        }
    } 
}
