using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim_tp2.Utilities
{
    /// <summary>
    /// Realiza el método de integración de Euler según parámetros.
    /// </summary>
    public static class EulerIntegration
    {
        public static int _ultimoId = 0;

        /// <summary>
        /// Integra utilizando el método de Euler según los parámetros
        /// </summary>
        /// <param name="f">Funcion de integracion</param>
        /// <param name="expectedY">y esperado. Condición de corte de iteraciones</param>
        /// <param name="h">Paso parametrizable</param>
        /// <param name="c">Constante de la funcion</param>
        /// <returns></returns>
        public static EulerIntegrationResultDto Integrate(Func<double, double, int, double> f, double expectedY, double h, int c)
        {
            _ultimoId ++;

            EulerIntegrationResultDto result = new EulerIntegrationResultDto()
            {
                ExpectedY = expectedY,
                H = h,
                C = c,
                Id = _ultimoId
            };

            double x = 0;
            double y = 0;
            double y_next = 0;
            double dydx;
            double hdydx;
            var primeraVuelta = true;

            while (y < expectedY)
            {
                y = y_next;
                x += h;

                if (primeraVuelta)
                {
                    y = 0;
                    x = 0;
                    primeraVuelta = false;
                }

                dydx = f(x, y, c);
                hdydx = h * dydx;
                y_next = y + hdydx;

                var iterationResultDto = new EulerIntegrationIterationDto
                {
                    X = Math.Round(x, 4),
                    Y = Math.Round(y, 4),
                    DyDx = Math.Round(dydx, 4),
                    H_DyDx = Math.Round(hdydx, 4),
                    YNext = Math.Round(y_next, 4)
                };

                result.EulerIntegrationIterations.Add(iterationResultDto);
            }

            result.Xf = Math.Round(x, 4);
            return result;
        }
    }

    public class EulerIntegrationIterationDto
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double DyDx { get; set; }
        public double H_DyDx { get; set; }
        public double YNext { get; set; }
    }

    public class EulerIntegrationResultDto
    {
        #region Parametros
        public double ExpectedY { get; set; }
        public int C { get; set; }
        public double H { get; set; }
        #endregion

        #region Resultados
        public int Id { get; set; }
        public List<EulerIntegrationIterationDto> EulerIntegrationIterations { get; set; } = new List<EulerIntegrationIterationDto>();
        public double Xf { get; set; }
        #endregion
    }
}
