 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sim_tp2.DTOs;
using sim_tp2.DTOs.Peluqueria;
using sim_tp2.Services;
using sim_tp2.Utilities;


namespace sim_tp2.Views
{
    public partial class SistemaColas : Form
    {
        public PeluqueriaParametrizacionDto param = new PeluqueriaParametrizacionDto();
        
        public List<EulerIntegrationIterationDto> _datosEuler = new List<EulerIntegrationIterationDto>();
        private bool EsConEuler = false;
        public SistemaColas(bool esConEuler)
        {
            InitializeComponent();
            this.EsConEuler = esConEuler;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            EulerIntegration._ultimoId = 0;
            simularPeluqueriaVIP();
            if (EsConEuler && dgvPeluqueria.Rows.Count > 0)
            {
                this.eulerButton.Visible = true;
                this.eulerButton.Enabled = true;
            }
        }

        private void simularPeluqueriaVIP()
        {
            dgvPeluqueria.Rows.Clear();
            dgvPeluqueria.Columns.Clear();
            var dias = Convert.ToInt32(inputDias.Value);
            var cantIteraciones = Convert.ToInt32(inputIteraciones.Value);
            var hora = Convert.ToInt32(inputHora.Value);


            if (cantIteraciones == 0)
            {
                MessageBox.Show("Error: La cantidad de iteraciones debe ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (dias == 0)
            {
                MessageBox.Show("Error: Los días deben ser mayor a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EsConEuler)
            {
                var peluqueriaService = new PeluqueriaVipContinuousQueueSimulationService();
                var simulacion = peluqueriaService.SimularPeluqueria(dias, cantIteraciones, hora, this.param);
                creardgvPeluqueria(simulacion);
            }
            
            else
            {
                var peluqueriaService = new PeluqueriaVipQueueSimulationService();
                var simulacion = peluqueriaService.SimularPeluqueria(dias, cantIteraciones, hora, this.param);
                creardgvPeluqueria(simulacion);
            }

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblTiempo_Click(object sender, EventArgs e)
        {

        }

        private void SistemaColas_Load(object sender, EventArgs e)
        {

        }
        private void creardgvPeluqueria(List<PeluqueriaEventoDto> eventos)
        {
            var posicionesClientes = new Dictionary<int, int>();

            dgvPeluqueria.Columns.Add("EventoNombre", "Evento Nombre");
            dgvPeluqueria.Columns.Add("Reloj", "Reloj");
            dgvPeluqueria.Columns.Add("LlegadaClienteRandom", "Llegada Cliente Random");
            dgvPeluqueria.Columns.Add("LlegadaClienteTiempo", "Llegada Cliente Tiempo");
            dgvPeluqueria.Columns.Add("LlegadaClienteProximoEvento", "Llegada Cliente Próximo Evento");
            dgvPeluqueria.Columns.Add("RandomPeluquero", "Random Peluquero");
            dgvPeluqueria.Columns.Add("Peluquero", "Peluquero");
            if (EsConEuler){ dgvPeluqueria.Columns.Add("IdDeEulerAprendiz", "Id de Tabla Euler Aprendiz"); }
            else { dgvPeluqueria.Columns.Add("AprendizFinAtencionRandom", "Aprendiz Fin Atención Random"); }
            dgvPeluqueria.Columns.Add("AprendizFinAtencionTiempo", "Aprendiz Fin Atención Tiempo");
            dgvPeluqueria.Columns.Add("AprendizFinAtencionProximoEvento", "Aprendiz Fin Atención Próximo Evento");
            if (EsConEuler) { dgvPeluqueria.Columns.Add("IdDeEulerVeteranoA", "Id de Tabla Euler Veterano A"); }
            else { dgvPeluqueria.Columns.Add("VeteranoAFinAtencionRandom", "Veterano A Fin Atención Random"); }
            dgvPeluqueria.Columns.Add("VeteranoAFinAtencionTiempo", "Veterano A Fin Atención Tiempo");
            dgvPeluqueria.Columns.Add("VeteranoAFinAtencionProximoEvento", "Veterano A Fin Atención Próximo Evento");
            if (EsConEuler) { dgvPeluqueria.Columns.Add("IdDeEulerVeteranoB", "Id de Tabla Euler Veterano B"); }
            else { dgvPeluqueria.Columns.Add("VeteranoBFinAtencionRandom", "Veterano B Fin Atención Random"); }
            dgvPeluqueria.Columns.Add("VeteranoBFinAtencionTiempo", "Veterano B Fin Atención Tiempo");
            dgvPeluqueria.Columns.Add("VeteranoBFinAtencionProximoEvento", "Veterano B Fin Atención Próximo Evento");
            dgvPeluqueria.Columns.Add("Cierre", "Cierre");
            dgvPeluqueria.Columns.Add("Apertura", "Apertura");
            dgvPeluqueria.Columns.Add("AprendizEstado", "Aprendiz Estado");
            dgvPeluqueria.Columns.Add("AprendizColaClientes", "Aprendiz Cola Clientes");
            dgvPeluqueria.Columns.Add("VeteranoAEstado", "Veterano A Estado");
            dgvPeluqueria.Columns.Add("VeteranoAColaClientes", "Veterano A Cola Clientes");
            dgvPeluqueria.Columns.Add("VeteranoBEstado", "Veterano B Estado");
            dgvPeluqueria.Columns.Add("VeteranoBColaClientes", "Veterano B Cola Clientes");
            dgvPeluqueria.Columns.Add("AcumuladorRecaudacionTotal", "Acumulador Recaudación Total");
            dgvPeluqueria.Columns.Add("ContadorDiasTrabajados", "Contador Días Trabajados");
            dgvPeluqueria.Columns.Add("PromedioRecuadacionPorDia", "Promedio Recuadacion Por Dia");
            dgvPeluqueria.Columns.Add("ClientesEnCola", "Clientes En Cola");
            dgvPeluqueria.Columns.Add("MaximoClientesEnCola", "Máximo Clientes En Cola");
           
            for (int i = 0; i < eventos.Max(x => x.MaximoClientesEnCola + 5); i++)
            {
                dgvPeluqueria.Columns.Add($"ClienteId", $"ClienteId{i + 1}");
                dgvPeluqueria.Columns.Add($"Estado", $"Estado{i + 1}");
                dgvPeluqueria.Columns.Add($"HoraRefrigerio", $"HoraRefrigerio{i + 1}");
                dgvPeluqueria.Columns.Add($"ConRefrigerio", $"ConRefrigerio{i + 1}");
            }

            foreach (PeluqueriaEventoDto evento in eventos)
            {
                var clientesIds = evento.Clientes.Select(x => x.Id).ToList();
                posicionesClientes = posicionesClientes.Where(x => clientesIds.Contains(x.Key)).ToDictionary(x => x.Key, x => x.Value);

                var rowValues = new List<string>();
                if (EsConEuler)
                {
                    var valores = new List<string>
                    {
                        evento.EventoNombre ?? string.Empty,
                        evento.Reloj.ToString() ?? string.Empty,
                        evento.LlegadaCliente.Random?.ToString() ?? string.Empty,
                        evento.LlegadaCliente.Tiempo?.ToString() ?? string.Empty,
                        evento.LlegadaCliente.ProximoEvento.ToString() ?? string.Empty,
                        evento.RandomPeluquero?.ToString() ?? string.Empty,
                        evento.Peluquero ?? string.Empty,
                        evento.AprendizFinAtencion.EulerIntegrationId.ToString() ?? string.Empty,
                        evento.AprendizFinAtencion.Tiempo.ToString() ?? string.Empty,
                        evento.AprendizFinAtencion.ProximoEvento.ToString() ?? string.Empty,
                        evento.VeteranoAFinAtencion.EulerIntegrationId.ToString() ?? string.Empty,
                        evento.VeteranoAFinAtencion.Tiempo.ToString() ?? string.Empty,
                        evento.VeteranoAFinAtencion.ProximoEvento.ToString() ?? string.Empty,
                        evento.VeteranoBFinAtencion.EulerIntegrationId.ToString() ?? string.Empty,
                        evento.VeteranoBFinAtencion.Tiempo.ToString() ?? string.Empty,
                        evento.VeteranoBFinAtencion.ProximoEvento.ToString() ?? string.Empty,
                        evento.Cierre.ToString() ?? string.Empty,
                        evento.Apertura.ToString() ?? string.Empty,
                        evento.Aprendiz.Estado.ToString(),
                        evento.Aprendiz.ColaClientes.Count().ToString() ?? string.Empty,
                        evento.VeteranoA.Estado.ToString(),
                        evento.VeteranoA.ColaClientes.Count().ToString() ?? string.Empty,
                        evento.VeteranoB.Estado.ToString(),
                        evento.VeteranoB.ColaClientes.Count().ToString() ?? string.Empty,
                        evento.AcumuladorRecaudacionTotal.ToString() ?? string.Empty,
                        evento.ContadorDiasTrabajados.ToString() ?? string.Empty,
                        evento.PromedioRecuadacionPorDia.ToString() ?? string.Empty,
                        evento.ClientesEnCola.ToString() ?? string.Empty,
                        evento.MaximoClientesEnCola.ToString() ?? string.Empty
                    };
                    rowValues = valores;
                }
                else
                {
                    var valores = new List<string>
                    {
                        evento.EventoNombre ?? string.Empty,
                        evento.Reloj.ToString() ?? string.Empty,
                        evento.LlegadaCliente.Random?.ToString() ?? string.Empty,
                        evento.LlegadaCliente.Tiempo?.ToString() ?? string.Empty,
                        evento.LlegadaCliente.ProximoEvento.ToString() ?? string.Empty,
                        evento.RandomPeluquero?.ToString() ?? string.Empty,
                        evento.Peluquero ?? string.Empty,
                        evento.AprendizFinAtencion.Random.ToString() ?? string.Empty,
                        evento.AprendizFinAtencion.Tiempo.ToString() ?? string.Empty,
                        evento.AprendizFinAtencion.ProximoEvento.ToString() ?? string.Empty,
                        evento.VeteranoAFinAtencion.Random.ToString() ?? string.Empty,
                        evento.VeteranoAFinAtencion.Tiempo.ToString() ?? string.Empty,
                        evento.VeteranoAFinAtencion.ProximoEvento.ToString() ?? string.Empty,
                        evento.VeteranoBFinAtencion.Random.ToString() ?? string.Empty,
                        evento.VeteranoBFinAtencion.Tiempo.ToString() ?? string.Empty,
                        evento.VeteranoBFinAtencion.ProximoEvento.ToString() ?? string.Empty,
                        evento.Cierre.ToString() ?? string.Empty,
                        evento.Apertura.ToString() ?? string.Empty,
                        evento.Aprendiz.Estado.ToString(),
                        evento.Aprendiz.ColaClientes.Count().ToString() ?? string.Empty,
                        evento.VeteranoA.Estado.ToString(),
                        evento.VeteranoA.ColaClientes.Count().ToString() ?? string.Empty,
                        evento.VeteranoB.Estado.ToString(),
                        evento.VeteranoB.ColaClientes.Count().ToString() ?? string.Empty,
                        evento.AcumuladorRecaudacionTotal.ToString() ?? string.Empty,
                        evento.ContadorDiasTrabajados.ToString() ?? string.Empty,
                        evento.PromedioRecuadacionPorDia.ToString() ?? string.Empty,
                        evento.ClientesEnCola.ToString() ?? string.Empty,
                        evento.MaximoClientesEnCola.ToString() ?? string.Empty
                    };
                    rowValues = valores;
                }

                var valuesEstaticos = rowValues.Count;

                foreach (ClienteDto cliente in evento.Clientes)
                {
                    if (!posicionesClientes.ContainsKey(cliente.Id))
                    {
                        if (!posicionesClientes.ContainsValue(valuesEstaticos))
                        {
                            posicionesClientes.Add(cliente.Id, valuesEstaticos);
                        }
                        else
                        {
                            while (posicionesClientes.ContainsValue(valuesEstaticos))
                            {
                                valuesEstaticos += 4;
                            }
                            posicionesClientes.Add(cliente.Id, valuesEstaticos);
                        }
                    }

                    while (rowValues.Count < posicionesClientes[cliente.Id] + 4)
                    {
                        rowValues.Add(string.Empty);
                    }

                    rowValues.RemoveRange(posicionesClientes[cliente.Id], 4);
                    rowValues.Insert(posicionesClientes[cliente.Id], cliente.Id.ToString() ?? string.Empty);
                    rowValues.Insert(posicionesClientes[cliente.Id] + 1, cliente.Estado.ToString() ?? string.Empty);
                    rowValues.Insert(posicionesClientes[cliente.Id] + 2, cliente.HoraRefrigerio.ToString() ?? string.Empty);
                    rowValues.Insert(posicionesClientes[cliente.Id] + 3, cliente.ConRefrigerio.ToString() ?? string.Empty);
                }

                this.dgvPeluqueria.Rows.Add(rowValues.ToArray());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SistemaColasDistribucion form2 = new SistemaColasDistribucion();
            form2.FormularioPadre = this;
            form2.Show();
        }
        public void RecibirProbabilidades(PeluqueriaParametrizacionDto param)
        {
            this.param = param;
        }

        private void eulerButton_Click(object sender, EventArgs e)
        {
            //Euler eulerForm = new Euler(_datosEuler);
            Euler eulerForm = new Euler();
            eulerForm.Show();
        }

        private void dgvPeluqueria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cerrarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
