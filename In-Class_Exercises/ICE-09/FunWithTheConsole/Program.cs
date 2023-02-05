//Name: Erik Menchaca
//Date: February 5, 2023
//Course: Programming Fundamentals I: Mobile Domain
//Instructor: Kemoy Campbell
//Assignment: Fun With The Console

Console.Title = "Fun With The Console";
System.Console.Write("What is your name? --> ");
string name = Console.ReadLine();
System.Console.Write("What is your major? --> ");
string major = Console.ReadLine();
System.Console.Write("What is your dream job? --> ");
string dreamJob = Console.ReadLine();

System.Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.BackgroundColor = ConsoleColor.White;

Console.WriteLine("Programming Fundamentals I: Mobile Domain");
System.Console.Write($"Name: {name}, Major: {major}, Dream Job: {dreamJob}");

Console.ResetColor();