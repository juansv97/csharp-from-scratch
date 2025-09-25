class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero >= 10 && numero <= 20)
        {
            Console.WriteLine("Está en el rango.");
        }
        else
        {
            Console.WriteLine("Fuera del rango.");
        }
    }
}
