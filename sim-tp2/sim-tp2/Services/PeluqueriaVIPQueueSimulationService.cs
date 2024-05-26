using sim_tp2.DTOs.Peluqueria;
using System;
using System.Collections.Generic;
using System.Linq;

namespace sim_tp2.Services
{
    public class PeluqueriaVipQueueSimulationService
    {
        private PeluqueriaParametrizacionDto _parametrizacion;

        /// <summary>
        /// Realiza la simulación de un sistemas de colas de una peluqueria.
        /// </summary>
        /// <param name="numeroDiasASimular"></param>
        /// <param name="iteracionesAMostrar"></param>
        /// <param name="horaDesdeAMostrar"></param>
        /// <param name="parametrizacion"></param>
        /// <returns></returns>
        public List<PeluqueriaEventoDto> SimularPeluqueria(int numeroDiasASimular, int iteracionesAMostrar, TimeSpan horaDesdeAMostrar, PeluqueriaParametrizacionDto parametrizacion)
        {
            _parametrizacion = parametrizacion;
            var iteracionesAImprimir = new List<PeluqueriaEventoDto>();
            var mostrarIteracionHasta = int.MaxValue;

            var iteracion = new PeluqueriaEventoDto()
            {
                LlegadaCliente = new PeluqueriaObtencionTiempoDto() { ProximoEvento = new TimeSpan(0,0,0)}
            };

            while (numeroDiasASimular <= iteracion.ContadorDiasTrabajados)
            {
                iteracion = SimularEvento(iteracion);
                if (iteracion.Reloj >= horaDesdeAMostrar && mostrarIteracionHasta < iteracion.NumeroIteracion)
                {
                    mostrarIteracionHasta = mostrarIteracionHasta == int.MaxValue ? iteracion.NumeroIteracion + iteracionesAMostrar : mostrarIteracionHasta;
                    iteracionesAImprimir.Add(iteracion);
                }
            }

            return iteracionesAImprimir;
        }

        private PeluqueriaEventoDto SimularEvento(PeluqueriaEventoDto iteracionAnterior)
        {
            var iteracionActual = new PeluqueriaEventoDto();
            DeterminarEventoASimular(iteracionAnterior, ref iteracionActual);

            switch(iteracionActual.EventoNombre)
            {
                case nameof(iteracionActual.LlegadaCliente):
                    LlegarCliente(iteracionAnterior, ref iteracionActual);
                    break;
                case nameof(iteracionActual.AprendizFinAtencion):
                    FinalizarAtencionAprendiz(iteracionAnterior, ref iteracionActual);
                    break;
                case nameof(iteracionActual.VeteranoAFinAtencion):
                    FinalizarAtencionVeteranoA(iteracionAnterior, ref iteracionActual);
                    break;
                case nameof(iteracionActual.VeteranoBFinAtencion):
                    FinalizarAtencionVeteranoB(iteracionAnterior, ref iteracionActual);
                    break;
                case nameof(iteracionActual.Cierre):
                    Cerrar(iteracionAnterior, ref iteracionActual);
                    break;
                case nameof(iteracionActual.Apertura):
                    Abrir(iteracionAnterior, ref iteracionActual);
                    break;
                case nameof(iteracionActual.Refrigerio):
                    DarRefrigerio(iteracionAnterior, ref iteracionActual);
                    break;
            }

            return iteracionActual;
        }

        private void DarRefrigerio(PeluqueriaEventoDto iteracionAnterior, ref PeluqueriaEventoDto iteracionActual)
        {
            throw new NotImplementedException();
        }

        private void Abrir(PeluqueriaEventoDto iteracionAnterior, ref PeluqueriaEventoDto iteracionActual)
        {
            throw new NotImplementedException();
        }

        private void Cerrar(PeluqueriaEventoDto iteracionAnterior, ref PeluqueriaEventoDto iteracionActual)
        {
            throw new NotImplementedException();
        }

        private void FinalizarAtencionVeteranoB(PeluqueriaEventoDto iteracionAnterior, ref PeluqueriaEventoDto iteracionActual)
        {
            throw new NotImplementedException();
        }

        private void FinalizarAtencionVeteranoA(PeluqueriaEventoDto iteracionAnterior, ref PeluqueriaEventoDto iteracionActual)
        {
            throw new NotImplementedException();
        }

        private void FinalizarAtencionAprendiz(PeluqueriaEventoDto iteracionAnterior, ref PeluqueriaEventoDto iteracionActual)
        {
            throw new NotImplementedException();
        }

        private void LlegarCliente(PeluqueriaEventoDto iteracionAnterior, ref PeluqueriaEventoDto iteracionActual)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determina cual es el siguiente evento y adelanta el reloj a ese evento.
        /// </summary>
        /// <param name="iteracionAnterior"></param>
        /// <param name="iteracionActual"></param>
        private void DeterminarEventoASimular(PeluqueriaEventoDto iteracionAnterior, ref PeluqueriaEventoDto iteracionActual)
        {
            var diccionarioEventos = new Dictionary<string, TimeSpan?>
            {
                {nameof(iteracionActual.LlegadaCliente), iteracionAnterior.LlegadaCliente.ProximoEvento },
                {nameof(iteracionActual.AprendizFinAtencion), iteracionAnterior.AprendizFinAtencion.ProximoEvento },
                {nameof(iteracionActual.VeteranoAFinAtencion), iteracionAnterior.VeteranoAFinAtencion.ProximoEvento },
                {nameof(iteracionActual.VeteranoBFinAtencion), iteracionAnterior.VeteranoBFinAtencion.ProximoEvento },
                {nameof(iteracionActual.Cierre), iteracionAnterior.Cierre },
                {nameof(iteracionActual.Apertura), iteracionAnterior.Apertura },
                {nameof(iteracionActual.Refrigerio), iteracionAnterior.Refrigerio }
            };

            var nombreEvento = string.Empty;
            var menorTimeSpan = TimeSpan.MaxValue;
            foreach (var kvp in diccionarioEventos.Where(x => x.Value.HasValue))
            {
                if (kvp.Value.Value < menorTimeSpan)
                {
                    menorTimeSpan = kvp.Value.Value;
                    nombreEvento = kvp.Key;
                }
            }

            iteracionActual.Reloj = menorTimeSpan;
            iteracionActual.EventoNombre = nombreEvento;
        }
    }
}
