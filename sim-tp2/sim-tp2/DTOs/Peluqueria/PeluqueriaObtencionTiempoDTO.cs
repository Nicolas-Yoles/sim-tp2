using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs.Peluqueria
{
    public class PeluqueriaObtencionTiempoDto
    {
        public int? EulerIntegrationId {  get; set; }

        public double? Random {  get; set; }

        public double? Tiempo { get; set; }

        public double? ProximoEvento { get; set; }
    }
}
