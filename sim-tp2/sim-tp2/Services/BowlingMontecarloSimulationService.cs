using sim_tp2.DTOs;
using sim_tp2.Utilities;
using System.Collections.Generic;

namespace sim_tp2.Services
{
    public static class BowlingMontecarloSimulationService
    {
        /// <summary>
        /// Determina los pinos tirados por el primer tiro.
        /// </summary>
        /// <param name="ronda"></param>
        private static void RealizarPrimerTiro(ref RondaBowlingDto ronda)
        {
            ronda.RandomPrimerTiro = NumerosUtility.Truncar4Decimales(NumerosUtility.GetAleatorio());

            if(ronda.RandomPrimerTiro <= 0.16)
            {
                ronda.PinosTiradosPrimerTiro = 6;
                return;
            }
            else if(ronda.RandomPrimerTiro <= 0.26)
            {
                ronda.PinosTiradosPrimerTiro = 7;
                return;
            }
            else if(ronda.RandomPrimerTiro <= 0.41)
            {
                ronda.PinosTiradosPrimerTiro = 8;
                return;
            }
            else if (ronda.RandomPrimerTiro <= 0.59)
            {
                ronda.PinosTiradosPrimerTiro = 9;
                return;
            }

            ronda.PinosTiradosPrimerTiro = 10;
        }

        /// <summary>
        /// Determina los pinos tirados por el segundo tiro, segun los tirados
        /// por el primer tiro.
        /// </summary>
        /// <param name="ronda"></param>
        /// <returns></returns>
        private static void RealizarSegundoTiro(ref RondaBowlingDto ronda)
        {
            ronda.RandomSegundoTiro = NumerosUtility.Truncar4Decimales(NumerosUtility.GetAleatorio());

            if (ronda.PinosTiradosPrimerTiro == 6)
            {
                if (ronda.RandomSegundoTiro <= 0.09)
                {
                    ronda.PinosTiradosSegundoTiro = 0;
                    return;
                }
                else if (ronda.RandomSegundoTiro <= 0.29)
                {
                    ronda.PinosTiradosSegundoTiro = 1;
                    return;
                }
                else if (ronda.RandomSegundoTiro <= 0.59)
                {
                    ronda.PinosTiradosSegundoTiro = 2;
                    return;
                }
                else if (ronda.RandomSegundoTiro <= 0.89)
                {
                    ronda.PinosTiradosSegundoTiro = 3;
                    return;
                }

                ronda.PinosTiradosSegundoTiro = 4;
                return;
            }
            else if (ronda.PinosTiradosPrimerTiro == 7)
            {
                if (ronda.RandomSegundoTiro <= 0.01)
                {
                    ronda.PinosTiradosSegundoTiro = 0;
                    return;
                }
                else if (ronda.RandomSegundoTiro <= 0.11)
                {
                    ronda.PinosTiradosSegundoTiro = 1;
                    return;
                }
                else if (ronda.RandomSegundoTiro <= 0.56)
                {
                    ronda.PinosTiradosSegundoTiro = 2;
                    return;
                }

                ronda.PinosTiradosSegundoTiro = 3;
                return;
            }
            else if (ronda.PinosTiradosPrimerTiro == 8)
            {
                if (ronda.RandomSegundoTiro <= 0.03)
                {
                    ronda.PinosTiradosSegundoTiro = 0;
                    return;
                }
                else if (ronda.RandomSegundoTiro <= 0.23)
                {
                    ronda.PinosTiradosSegundoTiro = 1;
                    return;
                }

                ronda.PinosTiradosSegundoTiro = 2;
                return;
            }
            else
            {
                if (ronda.RandomSegundoTiro <= 0.05)
                {
                    ronda.PinosTiradosSegundoTiro = 0;
                    return;
                }

                ronda.PinosTiradosSegundoTiro = 1;
                return;
            }
        }

