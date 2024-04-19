using sim_tp2.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim_tp2.Distribution
{
    public class ExponentialNegative
    {
        public List<double> Lista = new List<double>();

        public List<double> Datos = new List<double>();
        private Random rnd = new Random();
        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }

        public List<double> GenerarDistribucion(ExponentialNegativeDistribution exponencialNegativa)
        {
            for (int i = 0; i < exponencialNegativa.cantidadMuestra; i++)
            {
                double random = GenerarAleatorio();
                double variableAleatoria = (-1 / exponencialNegativa.lambda) * (Math.Log(1 - random));
                double variableAleatoriaTruncada = Math.Truncate(variableAleatoria * 10000) / 10000;
                Lista.Add(variableAleatoriaTruncada);
                Datos.Add(variableAleatoriaTruncada);

            }
            return Lista;
        }
    }
}
