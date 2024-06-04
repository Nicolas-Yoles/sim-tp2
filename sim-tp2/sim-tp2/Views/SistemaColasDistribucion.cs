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

namespace sim_tp2.Views
{
    public partial class SistemaColasDistribucion : Form
    {
        private SistemaColas sistemaColaForm;
        public SistemaColas FormularioPadre
        {
            get { return sistemaColaForm; }
            set { sistemaColaForm = value; }
        }
        public SistemaColasDistribucion()
        {
            InitializeComponent();
            this.numericUpDownAprendizLimiteInferior.Value = Convert.ToDecimal(20);
            this.numericUpDownAprendizLimiteSuperior.Value = Convert.ToDecimal(30);
            this.numericUpDownProbabilidadAprendiz.Value = 0.15M;
            this.numericUpDownLimiteInferiorVeteranoA.Value = Convert.ToDecimal(11);
            this.numericUpDownLimiteSuperiorVeteranoA.Value = Convert.ToDecimal(13);
            this.numericUpDownProbabilidadVeteranoA.Value = 0.45M;
            this.numericUpDownLimiteInferiorVeteranoB.Value = Convert.ToDecimal(12);
            this.numericUpDownLimiteSuperiorVeteranoB.Value = Convert.ToDecimal(18);
            this.numericUpDownLimiteInferiorCliente.Value = Convert.ToDecimal(2);
            this.numericUpDownLimiteSuperiorCliente.Value = Convert.ToDecimal(12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarParametros();
        }
        private void cargarParametros()
        {
            var limiteInferiorAprendiz = (double)numericUpDownAprendizLimiteInferior.Value;
            var limiteSuperiorAprendiz = (double)numericUpDownAprendizLimiteSuperior.Value;
            var probabilidadAprendiz = (double)numericUpDownProbabilidadAprendiz.Value;
            var limiteInferiorVeteranoA = (double)numericUpDownLimiteInferiorVeteranoA.Value;
            var limiteSuperiorVeteranoA = (double)numericUpDownLimiteSuperiorVeteranoA.Value;
            var probabilidadVeterano = (double) numericUpDownProbabilidadVeteranoA.Value;
            var limiteInferiorVeteranoB = (double) numericUpDownLimiteInferiorVeteranoB.Value;
            var limiteSuperiorVeteranoB = (double)numericUpDownLimiteSuperiorVeteranoB.Value;
            var limiteInferiorCliente = (double)numericUpDownLimiteInferiorCliente.Value;
            var limiteSuperiorCliente = (double)numericUpDownLimiteSuperiorCliente.Value;
            var sumaProbailidades = probabilidadAprendiz + probabilidadVeterano;
            if (sumaProbailidades == 1)
            {
                MessageBox.Show("Error: La suma de las dos probabilidades debe ser menor a 1", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var probabilidadVeteranoB = 1 - sumaProbailidades;
            }
            if (limiteInferiorAprendiz >= limiteSuperiorAprendiz)
            {
                MessageBox.Show("Error: El limite inferior no debe ser mayor a igual al limite superior en el Aprendiz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (limiteInferiorVeteranoA >= limiteSuperiorVeteranoA)
            {
                MessageBox.Show("Error: El limite inferior no debe ser mayor a igual al limite superior en el Veterano A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (limiteInferiorVeteranoB >= limiteSuperiorVeteranoB)
            {
                MessageBox.Show("Error: El limite inferior no debe ser mayor a igual al limite superior en el Veterano B", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (limiteInferiorCliente >= limiteSuperiorCliente)
            {
                MessageBox.Show("Error: El limite inferior no debe ser mayor a igual al limite superior en el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PeluqueriaParametrizacionDto parametros = new PeluqueriaParametrizacionDto();
            parametros.AprendizProbabilidadAtender = probabilidadAprendiz;
            parametros.VeteranoAProbabilidadAtender = probabilidadVeterano;
            parametros.AprendizLimiteInferior = Convert.ToInt32(limiteInferiorAprendiz);
            parametros.AprendizLimiteSuperior = Convert.ToInt32(limiteSuperiorAprendiz);
            parametros.VeteranoALimiteInferior = Convert.ToInt32(limiteInferiorVeteranoA);
            parametros.VeteranoALimiteSuperior = Convert.ToInt32(limiteSuperiorVeteranoA);
            parametros.VeteranoBLimiteInferior = Convert.ToInt32(limiteInferiorVeteranoB);
            parametros.VeteranoBLimiteSuperior = Convert.ToInt32(limiteSuperiorVeteranoB);
            parametros.LlegadaClienteLimiteInferior = Convert.ToInt32(limiteInferiorCliente);
            parametros.LlegadaClienteLimiteSuperior = Convert.ToInt32(limiteSuperiorCliente);
            sistemaColaForm.RecibirProbabilidades(parametros);
            this.Close();


        }
    }
}
