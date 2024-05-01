using sim_tp2.DTOs;
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
    public partial class MontecarloForm : Form
    {
        public MontecarloForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// evento al hacer click en consultar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirMontecarlo();
        }

        /// <summary>
        /// Muestra en pantalla el metodo de montecarlo para el juego de bowling
        /// </summary>
        private void ImprimirMontecarlo()
        {
            MontecarloDTO montecarloDTO = new MontecarloDTO()
            {
                Grilla = dgvMontecarlo
            };

            var cantRondas = Convert.ToInt32(cantidadRondasTxt.Text.Trim());
            var rondaInicial = Convert.ToInt32(rondaInicialTxt.Text.Trim());
            var rondaFinal = Convert.ToInt32(rondaFinalTxt.Text.Trim());

            if (cantRondas == 0)
            {
                MessageBox.Show("Error: La cantidad de rondas no pueden ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (rondaInicial >= rondaFinal)
            {
                MessageBox.Show("Error: La ronda final debe ser superior a la ronda inicial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // TODO: Crear inputs para parametros de reglas y probabilidades (mostrar valores por defecto)
            // TODO: Crear propiedades del servicio con los valores tomados de interfaz grafica.
            var bowlingService = new BowlingMontecarloSimulationService
            {
                Reglas = new ReglasBowlingDto(),
                ProbabilidadesPrimerTiro = new ProbabilidadesPrimerTiroBowlingDto(),
                ProbabilidadesSegundoTiro = new ProbabilidadesSegundoTiroBowlingDto()
            };

            var rondaBowlingDtos = bowlingService.ImprimirMontecarlo(cantRondas, rondaInicial, rondaFinal);
            dgvMontecarlo.DataSource = rondaBowlingDtos;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cantidadRondasTxt.Text = "0";
            rondaInicialTxt.Text = "0";
            rondaFinalTxt.Text = "0";
            dgvMontecarlo.DataSource = new List<RondaBowlingDto>();
        }
    }
}
