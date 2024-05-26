using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs.Peluqueria
{
    public class PeluqueriaEventoDto
    {
        public int NumeroIteracion { get; set; } = 0;

        public TimeSpan Reloj { get; set; } = new TimeSpan(0, 0, 0);

        public string EventoNombre { get; set; } = "Inicialización";

        public PeluqueriaObtencionTiempoDto LlegadaCliente { get; set; } = new PeluqueriaObtencionTiempoDto();

        public decimal? RandomPeluquero { get; set; }

        public string Peluquero { get; set; }

        public PeluqueriaObtencionTiempoDto AprendizFinAtencion { get; set; } = new PeluqueriaObtencionTiempoDto();

        public PeluqueriaObtencionTiempoDto VeteranoAFinAtencion { get; set; } = new PeluqueriaObtencionTiempoDto();

        public PeluqueriaObtencionTiempoDto VeteranoBFinAtencion { get; set; } = new PeluqueriaObtencionTiempoDto();

        public TimeSpan Cierre { get; set; }

        public TimeSpan Apertura { get; set; }

        public TimeSpan Refrigerio { get; set; }

        public ServidorDto Aprendiz {  get; set; }

        public ServidorDto VeteranoA { get; set; }

        public ServidorDto VeteranoB { get; set; }

        public int AcumuladorRecaudacionTotal { get; set; } = 0;

        public int ContadorDiasTrabajados { get; set; } = 0;

        public int MaximoClientesEnCola { get; set; } = 0;

        public List<ClienteDto> Clientes { get; set; } = new List<ClienteDto>();
    }
}
