//Name: Erik Menchaca
//Date: February 5, 2023
//Course: Programming Fundamentals I: Mobile Domain
//Instructor: Kemoy Campbell
//Assignment: The Magic of Inputs

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Score 1: ");
double scoreOne = double.Parse(Console.ReadLine());
Console.Write("Score 2: ");
double scoreTwo = double.Parse(Console.ReadLine());
Console.Write("Score 3: ");
double scoreThree = double.Parse(Console.ReadLine());
Console.Write("Score 4: ");
double scoreFour = double.Parse(Console.ReadLine());
System.Console.WriteLine();
double averageScore = ((scoreOne+scoreTwo+scoreThree+scoreFour)/4);

System.Console.WriteLine($"Your Average Score: {averageScore}");