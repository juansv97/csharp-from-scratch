class Program
{
    static void Main()
    {
        Console.WriteLine("=== Remainder Finder ===");

        Console.Write("Ingrese el primer número: ");
        string input1 = Console.ReadLine();

        Console.Write("Ingrese el segundo número: ");
        string input2 = Console.ReadLine();

        if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2))
        {
            var finder = new RemainderFinder();
            string resultado = finder.CalcularResiduo(num1, num2);
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese números enteros.");
        }

        Console.ReadLine();
    }
}

public class RemainderFinder
{
    public string CalcularResiduo(int dividendo, int divisor)
    {
        if (divisor == 0)
            return "No se puede dividir por cero.";
        
        int residuo = dividendo % divisor;
        return residuo.ToString();
    }
}
