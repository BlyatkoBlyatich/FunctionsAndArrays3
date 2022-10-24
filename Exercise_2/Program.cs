double Rasst(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = Math.Pow(x2 - x1, 2);
    double b = Math.Pow(y2 - y1, 2);
    double c = Math.Pow(z2 - z1, 2);
    double res = Math.Sqrt(a + b + c);
    return Math.Round(res, 2);
}

Console.WriteLine("Input X1: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y1: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input z1: ");
double num3 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x2: ");
double num4 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y1: ");
double num5 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input z2: ");
double num6 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Rasst(num1, num2, num3, num4, num5, num6));