using sim_tp2.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim_tp2.Views
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Distribuciones distribucionesForm = new Distribuciones();
            distribucionesForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MontecarloForm montecarloForm = new MontecarloForm();
            montecarloForm.Show();

        }

        private void button_colas_Click(object sender, EventArgs e)
        {
            SistemaColas sistemaColasForm = new SistemaColas();
            sistemaColasForm.Show();
        }
    }
}
