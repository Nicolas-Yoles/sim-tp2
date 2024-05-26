using sim_tp2.Distribution;
using sim_tp2.DTOs.Peluqueria;
using sim_tp2.Utilities;
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
        public List<PeluqueriaEventoDto> SimularPeluqueria(int numeroDiasASimular, int iteracionesAMostrar, double horaDesdeAMostrar, PeluqueriaParametrizacionDto parametrizacion)
        {
            _parametrizacion = parametrizacion;
            var iteracionesAImprimir = new List<PeluqueriaEventoDto>();
            var mostrarIteracionHasta = int.MaxValue;
            var ultimaIteracionAgregada = false;

            var iteracion = new PeluqueriaEventoDto()
            {
                Cierre = 8,
                Apertura = 24
            };

            while (true)
            {
                iteracion = SimularEvento(iteracion);
                if (iteracion.ContadorDiasTrabajados > numeroDiasASimular) break;
                ultimaIteracionAgregada = false;

                if (iteracion.Reloj >= horaDesdeAMostrar && mostrarIteracionHasta < iteracion.NumeroIteracion)
                {
                    mostrarIteracionHasta = mostrarIteracionHasta == int.MaxValue ? iteracion.NumeroIteracion + iteracionesAMostrar : mostrarIteracionHasta;
                    iteracionesAImprimir.Add(iteracion);
                    ultimaIteracionAgregada = true;
                }
            }

            if(!ultimaIteracionAgregada) iteracionesAImprimir.Add(iteracion);
            return iteracionesAImprimir;
        }

        private PeluqueriaEventoDto SimularEvento(PeluqueriaEventoDto iteracionAnterior)
        {
            var iteracionActual = new PeluqueriaEventoDto()
            {
                LlegadaCliente = new PeluqueriaObtencionTiempoDto() { ProximoEvento = iteracionAnterior.LlegadaCliente.ProximoEvento },
                AprendizFinAtencion = new PeluqueriaObtencionTiempoDto { ProximoEvento = iteracionAnterior.AprendizFinAtencion.ProximoEvento },
                VeteranoAFinAtencion = new PeluqueriaObtencionTiempoDto { ProximoEvento = iteracionAnterior.VeteranoAFinAtencion.ProximoEvento },
                VeteranoBFinAtencion = new PeluqueriaObtencionTiempoDto { ProximoEvento = iteracionAnterior.VeteranoBFinAtencion.ProximoEvento },
                Cierre = iteracionAnterior.Cierre,
                Apertura = iteracionAnterior.Apertura,
                Aprendiz = iteracionAnterior.Aprendiz,
                VeteranoA = iteracionAnterior.VeteranoA,
                VeteranoB = iteracionAnterior.VeteranoB,
                AcumuladorRecaudacionTotal = iteracionAnterior.AcumuladorRecaudacionTotal,
                ContadorDiasTrabajados = iteracionAnterior.ContadorDiasTrabajados,
                MaximoClientesEnCola = iteracionAnterior.MaximoClientesEnCola,
                Clientes = iteracionAnterior.Clientes,
                NumeroIteracion = iteracionAnterior.NumeroIteracion + 1
            };

            DeterminarEventoASimular(ref iteracionActual);

            switch(iteracionActual.EventoNombre)
            {
                case nameof(iteracionActual.LlegadaCliente):
                    LlegarCliente(ref iteracionActual);
                    break;
                case nameof(iteracionActual.AprendizFinAtencion):
                    FinalizarAtencionAprendiz(ref iteracionActual);
                    break;
                case nameof(iteracionActual.VeteranoAFinAtencion):
                    FinalizarAtencionVeteranoA(ref iteracionActual);
                    break;
                case nameof(iteracionActual.VeteranoBFinAtencion):
                    FinalizarAtencionVeteranoB(ref iteracionActual);
                    break;
                case nameof(iteracionActual.Cierre):
                    iteracionActual.LlegadaCliente.ProximoEvento = null;
                    iteracionActual.Cierre = iteracionActual.Apertura + 8;
                    break;
                case nameof(iteracionActual.Apertura):
                    iteracionActual.ContadorDiasTrabajados++;
                    CalcularLlegadaCliente(ref iteracionActual);
                    iteracionActual.Apertura += 24;
                    break;
                case "Refrigerio":
                    DarRefrigerio(ref iteracionActual);
                    break;
                case "Inicializacion":
                    CalcularLlegadaCliente(ref iteracionActual);
                    break;
            }

            var estadosAtencion = new List<EstadoClienteEnum> { EstadoClienteEnum.SiendoAtendidoVeteranoA, EstadoClienteEnum.SiendoAtendidoAprendiz, EstadoClienteEnum.SiendoAtendidoVeteranoB };
            iteracionActual.ClientesEnCola = iteracionActual.Clientes.Count(x => !estadosAtencion.Contains(x.Estado));
            iteracionActual.MaximoClientesEnCola = iteracionActual.ClientesEnCola > iteracionActual.MaximoClientesEnCola 
                ? iteracionActual.ClientesEnCola 
                : iteracionActual.MaximoClientesEnCola;

            iteracionActual.PromedioRecuadacionPorDia = iteracionActual.AcumuladorRecaudacionTotal / iteracionActual.ContadorDiasTrabajados;

            return iteracionActual;
        }

        private void CalcularLlegadaCliente(ref PeluqueriaEventoDto iteracionActual)
        {
            iteracionActual.LlegadaCliente.Random = NumerosUtility.GetAleatorio();
            iteracionActual.LlegadaCliente.Tiempo = Uniform.GenerarAleatorio(
                _parametrizacion.LlegadaClienteLimiteInferior,
                _parametrizacion.LlegadaClienteLimiteSuperior,
                iteracionActual.LlegadaCliente.Random);
            iteracionActual.LlegadaCliente.ProximoEvento = iteracionActual.Reloj + iteracionActual.LlegadaCliente.Tiempo;
        }

        private void DarRefrigerio(ref PeluqueriaEventoDto iteracionActual)
        {
            var cliente = iteracionActual.Clientes.Where(x => !x.ConRefrigerio).OrderBy(x => x.HoraRefrigerio).First();
            cliente.ConRefrigerio = true;
            cliente.HoraRefrigerio = null;
            iteracionActual.AcumuladorRecaudacionTotal += 1500;
        }

        private void FinalizarAtencionVeteranoB(ref PeluqueriaEventoDto iteracionActual)
        {
            iteracionActual.AcumuladorRecaudacionTotal += 3500;

            if (!iteracionActual.VeteranoB.ColaClientes.Any())
            {
                iteracionActual.VeteranoB.Estado = EstadoServidorEnum.Libre;
                iteracionActual.Clientes = iteracionActual.Clientes.Where(x => x.Estado != EstadoClienteEnum.SiendoAtendidoVeteranoB).ToList();
                return;
            }

            var cliente = iteracionActual.VeteranoB.ColaClientes.First();
            iteracionActual.VeteranoB.ColaClientes.Remove(cliente);
            iteracionActual.Clientes.Find(x => x.Id == cliente.Id).Estado = EstadoClienteEnum.SiendoAtendidoVeteranoB;
            iteracionActual.Clientes.Find(x => x.Id == cliente.Id).HoraRefrigerio = null;
            iteracionActual.VeteranoBFinAtencion = CalcularFinAtencionVeteranoB(iteracionActual.Reloj);
        }

        private void FinalizarAtencionVeteranoA(ref PeluqueriaEventoDto iteracionActual)
        {
            iteracionActual.AcumuladorRecaudacionTotal += 3500;

            if (!iteracionActual.VeteranoA.ColaClientes.Any())
            {
                iteracionActual.VeteranoA.Estado = EstadoServidorEnum.Libre;
                iteracionActual.Clientes = iteracionActual.Clientes.Where(x => x.Estado != EstadoClienteEnum.SiendoAtendidoVeteranoA).ToList();
                return;
            }

            var cliente = iteracionActual.VeteranoA.ColaClientes.First();
            iteracionActual.VeteranoA.ColaClientes.Remove(cliente);
            iteracionActual.Clientes.Find(x => x.Id == cliente.Id).Estado = EstadoClienteEnum.SiendoAtendidoVeteranoA;
            iteracionActual.Clientes.Find(x => x.Id == cliente.Id).HoraRefrigerio = null;
            iteracionActual.VeteranoAFinAtencion = CalcularFinAtencionVeteranoA(iteracionActual.Reloj);
        }

        private void FinalizarAtencionAprendiz(ref PeluqueriaEventoDto iteracionActual)
        {
            iteracionActual.AcumuladorRecaudacionTotal += 1800;

            if (!iteracionActual.Aprendiz.ColaClientes.Any())
            {
                iteracionActual.Aprendiz.Estado = EstadoServidorEnum.Libre;
                iteracionActual.Clientes = iteracionActual.Clientes.Where(x => x.Estado != EstadoClienteEnum.SiendoAtendidoAprendiz).ToList();
                return;
            }

            var cliente = iteracionActual.Aprendiz.ColaClientes.First();
            iteracionActual.Aprendiz.ColaClientes.Remove(cliente);
            iteracionActual.Clientes.Find(x => x.Id == cliente.Id).Estado = EstadoClienteEnum.SiendoAtendidoAprendiz;
            iteracionActual.Clientes.Find(x => x.Id == cliente.Id).HoraRefrigerio = null;
            iteracionActual.AprendizFinAtencion = CalcularFinAtencionAprendiz(iteracionActual.Reloj);
        }

        private void LlegarCliente(ref PeluqueriaEventoDto iteracionActual)
        {
            ClienteDto.UltimoId++;
            var cliente = new ClienteDto()
            {
                HoraRefrigerio = iteracionActual.Reloj + 30,
                ConRefrigerio = false,
                Id = ClienteDto.UltimoId
            };

            CalcularLlegadaCliente(ref iteracionActual);

            iteracionActual.RandomPeluquero = NumerosUtility.GetAleatorio();

            if (iteracionActual.RandomPeluquero < _parametrizacion.AprendizProbabilidadAtender)
            {
                iteracionActual.Peluquero = nameof(iteracionActual.Aprendiz);
                LlegarClienteAServidor(ref iteracionActual, nameof(iteracionActual.Aprendiz), cliente);
            }
            else if (iteracionActual.RandomPeluquero < (_parametrizacion.AprendizProbabilidadAtender + _parametrizacion.VeteranoAProbabilidadAtender))
            {
                iteracionActual.Peluquero = nameof(iteracionActual.VeteranoA);
                LlegarClienteAServidor(ref iteracionActual, nameof(iteracionActual.VeteranoA), cliente);
            }
            else
            {
                iteracionActual.Peluquero = nameof(iteracionActual.VeteranoB);
                LlegarClienteAServidor(ref iteracionActual, nameof(iteracionActual.VeteranoB), cliente);
            }
        }

        private void LlegarClienteAServidor(ref PeluqueriaEventoDto iteracionActual, string servidor, ClienteDto cliente)
        {
            switch (servidor) 
            {
                case nameof(iteracionActual.Aprendiz):
                    if(iteracionActual.Aprendiz.Estado == EstadoServidorEnum.Ocupado)
                    {
                        cliente.Estado = EstadoClienteEnum.EsperandoAtencionAprendiz;
                        iteracionActual.Aprendiz.ColaClientes.Add(cliente);
                        break;
                    }

                    cliente.Estado = EstadoClienteEnum.SiendoAtendidoAprendiz;
                    iteracionActual.Aprendiz.Estado = EstadoServidorEnum.Ocupado;
                    iteracionActual.AprendizFinAtencion = CalcularFinAtencionAprendiz(iteracionActual.Reloj);
                    break;

                case nameof(iteracionActual.VeteranoA):
                    if (iteracionActual.VeteranoA.Estado == EstadoServidorEnum.Ocupado)
                    {
                        cliente.Estado = EstadoClienteEnum.EsperandoAtencionVeteranoA;
                        iteracionActual.VeteranoA.ColaClientes.Add(cliente);
                        break;
                    }

                    cliente.Estado = EstadoClienteEnum.SiendoAtendidoVeteranoA;
                    iteracionActual.VeteranoA.Estado = EstadoServidorEnum.Ocupado;
                    iteracionActual.VeteranoAFinAtencion = CalcularFinAtencionVeteranoA(iteracionActual.Reloj);
                    break;

                case nameof(iteracionActual.VeteranoB):
                    if (iteracionActual.VeteranoB.Estado == EstadoServidorEnum.Ocupado)
                    {
                        cliente.Estado = EstadoClienteEnum.EsperandoAtencionVeteranoB;
                        iteracionActual.VeteranoB.ColaClientes.Add(cliente);
                        break;
                    }

                    cliente.Estado = EstadoClienteEnum.SiendoAtendidoVeteranoB;
                    iteracionActual.VeteranoB.Estado = EstadoServidorEnum.Ocupado;
                    iteracionActual.VeteranoBFinAtencion = CalcularFinAtencionVeteranoB(iteracionActual.Reloj);
                    break;
            }

            iteracionActual.Clientes.Add(cliente);
        }

        private PeluqueriaObtencionTiempoDto CalcularFinAtencionVeteranoA(double reloj)
        {
            var finAtencion = new PeluqueriaObtencionTiempoDto();

            finAtencion.Random = NumerosUtility.GetAleatorio();
            finAtencion.Tiempo = Uniform.GenerarAleatorio(
                _parametrizacion.VeteranoALimiteInferior,
                _parametrizacion.VeteranoALimiteSuperior,
                finAtencion.Random);
            finAtencion.ProximoEvento = reloj + finAtencion.Tiempo;

            return finAtencion;
        }

        private PeluqueriaObtencionTiempoDto CalcularFinAtencionVeteranoB(double reloj)
        {
            var finAtencion = new PeluqueriaObtencionTiempoDto();

            finAtencion.Random = NumerosUtility.GetAleatorio();
            finAtencion.Tiempo = Uniform.GenerarAleatorio(
                _parametrizacion.VeteranoBLimiteInferior,
                _parametrizacion.VeteranoBLimiteSuperior,
                finAtencion.Random);
            finAtencion.ProximoEvento = reloj + finAtencion.Tiempo;

            return finAtencion;
        }

        private PeluqueriaObtencionTiempoDto CalcularFinAtencionAprendiz(double reloj)
        {
            var finAtencion = new PeluqueriaObtencionTiempoDto();

            finAtencion.Random = NumerosUtility.GetAleatorio();
            finAtencion.Tiempo = Uniform.GenerarAleatorio(
                _parametrizacion.AprendizLimiteInferior,
                _parametrizacion.AprendizLimiteSuperior,
                finAtencion.Random);
            finAtencion.ProximoEvento = reloj + finAtencion.Tiempo;

            return finAtencion;
        }

        /// <summary>
        /// Determina cual es el siguiente evento y adelanta el reloj a ese evento.
        /// </summary>
        /// <param name="iteracionAnterior"></param>
        /// <param name="iteracionActual"></param>
        private void DeterminarEventoASimular(ref PeluqueriaEventoDto iteracionActual)
        {
            if (iteracionActual.NumeroIteracion == 0)
            {
                iteracionActual.EventoNombre = "Inicializacion";
                return;
            }

            var diccionarioEventos = new Dictionary<string, double?>
            {
                {nameof(iteracionActual.LlegadaCliente), iteracionActual.LlegadaCliente.ProximoEvento },
                {nameof(iteracionActual.AprendizFinAtencion), iteracionActual.AprendizFinAtencion.ProximoEvento },
                {nameof(iteracionActual.VeteranoAFinAtencion), iteracionActual.VeteranoAFinAtencion.ProximoEvento },
                {nameof(iteracionActual.VeteranoBFinAtencion), iteracionActual.VeteranoBFinAtencion.ProximoEvento },
                {nameof(iteracionActual.Cierre), iteracionActual.Cierre },
                {nameof(iteracionActual.Apertura), iteracionActual.Apertura },
                {"Refrigerio", iteracionActual.Clientes.Where(x => !x.ConRefrigerio).Min(x => x.HoraRefrigerio)}
            };

            var nombreEvento = string.Empty;
            var menorTimeSpan = double.PositiveInfinity;
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
