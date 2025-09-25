class Program
{
    static void Main()
    {
        Console.WriteLine("=== Tax Calculator ===");

        Console.Write("Ingrese su salario anual: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double salario) && salario >= 0)
        {
            var taxCalc = new TaxCalculator();
            string resultado = taxCalc.CalcularImpuesto(salario);
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número positivo.");
        }

        Console.ReadLine();
    }
}

public class TaxCalculator
{
    private const double UMBRAL = 12000;
    private const double TASA = 0.15;

    public string CalcularImpuesto(double salario)
    {
        if (salario <= UMBRAL)
            return "No debe impuestos.";
        
        double excedente = salario - UMBRAL;
        double impuesto = excedente * TASA;
        return impuesto.ToString("F0"); // sin decimales
    }
}
