namespace Strings
{

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
            for (int i = a.Length -1; i >= 0; i--)
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
                } catch (IndexOutOfRangeException)
                {
                    done = true;
                }
            } while(!done);
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

    }
}
