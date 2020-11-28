using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4_LISTA_1_Yohan_Aquino
{
    class Triangulo
    {
        private double b;
        private double h;
        private double a;

        public void setBase(double x)
        {
            b = x;
        }
        public void setAltura(double x)
        {
            h = x;
        }
        public void calcularArea()
        {
            a = (b * h) / 2;
        }
        public double getArea()
        {
            return a;
        }
    }
}
