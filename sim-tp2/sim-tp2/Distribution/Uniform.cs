﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sim_tp2.DTO;
using System.Windows.Forms.DataVisualization.Charting;
using sim_tp2.Utilities;


namespace sim_tp2.Distribution
{
    public  class Uniform
    {
        public ListBox Lista { get; set; }

        public Chart Grafico { get; set; }

        public DataGridView Grilla { get; set; }

        private readonly Random Random = new Random();

        /// <summary>
        /// Devuelve un número aleatorio de tipo double en el
        /// intervalo[0, 1), es decir, incluye 0 pero excluye 1.
        /// </summary>
        /// <returns></returns>
        public double GetAleatorio()
        {
            return Random.NextDouble();
        }

        /// <summary>
        /// Devuelve un numero aleatorio uniforme [A; B]
        /// truncado a 4 decimales.
        /// </summary>
        /// <param name="minimo"></param>
        /// <param name="maximo"></param>
        /// <returns></returns>
        public double GetAleatorioUniforme(double minimo, double maximo)
            => NumerosUtility.Truncar4Decimales(minimo + (GetAleatorio() * (maximo - minimo)));

        /// <summary>
        /// Devuelve la frecuencia esperada
        /// </summary>
        /// <returns></returns>
        public double CalcularFrecuenciaEsperada(int tamMuestra, int cantIntervalos)
            => tamMuestra / cantIntervalos;

        /// <summary>
        /// Devuelve la frecuencia observada
        /// </summary>
        /// <param name="ListaDatos"></param>
        /// <param name="limiteInferior"></param>
        /// <param name="limiteSuperior"></param>
        /// <returns></returns>
        public int DeterminarFrecuenciaObservada(List<double> distribucion, double limiteInferior, double limiteSuperior)
            => distribucion.Where(x => limiteInferior <= x && x <= limiteSuperior).Count();

        /// <summary>
        /// Genera una secuencia de número que corresponden a una
        /// distribución uniforme [A,B]. Por defecto [0,1).
        /// </summary>
        /// <param name="tamMuestra"></param>
        /// <param name="limInferior">Por defecto: 0</param>
        /// <param name="limSuperior">Por defecto: 1</param>
        /// <returns></returns>
        public List<double> GenerarDistribucionUniforme(int tamMuestra, double limInferior = 0, double limSuperior = 1)
        {
            var distribucion = new List<double>();

            var numeroGenerado = GetAleatorioUniforme(limInferior, limSuperior);
            distribucion.Add(numeroGenerado);

            for (int i = 0; i < tamMuestra; i++)
            {
                numeroGenerado = GetAleatorioUniforme(limInferior, limSuperior);
                distribucion.Add(numeroGenerado);
            }

            return distribucion;
        }

        public void ImprimirHistogramaDistribucionUniforme(int tamMuestra, int cantIntervalos, double limInferior = 0, double limSuperior = 1)
        {
            if (limInferior > limSuperior || tamMuestra == 0 || cantIntervalos == 0)
                return;

            var distribucion = GenerarDistribucionUniforme(tamMuestra, limInferior, limSuperior);

            if (!distribucion.Any())
                return;

            CrearHistograma(distribucion, cantIntervalos);
        }

        private void CrearHistograma(List<double> distribucion, int cantIntervalos)
        {
            Lista.Items.Clear();
            Grafico.Series.Clear();
            Grilla.Rows.Clear();

            Lista.BeginUpdate();
            distribucion.ForEach(x => Lista.Items.Add(x));
            AgregarIntervalos(distribucion, cantIntervalos);
        }

        private void AgregarIntervalos(List<double> distribucion, int cantIntervalos)
        {
            var anchoIntervalo = ((distribucion.Max() - distribucion.Min()) / cantIntervalos) + 0.0001;
            var limiteInferior = distribucion.Min();
            var limiteSuperior = limiteInferior + anchoIntervalo;
            var frecuenciaEsperada = CalcularFrecuenciaEsperada(distribucion.Count, cantIntervalos);

            double chiCuadradoAcumulado = 0;
            double frecuenciaObservadaAcumulada = 0;

            for (int i = 0; i < cantIntervalos; i++)
            {
                double marcaClase = (limiteInferior + limiteSuperior) / 2;
                double frecuenciaObservada = DeterminarFrecuenciaObservada(distribucion, limiteInferior, limiteSuperior);
                double chiCuadrado = Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2) / frecuenciaEsperada;
                double frecuenciaEsperadaAcumulada = frecuenciaEsperada * (i + 1);

                frecuenciaObservadaAcumulada += frecuenciaObservada;
                chiCuadradoAcumulado += chiCuadrado;

                AgregarFilaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);
                NumerosUtility.Truncar4Decimales(limiteInferior).ToString();
                string etiquetaInferiorIntervalo = NumerosUtility.Truncar4Decimales(limiteInferior).ToString();
                string etiquetaSuperiorIntervalo = NumerosUtility.Truncar4Decimales(limiteSuperior).ToString();
                string etiquetaIntervalo = $"{etiquetaInferiorIntervalo} - {etiquetaSuperiorIntervalo}";
                Series serie = Grafico.Series.Add(etiquetaIntervalo);
                serie.Points.AddXY("Intervalos", frecuenciaObservada);
                ///Agregar para eje y

                limiteInferior = limiteSuperior;
                limiteSuperior += anchoIntervalo;
            }
        }

        public void AgregarFilaGrilla(double limiteInferior, double limiteSuperior, double marcaClase, double frecuenciaObservada,
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

