namespace LoopsC_
{
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMultiplicationTable();
            int[] array1 = { 190, 291, 145, 209, 280, 200 };
            int[] array2 = { -9, -2, -7, -8, -4 };

            int[] array3 = { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 };
            int[] array4 = { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 };


            int[] array5 = { 45, 23, 44, 68, 65, 70, 80, 81, 82 };
            int[] array6 = { 7, 3, 5, 8, 9, 3, 1, 4 };


            int n = 30;
            List<int> primes = SieveOfEratosthenes(n);


            // WriteLine

            WriteLine("The biggest number in array1 is: " + TheBiggestNumber(array1));
            WriteLine("The biggest number in array2 is: " + TheBiggestNumber(array2));

            WriteLine("Antal gange to 7'ere er ved siden af hinanden i array3: " + Two7sNextToEachOther(array3));
            WriteLine("Antal gange to 7'ere er ved siden af hinanden i array4: " + Two7sNextToEachOther(array4));

            WriteLine("Are there three increasing adjacent numbers in array5? " + ThreeIncreasingAdjacent(array5));
            WriteLine("Are there three increasing adjacent numbers in array6? " + ThreeIncreasingAdjacent(array6));

            WriteLine("Prime numbers up to " + n + ": " + string.Join(", ", primes));
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

            
            int biggestNumber = numbers[0];

            // Looper gennem array
            for (int i = 1; i < numbers.Length; i++)
            {
                
                if (numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                }
            }

            // Retunere det største nummer
            return biggestNumber;
        }

        static int Two7sNextToEachOther(int[] digits)
        {
            // Bruger en tæller til at gemme antallet af gange to 7 taller er ved siden af hinanden
            int count = 0;

            // Løber gennem arrayet, starter fra det andet element
            for (int i = 1; i < digits.Length; i++)
            {
                // Tjekker om det aktuelle element og det forrige element er 7
                if (digits[i] == 7 && digits[i - 1] == 7)
                {
                    count++;
                }
            }

            // Returnerer antallet af gange to 7 taller er ved siden af hinanden
            return count;
        }



        static bool ThreeIncreasingAdjacent(int[] numbers)
        {
            
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                
                if (numbers[i] + 1 == numbers[i + 1] && numbers[i + 1] + 1 == numbers[i + 2])
                {
                    
                    return true;
                }
            }
            
            return false;
        }


        static List<int> SieveOfEratosthenes(int n)
        {
            
            bool[] prime = new bool[n + 1];
            for (int i = 0; i <= n; i++)
                prime[i] = true;

            
            for (int p = 2; p * p <= n; p++)
            {
                
                if (prime[p] == true)
                {
                    
                    for (int i = p * p; i <= n; i += p)
                        prime[i] = false;
                }
            }

            
            List<int> primes = new List<int>();
            for (int p = 2; p <= n; p++)
            {
                if (prime[p] == true)
                    primes.Add(p);
            }

            return primes;
        }
    }


}
