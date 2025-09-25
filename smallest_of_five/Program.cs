class Program
{
    static void Main()
    {
        System.Console.WriteLine("=== Smallest of Five ===");

        System.Console.Write("Ingrese el primer número: ");
        double n1 = double.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el segundo número: ");
        double n2 = double.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el tercer número: ");
        double n3 = double.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el cuarto número: ");
        double n4 = double.Parse(System.Console.ReadLine());

        System.Console.Write("Ingrese el quinto número: ");
        double n5 = double.Parse(System.Console.ReadLine());

        double menor = n1;

        if (n2 < menor) menor = n2;
        if (n3 < menor) menor = n3;
        if (n4 < menor) menor = n4;
        if (n5 < menor) menor = n5;

        System.Console.WriteLine($"Resultado: {menor}");
    }
}
