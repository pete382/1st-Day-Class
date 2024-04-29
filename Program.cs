// See https://aka.ms/new-console-template for more information

//Getting input from user
using System.Runtime.InteropServices;

Console.WriteLine("Enter the radius");
string entry = Console.ReadLine();
Console.WriteLine(entry);

//int result = int.Parse(entry);
//Console.WriteLine(result);

float resulte = float.Parse(Console.ReadLine());
double AREA = Math.PI * resulte*resulte;

Console.WriteLine(AREA);

Console.WriteLine();


string name = "Pedro Rueda Diaz"