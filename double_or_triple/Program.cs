class Program
{
    static void Main()
    {
        Console.WriteLine("=== Double or Triple ===");

        Console.Write("Ingrese el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string input2 = Console.ReadLine();

        if (double.TryParse(input1, out double num1) && double.TryParse(input2, out double num2))
        {
            var calc = new DoubleOrTriple();
            double resultado = calc.Calcular(num1, num2);
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese números válidos.");
        }

        Console.ReadLine();
    }
}

public class DoubleOrTriple
{
    public double Calcular(double primero, double segundo)
    {
        if (primero >= segundo) // ✅ incluye el caso de igualdad
            return primero * 2;
        else
            return segundo * 3;
    }
}
