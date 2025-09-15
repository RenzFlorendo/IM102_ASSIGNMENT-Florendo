using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
            if (num % i == 0) return false;
        return true;
    }

    static (double peso, double yen) ConvertCurrency(double dollar)
    {
        double peso = dollar * 57.17;
        double yen = dollar * 146.67;
        return (peso, yen);
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string[] numbers = Console.ReadLine().Split(' ');

        int count = 1;
        foreach (string s in numbers)
        {
            int num = int.Parse(s);
            Console.WriteLine($"{count}. {num}\t{(IsPrime(num) ? "Prime" : "Composite")}");
            count++;
        }

        Console.Write("Enter currency in ($): ");
        string[] dollarValues = Console.ReadLine().Split(',');

        Console.WriteLine("\nDollar($)\tPhil Peso(P)\tJpn Yen(Y)");
        foreach (string d in dollarValues)
        {
            double dollar = double.Parse(d);
            var (peso, yen) = ConvertCurrency(dollar);
            Console.WriteLine($"{dollar}\t\t{peso:F2}\t\t{yen:F2}");
        }
        Console.ReadLine();
    }
}
