using System;

namespace L2_7_Zad_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w prostym kalkulatorze. Podaj dwie liczby i wybierz działanie.");
            Console.Write("Podaj pierwszą liczbę: ");
            double.TryParse(Console.ReadLine(), out double firstNumber);

            Console.Write("Podaj drugą liczbę: ");
            double.TryParse(Console.ReadLine(), out double secondNumber);

            Console.WriteLine("Menu: \r\n 1. Dodawanie \r\n 2. Odejmowanie \r\n 3. Mnożenie \r\n 4. Dzielenie");
            Console.Write("Podaj numer operacji do wykonania: ");
            byte.TryParse(Console.ReadLine(), out byte operation);

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Wynik dodawania to: {firstNumber + secondNumber}");
                    break;
                case 2:
                    Console.WriteLine($"Wynik odejmowania to: {firstNumber - secondNumber}");
                    break;
                case 3:
                    Console.WriteLine($"Wynik mnożenia to: {firstNumber * secondNumber}");
                    break;
                case 4:
                    if (secondNumber == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez zero!");
                    }
                    else
                    {
                        Console.WriteLine($"Wynik dzielenia to: {firstNumber / secondNumber}");
                    }
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy numer operacji.");
                    break;
            }
        }
    }
}
