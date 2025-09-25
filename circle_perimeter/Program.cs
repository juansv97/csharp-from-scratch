class Program
{
    static void Main()
    {
        Console.WriteLine("=== Calculadora de Perímetro de un Círculo ===");

        Console.Write("Ingrese el radio del círculo: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double radio) && radio > 0)
        {
            var circle = new Circle { Radio = radio };
            double perimetro = circle.Perimetro();
            Console.WriteLine($"El perímetro del círculo es: {perimetro:F2}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo.");
        }

        Console.ReadLine();
    }
}

public class Circle
{
    public double Radio { get; set; }

    public double Perimetro() => 2 * Math.PI * Radio;
}
