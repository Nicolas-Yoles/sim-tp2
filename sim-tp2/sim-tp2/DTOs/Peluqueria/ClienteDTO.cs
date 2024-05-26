using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs.Peluqueria
{
    public class ClienteDto
    {
        public static int UltimoId { get; set; }

        public int Id;

        public EstadoClienteEnum Estado { get; set; }

        public double HoraRefrigerio { get; set; }

        public bool ConRefrigerio { get; set; }
    }
}
