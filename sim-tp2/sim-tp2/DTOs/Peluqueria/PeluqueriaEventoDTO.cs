﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs.Peluqueria
{
    public class PeluqueriaEventoDto
    {
        public int NumeroIteracion { get; set; } = -1;

        public double Reloj { get; set; } = 0;

        public string EventoNombre { get; set; } = "Inicialización";

        public PeluqueriaObtencionTiempoDto LlegadaCliente { get; set; } = new PeluqueriaObtencionTiempoDto();

        public double? RandomPeluquero { get; set; }

        public string Peluquero { get; set; }

        public PeluqueriaObtencionTiempoDto AprendizFinAtencion { get; set; } = new PeluqueriaObtencionTiempoDto();

        public PeluqueriaObtencionTiempoDto VeteranoAFinAtencion { get; set; } = new PeluqueriaObtencionTiempoDto();

        public PeluqueriaObtencionTiempoDto VeteranoBFinAtencion { get; set; } = new PeluqueriaObtencionTiempoDto();

        public double Cierre { get; set; }

        public double Apertura { get; set; }

        public ServidorDto Aprendiz {  get; set; } = new ServidorDto();

        public ServidorDto VeteranoA { get; set; } = new ServidorDto();

        public ServidorDto VeteranoB { get; set; } = new ServidorDto();

        public int AcumuladorRecaudacionTotal { get; set; } = 0;

        public int ContadorDiasTrabajados { get; set; } = 1;

        public decimal PromedioRecuadacionPorDia { get; set; } = 0;

        public int ClientesEnCola {  get; set; } = 0;

        public int MaximoClientesEnCola { get; set; } = 0;

        public List<ClienteDto> Clientes { get; set; } = new List<ClienteDto>();

        public int IdDeEuler { get; set; } = 0;
    }
}
