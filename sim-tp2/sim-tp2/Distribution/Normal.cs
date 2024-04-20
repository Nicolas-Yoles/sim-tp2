using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using sim_tp2.DTO;
using sim_tp2.Utilities;

namespace sim_tp2.Distribution
{
    public class Normal
    {
        public Chart Grafico { get; set; }

        public DataGridView Grilla { get; set; }

        public ListBox Lista { get; set; }

        /// <summary>
        /// Devuelve un par de numeros aleatorios para una distribución normal
        /// utilizando Box Muller
        /// </summary>
        /// <param name="media"></param>
        /// <param name="desviacion"></param>
        /// <returns></returns>
        public static (double, double) GenerarAleatoriosBoxMuller(double media, double desviacion)
        {
            var aleatorioUniforme1 = NumerosUtility.GetAleatorio();
            var aleatorioUniforme2 = NumerosUtility.GetAleatorio();

            var aleatorioBoxMuller1 = Math.Sqrt(-2 * Math.Log(aleatorioUniforme1)) * Math.Cos(2 * Math.PI * aleatorioUniforme2) * desviacion + media;
            var aleatorioBoxMuller2 = Math.Sqrt(-2 * Math.Log(aleatorioUniforme1)) * Math.Sin(2 * Math.PI * aleatorioUniforme2) * desviacion + media;

            return (aleatorioBoxMuller1, aleatorioBoxMuller2);
        }

        /// <summary>
        /// Devuelve un numero aleatorio para una distribución normal
        /// utilizando Convolusion
        /// </summary>
        /// <param name="media"></param>
        /// <param name="desviacion"></param>
        /// <returns></returns>
        public static double GenerarAleatorioConvolusion(double media = 0, double desviacion = 1)
        {
            var aleatoriosUniformes = Enumerable.Range(0, 12).Select(_ => NumerosUtility.GetAleatorio()).ToList();
            return (aleatoriosUniformes.Sum() - 6) * desviacion + media;
        }

        /// <summary>
        /// Obtiene una secuencia de números correspondiente a una distribución 
        /// normal.
        /// </summary>
        /// <param name="tamMuestra"></param>
        /// <param name="lambda"></param>
        /// <returns></returns>
        public static List<double> GenerarDistribucion(int tamMuestra, double media = 0, double desviacion = 1)
            => Enumerable.Range(0, tamMuestra).Select(_ => GenerarAleatorioConvolusion(media, desviacion)).ToList();

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
        /// Obtiene la frecuencia esperada para un intervalo de una distribucion normal.
        /// Calcula la probabilidad en el punto medio del intervalo,
        /// luego aproxima esa probabilidad multiplicando por el ancho del intervalo.
        /// </summary>
        /// <param name="media"></param>
        /// <param name="desviacion"></param>
        /// <param name="limiteInferior"></param>
        /// <param name="limiteSuperior"></param>
        /// <returns></returns>
        static double CalcularFrecuenciaEsperada(double media, double desviacion, double limiteInferior, double limiteSuperior)
        {
            double marcaIntervalo = (limiteInferior + limiteSuperior) / 2;
            var coeficiente = 1 / (Math.Sqrt(2 * Math.PI) * desviacion);
            var exponente = -(Math.Pow(marcaIntervalo - media, 2) / (2 * Math.Pow(desviacion, 2)));

            var densidadProbabilidad = coeficiente * Math.Exp(exponente);

            var anchoIntervalo = limiteSuperior - limiteInferior;
            return densidadProbabilidad * anchoIntervalo;
        }

        public void ImprimirHistogramaDistribucionNormal(int tamMuestra, int cantIntervalos, double media = 0, double desviacion = 1)
        {
            if (tamMuestra == 0)
                return;

            var distribucion = GenerarDistribucion(tamMuestra, media, desviacion);

            if (!distribucion.Any())
                return;

            CrearHistograma(distribucion, cantIntervalos, tamMuestra, media, desviacion);
        }

        private void CrearHistograma(List<double> distribucion, int cantIntervalos, int tamMuestra, double media, double desviacion)
        {
            Lista.Items.Clear();
            Grafico.Series.Clear();
            Grilla.Rows.Clear();

            Lista.BeginUpdate();
            distribucion.ForEach(x => Lista.Items.Add(x));
            Lista.EndUpdate();
            AgregarIntervalos(distribucion, cantIntervalos, tamMuestra, media, desviacion);
        }

        private void AgregarIntervalos(List<double> distribucion, int cantIntervalos, int tamMuestra, double media, double desviacion)
        {
            var anchoIntervalo = ((distribucion.Max() - distribucion.Min()) / tamMuestra) + 0.0001;
            var limiteInferior = distribucion.Min();
            var limiteSuperior = limiteInferior + anchoIntervalo;

            double frecuenciaObservadaAcumulada = 0;
            double frecuenciaEsperadaAcumulada = 0;

            for (int i = 0; i < cantIntervalos; i++)
            {
                var marcaClase = (limiteInferior + limiteSuperior) / 2;
                var frecuenciaObservada = DeterminarFrecuenciaObservada(distribucion, limiteInferior, limiteSuperior);
                var frecuenciaEsperada = CalcularFrecuenciaEsperada(media, desviacion, limiteInferior, limiteSuperior);

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
