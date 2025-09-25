class Program
{
    static void Main()
    {
        System.Console.WriteLine("=== Average of Four ===");

        System.Console.Write("Ingrese el primer número: ");
        double n1 = double.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el segundo número: ");
        double n2 = double.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el tercer número: ");
        double n3 = double.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el cuarto número: ");
        double n4 = double.Parse(System.Console.ReadLine());

        double promedio = (n1 + n2 + n3 + n4) / 4;

        System.Console.WriteLine($"Resultado: {promedio}");
    }
}
