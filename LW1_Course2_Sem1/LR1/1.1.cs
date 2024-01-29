double a = 2.5;
int b = 1;
Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

double Y = Math.Pow(x, 3) * (x * Math.Atan(a / x) - Math.Sqrt(Math.Abs(x + b)) + Math.Log(Math.Pow(Math.Abs(x - a) + 1, 2)));
double F = Math.Sqrt(a * Math.Pow(x, 2) + b + x) * Math.Exp(-a * x) + Math.Log(Math.Abs(x) + 1);

Console.WriteLine("\nY=" + Y);
Console.WriteLine("F=" + F);

Console.ReadKey();