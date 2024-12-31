using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTriangulo
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;    

        public Triangulo(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C; 
        }

        public double Area(double A, double B, double C)
        {   
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (p - A) * (p - B));
            return raiz;

        }
    }
}
