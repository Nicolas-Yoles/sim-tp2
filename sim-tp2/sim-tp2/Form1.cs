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
        

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (checkBoxExponencialNegativa.Checked == true)
            {
          
                ExponentialNegative exponencialNegativa = new ExponentialNegative();

                exponencialNegativa.CantidadMuestra = Convert.ToInt32(numericUpDownMuestra.Text.Trim());
                exponencialNegativa.CantidadIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim());
                exponencialNegativa.Lambda = (double)numericUpDownLambdaExponencialNegativa.Value;
                exponencialNegativa.Lista = listBoxVariablesAleatorias;
                exponencialNegativa.Grafico = chartDistribucion;

                exponencialNegativa.Grilla = dgvDatos;

                if (exponencialNegativa.CantidadMuestra > 0)
                {
                    exponencialNegativa.GenerarDistribucion(exponencialNegativa);
                    listBoxVariablesAleatorias.Visible = true;
                    dgvDatos.Visible = true;
                    chartDistribucion.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error: La muestra no puede ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                


            }
            if (checkBoxNormal.Checked == true)
            {              

                Normal normal = new Normal();

                normal.CantidadMuestra = Convert.ToInt32(numericUpDownMuestra.Text.Trim());
                normal.Desviacion = Convert.ToDouble(numericUpDownDesviacionNormal.Text.Trim());
                normal.Media = Convert.ToDouble(numericUpDownMediaNormal.Text.Trim());
                normal.CantidadIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim());
                normal.Lista = listBoxVariablesAleatorias;
                normal.Grafico = chartDistribucion;
                normal.Grilla = dgvDatos;

                if (normal.CantidadMuestra == 0 || normal.CantidadIntervalos == 0)
                {
                    MessageBox.Show("Error: La cantidad de muestra o la cantidad de intervalos no pueden ser 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    normal.GenerarDistribucion(normal);
           
                }
            }
            if (checkBoxUniforme.Checked == true)
            {

                Uniform uniforme = new Uniform();

                uniforme.cantidadMuestra = Convert.ToInt32(numericUpDownMuestra.Text.Trim());
                uniforme.Minimo = Convert.ToDouble(numericUpDownMinimoUniforme.Text.Trim());
                uniforme.Maximo = Convert.ToDouble(numericUpDownMaximoUniforme.Text.Trim());
                uniforme.cantidadIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim());
                uniforme.Lista = listBoxVariablesAleatorias;
                uniforme.Grafico = chartDistribucion;
                uniforme.Grilla = dgvDatos;


                uniforme.GenerarDistribucion(uniforme);


                listBoxVariablesAleatorias.Visible = true;
                dgvDatos.Visible = true;
                chartDistribucion.Visible = true;

            }
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
        }

        private void DeshabilitarElementos()
        {
            listBoxVariablesAleatorias.Visible = false;
            dgvDatos.Visible = false;
            chartDistribucion.Visible = false;
        }

      
    }
}
