using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using sim_tp2.DTO;

namespace sim_tp2.Distribution
{
    public class Normal
    {
      
        private Random rnd = new Random();
        public int CantidadMuestra { get; set; }
        public double Desviacion { get; set; }
        public double Media { get; set; }
        public int CantidadIntervalos { get; set; }
        public Chart Grafico { get; set; }
        public DataGridView Grilla { get; set; }
        public ListBox Lista { get; set; }

        private List<double> Datos = new List<double>();

        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }

        public void GenerarDistribucion(Normal obj)
        {

            double random;
            double random2;
            double variableAleatoria;

            Lista.Items.Clear();
            Lista.BeginUpdate();
            /*Este método nos permite la generación de variables aleatorias normales, ya sea para distribución normal estándar (µ=0
            y σ = 1) o para cualquier otra combinación de media µ y desviación estándar σ.*/
           
            int contadorBoxMuller = 0;

            for (int i = 0; i < CantidadMuestra; i++)
            {
                contadorBoxMuller++;

                random = GenerarAleatorio();
                random2 = GenerarAleatorio();

                if (contadorBoxMuller % 2 == 0)
                {
                    variableAleatoria = Media + ((Math.Sqrt(-2 * Math.Log(1 - random)) * Math.Cos(2 * Math.PI * random2)) * Desviacion);
                }
                else
                {
                    variableAleatoria = Media + ((Math.Sqrt(-2 * Math.Log(1 - random)) * Math.Sin(2 * Math.PI * random2)) * Desviacion);
                }

                double variableAleatoriaTruncada = Math.Truncate(variableAleatoria * 10000) / 10000;
                Lista.Items.Add(variableAleatoriaTruncada);
                Datos.Add(variableAleatoriaTruncada);
            }
            Lista.EndUpdate();

           GenerarHistograma();

        }

        public void GenerarHistograma()
        {

            Grafico.Series.Clear();
            Grilla.Rows.Clear();

            double limiteInferior = 0;
            double limiteSuperior = 0;

            double valorMaximo = Datos.Max();
            double valorMinimo = Datos.Min();
            double precision = 0.0001;

            double ancho_intervalo = ((valorMaximo - valorMinimo) / CantidadIntervalos) + precision;

            int frecuenciaObservada = 0;
            double frecuenciaEsperada = 0;
            double frecuenciaObservadaAcumulada = 0;
            double frecuenciaEsperadaAcumulada = 0;
            double marcaClase = 0;


            for (int i = 0; i < CantidadIntervalos; i++)
            {

                /*
                 * Determinar el primer intervalo del histograma y determinar cuantos valores entran en el.
                 */

                if (i == 0)
                {
                    limiteInferior = valorMinimo;
                    limiteSuperior = valorMinimo + ancho_intervalo;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada = frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);
                    frecuenciaEsperadaAcumulada = frecuenciaEsperada;

                    AgregarFillaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);
                }

                /*
                 * Determinar el resto de intervalos del histograma y determinar cuantos valores entran en ellos.
                 */

                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + ancho_intervalo;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada += frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);
                    frecuenciaEsperadaAcumulada += frecuenciaEsperada;

                    AgregarFillaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);

                }

                /*
                 * Generar la etiqueta del mínimo y máximo de cada intervalo y lo agrega a la serie de intervalos del histograma.
                 * Los valores se truncan a 4 decimales.
                 */

                string etiquetaInferiorIntervalo = (Math.Truncate(limiteInferior * 10000) / 10000).ToString();
                string etiquetaSuperiorIntervalo = (Math.Truncate(limiteSuperior * 10000) / 10000).ToString();
                string etiquetaIntervalo = etiquetaInferiorIntervalo + " - " + etiquetaSuperiorIntervalo;

                Series serie = Grafico.Series.Add(etiquetaIntervalo);
                serie.Points.AddXY("Intervalos", frecuenciaObservada);

            }

        }

        public int DeterminarFrecuenciaObservada(List<double> ListaDatos, double limite_inferior, double limite_superior)
        {

            int frecuenciaObservada = 0;

            foreach (double valor in ListaDatos)
            {
                if (limite_inferior <= valor && valor <= limite_superior)
                {
                    frecuenciaObservada++;
                }
            }

            return frecuenciaObservada;
        }

        public double FrecuenciaNormal(double x, double mu, double sigma)
        {
            // MathNet.Numerics.Distributions.Normal resultado = new MathNet.Numerics.Distributions.Normal(mu, sigma);
            //   return resultado.CumulativeDistribution(x);
            return 0;
        }

        public double CalcularFrecuenciaEsperada(double limiteInferior, double limiteSuperior)
        {
            double frecuenciaEsperada = (FrecuenciaNormal(limiteSuperior, Media, Desviacion) - FrecuenciaNormal(limiteInferior, Media, Desviacion)) * CantidadMuestra;

            return frecuenciaEsperada;
        }


        public void AgregarFillaGrilla(double limiteInferior, double limiteSuperior, double marcaClase, double frecuenciaObservada,
            double frecuenciaEsperada, double frecuenciaObservadaAcumulada, double frecuenciaEsperadaAcumulada)
        {
            limiteInferior = Math.Truncate(limiteInferior * 10000) / 10000;
            limiteSuperior = Math.Truncate(limiteSuperior * 10000) / 10000;
            marcaClase = Math.Truncate(marcaClase * 10000) / 10000;
            frecuenciaObservada = Math.Truncate(frecuenciaObservada * 10000) / 10000;
            frecuenciaEsperada = Math.Truncate(frecuenciaEsperada * 10000) / 10000;
            frecuenciaObservadaAcumulada = Math.Truncate(frecuenciaObservadaAcumulada * 10000) / 10000;
            frecuenciaEsperadaAcumulada = Math.Truncate(frecuenciaEsperadaAcumulada * 10000) / 10000;

            Grilla.Rows.Add(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada,
                frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);

        }


    }
}
