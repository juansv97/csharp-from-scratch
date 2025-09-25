class Program
{
    static void Main()
    {
        System.Console.WriteLine("=== String Length ===");
        System.Console.Write("Ingrese una palabra: ");
        string palabra = System.Console.ReadLine();

        int longitud = palabra.Length;

        System.Console.WriteLine($"Resultado: {longitud}");
    }
}
