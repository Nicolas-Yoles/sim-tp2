using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs.Peluqueria
{
    public class PeluqueriaObtencionTiempoDto
    {
        public decimal Random {  get; set; }

        public TimeSpan Tiempo { get; set; }

        public DateTime ProximoEvento { get; set; }
    }
}
