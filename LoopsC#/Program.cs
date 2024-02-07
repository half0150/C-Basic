namespace LoopsC_
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Kalder metoden til at udskrive multiplikationstabellen
            PrintMultiplicationTable();
            int[] array = { 10, 5, 7, 23, 15 };
            int maxNumber = FindBiggestNumber(array);
            Console.WriteLine("The biggest number in the array is: " + maxNumber);
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

        static int FindBiggestNumber(int[] numbers)
        {
            // Check if the array is empty
            if (numbers.Length == 0)
            {
                throw new ArgumentException("Array is empty");
            }

            // Initialize the variable to store the maximum number
            int maxNumber = numbers[0];

            // Loop through the array starting from the second element
            for (int i = 1; i < numbers.Length; i++)
            {
                // If the current element is greater than the maximum number found so far
                // update the maximum number
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            // Return the maximum number
            return maxNumber;
        }

        
    }
}
