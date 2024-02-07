using System;
using static System.Console;

namespace C_Basic
{
    public class basic_
    {
        static void Main(string[] args)
        {
            WriteLine(AddAndMultiply(2, 4, 5)); // Udskriver resultatet af AddAndMultiply metoden

            WriteLine(CtoF(0));    // Udskriver konvertering fra Celsius til Fahrenheit for 0 grader Celsius
            WriteLine(CtoF(100));  // Udskriver konvertering fra Celsius til Fahrenheit for 100 grader Celsius  
            WriteLine(CtoF(-300)); // Udskriver fejlmeddelelse for temperatur
            WriteLine(ElementaryOperations(3, 8)); // tal til opgave Elementary operations
            WriteLine(IsResultTheSame(2 + 2, 2 * 2)); // true
            WriteLine(IsResultTheSame(9 / 3, 16 - 1)); // false
            WriteLine(ModuloOperations(8, 5, 2));
            WriteLine(TheCubeOf(2));
            WriteLine(TheCubeOf(-5.5));
            SwapTwoNumbers(87, 45);
            SwapTwoNumbers(-13, 2);

        }

        public static int AddAndMultiply(int a, int b, int c)
        {
            return (a + b) * c; // Returnerer resultatet af at lægge a og b sammen og derefter gange med c
        }

        static string CtoF(double celsius)
        {
            if (celsius < -273.15)
            {
                return "Temperatur under absolut nulpunkt!"; // Returnerer fejlmeddelelse for temperatur
            }

            double fahrenheit = celsius * 9 / 5 + 32; // Konverterer Celsius til Fahrenheit
            return $"T = {fahrenheit}F"; // Returnerer resultatet som en string
        }



        // Elementary operations

        static string ElementaryOperations(double a, double b)
        {
            if (b == 0)
            {
                return "Du kan ikke dividere med 0";
            }

            return $"plus: {a + b} minus: {a - b} gange: {a * b} dividere: {a / b}";
        }

        // Is Result the same

        static bool IsResultTheSame(int a, int b)
        {
            return a == b; //Tjekker om det giver det samme
        }

        // Modulo operations

        static int ModuloOperations(int a, int b, int c)
        {
            return a % b % c;
        }


        //The cube of

        static double TheCubeOf(double a)
        {
            return a * a * a;
            
        }

        static void SwapTwoNumbers(int a, int b)
        {
            WriteLine($"Before: a = {a}, b = {b};");

            
            int temp = a;
            a = b;
            b = temp;

            WriteLine($"After: a = {a}, b = {b}");
        }

    }
}
