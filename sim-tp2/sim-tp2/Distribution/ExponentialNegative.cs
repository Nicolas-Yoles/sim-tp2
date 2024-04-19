using sim_tp2.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace sim_tp2.Distribution
{
    public class ExponentialNegative
    {       
        public int CantidadMuestra { get; set; }
        public int CantidadIntervalos { get; set; }
        public double Lambda { get; set; }
        public ListBox Lista { get; set; }
        public Chart Grafico { get; set; }
        private List<double> Datos = new List<double>();
        public DataGridView Grilla { get; set; }

        private Random rnd = new Random();

        public double GenerarAleatorio()
        {
            return rnd.NextDouble();
        }

        public void GenerarDistribucion(ExponentialNegative exponencialNegativa)
        {
            Lista.Items.Clear();
            Grilla.Rows.Clear();

            Lista.BeginUpdate();
            for (int i = 0; i < CantidadMuestra; i++)
            {
                double random = GenerarAleatorio();
               // X = -1 / lambda * ln (1- RND) = -media * ln (1-RND)
                double variableAleatoria = (-1 / Lambda) * (Math.Log(1 - random));
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

                
                // Determina el primer intervalo del histograma y determinar cuantos valores entran en el.
                 

                if (i == 0)
                {
                    limiteInferior = valorMinimo;
                    limiteSuperior = valorMinimo + ancho_intervalo;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada = frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);
                    frecuenciaEsperadaAcumulada = frecuenciaEsperada;

                    AgregarFilaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);
                }

                
                // Determinar el resto de intervalos del histograma y determinar cuantos valores entran en ellos.
                 


                else
                {
                    limiteInferior = limiteSuperior;
                    limiteSuperior = limiteSuperior + ancho_intervalo;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada += frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada(limiteInferior, limiteSuperior);
                    frecuenciaEsperadaAcumulada += frecuenciaEsperada;

                    AgregarFilaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);

                }

                
               //  Genera la etiqueta del mínimo y máximo de cada intervalo y lo agrega a la serie de intervalos del histograma.
                // Los valores se truncan a 4 decimales.
                 

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

        public double CalcularFrecuenciaEsperada(double limiteInferior, double limiteSuperior)
        {
            
            double frecuenciaEsperada = ((1 - Math.Exp((-Lambda) * limiteSuperior)) - (1 - Math.Exp((-Lambda) * limiteInferior))) * CantidadMuestra;

            return frecuenciaEsperada;
        }

        public void AgregarFilaGrilla(double limiteInferior, double limiteSuperior, double marcaClase, double frecuenciaObservada,
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

