class Program
{
    static void Main()
    {
        Console.WriteLine("=== Midweek Day ===");

        Console.Write("Ingrese un número entre 1 y 7: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int numero))
        {
            var midweek = new MidweekDay();
            string resultado = midweek.ObtenerDia(numero);
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, ingrese un número entero entre 1 y 7.");
        }

        Console.ReadLine();
    }
}

public class MidweekDay
{
    public string ObtenerDia(int numero)
    {
        switch (numero)
        {
            case 1: return "Lunes";
            case 2: return "Martes";
            case 3: return "Miércoles";
            case 4: return "Jueves";
            case 5: return "Viernes";
            case 6:
            case 7:
                return "Número fuera del rango laboral.";
            default:
                return "Número inválido. Debe estar entre 1 y 7.";
        }
    }
}
