namespace ElevatorSimulator
{
    public class Elevator
    {
        private const int MIN_FLOOR = 1;
        private const int MAX_FLOOR = 10;

        private int currentFloor;
        private int peopleInside;

        public int CurrentFloor => currentFloor;

        public int PeopleInside => peopleInside;

        public Elevator()
        {
            this.currentFloor = MIN_FLOOR;
            this.peopleInside = 0;
        }

        public void Status() // Elevator status
        {
            Console.WriteLine("ELEVATOR STATUS");
            Console.WriteLine($"Currently on the floor: {currentFloor}.");
            Console.WriteLine($"People inside {peopleInside}.");
        }

        public void GoTo(int userFloor) // Go to specified floor
        {
            if (userFloor < MIN_FLOOR || userFloor > MAX_FLOOR)
            {
                Console.WriteLine($"Error! Please choose a floor between {MIN_FLOOR} and {MAX_FLOOR}.");
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

                Console.WriteLine($"Going to the floor {currentFloor}...");
            }

            Console.WriteLine($"Stopping at the floor: {currentFloor}");
        }

        public void GetIn() // Enter the elevator
        {
            peopleInside++;
            Console.WriteLine($"People inside {peopleInside}.");
        }

        public void GetOut() // Exit the elevator
        {
            if (peopleInside == 0)
            {
                Console.WriteLine("Error! There is nobody in the elevator.");
                return;
            }

            peopleInside--;
            Console.WriteLine($"People inside {peopleInside}.");
        }

        public void GoToDefault() // Go to default position
        {
            if (currentFloor == MIN_FLOOR)
            {
                Console.WriteLine("Already in default position.");
                return;
            }

            GoTo(MIN_FLOOR);
        }
    }
}
