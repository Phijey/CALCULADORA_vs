using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Metodos
    {

        public double Soma (double a, double b, double c, double d, double e)
        {
            return a + b + c + d + e;
        }

        public double Med(double a, double b, double c, double d, double e)
        {
            return (a + b + c + d + e) / 5;
        }

        public double Max(double a, double b, double c, double d, double e)
        {
            return Math.Max(a,Math.Max(b,Math.Max(c,Math.Max(d,e))));
        }

        public double Min(double a, double b, double c, double d, double e)
        {
            return Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e))));
        }

        public double Elev(double a, double b)
        {
            return Math.Pow(a,b);
        }
    }
}
