using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1POOMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write( "Digite a base do retângulo:");

            Double baseInput = Double.Parse(Console.ReadLine());



            Console.Write( "Digite a altura do retângulo:");

            Double alturaInput = Double.Parse(Console.ReadLine());



            Retangulo retangulo = new Retangulo(baseInput, alturaInput);

            Double area = retangulo.CalcularArea();



            Console.WriteLine("A área do retângulo é: {0}", area);
        }
    }
}
