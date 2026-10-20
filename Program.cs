using static Assignment7_4.TextFuncs;
namespace Assignment7_4 {
    internal class Program {

        static string[] sizes = { "big", "medium", "small" };

        static void Main(string[] args) {

            Console.WriteLine("Spaces in the lot for each size.");
            int big = ReadCount("Big:");
            int medium = ReadCount("Medium:");
            int small = ReadCount("Small:");

            ParkingSystem lot = new ParkingSystem(big, medium, small);

            Console.WriteLine();

        startLoop:

            RunParking(lot);

            Console.WriteLine();
            Console.WriteLine("...");
            Console.ReadKey(true);
            Console.Clear();

            goto startLoop;

        }

        static void RunParking(ParkingSystem lot) {

            Console.WriteLine("Park a car: 1 big, 2 medium, 3 small.");
            Console.WriteLine($"Open: big {lot.OpenSpaces(1)}, medium {lot.OpenSpaces(2)}, small {lot.OpenSpaces(3)}");

            int carType = ReadCarType("Car:");

            if (carType == 0) {
                Console.WriteLine("No input, try again.");
                return;
            }

            if (lot.AddCar(carType))
                Console.WriteLine($"Parked in a {sizes[carType - 1]} space.");
            else
                Console.WriteLine($"No {sizes[carType - 1]} space.");

        }
    }
}
