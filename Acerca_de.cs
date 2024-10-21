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
    public partial class Acerca_de : Form
    {
        private Form1 _mainForm;

        public Acerca_de(Form1 mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void Acerca_de_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _mainForm.FocusOnMain1();
            this.Close();

        }
    }
}
