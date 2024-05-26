using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs.Peluqueria
{
    public class ServidorDto
    {
        public EstadoServidorEnum Estado { get; set; } = EstadoServidorEnum.Libre;

        public List<ClienteDto> ColaClientes { get; set; } = new List<ClienteDto>();
    }
}
