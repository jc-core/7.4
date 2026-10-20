namespace Assignment7_4 {
    internal class TextFuncs {

        internal static int ReadCount(string prompt) {

            while (true) {

                Console.Write($"{prompt} ");
                string? line = Console.ReadLine();

                if (line == null)
                    return 0;

                if (int.TryParse(line, out int count) && count >= 0)
                    return count;

                Console.WriteLine("Whole number 0 or more, try again.");

            }
        }

        internal static int ReadCarType(string prompt) {

            while (true) {

                Console.Write($"{prompt} ");
                string? line = Console.ReadLine();

                if (line == null)
                    return 0;

                if (int.TryParse(line, out int carType) && carType >= 1 && carType <= 3)
                    return carType;

                Console.WriteLine("1, 2 or 3 only, try again.");

            }
        }
    }
}
