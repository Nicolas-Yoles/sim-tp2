using sim_tp2.DTOs;
using sim_tp2.Utilities;
using System.Collections.Generic;

namespace sim_tp2.Services
{
    public class BowlingMontecarloSimulationService
    {
        public ReglasBowlingDto Reglas { get; set; }

        public ProbabilidadesPrimerTiroBowlingDto ProbabilidadesPrimerTiro {  get; set; }

        public ProbabilidadesSegundoTiroBowlingDto ProbabilidadesSegundoTiro { get; set; }

        /// <summary>
        /// Determina los pinos tirados por el primer tiro.
        /// </summary>
        /// <param name="ronda"></param>
        private void RealizarPrimerTiro(ref RondaBowlingDto ronda)
        {
            ronda.RandomPrimerTiro = NumerosUtility.Truncar4Decimales(NumerosUtility.GetAleatorio());

            var limiteSeis = ProbabilidadesPrimerTiro.ProbabilidadSeis;
            var limiteSiete = limiteSeis + ProbabilidadesPrimerTiro.ProbabilidadSiete;
            var limiteOcho = limiteSiete + ProbabilidadesPrimerTiro.ProbabilidadOcho;
            var limiteNueve = limiteOcho + ProbabilidadesPrimerTiro.ProbabilidadNueve;

            if (ronda.RandomPrimerTiro < limiteSeis)
            {
                ronda.PinosTiradosPrimerTiro = 6;
                return;
            }
            else if(ronda.RandomPrimerTiro < limiteSiete)
            {
                ronda.PinosTiradosPrimerTiro = 7;
                return;
            }
            else if(ronda.RandomPrimerTiro < limiteOcho)
            {
                ronda.PinosTiradosPrimerTiro = 8;
                return;
            }
            else if (ronda.RandomPrimerTiro < limiteNueve)
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
        private void RealizarSegundoTiro(ref RondaBowlingDto ronda)
        {
            ronda.RandomSegundoTiro = NumerosUtility.Truncar4Decimales(NumerosUtility.GetAleatorio());

            if (ronda.PinosTiradosPrimerTiro == 6)
            {
                var limiteCero = ProbabilidadesSegundoTiro.ProbabilidadSeisCero;
                var limiteUno = limiteCero + ProbabilidadesSegundoTiro.ProbabilidadSeisUno;
                var limiteDos = limiteUno + ProbabilidadesSegundoTiro.ProbabilidadSeisDos;
                var limiteTres = limiteDos + ProbabilidadesSegundoTiro.ProbabilidadSeisTres;

                if (ronda.RandomSegundoTiro < limiteCero)
                {
                    ronda.PinosTiradosSegundoTiro = 0;
                    return;
                }
                else if (ronda.RandomSegundoTiro < limiteUno)
                {
                    ronda.PinosTiradosSegundoTiro = 1;
                    return;
                }
                else if (ronda.RandomSegundoTiro < limiteDos)
                {
                    ronda.PinosTiradosSegundoTiro = 2;
                    return;
                }
                else if (ronda.RandomSegundoTiro < limiteTres)
                {
                    ronda.PinosTiradosSegundoTiro = 3;
                    return;
                }

                ronda.PinosTiradosSegundoTiro = 4;
                return;
            }
            else if (ronda.PinosTiradosPrimerTiro == 7)
            {
                var limiteCero = ProbabilidadesSegundoTiro.ProbabilidadSieteCero;
                var limiteUno = limiteCero + ProbabilidadesSegundoTiro.ProbabilidadSieteUno;
                var limiteDos = limiteUno + ProbabilidadesSegundoTiro.ProbabilidadSieteDos;

                if (ronda.RandomSegundoTiro < limiteCero)
                {
                    ronda.PinosTiradosSegundoTiro = 0;
                    return;
                }
                else if (ronda.RandomSegundoTiro < limiteUno)
                {
                    ronda.PinosTiradosSegundoTiro = 1;
                    return;
                }
                else if (ronda.RandomSegundoTiro < limiteDos)
                {
                    ronda.PinosTiradosSegundoTiro = 2;
                    return;
                }

                ronda.PinosTiradosSegundoTiro = 3;
                return;
            }
            else if (ronda.PinosTiradosPrimerTiro == 8)
            {
                var limiteCero = ProbabilidadesSegundoTiro.ProbabilidadOchoCero;
                var limiteUno = limiteCero + ProbabilidadesSegundoTiro.ProbabilidadOchoUno;

                if (ronda.RandomSegundoTiro < limiteCero)
                {
                    ronda.PinosTiradosSegundoTiro = 0;
                    return;
                }
                else if (ronda.RandomSegundoTiro < limiteUno)
                {
                    ronda.PinosTiradosSegundoTiro = 1;
                    return;
                }

                ronda.PinosTiradosSegundoTiro = 2;
                return;
            }
            else
            {
                if (ronda.RandomSegundoTiro < (ProbabilidadesSegundoTiro.ProbabilidadNueveCero))
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
        private void ObtenerPuntajeObtenido(ref RondaBowlingDto ronda)
        {
            if (ronda.PinosTotales < 10)
            {
                ronda.PuntajeObtenido = ronda.PinosTotales;
                return;
            }

            if (ronda.PinosTiradosSegundoTiro.HasValue)
            {
                ronda.PuntajeObtenido = Reglas.PuntajeSpare;
                return;
            }

            ronda.PuntajeObtenido = Reglas.PuntajeStrike;
        }

        /// <summary>
        /// Obtiene el puntaje obtenido en una ronda simulada
        /// </summary>
        /// <param name="rondaAnterior"></param>
        /// <returns></returns>
        private RondaBowlingDto SimularRondaBowling(RondaBowlingDto rondaAnterior)
        {
            // Seteo de acumuladores y resultados de ronda anterior
            var ronda = new RondaBowlingDto()
            {
                ProbabilidadExito = rondaAnterior.ProbabilidadExito,
                PuntajeAcumuladoJuego = rondaAnterior.TerminoJuego ? 0 : rondaAnterior.PuntajeAcumuladoJuego,
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
            var terminoJuego = ronda.NumeroRonda % Reglas.RondasPorPartida == 0;

            if (terminoJuego)
            {
                ronda.ContadorExitos = ronda.PuntajeAcumuladoJuego >= Reglas.PuntajeExito ? ronda.ContadorExitos + 1 : ronda.ContadorExitos;
                ronda.ProbabilidadExito = NumerosUtility.Truncar4Decimales(ronda.ContadorExitos / (ronda.NumeroRonda / (double)Reglas.RondasPorPartida));
                ronda.TerminoJuego = true;
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
        private List<RondaBowlingDto> SimularBowling(int numeroRondas, int mostrarRondaDesde, int mostrarRondaHasta, ProbabilidadesPrimerTiroBowlingDto probabildadesPrimerTiro, ProbabilidadesSegundoTiroBowlingDto probabilidadSegundoTiro)
        {
            this.ProbabilidadesPrimerTiro = probabildadesPrimerTiro;
            this.ProbabilidadesSegundoTiro = probabilidadSegundoTiro;
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
        public List<RondaBowlingDto> ImprimirMontecarlo(int cantRondas, int rondaInicial, int rondaFinal,ProbabilidadesPrimerTiroBowlingDto probabildadesPrimerTiro,ProbabilidadesSegundoTiroBowlingDto probabilidadSegundoTiro)
            => SimularBowling( cantRondas,  rondaInicial,  rondaFinal, probabildadesPrimerTiro, probabilidadSegundoTiro);
    }
}
