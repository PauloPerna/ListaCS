using System;

namespace NIvel2{
    public class Exercicio23{
        static void Main(string[] args){
            Console.WriteLine("Selecione a operação que deseja realizar:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("QUalquer outro para finalizar.");

            int.TryParse(Console.ReadLine(),out int opcao);

            decimal number1, number2;
            switch(opcao){
                case 1: 
                    Console.WriteLine("Entre o dígito");
                    decimal.TryParse(Console.ReadLine(),out number1);
                    Console.WriteLine("Entre outro dígito");
                    decimal.TryParse(Console.ReadLine(),out number2);
                    Console.WriteLine($"A soma é {number1 + number2}");
                    break;

                case 2:
                    Console.WriteLine("Entre o dígito");
                    decimal.TryParse(Console.ReadLine(),out number1);
                    Console.WriteLine("Entre outro dígito");
                    decimal.TryParse(Console.ReadLine(),out number2);
                    Console.WriteLine($"A subtração é {number1 - number2}");
                    break;

                case 3:
                    Console.WriteLine("Entre o dígito");
                    decimal.TryParse(Console.ReadLine(),out number1);
                    Console.WriteLine("Entre outro dígito");
                    decimal.TryParse(Console.ReadLine(),out number2);
                    Console.WriteLine($"A multiplicação é {number1*number2}");
                    break;

                case 4:
                    Console.WriteLine("Entre o dígito");
                    decimal.TryParse(Console.ReadLine(),out number1);
                    Console.WriteLine("Entre outro dígito");
                    decimal.TryParse(Console.ReadLine(),out number2);
                    Console.WriteLine($"A divisão é {number1/number2}");
                    break;

                default:
                    Console.WriteLine("Saindo do programa");
                    break;
            };
        }
    }
}