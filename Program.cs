using System;

namespace VSProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite (c) para Celsius ou (f) para Fahrenheit:");
            string opcaoString = Console.ReadLine();

            if (opcaoString == "c")
            {
                ConvertToFahrenheit();
            }
            else if (opcaoString == "f")
            {
                ConvertToCelsius();
            }
        }


        static void ConvertToFahrenheit()
        {
            Console.WriteLine("Digite a temperatura em Graus Celsius:");
            string celsiusString = Console.ReadLine();
            double celsiusDouble = Convert.ToDouble(celsiusString);

            double operacaoC = (celsiusDouble * 9 / 5) + 32;
            string mensagem = string.Format("{0}°C equivale {1}°F", celsiusDouble, operacaoC);
            Console.WriteLine(mensagem);
        }


        static void ConvertToCelsius()
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit:");
            string fahrenheitString = Console.ReadLine();
            double fahrenheitDouble = Convert.ToDouble(fahrenheitString);

            double operacaoF = (fahrenheitDouble - 32) * 5 / 9;
            string mensagem = string.Format("{0}°F equivale {1}°C", fahrenheitDouble, operacaoF);
            Console.WriteLine(mensagem);
        }


    }
}
