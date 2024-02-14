namespace Strings
{
    using System.Linq;
    using System.Text;
    using static System.Console;
    using static System.Net.Mime.MediaTypeNames;

    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine(AddSeparator("ABCD", "^"));
            WriteLine(AddSeparator("chocolate", "-"));


            WriteLine(IsPalindrome("eye", ""));
            WriteLine(IsPalindrome("home", ""));

            WriteLine(LengthOfAString("computer"));
            WriteLine(LengthOfAString("ice cream"));


            WriteLine(StringInReverseOrder("qwerty"));
            WriteLine(StringInReverseOrder("oe93 kr"));

            WriteLine(NumberOfWords("This is sample sentence"));
            WriteLine(NumberOfWords("OK"));


            WriteLine(RevertWordsOrder("John Doe."));
            WriteLine(RevertWordsOrder("A. B. C."));


            WriteLine(HowManyOccurrences("do it now", "do"));
            WriteLine(HowManyOccurrences("", "d"));

            WriteLine(SortCharactersDescending("onomatopoeia"));
            WriteLine(SortCharactersDescending("fohjwf42os"));

            WriteLine(CompressString("kkkktttrrrrrrrrrr"));
            WriteLine(CompressString("p555ppp7www"));
        }

        static string AddSeparator(string input, string separator)
        {
            
            System.Text.StringBuilder resultBuilder = new System.Text.StringBuilder();

            
            for (int i = 0; i < input.Length; i++)
            {
                
                resultBuilder.Append(input[i]);

                
                if (i != input.Length - 1)
                {
                    resultBuilder.Append(separator);
                }
            }

            
            return resultBuilder.ToString();
        }

        static bool IsPalindrome(string a, string reverse)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                reverse += a[i];
            }
            
            if (a == reverse)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int LengthOfAString(string str)
        {
            int length = 0;
            bool done = false;
            do
            {
                try
                {
                    char c = str[length];
                    length++;
                {
                    done = true;
                }
            return length;
        }

        static string StringInReverseOrder(string input)
        {
            char[] cArray = input.ToCharArray();
            string reverse = string.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

        static int NumberOfWords(string input)
        {
            int count = 0;
            bool wasInWord = false;
            bool inWord = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (inWord)
                {
                    wasInWord = true;
                }

                if (Char.IsWhiteSpace(input[i]))
                {
                    if (wasInWord)
                    {
                        count++;
                        wasInWord = false;
                    }
                    inWord = false;
                }
                else
                {
                    inWord = true;
                }
            }

            
            if (wasInWord)
            {
                count++;
            }

            return count;
        }

        static string RevertWordsOrder(string input)
        {
        }

        
        static int HowManyOccurrences(string input, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = input.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }
            return count;
        }

        static string SortCharactersDescending(string input)
        {
            char[] chars = input.ToCharArray();

            Array.Sort(chars);
            Array.Reverse(chars);

            string sortedString = new string(chars);

            return sortedString;
        }

        static string CompressString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder CompressedString = new StringBuilder();

            char currentChar = input[0];
            int charCount = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    charCount++;
                }
                else
                {
                    CompressedString.Append(currentChar);
                    CompressedString.Append(charCount);

                    currentChar = input[i];
                    charCount = 1;
                }
            }

            CompressedString.Append(currentChar);
            CompressedString.Append(charCount);

            return CompressedString.ToString();
        }

    }
}
