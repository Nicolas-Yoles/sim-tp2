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
        //public Euler(List<EulerIntegrationIterationDto> _datosEuler)
        public Euler()
        {
            InitializeComponent();
            //crearDgvEuler(_datosEuler);
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
            dgvEuler.Columns.Add("Id", "Id de Euler");
            dgvEuler.Columns.Add("X", "X inicial");
            dgvEuler.Columns.Add("Y", "Y inicial");
            dgvEuler.Columns.Add("DyDx", "Derivada de Y");
            dgvEuler.Columns.Add("H_dyDx", "X próxima");
            dgvEuler.Columns.Add("YNext", "Y próxima");

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

                this.dgvEuler.Rows.Add(rowValues);
            }

        }

        private void consultarEulerButton_Click(object sender, EventArgs e)
        {
            //eulerDataGridView.Rows.Clear();
            //eulerDataGridView.Columns.Clear();
        }
    }
}
