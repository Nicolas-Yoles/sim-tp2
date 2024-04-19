using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTO
{
    public  class UniformDistribution
    {
        public int cantidadMuestra { get; set; }
        public double Minimo { get; set; }
        public double Maximo { get; set; }
        public int cantidadIntervalos {  get; set; }
    }
}
