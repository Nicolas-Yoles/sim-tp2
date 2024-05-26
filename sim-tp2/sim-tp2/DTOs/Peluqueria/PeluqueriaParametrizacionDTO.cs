using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.DTOs.Peluqueria
{
    public class PeluqueriaParametrizacionDto
    {
        /// <summary>
        /// Indica el límite inferior de la distribución uniforme de la demora
        /// en el corte del aprendiz.
        /// </summary>
        public int AprendizLimiteInferior { get; set; }

        /// <summary>
        /// Indica el límite superior de la distribución uniforme de la demora
        /// en el corte del aprendiz.
        /// </summary>
        public int AprendizLimiteSuperior { get; set; }

        /// <summary>
        /// Indica el límite inferior de la distribución uniforme de la demora
        /// en el corte del Veterano A.
        /// </summary>
        public int VeteranoALimiteInferior { get; set; }

        /// <summary>
        /// Indica el límite superior de la distribución uniforme de la demora
        /// en el corte del Veterano A.
        /// </summary>
        public int VeteranoALimiteSuperior { get; set; }

        /// <summary>
        /// Indica el límite inferior de la distribución uniforme de la demora
        /// en el corte del Veterano B.
        /// </summary>
        public int VeteranoBLimiteInferior { get; set; }

        /// <summary>
        /// Indica el límite superior de la distribución uniforme de la demora
        /// en el corte del Veterano B.
        /// </summary>
        public int VeteranoBLimiteSuperior { get; set; }

        /// <summary>
        /// Indica el límite superior de la distribución uniforme del tiempo
        /// de llegada de clientes.
        /// </summary>
        public int LlegadaClienteLimiteInferior { get; set; }

        /// <summary>
        /// Indica el límite superior de la distribución uniforme ddel tiempo
        /// de llegada de clientes.
        /// </summary>
        public int LlegadaClienteLimiteSuperior{ get; set; }

        /// <summary>
        /// Indica la probabilidad de que un cliente sea atendido por el aprendiz.
        /// </summary>
        public double AprendizProbabilidadAtender { get; set; }

        /// <summary>
        /// Indica la probabilidad de que un cliente sea atendido por el Veterano A.
        /// </summary>
        public double VeteranoAProbabilidadAtender{ get; set; }
    }
}
