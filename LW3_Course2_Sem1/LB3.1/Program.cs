double B = 2 * Math.PI;
double y = 0;

for (double i = -2*Math.PI; i < B; i += Math.PI / 6)
{
    y = Math.Pow(i, 3) + Math.Sin(i);
    Console.WriteLine( $"y = {y}, x = {i}" );
}
Console.ReadKey();