using System;
using static System.Console;

namespace C_Basic
{
    public class Conditional_Statements
    {
        static void Main(string[] args)
        {
            WriteLine(AbsoluteValue(6832));
            WriteLine(AbsoluteValue(-392));
           
            
            WriteLine(DivisibleBy2Or3(15, 30)); // Output: 450
            WriteLine(DivisibleBy2Or3(2, 90));  // Output: 180
            WriteLine(DivisibleBy2Or3(7, 12));  // Output: 19
            
            
            WriteLine(IfConsistsOfUppercaseLetters("xyz")); // Output: False
            WriteLine(IfConsistsOfUppercaseLetters("DOG")); // Output: True
            WriteLine(IfConsistsOfUppercaseLetters("L9#")); // Output: False

            WriteLine(IfGreaterThanThirdOne(new int[] { 2, 7, 12 })); // Output: True
            WriteLine(IfGreaterThanThirdOne(new int[] { -5, -8, 50 })); // Output: False

            WriteLine(IfNumberIsEven(721)); // Output: False
            WriteLine(IfNumberIsEven(1248)); // Output: True

            WriteLine(IfSortedAscending(new int[] { 3, 7, 10 })); // Output: True
            WriteLine(IfSortedAscending(new int[] { 74, 62, 99 })); // Output: False

            WriteLine(PositiveNegativeOrZero(5.24)); // Output: Positive
            WriteLine(PositiveNegativeOrZero(0.0)); // Output: Zero
            WriteLine(PositiveNegativeOrZero(-994.53)); // Output: Negative

            WriteLine(IfYearIsLeap(2016)); // Output: True
            WriteLine(IfYearIsLeap(2018)); // Output: False
        }

        // Bruger inbygget Math funktion og returnere derefter nummeret
        static int AbsoluteValue(int number)
        {
            number = Math.Abs(number);
            return number;
        }


        static int DivisibleBy2Or3(int a, int b)
        {
            // Tjek om enten 'a' eller 'b' er delelig med 2 eller 3
            bool divisibleBy2Or3 = (a % 2 == 0 || a % 3 == 0) && (b % 2 == 0 || b % 3 == 0);
            // Hvis enten 'a' eller 'b' er delelig med 2 eller 3
            if (divisibleBy2Or3)
            {
                // Returner produktet af 'a' og 'b'
                return a * b;
            }
            // Hvis hverken 'a' eller 'b' er delelig med 2 eller 3
            else
            {
                // Returner summen af 'a' og 'b'
                return a + b;
            }
        }

        // Her bruger jeg en boolean til at tjekke om der er en uppercase bogstav. 
        static bool IfConsistsOfUppercaseLetters(string input)
        {

            // Og hvis der er en uppercase bogstav, så retunere den false
            foreach (char c in input)
            {
                if (!char.IsUpper(c))
                    return false;
            }
            // Og her retunere vi bare true, hvis der ikke er nogle uppercase bogstaver
            return true;
        }

        static bool IfGreaterThanThirdOne(int[] numbers)
        {
            int sum = numbers[0] + numbers[1];
            return sum > numbers[2] || (numbers[0] * numbers[1]) > numbers[2];
        }

        static bool IfNumberIsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IfSortedAscending(int[] numbers)
        {
            return numbers[0] < numbers[1] && numbers[1] < numbers[2];
        }

        static string PositiveNegativeOrZero(double number)
        {
            if (number > 0)
                return "positive";
            else if (number < 0)
                return "negative";
            else
                return "zero";
        }

        static bool IfYearIsLeap(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }


    }
}
