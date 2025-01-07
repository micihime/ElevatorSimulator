// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Elevator Simulator!");

ElevatorSimulator.Elevator elevator = new ElevatorSimulator.Elevator();
elevator.Call(5);

Console.WriteLine("Simulation finished!");
Console.ReadLine();
