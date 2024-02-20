//Arbejdet sammen med Anton
using System;

namespace ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rotatedArray = ArrayRotation(new int[] { 3, 8, 9, 7, 6 }, 1);
            Console.WriteLine(string.Join(", ", rotatedArray)); // For at udskrive det roterede array
        }

        static int[] ArrayRotation(int[] A, int K)
        {
            int N = A.Length;
            int[] rotatedArray = new int[N];

            for (int i = 0; i < N; i++)
            {
                int newIndex = (i + K) % N; // Beregning af det nye indeks efter rotation
                rotatedArray[newIndex] = A[i]; // Indsætter værdien på det nye indeks
            }

            return rotatedArray;
        }
    }
}
