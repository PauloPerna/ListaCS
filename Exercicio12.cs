using System;

namespace Nivel2{
    public class Exercicio12{
        static void Main(string[] args){
            Console.WriteLine("Digite o valor de x:");
            decimal.TryParse(Console.ReadLine(), out decimal x);
            x = x > 0? x : -x;
            Console.WriteLine($"O módulo de x é {x}");
        }
    }
}