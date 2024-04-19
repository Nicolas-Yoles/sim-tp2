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
    public class Normal
    {
        public List<double> Lista { get; set; }

        public List<double> Datos = new List<double>();
        private Random rnd = new Random();

        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }
        public List<double> GenerarDistribucion(NormalDistribution obj)
        {

            double random;
            double random2;
            double variableAleatoria;

            int contadorBoxMuller = 0;

            for (int i = 0; i < obj.cantMuestras; i++)
            {
                contadorBoxMuller++;

                random = GenerarAleatorio();
                random2 = GenerarAleatorio();

                if (contadorBoxMuller % 2 == 0)
                {
                    variableAleatoria = obj.Media + ((Math.Sqrt(-2 * Math.Log(1 - random)) * Math.Cos(2 * Math.PI * random2)) * obj.Desviacion);
                }
                else
                {
                    variableAleatoria = obj.Media + ((Math.Sqrt(-2 * Math.Log(1 - random)) * Math.Sin(2 * Math.PI * random2)) * obj.Desviacion);
                }
                /*
                   * Se añaden los valores para mostrar a una lista de WinForms.
                   * También genera una lista para poder tomar los datos para generar el histograma.
                   * Trunca cada dato a 4 decimales.
                   */
                double variableAleatoriaTruncada = Math.Truncate(variableAleatoria * 10000) / 10000;
                Lista.Add(variableAleatoriaTruncada);
                Datos.Add(variableAleatoriaTruncada);
            }
            return Lista;


        }
    }
}
