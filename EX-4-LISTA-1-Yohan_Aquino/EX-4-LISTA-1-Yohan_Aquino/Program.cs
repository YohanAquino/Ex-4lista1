using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX_4_LISTA_1_Yohan_Aquino
{
    class Program
    {
        static void Main(string[] args)
        {
            /*4. A partir dos valores da base e altura de um triângulo, calcular e exibir sua área.*/
            Triangulo tri =new Triangulo();

            Console.WriteLine("Digite a base do triângulo: ");
            tri.setBase(double.Parse(Console.ReadLine()));

            Console.WriteLine("Digite a altura do triângulo: ");
            tri.setAltura(double.Parse(Console.ReadLine()));

            tri.calcularArea();
            Console.WriteLine("A área do triângulo é {0}",tri.getArea());
            Console.ReadKey();
        }
    }
}
