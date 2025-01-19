using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    class   Kalkulator
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            string operation;
            Console.WriteLine("Kalkulator w C#");
            Console.WriteLine("Wybierz operację ( +, -, *, / )");
            Console.Write("Wpisz pierwszą liczbę: ");
            num1 = Convert.ToDouble(Console.ReadLine());      
            Console.Write("Wpisz drugą liczbę: ");
            num2 = Convert.ToDouble(Console.ReadLine());         
            Console.Write("Wybierz operację (+, -, *, /): ");
            operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Wynik dodawania: {num1} + {num2} = {result}");
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Wynik odejmowania: {num1} - {num2} = {result}");
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Wynik mnożenia: {num1} * {num2} = {result}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"Wynik dzielenia: {num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Błąd: Nie można dzielić przez zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Błąd: Niewłaściwa operacja!");
                    break;
            }
            Console.WriteLine("Naciśnij enter, aby wyjść z konsoli");
            Console.ReadKey();
        }
    }
}
    