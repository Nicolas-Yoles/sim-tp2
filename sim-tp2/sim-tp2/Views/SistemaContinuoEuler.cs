using sim_tp2.DTOs.Peluqueria;
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
    public partial class SistemaContinuoEuler : Form
    {
        private SistemaColas sistemaColaForm;
        public SistemaColas FormularioPadre
        {
            get { return sistemaColaForm; }
            set { sistemaColaForm = value; }
        }
        public SistemaContinuoEuler()
        {
            InitializeComponent();
            this.numericUpDownProbabilidadAprendiz.Value = 0.15M;
            this.numericUpDownVeteranoA.Value = 0.45M;
            this.numericUpDownTiempoAprendiz.Value = Convert.ToDecimal(180);
            this.numericUpDownTiempoCorteVeterano.Value = Convert.ToDecimal(130);
            this.numericUpDownLimiteInferiorCliente.Value = Convert.ToDecimal(2);
            this.numericUpDownLimiteSuperiorCliente.Value = Convert.ToDecimal(12);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var probabilidadAprendiz = (double)numericUpDownProbabilidadAprendiz.Value;
            var probabilidadVeterano = (double)numericUpDownVeteranoA.Value;
            var tiempoAprendiz = (double)numericUpDownTiempoAprendiz.Value;
            var tiempoVeterano = (double)numericUpDownTiempoCorteVeterano.Value;
            var limiteInferiorCliente = (double) numericUpDownLimiteInferiorCliente.Value;
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
            if (limiteInferiorCliente >= limiteSuperiorCliente)
            {
                MessageBox.Show("Error: El limite inferior no debe ser mayor a igual al limite superior en el Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PeluqueriaParametrizacionDto parametros = new PeluqueriaParametrizacionDto();
            parametros.AprendizProbabilidadAtender = probabilidadAprendiz;
            parametros.VeteranoAProbabilidadAtender = probabilidadVeterano;
            parametros.TAprendiz = Convert.ToInt32(tiempoAprendiz);
            parametros.TVeteranos = Convert.ToInt32(tiempoVeterano);
            parametros.LlegadaClienteLimiteInferior = Convert.ToInt32(limiteInferiorCliente);
            parametros.LlegadaClienteLimiteSuperior = Convert.ToInt32(limiteSuperiorCliente);
            sistemaColaForm.RecibirProbabilidades(parametros);
            this.Close();
        }
    }
}
