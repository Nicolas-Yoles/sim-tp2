using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using sim_tp2.DTO;

namespace sim_tp2.Distribution
{
    public  class Uniform
    {
        public int cantidadMuestra { get; set; }
        public double Minimo { get; set; }
        public double Maximo { get; set; }
        public int cantidadIntervalos { get; set; }
        public ListBox Lista { get; set; }
        public Chart Grafico { get; set; }
        public DataGridView Grilla { get; set; }

        private List<double> Datos = new List<double>();

        private Random rnd = new Random();



        /*La función GenerarAleatorio() devuelve un número aleatorio de tipo double en el
        intervalo [0, 1), es decir, incluye 0 pero excluye 1.*/
        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }
        public void GenerarDistribucion(Uniform uniforme)
        {

            if (uniforme.Minimo < uniforme.Maximo)
            {
                Lista.Items.Clear();

                Lista.BeginUpdate();

                for (int i = 0; i < uniforme.cantidadMuestra; i++)
                {
                    double random = GenerarAleatorio();
                 /*Para la generación de números aleatorios uniformemente distribuidos entre el intervalo [A; B] se utilizará el siguiente
                 modelo:  𝑋 = 𝐴 + 𝑅𝑁𝐷(𝐵 − 𝐴) */
                    double variableAleatoria = uniforme.Minimo + (random * (uniforme.Maximo - uniforme.Minimo));
                 //Se trunca cada dato a 4 decimales   
                    double variableAleatoriaTruncada = Math.Truncate(variableAleatoria * 10000) / 10000;
                 //Se añaden los valores para mostrar a una lista de WinForms.
                    Lista.Items.Add(variableAleatoriaTruncada);
                 //Genera una lista para poder tomar los datos para generar el histograma.
                    Datos.Add(variableAleatoriaTruncada);

                }


            }

        }
    }
}
