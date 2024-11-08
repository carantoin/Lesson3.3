try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    int S = -1;
    double s = 1;
    for (int i = 3; i <= n; i++)
    {
        int coeff = 2 * i + 1;
        double fact = (2 * i);
        double term = S * (coeff / fact) * Math.Pow(x,2*i);
        s += term;
        S = -S;
    }
    Console.WriteLine($"Сумма {n} членов равна {s:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}