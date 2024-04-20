using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sim_tp2.Distribution;
using sim_tp2.DTO;

namespace sim_tp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_calcular.Hide();

            checkBoxUniforme.Checked = false;
            checkBoxNormal.Checked= false;
            checkBoxExponencialNegativa.Checked = false;

            DeshabilitarElementos();
        }
        private void resetearCheckBox()
        {
            numericUpDownDesviacionNormal.Visible = true;
            numericUpDownLambdaExponencialNegativa.Visible = true;
            numericUpDownMaximoUniforme.Visible = true;
            numericUpDownMinimoUniforme.Visible= true;
            numericUpDownMediaNormal.Visible = true;
            labelDesviacion.Visible = true;
            labelLambdaExponencialNegativa.Visible = true;
            labelMediaNormal.Visible = true;
            labelMinimoUniforme.Visible = true;
            labelMaximoUniforme.Visible = true ;
        }
        
        /// <summary>
        /// Onclick botón calcular. Devuelve la impresión de la distribución seleccionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (checkBoxExponencialNegativa.Checked)
            {
                ImprimirDistribucionExponencialNegativa();
            }
            if (checkBoxNormal.Checked)
            {
                ImprimirDistribucionNormal();
            }
            if (checkBoxUniforme.Checked)
            {
                ImprimirDistribucionUniforme();
            }
        }

        /// <summary>
        /// Muestra en pantalla una distribucion normal segun parametros
        /// </summary>
        private void ImprimirDistribucionNormal()
        {
            var normal = new Normal()
            {
                Lista = listBoxVariablesAleatorias,
                Grafico = chartDistribucion,
                Grilla = dgvDatos
            };

            var cantidadMuestra = Convert.ToInt32(numericUpDownMuestra.Text.Trim());
            var cantidadIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim());
            var desviacion = Convert.ToDouble(numericUpDownDesviacionNormal.Text.Trim());
            var media = Convert.ToDouble(numericUpDownMediaNormal.Text.Trim());

            if (cantidadMuestra == 0 || cantidadIntervalos == 0)
            {
                MessageBox.Show("Error: La cantidad de muestra o la cantidad de intervalos no pueden ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            normal.ImprimirHistogramaDistribucionNormal(cantidadMuestra, cantidadIntervalos, media, desviacion);
            listBoxVariablesAleatorias.Visible = true;
            dgvDatos.Visible = true;
            chartDistribucion.Visible = true;
        }

        /// <summary>
        /// Muestra en pantalla una distribucion exponencial negativa segun parametros
        /// </summary>
        private void ImprimirDistribucionExponencialNegativa()
        {
            var exponencialNegativa = new ExponentialNegative()
            {
                Lista = listBoxVariablesAleatorias,
                Grafico = chartDistribucion,
                Grilla = dgvDatos
            };

            var cantidadMuestra = Convert.ToInt32(numericUpDownMuestra.Text.Trim());
            var cantidadIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim());
            var lambda = (double)numericUpDownLambdaExponencialNegativa.Value;

            if (cantidadMuestra <= 0)
            {
                MessageBox.Show("Error: La muestra no puede ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            exponencialNegativa.ImprimirHistogramaDistribucionExponencialNegativa(cantidadMuestra, cantidadIntervalos, lambda);
            listBoxVariablesAleatorias.Visible = true;
            dgvDatos.Visible = true;
            chartDistribucion.Visible = true;
        }

        /// <summary>
        /// Muestra en pantalla una distribucion uniforme segun parametros
        /// </summary>
        private void ImprimirDistribucionUniforme()
        {
            var uniforme = new Uniform()
            {
                Lista = listBoxVariablesAleatorias,
                Grafico = chartDistribucion,
                Grilla = dgvDatos
            };

            var tamMuestra = Convert.ToInt32(numericUpDownMuestra.Text.Trim());
            var minimo = Convert.ToDouble(numericUpDownMinimoUniforme.Text.Trim());
            var maximo = Convert.ToDouble(numericUpDownMaximoUniforme.Text.Trim());
            var cantidadIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim());

            uniforme.ImprimirHistogramaDistribucionUniforme(tamMuestra, cantidadIntervalos, minimo, maximo);
            listBoxVariablesAleatorias.Visible = true;
            dgvDatos.Visible = true;
            chartDistribucion.Visible = true;
        }

        private void checkBoxUniforme_Click(object sender, EventArgs e)
        {
            numericUpDownLambdaExponencialNegativa.Visible = false;
            labelLambdaExponencialNegativa.Visible = false;
            checkBoxExponencialNegativa.Checked = false;
            numericUpDownMediaNormal.Visible = false;
            numericUpDownDesviacionNormal.Visible = false;
            labelDesviacion.Visible = false;
            labelMediaNormal.Visible = false;
            checkBoxNormal.Checked = false;
            numericUpDownMinimoUniforme.Visible = true;
            labelMinimoUniforme.Visible = true;
            numericUpDownMaximoUniforme .Visible = true;
            labelMaximoUniforme.Visible = true;
            btn_calcular.Show();
        }

        private void checkBoxExponencialNegativa_Click(object sender, EventArgs e)
        {
            labelMinimoUniforme.Visible = false;
            labelMaximoUniforme.Visible = false;
            labelDesviacion.Visible = false;
            labelMediaNormal.Visible = false;
            numericUpDownMaximoUniforme.Visible = false;
            numericUpDownMinimoUniforme.Visible = false;
            numericUpDownMediaNormal.Visible = false;
            numericUpDownDesviacionNormal.Visible = false;
            checkBoxNormal.Checked = false;
            checkBoxUniforme.Checked = false;
            labelLambdaExponencialNegativa.Visible = true;
            numericUpDownLambdaExponencialNegativa.Visible = true;
            btn_calcular.Show();
        }

        private void checkBoxNormal_Click(object sender, EventArgs e)
        {
            numericUpDownMaximoUniforme.Visible = false;
            numericUpDownMinimoUniforme.Visible = false;
            labelMinimoUniforme.Visible = false;
            labelMaximoUniforme.Visible = false;
            numericUpDownLambdaExponencialNegativa.Visible = false;
            labelLambdaExponencialNegativa.Visible = false;
            checkBoxUniforme.Checked = false;
            checkBoxExponencialNegativa.Checked = false;
            labelDesviacion.Visible = true ;
            labelMediaNormal .Visible = true ;
            numericUpDownMediaNormal .Visible = true ;
            numericUpDownDesviacionNormal .Visible = true ;
            btn_calcular.Show();
        }

        private void DeshabilitarElementos()
        {
            listBoxVariablesAleatorias.Visible = false;
            dgvDatos.Visible = false;
            chartDistribucion.Visible = false;
        }
      
    }
}
