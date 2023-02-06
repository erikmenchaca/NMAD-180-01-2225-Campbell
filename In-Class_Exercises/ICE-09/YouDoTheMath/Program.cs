//Name: Erik Menchaca
//Date: February 5, 2023
//Course: Programming Fundamentals I: Mobile Domain
//Instructor: Kemoy Campbell
//Assignment: You Do The Math

const double PI = 3.14;
int oneHundred = 100;
int threeHundred = 300; 
int sevenThousand = 7000;
double result = sevenThousand/(double)threeHundred;
double result2 = oneHundred * PI;
double result3 = sevenThousand/(int)threeHundred;


System.Console.WriteLine($"The value of the first variable is {oneHundred}.");
System.Console.WriteLine($"The value of the second variable is {threeHundred}.");
System.Console.WriteLine($"The amount in my bank is {sevenThousand:C}.");
System.Console.WriteLine($"The value of pi is {PI}.");
System.Console.WriteLine($"The value of pi, {PI}, multiplied by {oneHundred} is {result2}.");
System.Console.WriteLine($"The value of {sevenThousand} divided by {threeHundred} is {result}");
System.Console.WriteLine($"The value of {sevenThousand} divided by {threeHundred} is {result3}");