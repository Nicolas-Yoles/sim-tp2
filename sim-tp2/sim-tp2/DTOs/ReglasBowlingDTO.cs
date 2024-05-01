using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs
{
    public class ReglasBowlingDto
    {
        /// <summary>
        /// Puntaje de tirar todos los pinos con un tiro
        /// </summary>
        public int PuntajeStrike { get; set; } = 20;

        /// <summary>
        /// Puntaje de tirar todos los pinos con los dos tiros
        /// </summary>
        public int PuntajeSpare { get; set; } = 15;

        /// <summary>
        /// Rondas a jugar por partida
        /// </summary>
        public int RondasPorPartida { get; set; } = 10;

        /// <summary>
        /// Puntaje mínimo para contarlo como éxito en el calculo de probabilidad
        /// </summary>
        public int PuntajeExito { get; set; } = 120;
    }
}
