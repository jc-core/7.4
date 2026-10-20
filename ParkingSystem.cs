namespace Assignment7_4 {
    internal class ParkingSystem {

        private int[] open;

        public ParkingSystem(int big, int medium, int small) {

            open = new int[] { big, medium, small };

        }

        public bool AddCar(int carType) {

            if (open[carType - 1] == 0)
                return false;

            open[carType - 1]--;

            return true;

        }

        public int OpenSpaces(int carType) {

            return open[carType - 1];

        }
    }
}
