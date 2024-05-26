using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs.Peluqueria
{
    public class PeluqueriaEventoDto
    {
        public DateTime Reloj { get; set; }

        public string EventoNombre { get; set; }

        public PeluqueriaObtencionTiempoDto LlegadaCliente { get; set; }

        public decimal RandomPeluquero { get; set; }

        public string Peluquero { get; set; }

        public PeluqueriaObtencionTiempoDto AprendizFinAtencion { get; set; }

        public PeluqueriaObtencionTiempoDto VeteranoAFinAtencion { get; set; }

        public PeluqueriaObtencionTiempoDto VeteranoBFinAtencion { get; set; }

        public DateTime HoraCierre { get; set; }

        public DateTime HoraApertura { get; set; }

        public DateTime HoraProximoRefrigerio { get; set; }

        public ServidorDto Aprendiz {  get; set; }

        public ServidorDto VeteranoA { get; set; }

        public ServidorDto VeteranoB { get; set; }

        public int AcumuladorRecaudacionTotal { get; set; }

        public int ContadorDiasTrabajados { get; set; }

        public int MaximoClientesEnCola { get; set; }

        public List<ClienteDto> Clientes { get; set; }
    }
}
