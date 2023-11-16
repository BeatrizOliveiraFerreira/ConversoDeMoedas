using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            // desafio criptomoedas
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite 1 para para converter para criptomoedas ou  2 para anos Luz ? ");
            string opcao = Console.ReadLine();

            if ( opcao == "1" ) {
                double criptomoedas = 0.001;
                Console.WriteLine("Digite quanto você quer converter para Dolar: ");
                double valorEmDolar = double.Parse(Console.ReadLine());
                double valorEmReal = valorEmDolar * criptomoedas;
                Console.WriteLine("Olá " + nome + " o valor convertido em real é : " + "R$" + valorEmReal.ToString("F2", CultureInfo.InvariantCulture)); ; 
            }

            else {
                double anosLuz = 9.500000000000;
                Console.WriteLine("Digite quantos anos você converter para anos luz: ");
                double valorEmAnoNormal = double.Parse(Console.ReadLine());
                double valorNaTerra = valorEmAnoNormal * anosLuz;

                Console.WriteLine("Olá " + nome + " o ano em anos luz é: " + valorNaTerra);
            }

        }
    }
}
