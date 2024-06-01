using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sim_tp2.DTOs;
using sim_tp2.DTOs.Peluqueria;
using sim_tp2.Services;


namespace sim_tp2.Views
{
    public partial class SistemaColas : Form
    {
        public PeluqueriaParametrizacionDto param = new PeluqueriaParametrizacionDto();
        public SistemaColas()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            simularPeluqueriaVIP();
        }

        private void simularPeluqueriaVIP()
        {

            var dias = Convert.ToInt32(inputDias.Value);
            var cantIteraciones = Convert.ToInt32(inputIteraciones.Value);
            var hora = Convert.ToInt32(inputHora.Value);


            if (cantIteraciones == 0)
            {
                MessageBox.Show("Error: La cantidad de iteraciones debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dias == 0)
            {
                MessageBox.Show("Error: Los días deben ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // TODO: Crear inputs para parametros de reglas y probabilidades (mostrar valores por defecto)
            // TODO: Crear propiedades del servicio con los valores tomados de interfaz grafica.
            var peluqueriaService = new PeluqueriaVipQueueSimulationService();

            var simulacion = peluqueriaService.SimularPeluqueria(dias, cantIteraciones, hora, this.param);
            dgvPeluqueria.DataSource = simulacion;
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }

        private void SistemaColas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SistemaColasDistribucion form2 = new SistemaColasDistribucion();
            form2.FormularioPadre = this;
            form2.Show();
        }
        public void RecibirProbabilidades(PeluqueriaParametrizacionDto param)
        {
            this.param = param;
        }
    }
}
