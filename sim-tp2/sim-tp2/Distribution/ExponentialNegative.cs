using sim_tp2.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sim_tp2.Distribution
{
    public class ExponentialNegative
    {
        /// <summary>
        /// Lista de datos
        /// </summary>
        public ListBox Lista { get; set; }

        /// <summary>
        /// Grilla de datos
        /// </summary>
        public DataGridView Grilla { get; set; }

        /// <summary>
        /// Grafico de histograma
        /// </summary>
        public Chart Grafico { get; set; }

        /// <summary>
        /// Devuelve un número aleatorio para una distribución exponencial
        /// negativa
        /// </summary>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public static double GenerarAleatorio(double lambda)
            => NumerosUtility.Truncar4Decimales(-1 / lambda * Math.Log(1 - NumerosUtility.GetAleatorio()));

        /// <summary>
        /// Obtiene una secuencia de números correspondiente a una distribución 
        /// exponencial negativa, a partir de lambda.
        /// </summary>
        /// <param name="tamMuestra"></param>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public static List<double> GenerarDistribucion(int tamMuestra, double lambda)
            => Enumerable.Range(0, tamMuestra).Select(_ => GenerarAleatorio(lambda)).ToList();

        /// <summary>
        /// Calcula la frecuencia esperada para una distribucion Exponencial negativa.
        /// Utiliza la función acumulada, calcula el area del limite superior y le resta
        /// el del inferior, obteniendo la del intervalo.
        /// </summary>
        /// <param name="limiteInferior"></param>
        /// <param name="limiteSuperior"></param>
        /// <param name="lambda"></param>
        /// <param name="tamMuestra"></param>
        /// <returns></returns>
        public static double CalcularFrecuenciaEsperada(double limiteInferior, double limiteSuperior, double lambda, int tamMuestra)
            => (1 - Math.Exp((-lambda) * limiteSuperior) - (1 - Math.Exp((-lambda) * limiteInferior))) * tamMuestra;

        /// <summary>
        /// Devuelve la frecuencia observada
        /// </summary>
        /// <param name="ListaDatos"></param>
        /// <param name="limiteInferior"></param>
        /// <param name="limiteSuperior"></param>
        /// <returns></returns>
        public static int DeterminarFrecuenciaObservada(List<double> distribucion, double limiteInferior, double limiteSuperior)
            => distribucion.Where(x => limiteInferior <= x && x <= limiteSuperior).Count();

        /// <summary>
        /// Muestra el histograma en pantalla
        /// </summary>
        /// <param name="tamMuestra"></param>
        /// <param name="cantIntervalos"></param>
        /// <param name="lambda"></param>
        /// <param name="media"></param>
        public void ImprimirHistogramaDistribucionExponencialNegativa(int tamMuestra, int cantIntervalos, double? lambda = null, double? media = null)
        {
            if(tamMuestra  == 0 || (!lambda.HasValue && !media.HasValue))
                return;

            lambda = lambda ?? 1 / media;

            var distribucion = GenerarDistribucion(tamMuestra, lambda.Value);

            if (!distribucion.Any())
                return;

            CrearHistograma(distribucion, cantIntervalos, tamMuestra, lambda.Value);
        }

        /// <summary>
        /// Limpia las variables existentes y crea el histograma
        /// </summary>
        /// <param name="distribucion"></param>
        /// <param name="cantIntervalos"></param>
        /// <param name="tamMuestra"></param>
        /// <param name="lambda"></param>
        private void CrearHistograma(List<double> distribucion, int cantIntervalos, int tamMuestra, double lambda)
        {
            Lista.Items.Clear();
            Grafico.Series.Clear();
            Grilla.Rows.Clear();

            Lista.BeginUpdate();
            distribucion.ForEach(x => Lista.Items.Add(x));
            Lista.EndUpdate();

            AgregarIntervalos(distribucion, cantIntervalos, tamMuestra, lambda);
        }

        /// <summary>
        /// Obtiene los intervalos de la grilla
        /// </summary>
        /// <param name="distribucion"></param>
        /// <param name="cantIntervalos"></param>
        /// <param name="tamMuestra"></param>
        /// <param name="lambda"></param>
        private void AgregarIntervalos(List<double> distribucion, int cantIntervalos, int tamMuestra, double lambda)
        {
            var anchoIntervalo = ((distribucion.Max() - distribucion.Min()) / cantIntervalos) + 0.0001;
            var limiteInferior = distribucion.Min();
            var limiteSuperior = limiteInferior + anchoIntervalo;

            double frecuenciaObservadaAcumulada = 0;
            double frecuenciaEsperadaAcumulada = 0;

            for (int i = 0; i < cantIntervalos; i++)
            {
                var marcaClase = (limiteInferior + limiteSuperior) / 2;
                var frecuenciaObservada = DeterminarFrecuenciaObservada(distribucion, limiteInferior, limiteSuperior);
                var frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, lambda, tamMuestra);

                frecuenciaObservadaAcumulada += frecuenciaObservada;
                frecuenciaEsperadaAcumulada += frecuenciaEsperada;

                AgregarFilaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);
                string etiquetaInferiorIntervalo = (Math.Truncate(limiteInferior * 10000) / 10000).ToString();
                string etiquetaSuperiorIntervalo = (Math.Truncate(limiteSuperior * 10000) / 10000).ToString();
                string etiquetaIntervalo = etiquetaInferiorIntervalo + " - " + etiquetaSuperiorIntervalo;
                Series serie = Grafico.Series.Add(etiquetaIntervalo);
                serie.Points.AddXY("Intervalos", frecuenciaObservada);

                limiteInferior = limiteSuperior;
                limiteSuperior += anchoIntervalo;
            }
        }

        /// <summary>
        /// Obtiene los datos de la grilla
        /// </summary>
        /// <param name="limiteInferior"></param>
        /// <param name="limiteSuperior"></param>
        /// <param name="marcaClase"></param>
        /// <param name="frecuenciaObservada"></param>
        /// <param name="frecuenciaEsperada"></param>
        /// <param name="frecuenciaObservadaAcumulada"></param>
        /// <param name="frecuenciaEsperadaAcumulada"></param>
        private void AgregarFilaGrilla(double limiteInferior, double limiteSuperior, double marcaClase, double frecuenciaObservada,
            double frecuenciaEsperada, double frecuenciaObservadaAcumulada, double frecuenciaEsperadaAcumulada)
        {
            limiteInferior = NumerosUtility.Truncar4Decimales(limiteInferior);
            limiteSuperior = NumerosUtility.Truncar4Decimales(limiteSuperior);
            marcaClase = NumerosUtility.Truncar4Decimales(marcaClase);
            frecuenciaObservada = NumerosUtility.Truncar4Decimales(frecuenciaObservada);
            frecuenciaEsperada = NumerosUtility.Truncar4Decimales(frecuenciaEsperada);
            frecuenciaObservadaAcumulada = NumerosUtility.Truncar4Decimales(frecuenciaObservadaAcumulada);
            frecuenciaEsperadaAcumulada = NumerosUtility.Truncar4Decimales(frecuenciaEsperadaAcumulada);

            Grilla.Rows.Add(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada,
                frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);
        }
    }
}

