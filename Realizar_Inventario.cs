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
    public partial class Realizar_Inventario : Form
    {
		private Ventana_Empleados _mainForm;

        public Realizar_Inventario(Ventana_Empleados mainForm)
        {
            InitializeComponent();
			_mainForm = mainForm;
        }

		public class Inventario
		{
			public string Nombre { get; set; }
			public decimal Cantidad { get; set; }
			public string Unidad { get; set; }
		}

		private List<Inventario> inventario = new List<Inventario>();
		//Boton para registro de inventario 
		private void btnRegistrar_Click(object sender, EventArgs e) 
        {
			string[] nombres =
			{
				"Frijoles", "Queso", "Chicharron", "Ayote", "Pollo", "Harina de arroz","Harina de maíz", "Tomates",
			     "Repollo", "Zanahoria", "Cebolla", "Vinagre","Chile", "Papel encerado", "Papel toalla", "Servilletas"
				 ,"Bolsas pequeñas", "Bolsas para basura", "Platos desechables", "Bolsas para salsa"
			};

			string[] unidades = 
			{ 
				"Libras", "Libras", "Libras", "Unidades", "Libras", "Libras", "Libras", "Libras","Unidades", 
				"Libras", "Unidades", "Litros", "Libras", "Cajas", "Paquetes", "Paquetes","Paquetes", "Paquetes",
				"Paquetes", "Paquetes"
			};

			// esto es para los numeric ya que son 20
			for (int i = 0; i < 20; i++)
			{
				NumericUpDown numericControl = (NumericUpDown)this.Controls.Find($"numeric{i + 1}", true).FirstOrDefault();

				if (numericControl != null)
				{
					inventario.Add(new Inventario
					{
						Nombre = nombres[i],
						Cantidad = numericControl.Value,
						Unidad = unidades[i]
					});
				}
			}
			MessageBox.Show("Inventario ha sido registrado correctamente.", "Registro", MessageBoxButtons.OK);
		}

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _mainForm.FocusOnMain2();
            this.Close();
        }
    }
}
