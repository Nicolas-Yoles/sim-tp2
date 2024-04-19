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
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBoxExponencialNegativa.Checked == true)
            {
                ExponentialNegativeDistribution ObjectExponentialNegative = new ExponentialNegativeDistribution
                {
                    lambda = Convert.ToInt32(numericUpDownLambdaExponencialNegativa.Text.Trim()),
                    cantidadMuestra = Convert.ToInt32(numericUpDownMuestra.Text.Trim()),
                    cantidadIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim())

                };
                ExponentialNegative exponencialNegativa = new ExponentialNegative();
                listBoxVariablesAleatorias.Items.Add(exponencialNegativa.GenerarDistribucion(ObjectExponentialNegative));
            }
            if (checkBoxNormal.Checked == true)
            {
                NormalDistribution ObjectNormal = new NormalDistribution
                {
                    Media = Convert.ToInt32(numericUpDownMediaNormal.Text.Trim()),
                    Desviacion = Convert.ToInt32(numericUpDownDesviacionNormal.Text.Trim()),
                    cantMuestras = Convert.ToInt32(numericUpDownMuestra.Text.Trim()),
                    cantIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim())
                };
                Normal Normal = new Normal();
                listBoxVariablesAleatorias.Items.Add(Normal.GenerarDistribucion(ObjectNormal));

            }
            if (checkBoxUniforme.Checked == true)
            {
                UniformDistribution Objectuniform = new UniformDistribution
                {
                    Maximo = Convert.ToInt32(numericUpDownMaximoUniforme.Text.Trim()),
                    Minimo = Convert.ToInt32(numericUpDownMinimoUniforme.Text.Trim()),
                    cantidadIntervalos = Convert.ToInt32(numericUpDownIntervalos.Text.Trim()),
                    cantidadMuestra = Convert.ToInt32(numericUpDownMuestra.Text.Trim())
                };
                Uniform uniform = new Uniform();
                listBoxVariablesAleatorias.Items.Add(uniform.GenerarDistribucion(Objectuniform));

            }
        }

        private void checkBoxUniforme_Click(object sender, EventArgs e)
        {
            numericUpDownLambdaExponencialNegativa.Visible = false;
            labelLambdaExponencialNegativa.Visible = false;
            numericUpDownMediaNormal.Visible = false;
            numericUpDownDesviacionNormal.Visible = false;
            labelDesviacion.Visible = false;
            labelMediaNormal.Visible = false;
            checkBoxExponencialNegativa.Checked = false;
            checkBoxNormal.Checked = false;
            numericUpDownMinimoUniforme.Visible = true;
            labelMinimoUniforme.Visible = true;
            numericUpDownMaximoUniforme .Visible = true;
            labelMaximoUniforme.Visible = true;
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
            numericUpDownLambdaExponencialNegativa .Visible = true;
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
    }
}
