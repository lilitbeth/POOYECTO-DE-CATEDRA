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
	public partial class Revisar_Inventario : Form
    {
		public List<Inventario> inventarioRegistrado;

        private Form _mainForm;
        //Form vacio 
        public Revisar_Inventario(Form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _mainForm = mainForm;
        }
        //Metodo para asignar el inventario 

        public void AsignarInventario(List<Inventario> inventario)
		{
			inventarioRegistrado = inventario;
			CargarInventario();
		}


        public class Inventario
	   {
	      public string Nombre { get; set; }
          public decimal Cantidad { get; set; }
		  public string Unidad { get; set; }
	   }
		private void CargarInventario()
		{

			string[] nombres =
			{
				"Frijoles", "Queso", "Chicharron", "Ayote", "Pollo", "Harina de arroz", "Harina de maíz", "Tomates",
				"Repollo", "Zanahoria", "Cebolla", "Vinagre", "Chile", "Papel encerado", "Papel toalla", "Servilletas",
				"Bolsas pequeñas", "Bolsas para basura", "Platos desechables", "Bolsas para salsa"
			};

			// Esto es para los textboxes
			for (int i = 0; i < inventarioRegistrado.Count; i++)
			{
				TextBox textBoxControl = (TextBox)this.Controls.Find($"textBox{i + 1}", true).FirstOrDefault();
				if (textBoxControl != null)
				{
					// Asignar el valor de lo ya habiamos registramos
					var item = inventarioRegistrado.FirstOrDefault(inv => inv.Nombre == nombres[i]);
					if (item != null)
					{
						textBoxControl.Text = $"{item.Cantidad} {item.Unidad}";
					}
				}
			}
		}

        private void Revisar_Inventario_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
			if (_mainForm is Gerente_Dueño)
			{ 
				((Gerente_Dueño)_mainForm).FocusOnMain3();
			}
			else if (_mainForm is Ventana_Empleados)
			{
				((Ventana_Empleados)_mainForm).FocusOnMain2();
			}
			this.Close();
        }
    }
}
