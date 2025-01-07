Console.WriteLine("Welcome to Elevator Simulator!");
Console.WriteLine("");

ElevatorSimulator.Elevator elevator = new ElevatorSimulator.Elevator();

elevator.GoTo(5);
elevator.GetIn();
elevator.GoTo(7);
elevator.GetOut();

Console.WriteLine("");
Console.WriteLine("Simulation finished!");
Console.ReadLine();