        /// <summary>
        /// Determina el puntaje obtenido. Si no se tiraron los 10 pinos, devuelve cantidad de pinos.
        /// Si se tiraron los 10 con un tiro, devuelve 20, con dos tiros devuelve 15.
        /// </summary>
        /// <param name="ronda"></param>
        private static void ObtenerPuntajeObtenido(ref RondaBowlingDto ronda)
        {
            if (ronda.PinosTotales < 10)
            {
                ronda.PuntajeObtenido = ronda.PinosTotales;
                return;
            }

            if (ronda.PinosTiradosSegundoTiro.HasValue)
            {
                ronda.PuntajeObtenido = 15;
                return;
            }

            ronda.PuntajeObtenido = 20;
        }

        /// <summary>
        /// Obtiene el puntaje obtenido en una ronda simulada
        /// </summary>
        /// <param name="rondaAnterior"></param>
        /// <returns></returns>
        private static RondaBowlingDto SimularRondaBowling(RondaBowlingDto rondaAnterior)
        {
            // Seteo de acumuladores y resultados de ronda anterior
            var ronda = new RondaBowlingDto()
            {
                ProbabilidadExito = rondaAnterior.ProbabilidadExito,
                PuntajeAcumuladoJuego = rondaAnterior.PuntajeAcumuladoJuego,
                NumeroRonda = rondaAnterior.NumeroRonda + 1,
                ContadorExitos = rondaAnterior.ContadorExitos
            };

            // Operaciones de la ronda
            RealizarPrimerTiro(ref ronda);
            if(ronda.PinosTiradosPrimerTiro != 10)
            {
                RealizarSegundoTiro(ref ronda);
            }
            ronda.PinosTotales = ronda.PinosTiradosPrimerTiro + (ronda.PinosTiradosSegundoTiro ?? 0);
            ObtenerPuntajeObtenido(ref ronda);
            ronda.PuntajeAcumuladoJuego += ronda.PuntajeObtenido;

            //Recalculo de acumuladores y resultados
            var terminoJuego = ronda.NumeroRonda % 10 == 0;

            if (terminoJuego)
            {
                ronda.ContadorExitos = ronda.PuntajeAcumuladoJuego >= 120 ? ronda.ContadorExitos + 1 : ronda.ContadorExitos;
                ronda.ProbabilidadExito = NumerosUtility.Truncar4Decimales(ronda.ContadorExitos / (ronda.NumeroRonda / 10d));
                ronda.PuntajeAcumuladoJuego = 0;
            }

            return ronda;
        }

        /// <summary>
        /// Realiza la simulacion de N rondas devolviendo las rondas requeridas
        /// para mostrar por pantalla (las del rango y la última)
        /// </summary>
        /// <param name="numeroRondas"></param>
        /// <param name="mostrarRondaDesde"></param>
        /// <param name="mostrarRondaHasta"></param>
        /// <returns></returns>
        private static List<RondaBowlingDto> SimularBowling(int numeroRondas, int mostrarRondaDesde, int mostrarRondaHasta)
        {
            var rondasAMostrar = new List<RondaBowlingDto>();

            var rondaSimulada = new RondaBowlingDto()
            {
                ContadorExitos = 0,
                PuntajeAcumuladoJuego = 0,
                NumeroRonda = 0,
                ProbabilidadExito = 0.00
            };

            for(int i = 0; i < numeroRondas; i++)
            {
                rondaSimulada = SimularRondaBowling(rondaSimulada);
                if(i == (numeroRondas - 1) || (rondaSimulada.NumeroRonda >= mostrarRondaDesde && rondaSimulada.NumeroRonda <= mostrarRondaHasta))
                {
                    rondasAMostrar.Add(rondaSimulada);
                }
            }

            return rondasAMostrar;
        }

        /// <summary>
        /// Imprime la simulación de un intervalo de filas y la última fila
        /// del Bowling.
        /// </summary>
        /// <param name="cantRondas"></param>
        /// <param name="rondaInicial"></param>
        /// <param name="rondaFinal"></param>
        /// <returns></returns>
        public static List<RondaBowlingDto> ImprimirMontecarlo(int cantRondas, int rondaInicial, int rondaFinal)
            => SimularBowling( cantRondas,  rondaInicial,  rondaFinal);
    }
}
