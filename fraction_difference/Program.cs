class Program
{
    static void Main()
    {
        System.Console.WriteLine("=== Fraction Difference ===");

        System.Console.Write("Ingrese la primera fracción (ejemplo 1/2): ");
        string frac1 = System.Console.ReadLine();

        System.Console.Write("Ingrese la segunda fracción (ejemplo 1/3): ");
        string frac2 = System.Console.ReadLine();

        // Separar numerador y denominador
        string[] p1 = frac1.Split('/');
        string[] p2 = frac2.Split('/');

        int n1 = int.Parse(p1[0]);
        int d1 = int.Parse(p1[1]);
        int n2 = int.Parse(p2[0]);
        int d2 = int.Parse(p2[1]);

        // Calcular diferencia: a/b - c/d = (ad - bc) / bd
        int num = n1 * d2 - n2 * d1;
        int den = d1 * d2;

        // Simplificar resultado
        int gcd = GCD(System.Math.Abs(num), System.Math.Abs(den));
        num /= gcd;
        den /= gcd;

        if (num == 0)
        {
            System.Console.WriteLine("Resultado: 0");
        }
        else if (den == 1)
        {
            System.Console.WriteLine($"Resultado: {num}");
        }
        else
        {
            System.Console.WriteLine($"Resultado: {num}/{den}");
        }
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
