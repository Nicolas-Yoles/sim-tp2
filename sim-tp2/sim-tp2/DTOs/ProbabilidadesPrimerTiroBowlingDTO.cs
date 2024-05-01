using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs
{
    public class ProbabilidadesPrimerTiroBowlingDto
    {
        public double ProbabilidadSeis { get; set; } = 0.17;

        public double ProbabilidadSiete { get; set; } = 0.1;

        public double ProbabilidadOcho { get; set; } = 0.15;

        public double ProbabilidadNueve { get; set; } = 0.18;

        public double ProbabilidadDiez { get; set; } = 0.40;
    }
}
