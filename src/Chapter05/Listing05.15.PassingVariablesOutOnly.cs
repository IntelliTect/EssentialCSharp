namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_15
{
    using System;

    public class ConvertToPhoneNumber
    {
        public static int Main(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine(
                    "ConvertToPhoneNumber.exe <phrase>");
                Console.WriteLine(
                    "'_' indicates no standard phone button");
                return 1;
            }
            foreach(string word in args)
            {
                foreach(char character in word)
                {
#if !PRECSHARP7
                    if(TryGetPhoneButton(character, out char button))
#else
                    char button;
                    if(TryGetPhoneButton(character, out button))
#endif // PRECSHARP7
                    {
                        Console.Write(button);
                    }
                    else
                    {
                        Console.Write('_');
                    }
                }
            }
            Console.WriteLine();
            return 0;
        }

        static bool TryGetPhoneButton(char character, out char button)
        {
            bool success = true;
            switch(char.ToLower(character))
            {
                case '1':
                    button = '1';
                    break;
                case '2':
                    button = '2';
                    break;
                case '3':
                    button = '3';
                    break;
                case '4':
                    button = '4';
                    break;
                case '5':
                    button = '5';
                    break;
                case '6':
                    button = '6';
                    break;
                case '7':
                    button = '7';
                    break;
                case '8':
                    button = '8';
                    break;
                case '9':
                    button = '9';
                    break;
                case '0':
                    button = '0';
                    break;

                case 'a':
                case 'b':
                case 'c':
                    button = '2';
                    break;
                case 'd':
                case 'e':
                case 'f':
                    button = '3';
                    break;
                case 'g':
                case 'h':
                case 'i':
                    button = '4';
                    break;
                case 'j':
                case 'k':
                case 'l':
                    button = '5';
                    break;
                case 'm':
                case 'n':
                case 'o':
                    button = '6';
                    break;
                case 'p':
                case 'q':
                case 'r':
                case 's':
                    button = '7';
                    break;
                case 't':
                case 'u':
                case 'v':
                    button = '8';
                    break;
                case 'w':
                case 'x':
                case 'y':
                case 'z':
                    button = '9';
                    break;
                case '+':
                    button = '0';
                    break;
                case '-':
                    button = '-';
                    break;
                default:
                    // Set the button to indicate an invalid value
                    button = '_';
                    success = false;
                    break;
            }
            return success;
        }
    }
}
