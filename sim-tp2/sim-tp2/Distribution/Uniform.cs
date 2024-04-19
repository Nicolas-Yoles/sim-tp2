using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sim_tp2.DTO;
using System.Windows.Forms.DataVisualization.Charting;


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

                GenerarHistograma();

            }

        }

        public void GenerarHistograma()
        {
            //Reseteo gráfico y grilla
            Grafico.Series.Clear();
            Grilla.Rows.Clear();

            double limiteInferior = 0;
            double limiteSuperior = 0;

            double valorMaximo = Datos.Max();
            double valorMinimo = Datos.Min();
            double precision = 0.0001;

            double ancho_intervalo = ((valorMaximo - valorMinimo) / cantidadIntervalos) + precision;

            int frecuenciaObservada = 0;
            double frecuenciaEsperada = 0;
            double frecuenciaObservadaAcumulada = 0;
            double frecuenciaEsperadaAcumulada = 0;
            double marcaClase = 0;

            double chiCuadrado = 0;
            double chiCuadradoAcumulado = 0;


            for (int i = 0; i < cantidadIntervalos; i++)
            {

                
                // Determinar el primer intervalo del histograma y determinar cuantos valores entran en el.
                 

                if (i == 0)
                {
                    limiteInferior = valorMinimo;
                    limiteSuperior = valorMinimo + ancho_intervalo;
                    marcaClase = (limiteInferior + limiteSuperior) / 2;

                    frecuenciaObservada = DeterminarFrecuenciaObservada(Datos, limiteInferior, limiteSuperior);
                    frecuenciaObservadaAcumulada = frecuenciaObservada;
                    frecuenciaEsperada = CalcularFrecuenciaEsperada();
                    frecuenciaEsperadaAcumulada = frecuenciaEsperada;

                    chiCuadrado = Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2) / frecuenciaEsperada;
                    chiCuadradoAcumulado += chiCuadrado;

                    AgregarFilaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);
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
                    frecuenciaEsperada = CalcularFrecuenciaEsperada();
                    frecuenciaEsperadaAcumulada += frecuenciaEsperada;

                    chiCuadrado = Math.Pow(frecuenciaObservada - frecuenciaEsperada, 2) / frecuenciaEsperada;
                    chiCuadradoAcumulado += chiCuadrado;

                    AgregarFilaGrilla(limiteInferior, limiteSuperior, marcaClase, frecuenciaObservada, frecuenciaEsperada, frecuenciaObservadaAcumulada, frecuenciaEsperadaAcumulada);

                }

                
                 //Generar la etiqueta del mínimo y máximo de cada intervalo y lo agrega a la serie de intervalos del histograma.
                 //Los valores se truncan a 4 decimales.
                 

                string etiquetaInferiorIntervalo = (Math.Truncate(limiteInferior * 10000) / 10000).ToString();
                string etiquetaSuperiorIntervalo = (Math.Truncate(limiteSuperior * 10000) / 10000).ToString();
                string etiquetaIntervalo = etiquetaInferiorIntervalo + " - " + etiquetaSuperiorIntervalo;

                Series serie = Grafico.Series.Add(etiquetaIntervalo);
                serie.Points.AddXY("Intervalos", frecuenciaObservada);
                ///Agregar para eje y

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


        public double CalcularFrecuenciaEsperada()
        {
            return cantidadMuestra / cantidadIntervalos;
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

