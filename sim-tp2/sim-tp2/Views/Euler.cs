using sim_tp2.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sim_tp2.Views
{
    public partial class Euler : Form
    {
        public List<EulerIntegrationResultDto> EulersResults { get; set; }


        public Euler(List<EulerIntegrationResultDto> eulersResults)
        {
            InitializeComponent();
            EulersResults = eulersResults;
        }

        private void Euler_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void crearDgvEuler(List<EulerIntegrationIterationDto> listadoEuler)
        {
            dgvEuler.Columns.Add("X", "X");
            dgvEuler.Columns.Add("Yi", "Yi");
            dgvEuler.Columns.Add("Yi'", "Yi'");
            dgvEuler.Columns.Add("h * Yi''", "h * Yi'");
            dgvEuler.Columns.Add("Yi+1", "Yi+1");

            foreach(EulerIntegrationIterationDto euler in listadoEuler)
            {
                var rowValues = new List<string>()
                {
                    euler.X.ToString(),
                    euler.Y.ToString(),
                    euler.DyDx.ToString(),
                    euler.H_DyDx.ToString(),
                    euler.YNext.ToString()
                };

                this.dgvEuler.Rows.Add(rowValues.ToArray());
            }

        }

        private void consultarEulerButton_Click(object sender, EventArgs e)
        {
            dgvEuler.Rows.Clear();
            dgvEuler.Columns.Clear();

            var idEuler = int.Parse(nroEulerInput.Text);
            var euler = EulersResults.FirstOrDefault(x => x.Id == idEuler)?.EulerIntegrationIterations;

            if (euler is null) return;

            crearDgvEuler(euler);
        }
    }
}
