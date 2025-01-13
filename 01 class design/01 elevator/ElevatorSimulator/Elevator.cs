namespace ElevatorSimulator
{
    public class Elevator
    {
        private const int MIN_FLOOR = 1;
        private const int MAX_FLOOR = 10;

        private const int CAPACITY = 5;

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
            Console.WriteLine($"People inside: {peopleInside}.");
        }

        private void GoTo(int userFloor) // Go to specified floor
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

        public void Call(int floor) // Call an elevator to my floor
        {
            if (peopleInside > 0)
            {
                Console.WriteLine("Error! Somebody is using the elevator, wait and try later.");
                return;
            }

            Console.WriteLine($"Elevator called to floor {floor}.");
            GoTo(floor);
        }

        public void TravelWith(int floor) // Go with elevator to a specified floor
        {
            if (peopleInside == 0)
            {
                Console.WriteLine("Error! You have to call the elevator and get in first.");
                return;
            }

            Console.WriteLine($"Elevator starting on floor {floor} with {peopleInside} people.");
            GoTo(floor);
        }

        public void GetIn() // Enter the elevator
        {
            if (peopleInside == CAPACITY)
            {
                Console.WriteLine("Error! Elevator at full capacity.");
                return;
            }

            Console.WriteLine($"A person getting in.");
            peopleInside++;
            Console.WriteLine($"People inside: {peopleInside}.");
        }

        public void GetOut() // Exit the elevator
        {
            if (peopleInside == 0)
            {
                Console.WriteLine("Error! There is nobody in the elevator.");
                return;
            }

            Console.WriteLine($"A person getting out.");
            peopleInside--;
            Console.WriteLine($"People inside: {peopleInside}.");

            if (peopleInside == 0)
                GoToDefault();
        }

        private void GoToDefault() // Go to default position
        {
            if (currentFloor == MIN_FLOOR)
            {
                Console.WriteLine("Already in default position.");
                return;
            }

            Console.WriteLine("Going to default position.");
            GoTo(MIN_FLOOR);
        }
    }
}
