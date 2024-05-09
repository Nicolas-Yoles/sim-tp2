using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs
{
    public class RondaBowlingDto
    {
        public int NumeroRonda { get; set; }

        public double RandomPrimerTiro { get; set; }

        public int PinosTiradosPrimerTiro { get; set; }

        public double? RandomSegundoTiro { get; set; }

        public int? PinosTiradosSegundoTiro { get; set; }

        public int PinosTotales { get; set; }

        public int PuntajeObtenido { get; set; }

        public int PuntajeAcumuladoJuego { get; set; }

        public int ContadorExitos { get; set; }

        public double ProbabilidadExito { get; set; }

        public bool TerminoJuego { get; set; }
    }
}
