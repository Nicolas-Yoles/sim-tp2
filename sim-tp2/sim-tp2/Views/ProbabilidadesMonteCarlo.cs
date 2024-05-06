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
using sim_tp2.Services;
namespace sim_tp2.Views
{
    public partial class ProbabilidadesMonteCarlo : Form
    {
        private MontecarloForm montecarloForm;

        public ProbabilidadesPrimerTiroBowlingDto probabiladesPrimeraTirada = new ProbabilidadesPrimerTiroBowlingDto();

        public ProbabilidadesSegundoTiroBowlingDto probabilidadesSegundaTirada = new ProbabilidadesSegundoTiroBowlingDto();
        public MontecarloForm FormularioPadre
        {
            get { return montecarloForm; }
            set { montecarloForm = value; }
        }
        public ProbabilidadesMonteCarlo()
        {
            InitializeComponent();
            numericUpDownPrimerTiro6.Value = Convert.ToDecimal(probabiladesPrimeraTirada.ProbabilidadSeis);
            numericUpDownPrimerTiro7.Value = Convert.ToDecimal(probabiladesPrimeraTirada.ProbabilidadSiete);
            numericUpDownPrimerTiro8.Value = Convert.ToDecimal(probabiladesPrimeraTirada.ProbabilidadOcho);
            numericUpDownPrimerTiro9.Value = Convert.ToDecimal(probabiladesPrimeraTirada.ProbabilidadNueve);
            numericUpDownPrimerTiro10.Value = Convert.ToDecimal(probabiladesPrimeraTirada.ProbabilidadDiez);

            numericUpDownSegundoTiro6Cantidad0.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSeisCero);
            numericUpDownSegundoTiro6Cantidad1.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSeisUno);
            numericUpDownSegundoTiro6Cantidad2.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSeisDos);
            numericUpDownSegundoTiro6Cantidad3.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSeisTres);
            numericUpDownSegundoTiro6Cantidad4.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSeisCuatro);

            numericUpDownSegundoTiro7Cantidad0.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSieteCero);
            numericUpDownSegundoTiro7Cantidad1.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSieteUno);
            numericUpDownSegundoTiro7Cantidad2.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSieteDos);
            numericUpDownSegundoTiro7Cantidad3.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadSieteTres);

            numericUpDownSegundoTiro8Cantidad0.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadOchoCero);
            numericUpDownSegundoTiro8Cantidad1.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadOchoUno);
            numericUpDownSegundoTiro8Cantidad2.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadOchoDos);

            numericUpDownSegundoTiro9Cantidad0.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadNueveCero);
            numericUpDownSegundoTiro9Cantidad1.Value = Convert.ToDecimal(probabilidadesSegundaTirada.ProbabilidadNueveUno);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var primeraTirada6Pinos = (double)numericUpDownPrimerTiro6.Value;
            var primeraTirada7Pinos = (double)numericUpDownPrimerTiro7.Value;
            var primeraTirada8Pinos = (double)numericUpDownPrimerTiro8.Value;
            var primeraTirada9Pinos = (double)numericUpDownPrimerTiro9.Value;
            var primeraTirada10Pinos = (double)numericUpDownPrimerTiro10.Value;
            var sumaPrimerTiro = Math.Round(primeraTirada6Pinos + primeraTirada7Pinos + primeraTirada8Pinos + primeraTirada9Pinos + primeraTirada10Pinos,2);

            var primeraTirada6PinosSegunda0 = (double)numericUpDownSegundoTiro6Cantidad0.Value;
            var primeraTirada6PinosSegunda1 = (double)numericUpDownSegundoTiro6Cantidad1.Value;
            var primeraTirada6PinosSegunda2 = (double)numericUpDownSegundoTiro6Cantidad2.Value;
            var primeraTirada6PinosSegunda3 = (double)numericUpDownSegundoTiro6Cantidad3.Value;
            var primeraTirada6PinosSegunda4 = (double)numericUpDownSegundoTiro6Cantidad4.Value;
            var sumaPrimeraTirada6 = Math.Round(primeraTirada6PinosSegunda0 + primeraTirada6PinosSegunda1 + primeraTirada6PinosSegunda2 + primeraTirada6PinosSegunda3 + primeraTirada6PinosSegunda4,2);

            var primeraTirada7PinosSegunda0 = (double)numericUpDownSegundoTiro7Cantidad0.Value;
            var primeraTirada7PinosSegunda1 = (double)numericUpDownSegundoTiro7Cantidad1.Value;
            var primeraTirada7PinosSegunda2 = (double)numericUpDownSegundoTiro7Cantidad2.Value;
            var primeraTirada7PinosSegunda3 = (double)numericUpDownSegundoTiro7Cantidad3.Value;
            var sumaPrimeraTirada7 = Math.Round(primeraTirada7PinosSegunda0 + primeraTirada7PinosSegunda1 + primeraTirada7PinosSegunda2 + primeraTirada7PinosSegunda3,2);

            var primeraTirada8PinosSegunda0 = (double)numericUpDownSegundoTiro8Cantidad0.Value;
            var primeraTirada8PinosSegunda1 = (double)numericUpDownSegundoTiro8Cantidad1.Value;
            var primeraTirada8PinosSegunda2 = (double)numericUpDownSegundoTiro8Cantidad2.Value;
            var sumaPrimeraTirada8 = Math.Round(primeraTirada8PinosSegunda0 + primeraTirada8PinosSegunda1 + primeraTirada8PinosSegunda2,2);

            var primeraTirada9PinosSegunda0 = (double)numericUpDownSegundoTiro9Cantidad0.Value;
            var primeraTirada9PinosSegunda1 = (double)numericUpDownSegundoTiro9Cantidad1.Value;
            var sumaPrimeraTirada9 = Math.Round(primeraTirada9PinosSegunda0 + primeraTirada9PinosSegunda1,2);
            if (sumaPrimerTiro == 1)
            {
                probabiladesPrimeraTirada.ProbabilidadSeis = primeraTirada6Pinos;
                probabiladesPrimeraTirada.ProbabilidadSiete = primeraTirada7Pinos;
                probabiladesPrimeraTirada.ProbabilidadOcho = primeraTirada8Pinos;
                probabiladesPrimeraTirada.ProbabilidadNueve = primeraTirada9Pinos;
                probabiladesPrimeraTirada.ProbabilidadDiez = primeraTirada10Pinos;
            }
            else
            {
                MessageBox.Show("Error: La suma de la suma de las probabilidades de la primera tirada deben ser igual a 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sumaPrimeraTirada6 == 1) 
            {
                this.probabilidadesSegundaTirada.ProbabilidadSeisCero = primeraTirada6PinosSegunda0;
                this.probabilidadesSegundaTirada.ProbabilidadSeisUno = primeraTirada6PinosSegunda1;
                this.probabilidadesSegundaTirada.ProbabilidadSeisDos = primeraTirada6PinosSegunda2;
                this.probabilidadesSegundaTirada.ProbabilidadSeisTres = primeraTirada6PinosSegunda3;
                this.probabilidadesSegundaTirada.ProbabilidadSeisCuatro = primeraTirada6PinosSegunda4;
            }
            else 
            {
                MessageBox.Show("Error: La suma de la suma de las probabilidades de la segunda tirada cuando la primera es igual a 6 deben ser igual a 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sumaPrimeraTirada7 == 1)
            {
                this.probabilidadesSegundaTirada.ProbabilidadSieteCero = primeraTirada7PinosSegunda0;
                this.probabilidadesSegundaTirada.ProbabilidadSieteUno = primeraTirada7PinosSegunda1;
                this.probabilidadesSegundaTirada.ProbabilidadSieteDos = primeraTirada7PinosSegunda2;
                this.probabilidadesSegundaTirada.ProbabilidadSieteTres = primeraTirada7PinosSegunda3;
            }
            else
            {
                MessageBox.Show("Error: La suma de la suma de las probabilidades de la segunda tirada cuando la primera es igual a 7 deben ser igual a 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sumaPrimeraTirada8 == 1)
            {
                this.probabilidadesSegundaTirada.ProbabilidadOchoCero = primeraTirada8PinosSegunda0;
                this.probabilidadesSegundaTirada.ProbabilidadOchoUno = primeraTirada8PinosSegunda1;
                this.probabilidadesSegundaTirada.ProbabilidadOchoDos = primeraTirada8PinosSegunda2;
            }
            else
            {
                MessageBox.Show("Error: La suma de la suma de las probabilidades de la segunda tirada cuando la primera es igual a 8 deben ser igual a 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (sumaPrimeraTirada9 == 1)
            {
                this.probabilidadesSegundaTirada.ProbabilidadNueveCero = primeraTirada9PinosSegunda0;
                this.probabilidadesSegundaTirada.ProbabilidadNueveUno = primeraTirada9PinosSegunda1;
            }
            else
            {
                MessageBox.Show("Error: La suma de la suma de las probabilidades de la segunda tirada cuando la primera es igual a 9 deben ser igual a 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            montecarloForm.RecibirProbabilidades(this.probabiladesPrimeraTirada, this.probabilidadesSegundaTirada);
            this.Close();

        }
         
    }
}
