using System.Security.Cryptography;
using System.Diagnostics;

var sw = new Stopwatch();
sw.Start();

double A1, A2, B1, B2, C1, C2, A3, B3, C3;
Console.WriteLine("Введите A1");
A1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите A2");
A2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите B1");
B1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите B2");
B2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите C1");
C1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите C2");
C2 = Convert.ToDouble(Console.ReadLine());

A3 = Math.Sqrt(Math.Pow(A1,2) + Math.Pow(A2, 2));
B3 = Math.Sqrt(Math.Pow(B1, 2) + Math.Pow(B2, 2));
C3 = Math.Sqrt(Math.Pow(C1, 2) + Math.Pow(C2, 2));

if (A3 > B3 && A3 > C3) Console.WriteLine($"Первый треугольник имеет наибольшую гипотенузу: {A3}");

if (B3 > A3 && B3 > C3) Console.WriteLine($"Второй треугольник имеет наибольшую гипотенузу: {B3}");

if (C3 > A3 && C3 > B3) Console.WriteLine($"Третий треугольник имеет наибольшую гипотенузу: {C3}");

sw.Stop();
Console.WriteLine($"Времени пройдено: {sw.Elapsed}");

Console.ReadKey();



