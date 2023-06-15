using System.Text.RegularExpressions;

namespace UseCase10
{
    internal class Program
    {
        // As regex should have at least one uppercase letter, one lowercase letter, one digit, and one special character
        // the minimum acceptable max length should be > 4
        private const int minimumStringLenght = 4;

        static void Main()
        {
            var userInput = HandleInput();

            Console.WriteLine(Match(userInput.length, userInput.data));
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        public static bool Match(long length, string data)
        {
            var pattern = $"^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!\"#$%&'()*+,-./:;<=>?@[\\\\\\]^_`{{|}}~])[\\S]{{{minimumStringLenght},{length}}}$";
            return Regex.IsMatch(data, pattern);
        }

        private static (long length, string data) HandleInput()
        {
            long length = 0;
            var parsed = false;
            do
            {
                Console.Write("Please enter string max-length (should be a number greater than 4):");
                var result = Console.ReadLine();
                if (long.TryParse(result, out var parsedValue) && parsedValue > minimumStringLenght)
                {
                    length = parsedValue;
                    parsed = true;
                }
            }
            while (!parsed);

            Console.Write("Please enter data string:");
            var data = Console.ReadLine();

            return (length, data);
        }
    }
}