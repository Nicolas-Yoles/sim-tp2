using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.Utilities
{
    public static class NumerosUtility
    {
        /// <summary>
        /// Trunca un número a 4 decimales
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static double Truncar4Decimales(double num)
            =>  Math.Truncate(num * 10000) / 10000;
    }
}
