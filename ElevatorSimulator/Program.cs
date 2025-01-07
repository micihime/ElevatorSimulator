// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Elevator Simulator!");
Console.WriteLine("");

ElevatorSimulator.Elevator elevator = new ElevatorSimulator.Elevator();

elevator.GoTo(5);
elevator.GetIn();

Console.WriteLine("");
Console.WriteLine("Simulation finished!");
Console.ReadLine();
