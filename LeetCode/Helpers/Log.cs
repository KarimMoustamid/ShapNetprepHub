namespace Top_Interview_Questions.Helpers
{
    public static class Log
    {
        public static void LogMessage(string message)
        {
            var originalBackgroundColor = Console.BackgroundColor;
            var originalForegroundColor = Console.ForegroundColor;

            try
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(message);
            }
            finally
            {
                Console.BackgroundColor = originalBackgroundColor;
                Console.ForegroundColor = originalForegroundColor;
            }
        }

        public static void LogMessageWithColor(string message, ConsoleColor BackgroundColor = ConsoleColor.DarkCyan, ConsoleColor ForegroundColor = ConsoleColor.White)
        {
            var originalBackgroundColor = Console.BackgroundColor;
            var originalForegroundColor = Console.ForegroundColor;

            try
            {
                Console.BackgroundColor = BackgroundColor;
                Console.ForegroundColor = ForegroundColor;
                Console.WriteLine(message);
            }
            finally
            {
                Console.BackgroundColor = originalBackgroundColor;
                Console.ForegroundColor = originalForegroundColor;
            }
        }

        public static void Array<T>(T[] array, string message = "")
        {
            if (array == null)
            {
                Console.WriteLine("The resulting Array is null.");
                return;
            }

            var originalBackgroundColor = Console.BackgroundColor;
            var originalForegroundColor = Console.ForegroundColor;

            try
            {
                if (!string.IsNullOrEmpty(message))
                {
                    Console.WriteLine(message);
                }

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(string.Join(", ", array));
            }
            finally
            {
                Console.BackgroundColor = originalBackgroundColor;
                Console.ForegroundColor = originalForegroundColor;
            }
        }

        public static void LogDictionary(Dictionary<int, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}