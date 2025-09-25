class Program
{
    static void Main()
    {
        Console.WriteLine("=== Root or Square ===");

        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double numero))
        {
            var calc = new RootOrSquare();
            double resultado = calc.Calcular(numero);
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
        }

        Console.ReadLine();
    }
}

public class RootOrSquare
{
    public double Calcular(double numero)
    {
        if (numero > 0)
            return Math.Sqrt(numero);   // raíz cuadrada
        else
            return Math.Pow(numero, 2); // cuadrado
    }
}
