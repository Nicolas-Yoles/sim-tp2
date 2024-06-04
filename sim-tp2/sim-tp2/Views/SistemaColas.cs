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


namespace sim_tp2.Views
{
    public partial class SistemaColas : Form
    {
        public PeluqueriaParametrizacionDto param = new PeluqueriaParametrizacionDto();
        public DataGridView Grilla = new DataGridView();
        public SistemaColas()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            simularPeluqueriaVIP();
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
            // TODO: Crear inputs para parametros de reglas y probabilidades (mostrar valores por defecto)
            // TODO: Crear propiedades del servicio con los valores tomados de interfaz grafica.
            var peluqueriaService = new PeluqueriaVipQueueSimulationService();

            var simulacion = peluqueriaService.SimularPeluqueria(dias, cantIteraciones, hora, this.param);
            creardgvPeluqueria(simulacion);
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
            dgvPeluqueria.Columns.Add("EventoNombre", "Evento Nombre");
            dgvPeluqueria.Columns.Add("Reloj", "Reloj");
            dgvPeluqueria.Columns.Add("LlegadaClienteRandom", "Llegada Cliente Random");
            dgvPeluqueria.Columns.Add("LlegadaClienteTiempo", "Llegada Cliente Tiempo");
            dgvPeluqueria.Columns.Add("LlegadaClienteProximoEvento", "Llegada Cliente Próximo Evento");
            dgvPeluqueria.Columns.Add("RandomPeluquero", "Random Peluquero");
            dgvPeluqueria.Columns.Add("Peluquero", "Peluquero");
            dgvPeluqueria.Columns.Add("AprendizFinAtencionRandom", "Aprendiz Fin Atención Random");
            dgvPeluqueria.Columns.Add("AprendizFinAtencionTiempo", "Aprendiz Fin Atención Tiempo");
            dgvPeluqueria.Columns.Add("AprendizFinAtencionProximoEvento", "Aprendiz Fin Atención Próximo Evento");
            dgvPeluqueria.Columns.Add("VeteranoAFinAtencionRandom", "Veterano A Fin Atención Random");
            dgvPeluqueria.Columns.Add("VeteranoAFinAtencionTiempo", "Veterano A Fin Atención Tiempo");
            dgvPeluqueria.Columns.Add("VeteranoAFinAtencionProximoEvento", "Veterano A Fin Atención Próximo Evento");
            dgvPeluqueria.Columns.Add("VeteranoBFinAtencionRandom", "Veterano B Fin Atención Random");
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
            dgvPeluqueria.Columns.Add("ClientesEnCola", "Clientes En Cola");
            dgvPeluqueria.Columns.Add("MaximoClientesEnCola", "Máximo Clientes En Cola");
            for(int i = 0; i < eventos.Max(x => x.MaximoClientesEnCola + 3); i++)
            {
                dgvPeluqueria.Columns.Add($"Estado", $"Estado{i + 1}");
                dgvPeluqueria.Columns.Add($"HoraRefrigerio", $"HoraRefrigerio{i + 1}");
                dgvPeluqueria.Columns.Add($"ConRefrigerio", $"ConRefrigerio{i + 1}");
            }

            foreach (PeluqueriaEventoDto evento in eventos)
            {
                var rowValues = new List<string>
                {
                    evento.EventoNombre ?? "-",
                    evento.Reloj.ToString() ?? "-",
                    evento.LlegadaCliente.Random?.ToString() ?? "-",
                    evento.LlegadaCliente.Tiempo?.ToString() ?? "-",
                    evento.LlegadaCliente.ProximoEvento.ToString() ?? "-",
                    evento.RandomPeluquero?.ToString() ?? "-",
                    evento.Peluquero ?? "-",
                    evento.AprendizFinAtencion.Random.ToString() ?? "-",
                    evento.AprendizFinAtencion.Tiempo.ToString() ?? "-",
                    evento.AprendizFinAtencion.ProximoEvento.ToString() ?? "-",
                    evento.VeteranoAFinAtencion.Random.ToString() ?? "-",
                    evento.VeteranoAFinAtencion.Tiempo.ToString() ?? "-",
                    evento.VeteranoAFinAtencion.ProximoEvento.ToString() ?? "-",
                    evento.VeteranoBFinAtencion.Random.ToString() ?? "-",
                    evento.VeteranoBFinAtencion.Tiempo.ToString() ?? "-",
                    evento.VeteranoBFinAtencion.ProximoEvento.ToString() ?? "-",
                    evento.Cierre.ToString() ?? "-",
                    evento.Apertura.ToString() ?? "-",
                    evento.Aprendiz.Estado.ToString(),
                    evento.Aprendiz.ColaClientes.Count().ToString() ?? "-",
                    evento.VeteranoA.Estado.ToString(),
                    evento.VeteranoA.ColaClientes.Count().ToString() ?? "-",
                    evento.VeteranoB.Estado.ToString(),
                    evento.VeteranoB.ColaClientes.Count().ToString() ?? "-",
                    evento.AcumuladorRecaudacionTotal.ToString() ?? "-",
                    evento.ContadorDiasTrabajados.ToString() ?? "-",
                    evento.ClientesEnCola.ToString() ?? "-",
                    evento.MaximoClientesEnCola.ToString() ?? "-"
                };

                foreach (ClienteDto cliente in evento.Clientes)
                {
                    rowValues.Add(cliente.Estado.ToString() ?? "-");
                    rowValues.Add(cliente.HoraRefrigerio.ToString() ?? "-");
                    rowValues.Add(cliente.ConRefrigerio.ToString() ?? "-");
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
    }
}
