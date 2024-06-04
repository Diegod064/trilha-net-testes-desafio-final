using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraGeometrica.Models
{
    public class CalculadoraCirculo
    {
        public double CalcularArea(double raio)
        {
            return Math.PI * raio * raio;
        }

        public double CalcularPerimetro(double raio)
        {
            return 2 * Math.PI * raio;
        }

        public double CalcularDiametro(double raio)
        {
            return 2 * raio;
        }
    }
}