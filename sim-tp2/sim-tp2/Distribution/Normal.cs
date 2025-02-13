﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using sim_tp2.Utilities;

namespace sim_tp2.Distribution
{
    public class Normal
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
        /// Devuelve un par de numeros aleatorios para una distribución normal
        /// utilizando Box Muller
        /// </summary>
        /// <param name="media"></param>
        /// <param name="desviacion"></param>
        /// <returns></returns>
        public static List<double> GenerarAleatoriosBoxMuller(double media, double desviacion, int cantidadMuestras)
        {
            List<double> aleatorios = new List<double>();

            for (int i = 0; i < cantidadMuestras; i += 2)
            {
                double aleatorioUniforme1 = NumerosUtility.GetAleatorio();
                double aleatorioUniforme2 = NumerosUtility.GetAleatorio();

                double z1 = Math.Sqrt(-2 * Math.Log(aleatorioUniforme1)) * Math.Cos(2 * Math.PI * aleatorioUniforme2) * desviacion + media;
                double z2 = Math.Sqrt(-2 * Math.Log(aleatorioUniforme1)) * Math.Sin(2 * Math.PI * aleatorioUniforme2) * desviacion + media;
              
                aleatorios.Add(NumerosUtility.Truncar4Decimales(z1));
                if (i + 1 < cantidadMuestras)
                    aleatorios.Add(NumerosUtility.Truncar4Decimales(z2));
            }

            return aleatorios;
        }

       

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
        /// <param name="limiteInferior"></param>
        /// <param name="limiteSuperior"></param>
        /// <param name="Media"></param>
        /// <param name="Desviacion"></param>
        /// <param name="CantidadMuestra"></param>
        /// <returns></returns>
        public double CalcularFrecuenciaEsperada(double limiteInferior, double limiteSuperior,double media,double desviacion,int cantidadMuestra)
        {
           
            double mc = (limiteSuperior + limiteInferior) / 2;
            double part1 = Math.Pow((mc - media) / desviacion, 2);
            double part2 = -0.5 * part1;
            double part3 = Math.Pow(Math.E, part2);
            double part4 = desviacion * Math.Sqrt(2 * Math.PI);
            double fe = (part3 / part4) * (limiteSuperior - limiteInferior) * cantidadMuestra;
            NumerosUtility.Truncar4Decimales(fe);

            return fe;
        }

        /// <summary>
        /// Muestra el histograma en pantalla
        /// </summary>
        /// <param name="tamMuestra"></param>
        /// <param name="cantIntervalos"></param>
        /// <param name="media"></param>
        /// <param name="desviacion"></param>
        public void ImprimirHistogramaDistribucionNormal(int tamMuestra, int cantIntervalos, double media = 0, double desviacion = 1)
        {
            var distribucion = GenerarAleatoriosBoxMuller(media, desviacion, tamMuestra);

            if (!distribucion.Any())
                return;

            CrearHistograma(distribucion, cantIntervalos, tamMuestra, media, desviacion);
        }

        /// <summary>
        /// Limpia las variables existentes y crea el histograma
        /// </summary>
        /// <param name="distribucion"></param>
        /// <param name="cantIntervalos"></param>
        /// <param name="tamMuestra"></param>
        /// <param name="media"></param>
        /// <param name="desviacion"></param>
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

        /// <summary>
        /// Obtiene los intervalos de la grilla
        /// </summary>
        /// <param name="distribucion"></param>
        /// <param name="cantIntervalos"></param>
        /// <param name="tamMuestra"></param>
        /// <param name="media"></param>
        /// <param name="desviacion"></param>
        private void AgregarIntervalos(List<double> distribucion, int cantIntervalos, int tamMuestra, double media, double desviacion)
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
                var frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior, media, desviacion,tamMuestra);
                Console.WriteLine(frecuenciaEsperada + "FRECUENCIA ESPERADA");
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
