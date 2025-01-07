Console.WriteLine("Welcome to Elevator Simulator!");
Console.WriteLine("");

ElevatorSimulator.Elevator elevator = new ElevatorSimulator.Elevator();

elevator.Call(5);
elevator.GetIn();
elevator.TravelWith(7);
elevator.GetOut();
elevator.GoToDefault();
Console.WriteLine("");

Console.WriteLine("");
Console.WriteLine("Simulation finished!");
Console.ReadLine();
