class Program
{
    static void Main()
    {
        Console.WriteLine("=== Sum of Evens ===");

        var calc = new SumOfEvens();
        int resultado = calc.Calcular();

        Console.WriteLine($"Resultado: {resultado}");
        Console.ReadLine();
    }
}

public class SumOfEvens
{
    public int Calcular()
    {
        int suma = 0;
        for (int i = 2; i <= 50; i += 2)
        {
            suma += i;
        }
        return suma;
    }
}
