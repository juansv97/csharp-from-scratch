class Program
{
    static void Main()
    {
        System.Console.WriteLine("=== Vowel Counter ===");

        System.Console.Write("Ingrese una palabra: ");
        string palabra = System.Console.ReadLine().ToLower();

        int contador = 0;

        foreach (char letra in palabra)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                contador++;
            }
        }

        System.Console.WriteLine($"Resultado: {contador}");
    }
}
