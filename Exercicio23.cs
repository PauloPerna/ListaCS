using System;

namespace Nivel2{
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
                    (number1, number2) = DoisDigitos();
                    Console.WriteLine($"A soma é {number1 + number2}");
                    break;

                case 2:
                    (number1, number2) = DoisDigitos();
                    Console.WriteLine($"A subtração é {number1 - number2}");
                    break;

                case 3:
                    (number1, number2) = DoisDigitos();
                    Console.WriteLine($"A multiplicação é {number1*number2}");
                    break;

                case 4:
                    (number1, number2) = DoisDigitos();
                    Console.WriteLine($"A divisão é {number1/number2}");
                    break;

                default:
                    Console.WriteLine("Saindo do programa");
                    break;
            };

            (decimal,decimal) DoisDigitos(){
                Console.WriteLine("Entre o dígito");
                decimal.TryParse(Console.ReadLine(),out decimal n1);
                Console.WriteLine("Entre outro dígito");
                decimal.TryParse(Console.ReadLine(),out decimal n2);
                return (n1,n2);
            }
        }


    }
}