using System;

namespace Aula11PolimosfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
             Calculo c = new Calculo();

            Console.WriteLine($"{  c.Calcular()  }\n{  c.Calcular(5, 5, '+')  }\n{  c.Calcular("")  }\n{  c.Calcular("(7/5)*2")  }");
        }
    }
}