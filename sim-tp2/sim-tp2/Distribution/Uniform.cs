using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sim_tp2.DTO;

namespace sim_tp2.Distribution
{
    public  class Uniform
    {
        public List<double> Lista { get; set; }

        public List<double> Datos = new List<double>();
        private Random rnd = new Random();
        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }
        public List<double> GenerarDistribucion(UniformDistribution uniforme)
        {

            if (uniforme.Minimo < uniforme.Maximo)
            {

                for (int i = 0; i < uniforme.cantidadMuestra; i++)
                {
                    double random = GenerarAleatorio();

                    double variableAleatoria = uniforme.Minimo + (random * (uniforme.Maximo - uniforme.Minimo));
                    double variableAleatoriaTruncada = Math.Truncate(variableAleatoria * 10000) / 10000;
                    /*
                     * Se añaden los valores para mostrar a una lista de WinForms.
                     * También genera una lista para poder tomar los datos para generar el histograma.
                     * Trunca cada dato a 4 decimales.
                     */

                    Lista.Add(variableAleatoriaTruncada);
                    Datos.Add(variableAleatoriaTruncada);

                }
                

            }
            return Lista;

        }
    }
}
