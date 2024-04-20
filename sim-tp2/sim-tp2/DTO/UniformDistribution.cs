using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;

namespace sim_tp2.DTO
{
    public  class UniformDistribution
    {
      

        public int cantidadMuestra { get; set; }
        public double Minimo { get; set; }
        public double Maximo { get; set; }
        public int cantidadIntervalos { get; set; }
        public ListBox Lista { get; set; }
        public Chart Grafico { get; set; }
        public DataGridView Grilla { get; set; }

        private List<double> Datos = new List<double>();

        private Random rnd = new Random();
    }
}
