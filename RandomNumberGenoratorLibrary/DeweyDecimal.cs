using System;

namespace RandomNumberGenoratorLibrary
{
    public class DeweyDecimalGenerator
    {
        private static readonly Random random = new Random();

        // Generate a random number for the main class (e.g., 100, 200, 300, etc.)
        public static int GenerateMainClass()
        {
            return random.Next(100, 900);  // Adjust the range as needed
        }

        // Generate a random number for the division (e.g., 1-99)
        public static int GenerateDivision()
        {
            return random.Next(1, 100);  // Adjust the range as needed
        }

        // Generate a random author cutter number (a three-letter code, for example)
        public static string GenerateAuthorCutter()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] cutterChars = new char[3];

            for (int i = 0; i < 3; i++)
            {
                cutterChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(cutterChars);
        }
    }
}
