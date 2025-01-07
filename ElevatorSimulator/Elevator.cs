namespace ElevatorSimulator
{
    public class Elevator
    {
        private const int MAX_FLOOR = 10;

        private int currentFloor;
        private int peopleInside;

        public int CurrentFloor => currentFloor;

        public int PeopleInside => peopleInside;

        public Elevator()
        {
            this.currentFloor = 1;
            this.peopleInside = 0;
        }

        public void Call(int userFloor) // Call the elevator to the user's floor
        {
            if (userFloor < 1 || userFloor > MAX_FLOOR)
            {
                Console.WriteLine($"Error! Please choose a floor between 1 and {MAX_FLOOR}.");
                return;
            }

            Console.WriteLine($"Starting on the floor: {currentFloor}");

            while (currentFloor != userFloor)
            {
                if (currentFloor < userFloor)
                {
                    currentFloor++;
                }
                else
                {
                    currentFloor--;
                }

                Console.WriteLine($"Passing through floor {currentFloor}...");
            }

            Console.WriteLine($"Stopping at the floor: {currentFloor}");
        }
    }
}
