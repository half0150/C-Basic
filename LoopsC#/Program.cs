namespace LoopsC_
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Kalder metoden til at udskrive multiplikationstabellen
            // Udskriver TheBiggestNumber array1 og 2
            PrintMultiplicationTable();
            int[] array1 = { 190, 291, 145, 209, 280, 200 };
            int[] array2 = { -9, -2, -7, -8, -4 };

            int[] array3 = { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 };
            int[] array4 = { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 };


            WriteLine("The biggest number in array1 is: " + TheBiggestNumber(array1));
            WriteLine("The biggest number in array2 is: " + TheBiggestNumber(array2));

            WriteLine("Antal gange to 7'ere er ved siden af hinanden i array3: " + Two7sNextToEachOther(array3));
            WriteLine("Antal gange to 7'ere er ved siden af hinanden i array4: " + Two7sNextToEachOther(array4));
        }

        static void PrintMultiplicationTable()
        {
            // Looper gennem tallene fra 1 til 10 for første række
            for (int i = 1; i <= 10; i++)
            {
                // Looper gennem tallene fra 1 til 10 for anden faktor
                for (int j = 1; j <= 10; j++)
                {
                    // Udskriver resultatet af multiplikationen mellem de to faktorer
                    Write($"{i * j} ");
                }
                // Efter hver række af multiplikationer, gå til næste linje
                WriteLine();
            }
        }

        static int TheBiggestNumber(int[] numbers)
        {
            // tjekker om array er tomt
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            // Initialize the variable to store the biggest number
            int biggestNumber = numbers[0];

            // Looper gennem array fra det andet element
            for (int i = 1; i < numbers.Length; i++)
            {
                // If the current element is greater than the biggest number found so far
                // update the biggest number
                if (numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                }
            }

            // Return the biggest number
            return biggestNumber;
        }

        static int Two7sNextToEachOther(int[] digits)
        {
            // Initialiserer en tæller til at gemme antallet af gange to 7'ere er ved siden af hinanden
            int count = 0;

            // Løber gennem arrayet, starter fra det andet element
            for (int i = 1; i < digits.Length; i++)
            {
                // Tjekker om det aktuelle element og det forrige element begge er 7
                if (digits[i] == 7 && digits[i - 1] == 7)
                {
                    count++;
                }
            }

            // Returnerer antallet af gange to 7'ere er ved siden af hinanden
            return count;
        }
    }


}

