class Program
{
    static void Main()
    {
        Console.WriteLine("=== Positive Power ===");
        Console.Write("Ingrese un número: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double numero))
        {
            var power = new PositivePower();
            string resultado = power.Calcular(numero);
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número válido.");
        }

        Console.ReadLine();
    }
}

public class PositivePower
{
    public string Calcular(double numero)
    {
        if (numero > 0)
            return Math.Pow(numero, 2).ToString();
        else if (numero == 0)
            return "0";
        else
            return "Número negativo.";
    }
}
